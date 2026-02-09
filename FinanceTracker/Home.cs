using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;


namespace FinanceTracker
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();

            
        }
        public void LoadIncomePieChart()
        {
            

        }

        public void RefreshUser()
        {
            lblHello.Text = "Hello, " + CurrentUser.Username;

        }

       

        private void lblHello_Click(object sender, EventArgs e)
        {
            
        }

        private void IncomePieChart_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadTotals();
            LoadRecentTransactions();
            LoadIncomeChart();
            LoadExpenseChart();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private string MonthName(int month)
        {
            return new DateTime(DateTime.Now.Year, month, 1)
                .ToString("MMM");
        }


        private void LoadRecentTransactions()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                if (con == null) return;

                con.Open();

                string query =
                    "SELECT TOP 5 * FROM ( " +
                    "SELECT 'Income' AS Type, Amount, Category, IncomeDate AS TranDate " +
                    "FROM Income WHERE Date_Delete IS NULL " +
                    "UNION ALL " +
                    "SELECT 'Expense' AS Type, Amount, Category, ExpenseDate AS TranDate " +
                    "FROM Expense WHERE Date_Delete IS NULL " +
                    ") AS T ORDER BY TranDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRecentTransactions.DataSource = dt;
            }
        }



        private void LoadIncomeChart()
        {
            IncomeChart.Series[0].Points.Clear();

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query =
                    "SELECT DATENAME(MONTH, IncomeDate) AS MonthName, SUM(Amount) AS Total " +
                    "FROM Income WHERE Date_Delete IS NULL " +
                    "GROUP BY DATENAME(MONTH, IncomeDate), MONTH(IncomeDate) " +
                    "ORDER BY MONTH(IncomeDate)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IncomeChart.Series[0].Points.AddXY(
                            reader["MonthName"].ToString(),
                            Convert.ToDecimal(reader["Total"])
                        );
                    }
                }
            }
        }

    

    private void LoadTotals()
        {
            decimal totalIncome = 0;
            decimal totalExpense = 0;

            using (SqlConnection con = Database.GetConnection())
            {
                if (con == null) return;

                con.Open();

                // TOTAL INCOME
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT SUM(Amount) FROM Income WHERE Date_Delete IS NULL", con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                        totalIncome = Convert.ToDecimal(result);
                }

                // TOTAL EXPENSE (only completed)
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT SUM(Amount) FROM Expense " +
                    "WHERE Status = 'Completed' AND Date_Delete IS NULL", con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                        totalExpense = Convert.ToDecimal(result);
                }
            }

            decimal balance = totalIncome - totalExpense;

            lblTotalIncome.Text = totalIncome.ToString("0.00");
            lblTotalExpense.Text = totalExpense.ToString("0.00");
            lblBalance.Text = balance.ToString("0.00");
        }


        private void LoadExpenseChart()
        {
            ExpenseChart.Series[0].Points.Clear();

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query =
                    "SELECT MONTH(ExpenseDate) AS Month, SUM(Amount) AS Total " +
                    "FROM Expense WHERE Date_Delete IS NULL " +
                    "GROUP BY MONTH(ExpenseDate) ORDER BY Month";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int month = reader.GetInt32(0);
                        decimal total = reader.GetDecimal(1);

                        ExpenseChart.Series[0].Points.AddXY(
                            MonthName(month),
                            total
                        );
                    }
                }
            }
        }

        private void dgvRecentTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

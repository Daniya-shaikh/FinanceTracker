using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinanceTracker
{
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {


            lblUsed.BringToFront();
            lblRemaining.BringToFront();
            lblStatus.BringToFront();

            panelBudgetBg.SendToBack();


            Amount_Filter.Items.AddRange(new string[]
    {
        "All",
        "Below 500",
        "500 - 2000",
        "Above 2000"
    });
            Amount_Filter.SelectedIndex = 0;

            Type_Filter.Items.AddRange(new string[]
            {
        "All",
        "Income",
        "Expense"
            });
            Type_Filter.SelectedIndex = 0;

            LoadHistory();
        }

        private void LoadHistory()
        {
            DataHistory dh = new DataHistory();
            HistoryGrid.DataSource = dh.GetHistory(
                Type_Filter.Text,
                Amount_Filter.Text,
                From_Date.Value,
                To_Date.Value
            );

            HistoryGrid.ClearSelection();

            foreach (DataGridViewRow row in HistoryGrid.Rows)
            {
                if (row.Cells["Type"].Value.ToString() == "Income")
                    row.DefaultCellStyle.ForeColor = Color.Green;

                if (row.Cells["Type"].Value.ToString() == "Expense")
                    row.DefaultCellStyle.ForeColor = Color.Red;

                if (row.Cells["Status"].Value.ToString() == "Pending")
                    row.DefaultCellStyle.ForeColor = Color.Orange;

                if (row.Cells["Status"].Value.ToString() == "Cancelled")
                    row.DefaultCellStyle.ForeColor = Color.Gray;
            }

            LoadBudgetMonths();

        }

        private void LoadBudgetMonths()
        {
            cmbBudgetMonth.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                DateTime dt = DateTime.Now.AddMonths(i);
                cmbBudgetMonth.Items.Add(dt.ToString("MMMM yyyy"));
            }

            cmbBudgetMonth.SelectedIndex = 0;
        }


        private void Apply_Btn_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnSaveBudget_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtBudgetAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter valid budget amount");
                return;
            }

            DateTime selected = DateTime.ParseExact(
                cmbBudgetMonth.Text,
                "MMMM yyyy",
                null
            );

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string check =
                    "SELECT COUNT(*) FROM Budget " +
                    "WHERE UserId=@uid AND BudgetMonth=@m AND BudgetYear=@y";

                SqlCommand chk = new SqlCommand(check, con);
                chk.Parameters.AddWithValue("@uid", CurrentUser.Id);
                chk.Parameters.AddWithValue("@m", selected.Month);
                chk.Parameters.AddWithValue("@y", selected.Year);

                int exists = (int)chk.ExecuteScalar();

                string query = exists == 0
                    ? "INSERT INTO Budget (UserId,BudgetMonth,BudgetYear,Amount) VALUES (@uid,@m,@y,@a)"
                    : "UPDATE Budget SET Amount=@a WHERE UserId=@uid AND BudgetMonth=@m AND BudgetYear=@y";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", CurrentUser.Id);
                cmd.Parameters.AddWithValue("@m", selected.Month);
                cmd.Parameters.AddWithValue("@y", selected.Year);
                cmd.Parameters.AddWithValue("@a", amount);

                cmd.ExecuteNonQuery();
            }

            LoadBudgetSummary();
        }

        private void LoadBudgetSummary()
        {
            DateTime selected = DateTime.ParseExact(
                cmbBudgetMonth.Text,
                "MMMM yyyy",
                null
            );

            decimal budget = 0, used = 0;

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                // Budget
                SqlCommand b = new SqlCommand(
                    "SELECT Amount FROM Budget WHERE UserId=@u AND BudgetMonth=@m AND BudgetYear=@y",
                    con
                );
                b.Parameters.AddWithValue("@u", CurrentUser.Id);
                b.Parameters.AddWithValue("@m", selected.Month);
                b.Parameters.AddWithValue("@y", selected.Year);

                object br = b.ExecuteScalar();
                if (br == null) return;

                budget = Convert.ToDecimal(br);

                // Expense
                SqlCommand e = new SqlCommand(
                    "SELECT SUM(Amount) FROM Expense " +
                    "WHERE Status='Completed' AND Date_Delete IS NULL " +
                    "AND MONTH(ExpenseDate)=@m AND YEAR(ExpenseDate)=@y",
                    con
                );
                e.Parameters.AddWithValue("@m", selected.Month);
                e.Parameters.AddWithValue("@y", selected.Year);

                object er = e.ExecuteScalar();
                if (er != DBNull.Value)
                    used = Convert.ToDecimal(er);
            }

            decimal remaining = budget - used;
            int percent = (int)((used / budget) * 100);
            if (percent > 100) percent = 100;

            lblUsed.Text = $"Used This Month : ₹ {used}";
            lblRemaining.Text = $"Remaining Budget : ₹ {remaining}";

            int maxWidth = panelBudgetBg.Width;
            panelBudgetFill.Width = (percent * maxWidth) / 100;


            if (percent <= 60)
            {
                lblStatus.Text = "Status : Good";
                lblStatus.ForeColor = Color.Green;
                panelBudgetFill.BackColor = Color.Green;

            }
            else if (percent <= 90)
            {
                lblStatus.Text = "Status : Warning";
                lblStatus.ForeColor = Color.Orange;
                panelBudgetFill.BackColor = Color.Orange;

            }
            else
            {
                lblStatus.Text = "Status : Overspent";
                lblStatus.ForeColor = Color.Red;
                panelBudgetFill.BackColor = Color.Red;

            }


        }

        private void panelBudgetBg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

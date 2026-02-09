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
    public partial class AddIncome : UserControl
    {
        SqlConnection con;
        private int selectedIncomeId = -1;

        public AddIncome()
        {
            InitializeComponent();
            

        }

        private void AddIncome_Load(object sender, EventArgs e)
        {
            con = Database.GetConnection();
            if (con == null) return; 

            displayIncome();

            

        }


        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayIncome();
        }

        public void clearFields()
        {
            Income_Amount.Clear();
            Income_Category.SelectedIndex = -1;
            Income_Description.Clear();
        }

        public void displayIncome()
        {
            if (con == null) return;

            DataAddIncome dai = new DataAddIncome();
            AddIncomeGrid.DataSource = dai.addIncomeData();

            if (AddIncomeGrid.Columns["Status"] != null)
            {
                AddIncomeGrid.Columns["Status"].Visible = false;
            }

            AddIncomeGrid.ClearSelection();
        }

        private void Income_Add_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(Income_Amount.Text) ||
                string.IsNullOrWhiteSpace(Income_Category.Text) ||
                string.IsNullOrWhiteSpace(Income_Description.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (!decimal.TryParse(Income_Amount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid numeric amount");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Amount must be greater than zero");
                return;
            }

            if (con == null)
            {
                MessageBox.Show("Database connection not available");
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string insertData =
                    "INSERT INTO Income (Amount, Category, IncomeDate, Description, Date_Insert) " +
                    "VALUES (@Amount, @Category, @IncomeDate, @Description, @Date_Insert)";

                using (SqlCommand cmd = new SqlCommand(insertData, con))
                {
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Category", Income_Category.Text.Trim());
                    cmd.Parameters.AddWithValue("@IncomeDate", Income_Date.Value.Date);
                    cmd.Parameters.AddWithValue("@Description", Income_Description.Text.Trim());
                    cmd.Parameters.AddWithValue("@Date_Insert", DateTime.Today);

                    cmd.ExecuteNonQuery();
                }

                displayIncome();
                clearFields();

                MessageBox.Show(
                    "Added Successfully",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error inserting data:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

            

        private void Income_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
        !       char.IsControl(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void AddIncomeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = AddIncomeGrid.Rows[e.RowIndex];

            selectedIncomeId = Convert.ToInt32(row.Cells["Id"].Value);

            Income_Amount.Text = row.Cells["Amount"].Value.ToString();
            Income_Category.Text = row.Cells["Category"].Value.ToString();
            Income_Description.Text = row.Cells["Description"].Value.ToString();

            // Date conversion
            if (DateTime.TryParse(row.Cells["IncomeDate"].Value.ToString(), out DateTime date))
            {
                Income_Date.Value = date;
            }

            

        }

        private void Income_Update_Click(object sender, EventArgs e)
        {

            if (selectedIncomeId == -1)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            if (!decimal.TryParse(Income_Amount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid amount.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Income_Category.Text) ||
                string.IsNullOrWhiteSpace(Income_Description.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            SqlConnection con = Database.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();

                string query =
                    "UPDATE Income SET " +
                    "Amount = @Amount, Category = @Category, IncomeDate = @IncomeDate, Description = @Description " +
                    "WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Category", Income_Category.Text.Trim());
                    cmd.Parameters.AddWithValue("@IncomeDate", Income_Date.Value.Date);
                    cmd.Parameters.AddWithValue("@Description", Income_Description.Text.Trim());
                    cmd.Parameters.AddWithValue("@Id", selectedIncomeId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Updated successfully.","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

                displayIncome();
                AddIncomeGrid.ClearSelection();
                clearFields();
                selectedIncomeId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void Income_Delete_Click(object sender, EventArgs e)
        {
            if (selectedIncomeId == -1)
            {
                MessageBox.Show(
                    "Please select a record to delete.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            SqlConnection con = Database.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();

                string query = "DELETE FROM Income WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", selectedIncomeId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Deleted successfully.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                displayIncome();
                AddIncomeGrid.ClearSelection();
                clearFields();
                selectedIncomeId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Delete failed:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                con.Close();
            }
        }

        private void Income_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
            AddIncomeGrid.ClearSelection();
            selectedIncomeId = -1;

            
        }
    }
}

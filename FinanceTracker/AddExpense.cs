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
    public partial class AddExpense : UserControl
    {
        SqlConnection con;
        private int selectedExpenseId = -1;

        public AddExpense()
        {
            InitializeComponent();
        }

        private void AddExpense_Load(object sender, EventArgs e)
        {
            con = Database.GetConnection();
            if (con == null) return;

            displayExpense();

            Expense_Status.Items.Clear();
            Expense_Status.Items.AddRange(new string[]
            {
                "Pending",
                "Completed",
                "Cancelled"
            });

            Expense_Status.SelectedIndex = 0;

        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayExpense();
        }

        public void clearFields()
        {
            Expense_Amount.Clear();
            Expense_Category.SelectedIndex = -1;
            Expense_Description.Clear();
            Expense_Status.SelectedIndex = 0;
        }

        public void displayExpense()
        {
            if (con == null) return;

            DataAddExpense dae = new DataAddExpense();
            AddExpenseGrid.DataSource = dae.addExpenseData();

            AddExpenseGrid.ClearSelection();
        }

        private void Expense_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Expense_Amount.Text) ||
                string.IsNullOrWhiteSpace(Expense_Category.Text) ||
                string.IsNullOrWhiteSpace(Expense_Description.Text) ||
                string.IsNullOrWhiteSpace(Expense_Status.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (!decimal.TryParse(Expense_Amount.Text, out decimal amount))
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
                    "INSERT INTO Expense (Amount, Category, ExpenseDate, Description, Status, Date_Insert) " +
                    "VALUES (@Amount, @Category, @ExpenseDate, @Description, @Status, @Date_Insert)";

                using (SqlCommand cmd = new SqlCommand(insertData, con))
                {
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Category", Expense_Category.Text.Trim());
                    cmd.Parameters.AddWithValue("@ExpenseDate", Expense_Date.Value.Date);
                    cmd.Parameters.AddWithValue("@Description", Expense_Description.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", Expense_Status.Text.Trim());
                    cmd.Parameters.AddWithValue("@Date_Insert", DateTime.Today);

                    cmd.ExecuteNonQuery();
                }

                displayExpense();
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

        private void Expense_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void AddExpenseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = AddExpenseGrid.Rows[e.RowIndex];

            selectedExpenseId = Convert.ToInt32(
                AddExpenseGrid.Rows[e.RowIndex].Cells[0].Value
            );



            Expense_Amount.Text = row.Cells["Amount"].Value.ToString();
            Expense_Category.Text = row.Cells["Category"].Value.ToString();
            Expense_Description.Text = row.Cells["Description"].Value.ToString();
            Expense_Status.Text = row.Cells["Status"].Value.ToString();

            if (DateTime.TryParse(row.Cells["ExpenseDate"].Value.ToString(), out DateTime date))
            {
                Expense_Date.Value = date;
            }
        }

        private void Expense_Update_Click(object sender, EventArgs e)
        {
            if (selectedExpenseId == -1)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            if (!decimal.TryParse(Expense_Amount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid amount.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Expense_Category.Text) ||
                string.IsNullOrWhiteSpace(Expense_Description.Text) ||
                string.IsNullOrWhiteSpace(Expense_Status.Text))
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
                    "UPDATE Expense SET " +
                    "Amount = @Amount, Category = @Category, ExpenseDate = @ExpenseDate, " +
                    "Description = @Description, Status = @Status " +
                    "WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Category", Expense_Category.Text.Trim());
                    cmd.Parameters.AddWithValue("@ExpenseDate", Expense_Date.Value.Date);
                    cmd.Parameters.AddWithValue("@Description", Expense_Description.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", Expense_Status.Text.Trim());
                    cmd.Parameters.AddWithValue("@Id", selectedExpenseId);

                    


                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Updated successfully.",
                    "Information Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                displayExpense();
                AddExpenseGrid.ClearSelection();
                clearFields();
                selectedExpenseId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Update failed:\n" + ex.Message,
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

        private void Expense_Delete_Click(object sender, EventArgs e)
        {
            if (selectedExpenseId == -1)
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

                string query = "DELETE FROM Expense WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", selectedExpenseId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Deleted successfully.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                displayExpense();
                AddExpenseGrid.ClearSelection();
                clearFields();
                selectedExpenseId = -1;
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

        private void Expense_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
            AddExpenseGrid.ClearSelection();
            selectedExpenseId = -1;
        }

        private void AddExpenseGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

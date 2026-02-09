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
using System.Configuration;

namespace FinanceTracker
{
    public partial class RegisterForm : Form
    {
        SqlConnection con = Database.GetConnection();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage lform = new LoginPage();
            lform.Show();
            this.Hide();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(register_email.Text) ||
                string.IsNullOrEmpty(register_user.Text) ||
                string.IsNullOrEmpty(register_pass.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {
                using (SqlConnection con = Database.GetConnection())
                {

                    con.Open();

                    String checkUsername = "SELECT COUNT (*) FROM Users WHERE Username = @username";

                    using (SqlCommand checkCMD = new SqlCommand(checkUsername, con))
                    {
                        checkCMD.Parameters.AddWithValue("@username", register_user.Text.Trim());
                        int count = (int)checkCMD.ExecuteScalar();

                        if (count >= 1)
                        {
                            MessageBox.Show(register_user.Text.Trim()
                                + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                    }


                    //TO GET DATE TODAY
                    DateTime day = DateTime.Today;
                    String InsertData = "INSERT INTO Users (Email, Username, Password, Date_Register)"
                        + "VALUES(@email,@username,@password,@date)";

                    using (SqlCommand insertCMD = new SqlCommand(InsertData, con))
                    {
                        insertCMD.Parameters.AddWithValue("@email", register_email.Text.Trim());
                        insertCMD.Parameters.AddWithValue("@username", register_user.Text.Trim());
                        insertCMD.Parameters.AddWithValue("@password", register_pass.Text.Trim());
                        insertCMD.Parameters.AddWithValue("@date", day);

                        int newUserId = Convert.ToInt32(insertCMD.ExecuteScalar());

                        CurrentUser.Id = newUserId;
                        CurrentUser.Username = register_user.Text.Trim();
                        CurrentUser.Email = register_email.Text.Trim();

                    }
                    MessageBox.Show("Register successfully", " Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginPage lform = new LoginPage();
                    lform.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting database:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void regi_showpass_CheckedChanged(object sender, EventArgs e)
        {
            register_pass.UseSystemPasswordChar = !regi_showpass.Checked;
        }

        private void register_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                register_user.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void register_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                register_pass.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void register_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register_btn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}



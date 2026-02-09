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
    public partial class LoginPage : Form
    {
        


        public LoginPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_user.Text) ||
                string.IsNullOrWhiteSpace(login_password.Text))
            {
                MessageBox.Show(
                    "Please fill all blank fields",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            SqlConnection con = Database.GetConnection();

            
            if (con == null)
            {
                MessageBox.Show(
                    "Database connection not available.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                using (con)
                {
                    con.Open();

                    string selectData =
                        "SELECT Id, Username, Email " +
                        "FROM Users " +
                        "WHERE Username = @username AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@username", login_user.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                CurrentUser.Id = reader.GetInt32(0);
                                CurrentUser.Username = reader.GetString(1);
                                CurrentUser.Email = reader.GetString(2);

                                MessageBox.Show(
                                    "Login Successfully!",
                                    "Information Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Incorrect username or password",
                                    "Error Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error connecting database:\n" + ex.Message,
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }









        private void Registerbtn_Click(object sender, EventArgs e)
            {
                RegisterForm rForm = new RegisterForm();
                rForm.Show();
                this.Hide();
            }

            private void LoginPage_Load(object sender, EventArgs e)
            {

            }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
                login_password.UseSystemPasswordChar = !checkBox1.Checked;
            }

            private void login_user_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    login_password.Focus();
                    e.SuppressKeyPress = true;
                }
            }

            private void login_password_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Loginbtn.PerformClick();
                    e.SuppressKeyPress = true;
                }
            }
        }
    } 


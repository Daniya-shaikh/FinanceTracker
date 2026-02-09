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
    
    

public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void history1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginPage lForm = new LoginPage();
                lForm.Show();
                this.Hide();

            }
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            home2.Visible = true;
            addIncome1.Visible = false;
            addExpense1.Visible = false;
            history1.Visible = false;

            home2.RefreshUser();

           
        }

        private void AddIncome_btn_Click(object sender, EventArgs e)
        {
            home2.Visible = false;
            addIncome1.Visible = true;
            addExpense1.Visible = false;
            history1.Visible = false;
        }

        private void AddExpense_btn_Click(object sender, EventArgs e)
        {
            home2.Visible = false;
            addIncome1.Visible = false;
            addExpense1.Visible = true;
            history1.Visible = false;
        }

        private void History_btn_Click(object sender, EventArgs e)
        {
            home2.Visible = false;
            addIncome1.Visible = false;
            addExpense1.Visible = false;
            history1.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            home2.Visible = true;
            addIncome1.Visible = false;
            addExpense1.Visible = false;
            history1.Visible = false;

            home2.RefreshUser();
        }
    

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}


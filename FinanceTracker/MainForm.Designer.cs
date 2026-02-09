
namespace FinanceTracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.History_btn = new System.Windows.Forms.Button();
            this.AddExpense_btn = new System.Windows.Forms.Button();
            this.AddIncome_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.home2 = new FinanceTracker.Home();
            this.addIncome1 = new FinanceTracker.AddIncome();
            this.addExpense1 = new FinanceTracker.AddExpense();
            this.history1 = new FinanceTracker.History();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Home_btn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.History_btn);
            this.panel1.Controls.Add(this.AddExpense_btn);
            this.panel1.Controls.Add(this.AddIncome_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 711);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::FinanceTracker.Properties.Resources.icons8_power_401;
            this.button1.Location = new System.Drawing.Point(14, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_btn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_btn.ForeColor = System.Drawing.Color.White;
            this.Home_btn.Image = global::FinanceTracker.Properties.Resources.icons8_home_201;
            this.Home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_btn.Location = new System.Drawing.Point(24, 243);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(155, 43);
            this.Home_btn.TabIndex = 10;
            this.Home_btn.Text = "HOME";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FinanceTracker.Properties.Resources.icons8_saving_money_64;
            this.pictureBox2.Location = new System.Drawing.Point(68, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 70);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // History_btn
            // 
            this.History_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History_btn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History_btn.ForeColor = System.Drawing.Color.White;
            this.History_btn.Image = global::FinanceTracker.Properties.Resources.icons8_history_30;
            this.History_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.History_btn.Location = new System.Drawing.Point(24, 420);
            this.History_btn.Name = "History_btn";
            this.History_btn.Size = new System.Drawing.Size(155, 43);
            this.History_btn.TabIndex = 7;
            this.History_btn.Text = "HISTORY";
            this.History_btn.UseVisualStyleBackColor = true;
            this.History_btn.Click += new System.EventHandler(this.History_btn_Click);
            // 
            // AddExpense_btn
            // 
            this.AddExpense_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddExpense_btn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpense_btn.ForeColor = System.Drawing.Color.White;
            this.AddExpense_btn.Image = global::FinanceTracker.Properties.Resources.icons8_wallet_20;
            this.AddExpense_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddExpense_btn.Location = new System.Drawing.Point(24, 360);
            this.AddExpense_btn.Name = "AddExpense_btn";
            this.AddExpense_btn.Size = new System.Drawing.Size(155, 43);
            this.AddExpense_btn.TabIndex = 6;
            this.AddExpense_btn.Text = "ADD EXPENSE";
            this.AddExpense_btn.UseVisualStyleBackColor = true;
            this.AddExpense_btn.Click += new System.EventHandler(this.AddExpense_btn_Click);
            // 
            // AddIncome_btn
            // 
            this.AddIncome_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIncome_btn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIncome_btn.ForeColor = System.Drawing.Color.White;
            this.AddIncome_btn.Image = global::FinanceTracker.Properties.Resources.icons8_add_20__2_;
            this.AddIncome_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddIncome_btn.Location = new System.Drawing.Point(24, 301);
            this.AddIncome_btn.Name = "AddIncome_btn";
            this.AddIncome_btn.Size = new System.Drawing.Size(155, 43);
            this.AddIncome_btn.TabIndex = 5;
            this.AddIncome_btn.Text = "ADD INCOME";
            this.AddIncome_btn.UseVisualStyleBackColor = true;
            this.AddIncome_btn.Click += new System.EventHandler(this.AddIncome_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logout";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 38);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(10, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "PERSONAL FINANCE  TRACKER | HOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(998, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.home2);
            this.panel3.Controls.Add(this.addIncome1);
            this.panel3.Controls.Add(this.addExpense1);
            this.panel3.Controls.Add(this.history1);
            this.panel3.Location = new System.Drawing.Point(206, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 652);
            this.panel3.TabIndex = 2;
            // 
            // home2
            // 
            this.home2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home2.Location = new System.Drawing.Point(0, 0);
            this.home2.Name = "home2";
            this.home2.Size = new System.Drawing.Size(813, 652);
            this.home2.TabIndex = 4;
            // 
            // addIncome1
            // 
            this.addIncome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addIncome1.Location = new System.Drawing.Point(0, 0);
            this.addIncome1.Name = "addIncome1";
            this.addIncome1.Size = new System.Drawing.Size(813, 652);
            this.addIncome1.TabIndex = 2;
            // 
            // addExpense1
            // 
            this.addExpense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addExpense1.Location = new System.Drawing.Point(0, 0);
            this.addExpense1.Name = "addExpense1";
            this.addExpense1.Size = new System.Drawing.Size(813, 652);
            this.addExpense1.TabIndex = 1;
            // 
            // history1
            // 
            this.history1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history1.Location = new System.Drawing.Point(0, 0);
            this.history1.Name = "history1";
            this.history1.Size = new System.Drawing.Size(813, 652);
            this.history1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 707);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button History_btn;
        private System.Windows.Forms.Button AddExpense_btn;
        private System.Windows.Forms.Button AddIncome_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Panel panel3;
        private AddIncome addIncome1;
        private AddExpense addExpense1;
        private History history1;
        private Home home2;
        private System.Windows.Forms.Button button1;
    }
}
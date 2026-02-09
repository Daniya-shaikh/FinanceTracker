
namespace FinanceTracker
{
    partial class AddExpense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.AddExpenseGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Expense_Status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Expense_Clear = new System.Windows.Forms.Button();
            this.Expense_Update = new System.Windows.Forms.Button();
            this.Expense_Delete = new System.Windows.Forms.Button();
            this.Expense_Add = new System.Windows.Forms.Button();
            this.Expense_Date = new System.Windows.Forms.DateTimePicker();
            this.Expense_Category = new System.Windows.Forms.ComboBox();
            this.Expense_Description = new System.Windows.Forms.TextBox();
            this.Expense_Amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddExpenseGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AddExpenseGrid);
            this.panel2.Location = new System.Drawing.Point(310, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 631);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "EXPENSE";
            // 
            // AddExpenseGrid
            // 
            this.AddExpenseGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AddExpenseGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddExpenseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AddExpenseGrid.EnableHeadersVisualStyles = false;
            this.AddExpenseGrid.Location = new System.Drawing.Point(15, 52);
            this.AddExpenseGrid.Name = "AddExpenseGrid";
            this.AddExpenseGrid.RowHeadersVisible = false;
            this.AddExpenseGrid.Size = new System.Drawing.Size(463, 564);
            this.AddExpenseGrid.TabIndex = 0;
            this.AddExpenseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddExpenseGrid_CellClick);
            this.AddExpenseGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddExpenseGrid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Expense_Status);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Expense_Clear);
            this.panel1.Controls.Add(this.Expense_Update);
            this.panel1.Controls.Add(this.Expense_Delete);
            this.panel1.Controls.Add(this.Expense_Add);
            this.panel1.Controls.Add(this.Expense_Date);
            this.panel1.Controls.Add(this.Expense_Category);
            this.panel1.Controls.Add(this.Expense_Description);
            this.panel1.Controls.Add(this.Expense_Amount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 631);
            this.panel1.TabIndex = 4;
            // 
            // Expense_Status
            // 
            this.Expense_Status.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Expense_Status.FormattingEnabled = true;
            this.Expense_Status.Items.AddRange(new object[] {
            "Pending",
            "Completed",
            "Cancelled"});
            this.Expense_Status.Location = new System.Drawing.Point(118, 267);
            this.Expense_Status.Name = "Expense_Status";
            this.Expense_Status.Size = new System.Drawing.Size(151, 24);
            this.Expense_Status.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status :";
            // 
            // Expense_Clear
            // 
            this.Expense_Clear.BackColor = System.Drawing.Color.DarkCyan;
            this.Expense_Clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Clear.ForeColor = System.Drawing.Color.White;
            this.Expense_Clear.Location = new System.Drawing.Point(148, 363);
            this.Expense_Clear.Name = "Expense_Clear";
            this.Expense_Clear.Size = new System.Drawing.Size(104, 46);
            this.Expense_Clear.TabIndex = 12;
            this.Expense_Clear.Text = "CLEAR";
            this.Expense_Clear.UseVisualStyleBackColor = false;
            this.Expense_Clear.Click += new System.EventHandler(this.Expense_Clear_Click);
            // 
            // Expense_Update
            // 
            this.Expense_Update.BackColor = System.Drawing.Color.DarkCyan;
            this.Expense_Update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Update.ForeColor = System.Drawing.Color.White;
            this.Expense_Update.Location = new System.Drawing.Point(38, 363);
            this.Expense_Update.Name = "Expense_Update";
            this.Expense_Update.Size = new System.Drawing.Size(104, 46);
            this.Expense_Update.TabIndex = 11;
            this.Expense_Update.Text = "UPDATE";
            this.Expense_Update.UseVisualStyleBackColor = false;
            this.Expense_Update.Click += new System.EventHandler(this.Expense_Update_Click);
            // 
            // Expense_Delete
            // 
            this.Expense_Delete.BackColor = System.Drawing.Color.DarkCyan;
            this.Expense_Delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Delete.ForeColor = System.Drawing.Color.White;
            this.Expense_Delete.Location = new System.Drawing.Point(148, 311);
            this.Expense_Delete.Name = "Expense_Delete";
            this.Expense_Delete.Size = new System.Drawing.Size(104, 46);
            this.Expense_Delete.TabIndex = 10;
            this.Expense_Delete.Text = "DELETE";
            this.Expense_Delete.UseVisualStyleBackColor = false;
            this.Expense_Delete.Click += new System.EventHandler(this.Expense_Delete_Click);
            // 
            // Expense_Add
            // 
            this.Expense_Add.BackColor = System.Drawing.Color.DarkCyan;
            this.Expense_Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Add.ForeColor = System.Drawing.Color.White;
            this.Expense_Add.Location = new System.Drawing.Point(38, 311);
            this.Expense_Add.Name = "Expense_Add";
            this.Expense_Add.Size = new System.Drawing.Size(104, 46);
            this.Expense_Add.TabIndex = 9;
            this.Expense_Add.Text = "ADD";
            this.Expense_Add.UseVisualStyleBackColor = false;
            this.Expense_Add.Click += new System.EventHandler(this.Expense_Add_Click);
            // 
            // Expense_Date
            // 
            this.Expense_Date.CalendarFont = new System.Drawing.Font("Arial", 9.75F);
            this.Expense_Date.CalendarMonthBackground = System.Drawing.Color.DarkCyan;
            this.Expense_Date.CalendarTitleBackColor = System.Drawing.Color.DarkCyan;
            this.Expense_Date.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Expense_Date.Location = new System.Drawing.Point(118, 201);
            this.Expense_Date.Name = "Expense_Date";
            this.Expense_Date.Size = new System.Drawing.Size(151, 22);
            this.Expense_Date.TabIndex = 8;
            // 
            // Expense_Category
            // 
            this.Expense_Category.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Expense_Category.FormattingEnabled = true;
            this.Expense_Category.Items.AddRange(new object[] {
            "Rent / Housing",
            "Food",
            "Groceries",
            "Transport",
            "Utilities",
            "Healthcare",
            "Education",
            "Shopping",
            "Entertainment",
            "Bills & Subscriptions",
            "Travel",
            "Other"});
            this.Expense_Category.Location = new System.Drawing.Point(118, 166);
            this.Expense_Category.Name = "Expense_Category";
            this.Expense_Category.Size = new System.Drawing.Size(151, 24);
            this.Expense_Category.TabIndex = 7;
            // 
            // Expense_Description
            // 
            this.Expense_Description.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Expense_Description.Location = new System.Drawing.Point(118, 233);
            this.Expense_Description.Name = "Expense_Description";
            this.Expense_Description.Size = new System.Drawing.Size(151, 22);
            this.Expense_Description.TabIndex = 6;
            // 
            // Expense_Amount
            // 
            this.Expense_Amount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Expense_Amount.Location = new System.Drawing.Point(118, 135);
            this.Expense_Amount.Name = "Expense_Amount";
            this.Expense_Amount.Size = new System.Drawing.Size(151, 22);
            this.Expense_Amount.TabIndex = 5;
            this.Expense_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Expense_Amount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount :";
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddExpense";
            this.Size = new System.Drawing.Size(811, 650);
            this.Load += new System.EventHandler(this.AddExpense_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddExpenseGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView AddExpenseGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Expense_Clear;
        private System.Windows.Forms.Button Expense_Update;
        private System.Windows.Forms.Button Expense_Delete;
        private System.Windows.Forms.Button Expense_Add;
        private System.Windows.Forms.DateTimePicker Expense_Date;
        private System.Windows.Forms.ComboBox Expense_Category;
        private System.Windows.Forms.TextBox Expense_Description;
        private System.Windows.Forms.TextBox Expense_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Expense_Status;
        private System.Windows.Forms.Label label7;
    }
}

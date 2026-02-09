
namespace FinanceTracker
{
    partial class AddIncome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Income_panel1 = new System.Windows.Forms.Panel();
            this.Income_Clear = new System.Windows.Forms.Button();
            this.Income_Update = new System.Windows.Forms.Button();
            this.Income_Delete = new System.Windows.Forms.Button();
            this.Income_Add = new System.Windows.Forms.Button();
            this.Income_Date = new System.Windows.Forms.DateTimePicker();
            this.Income_Category = new System.Windows.Forms.ComboBox();
            this.Income_Description = new System.Windows.Forms.TextBox();
            this.Income_Amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.AddIncomeGrid = new System.Windows.Forms.DataGridView();
            this.Income_panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddIncomeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Income_panel1
            // 
            this.Income_panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Income_panel1.Controls.Add(this.Income_Clear);
            this.Income_panel1.Controls.Add(this.Income_Update);
            this.Income_panel1.Controls.Add(this.Income_Delete);
            this.Income_panel1.Controls.Add(this.Income_Add);
            this.Income_panel1.Controls.Add(this.Income_Date);
            this.Income_panel1.Controls.Add(this.Income_Category);
            this.Income_panel1.Controls.Add(this.Income_Description);
            this.Income_panel1.Controls.Add(this.Income_Amount);
            this.Income_panel1.Controls.Add(this.label4);
            this.Income_panel1.Controls.Add(this.label3);
            this.Income_panel1.Controls.Add(this.label1);
            this.Income_panel1.Controls.Add(this.label2);
            this.Income_panel1.Location = new System.Drawing.Point(8, 9);
            this.Income_panel1.Name = "Income_panel1";
            this.Income_panel1.Size = new System.Drawing.Size(291, 631);
            this.Income_panel1.TabIndex = 0;
            // 
            // Income_Clear
            // 
            this.Income_Clear.BackColor = System.Drawing.Color.DarkCyan;
            this.Income_Clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_Clear.ForeColor = System.Drawing.Color.White;
            this.Income_Clear.Location = new System.Drawing.Point(148, 336);
            this.Income_Clear.Name = "Income_Clear";
            this.Income_Clear.Size = new System.Drawing.Size(104, 46);
            this.Income_Clear.TabIndex = 12;
            this.Income_Clear.Text = "CLEAR";
            this.Income_Clear.UseVisualStyleBackColor = false;
            this.Income_Clear.Click += new System.EventHandler(this.Income_Clear_Click);
            // 
            // Income_Update
            // 
            this.Income_Update.BackColor = System.Drawing.Color.DarkCyan;
            this.Income_Update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_Update.ForeColor = System.Drawing.Color.White;
            this.Income_Update.Location = new System.Drawing.Point(38, 336);
            this.Income_Update.Name = "Income_Update";
            this.Income_Update.Size = new System.Drawing.Size(104, 46);
            this.Income_Update.TabIndex = 11;
            this.Income_Update.Text = "UPDATE";
            this.Income_Update.UseVisualStyleBackColor = false;
            this.Income_Update.Click += new System.EventHandler(this.Income_Update_Click);
            // 
            // Income_Delete
            // 
            this.Income_Delete.BackColor = System.Drawing.Color.DarkCyan;
            this.Income_Delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_Delete.ForeColor = System.Drawing.Color.White;
            this.Income_Delete.Location = new System.Drawing.Point(148, 284);
            this.Income_Delete.Name = "Income_Delete";
            this.Income_Delete.Size = new System.Drawing.Size(104, 46);
            this.Income_Delete.TabIndex = 10;
            this.Income_Delete.Text = "DELETE";
            this.Income_Delete.UseVisualStyleBackColor = false;
            this.Income_Delete.Click += new System.EventHandler(this.Income_Delete_Click);
            // 
            // Income_Add
            // 
            this.Income_Add.BackColor = System.Drawing.Color.DarkCyan;
            this.Income_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.Income_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.Income_Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_Add.ForeColor = System.Drawing.Color.White;
            this.Income_Add.Location = new System.Drawing.Point(38, 284);
            this.Income_Add.Name = "Income_Add";
            this.Income_Add.Size = new System.Drawing.Size(104, 46);
            this.Income_Add.TabIndex = 9;
            this.Income_Add.Text = "ADD";
            this.Income_Add.UseVisualStyleBackColor = false;
            this.Income_Add.Click += new System.EventHandler(this.Income_Add_Click);
            // 
            // Income_Date
            // 
            this.Income_Date.CalendarFont = new System.Drawing.Font("Arial", 11.25F);
            this.Income_Date.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_Date.Location = new System.Drawing.Point(118, 204);
            this.Income_Date.Name = "Income_Date";
            this.Income_Date.Size = new System.Drawing.Size(151, 22);
            this.Income_Date.TabIndex = 8;
            this.Income_Date.Value = new System.DateTime(2026, 2, 8, 13, 25, 25, 0);
            // 
            // Income_Category
            // 
            this.Income_Category.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_Category.FormattingEnabled = true;
            this.Income_Category.Items.AddRange(new object[] {
            "Salary",
            "Business ",
            "Freelance",
            "Scholarship / Stipend",
            "Pocket Money",
            "Investment Return",
            "Other"});
            this.Income_Category.Location = new System.Drawing.Point(118, 170);
            this.Income_Category.Name = "Income_Category";
            this.Income_Category.Size = new System.Drawing.Size(151, 24);
            this.Income_Category.TabIndex = 7;
            // 
            // Income_Description
            // 
            this.Income_Description.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_Description.Location = new System.Drawing.Point(118, 235);
            this.Income_Description.Name = "Income_Description";
            this.Income_Description.Size = new System.Drawing.Size(151, 22);
            this.Income_Description.TabIndex = 6;
            // 
            // Income_Amount
            // 
            this.Income_Amount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_Amount.Location = new System.Drawing.Point(118, 133);
            this.Income_Amount.Name = "Income_Amount";
            this.Income_Amount.Size = new System.Drawing.Size(151, 22);
            this.Income_Amount.TabIndex = 5;
            this.Income_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Income_Amount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 176);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AddIncomeGrid);
            this.panel2.Location = new System.Drawing.Point(309, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 631);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "INCOME";
            // 
            // AddIncomeGrid
            // 
            this.AddIncomeGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AddIncomeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddIncomeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AddIncomeGrid.EnableHeadersVisualStyles = false;
            this.AddIncomeGrid.Location = new System.Drawing.Point(15, 52);
            this.AddIncomeGrid.Name = "AddIncomeGrid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddIncomeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AddIncomeGrid.RowHeadersVisible = false;
            this.AddIncomeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AddIncomeGrid.Size = new System.Drawing.Size(463, 564);
            this.AddIncomeGrid.TabIndex = 0;
            this.AddIncomeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddIncomeGrid_CellClick);
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Income_panel1);
            this.Name = "AddIncome";
            this.Size = new System.Drawing.Size(811, 650);
            this.Load += new System.EventHandler(this.AddIncome_Load);
            this.Income_panel1.ResumeLayout(false);
            this.Income_panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddIncomeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Income_panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView AddIncomeGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Income_Clear;
        private System.Windows.Forms.Button Income_Update;
        private System.Windows.Forms.Button Income_Delete;
        private System.Windows.Forms.Button Income_Add;
        private System.Windows.Forms.DateTimePicker Income_Date;
        private System.Windows.Forms.ComboBox Income_Category;
        private System.Windows.Forms.TextBox Income_Description;
        private System.Windows.Forms.TextBox Income_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

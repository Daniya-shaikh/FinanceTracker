
namespace FinanceTracker
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHello = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ExpenseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvRecentTransactions = new System.Windows.Forms.DataGridView();
            this.IncomeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lblHello);
            this.panel3.Location = new System.Drawing.Point(7, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 104);
            this.panel3.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Take a look at your current balance ";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BackColor = System.Drawing.Color.Transparent;
            this.lblHello.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblHello.Location = new System.Drawing.Point(16, 20);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(93, 33);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Hello,";
            this.lblHello.Click += new System.EventHandler(this.lblHello_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(343, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 104);
            this.panel4.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkCyan;
            this.panel8.Controls.Add(this.lblBalance);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(325, 11);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(134, 83);
            this.panel8.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(9, 45);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(19, 19);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "BALANCE";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkCyan;
            this.panel7.Controls.Add(this.lblTotalExpense);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(171, 11);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(134, 83);
            this.panel7.TabIndex = 1;
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalExpense.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpense.ForeColor = System.Drawing.Color.White;
            this.lblTotalExpense.Location = new System.Drawing.Point(9, 45);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(19, 19);
            this.lblTotalExpense.TabIndex = 4;
            this.lblTotalExpense.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "EXPENSE";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkCyan;
            this.panel6.Controls.Add(this.lblTotalIncome);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(13, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(134, 83);
            this.panel6.TabIndex = 0;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalIncome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncome.ForeColor = System.Drawing.Color.White;
            this.lblTotalIncome.Location = new System.Drawing.Point(16, 46);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(19, 19);
            this.lblTotalIncome.TabIndex = 3;
            this.lblTotalIncome.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(9, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "INCOME";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.dgvRecentTransactions);
            this.panel5.Location = new System.Drawing.Point(7, 443);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(809, 211);
            this.panel5.TabIndex = 5;
            // 
            // ExpenseChart
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F);
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.ExpenseChart.ChartAreas.Add(chartArea1);
            this.ExpenseChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ExpenseChart.Legends.Add(legend1);
            this.ExpenseChart.Location = new System.Drawing.Point(0, 0);
            this.ExpenseChart.Name = "ExpenseChart";
            this.ExpenseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DarkCyan;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ExpenseChart.Series.Add(series1);
            this.ExpenseChart.Size = new System.Drawing.Size(421, 287);
            this.ExpenseChart.TabIndex = 4;
            this.ExpenseChart.Text = "chart2";
            title1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DarkCyan;
            title1.Name = "Title1";
            title1.Text = "Monthly Expense";
            this.ExpenseChart.Titles.Add(title1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkCyan;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Recent Transactions :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dgvRecentTransactions
            // 
            this.dgvRecentTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentTransactions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRecentTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentTransactions.EnableHeadersVisualStyles = false;
            this.dgvRecentTransactions.Location = new System.Drawing.Point(0, 0);
            this.dgvRecentTransactions.Name = "dgvRecentTransactions";
            this.dgvRecentTransactions.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentTransactions.RowHeadersVisible = false;
            this.dgvRecentTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRecentTransactions.Size = new System.Drawing.Size(809, 211);
            this.dgvRecentTransactions.TabIndex = 1;
            this.dgvRecentTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentTransactions_CellContentClick);
            // 
            // IncomeChart
            // 
            this.IncomeChart.BorderlineWidth = 0;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F);
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.IncomeChart.ChartAreas.Add(chartArea2);
            this.IncomeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.IncomeChart.Legends.Add(legend2);
            this.IncomeChart.Location = new System.Drawing.Point(0, 0);
            this.IncomeChart.Name = "IncomeChart";
            this.IncomeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BorderWidth = 0;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.DarkCyan;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.IncomeChart.Series.Add(series2);
            this.IncomeChart.Size = new System.Drawing.Size(382, 287);
            this.IncomeChart.TabIndex = 3;
            this.IncomeChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.DarkCyan;
            title2.Name = "Title1";
            title2.Text = "Monthly Income";
            this.IncomeChart.Titles.Add(title2);
            this.IncomeChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IncomeChart);
            this.panel1.Location = new System.Drawing.Point(7, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 287);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExpenseChart);
            this.panel2.Location = new System.Drawing.Point(395, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 287);
            this.panel2.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(822, 665);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvRecentTransactions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExpenseChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart IncomeChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

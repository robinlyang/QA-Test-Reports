namespace QA_Test_Reports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.addTestGroupBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.totalNumLbl = new System.Windows.Forms.Label();
            this.progressLbl = new System.Windows.Forms.Label();
            this.progressNumLbl = new System.Windows.Forms.Label();
            this.passRateLbl = new System.Windows.Forms.Label();
            this.passRateNumLbl = new System.Windows.Forms.Label();
            this.failRateLbl = new System.Windows.Forms.Label();
            this.failRateNumLbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.testGroupTab = new System.Windows.Forms.TabPage();
            this.testGroupList = new System.Windows.Forms.ListBox();
            this.testCaseTab = new System.Windows.Forms.TabPage();
            this.testCaseList = new System.Windows.Forms.ListBox();
            this.executionTab = new System.Windows.Forms.TabPage();
            this.testCaseGrid = new System.Windows.Forms.DataGridView();
            this.testCaseStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCSteps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminTab = new System.Windows.Forms.TabPage();
            this.resetBtn = new System.Windows.Forms.Button();
            this.mainPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.emailBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.testGroupTab.SuspendLayout();
            this.testCaseTab.SuspendLayout();
            this.executionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testCaseGrid)).BeginInit();
            this.adminTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // addTestGroupBtn
            // 
            this.addTestGroupBtn.Location = new System.Drawing.Point(13, 13);
            this.addTestGroupBtn.Name = "addTestGroupBtn";
            this.addTestGroupBtn.Size = new System.Drawing.Size(140, 28);
            this.addTestGroupBtn.TabIndex = 0;
            this.addTestGroupBtn.Text = "Add Test Group";
            this.addTestGroupBtn.UseVisualStyleBackColor = true;
            this.addTestGroupBtn.Click += new System.EventHandler(this.addTestGroupBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(12, 55);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(44, 17);
            this.totalLbl.TabIndex = 1;
            this.totalLbl.Text = "Total:";
            // 
            // totalNumLbl
            // 
            this.totalNumLbl.AutoSize = true;
            this.totalNumLbl.Location = new System.Drawing.Point(62, 55);
            this.totalNumLbl.Name = "totalNumLbl";
            this.totalNumLbl.Size = new System.Drawing.Size(16, 17);
            this.totalNumLbl.TabIndex = 2;
            this.totalNumLbl.Text = "0";
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Location = new System.Drawing.Point(12, 85);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(69, 17);
            this.progressLbl.TabIndex = 3;
            this.progressLbl.Text = "Progress:";
            // 
            // progressNumLbl
            // 
            this.progressNumLbl.AutoSize = true;
            this.progressNumLbl.Location = new System.Drawing.Point(87, 85);
            this.progressNumLbl.Name = "progressNumLbl";
            this.progressNumLbl.Size = new System.Drawing.Size(16, 17);
            this.progressNumLbl.TabIndex = 4;
            this.progressNumLbl.Text = "0";
            // 
            // passRateLbl
            // 
            this.passRateLbl.AutoSize = true;
            this.passRateLbl.Location = new System.Drawing.Point(12, 115);
            this.passRateLbl.Name = "passRateLbl";
            this.passRateLbl.Size = new System.Drawing.Size(77, 17);
            this.passRateLbl.TabIndex = 5;
            this.passRateLbl.Text = "Pass Rate:";
            // 
            // passRateNumLbl
            // 
            this.passRateNumLbl.AutoSize = true;
            this.passRateNumLbl.Location = new System.Drawing.Point(89, 115);
            this.passRateNumLbl.Name = "passRateNumLbl";
            this.passRateNumLbl.Size = new System.Drawing.Size(16, 17);
            this.passRateNumLbl.TabIndex = 6;
            this.passRateNumLbl.Text = "0";
            // 
            // failRateLbl
            // 
            this.failRateLbl.AutoSize = true;
            this.failRateLbl.Location = new System.Drawing.Point(12, 144);
            this.failRateLbl.Name = "failRateLbl";
            this.failRateLbl.Size = new System.Drawing.Size(68, 17);
            this.failRateLbl.TabIndex = 7;
            this.failRateLbl.Text = "Fail Rate:";
            // 
            // failRateNumLbl
            // 
            this.failRateNumLbl.AutoSize = true;
            this.failRateNumLbl.Location = new System.Drawing.Point(86, 144);
            this.failRateNumLbl.Name = "failRateNumLbl";
            this.failRateNumLbl.Size = new System.Drawing.Size(16, 17);
            this.failRateNumLbl.TabIndex = 8;
            this.failRateNumLbl.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.testGroupTab);
            this.tabControl1.Controls.Add(this.testCaseTab);
            this.tabControl1.Controls.Add(this.executionTab);
            this.tabControl1.Controls.Add(this.adminTab);
            this.tabControl1.Location = new System.Drawing.Point(244, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 400);
            this.tabControl1.TabIndex = 9;
            // 
            // testGroupTab
            // 
            this.testGroupTab.Controls.Add(this.testGroupList);
            this.testGroupTab.Location = new System.Drawing.Point(4, 25);
            this.testGroupTab.Name = "testGroupTab";
            this.testGroupTab.Padding = new System.Windows.Forms.Padding(3);
            this.testGroupTab.Size = new System.Drawing.Size(898, 371);
            this.testGroupTab.TabIndex = 0;
            this.testGroupTab.Text = "Test Groups";
            this.testGroupTab.UseVisualStyleBackColor = true;
            // 
            // testGroupList
            // 
            this.testGroupList.FormattingEnabled = true;
            this.testGroupList.ItemHeight = 16;
            this.testGroupList.Location = new System.Drawing.Point(6, 6);
            this.testGroupList.Name = "testGroupList";
            this.testGroupList.Size = new System.Drawing.Size(361, 356);
            this.testGroupList.TabIndex = 0;
            // 
            // testCaseTab
            // 
            this.testCaseTab.Controls.Add(this.testCaseList);
            this.testCaseTab.Location = new System.Drawing.Point(4, 25);
            this.testCaseTab.Name = "testCaseTab";
            this.testCaseTab.Padding = new System.Windows.Forms.Padding(3);
            this.testCaseTab.Size = new System.Drawing.Size(898, 371);
            this.testCaseTab.TabIndex = 1;
            this.testCaseTab.Text = "Test Cases";
            this.testCaseTab.UseVisualStyleBackColor = true;
            // 
            // testCaseList
            // 
            this.testCaseList.FormattingEnabled = true;
            this.testCaseList.ItemHeight = 16;
            this.testCaseList.Location = new System.Drawing.Point(7, 7);
            this.testCaseList.Name = "testCaseList";
            this.testCaseList.Size = new System.Drawing.Size(299, 356);
            this.testCaseList.TabIndex = 0;
            // 
            // executionTab
            // 
            this.executionTab.Controls.Add(this.testCaseGrid);
            this.executionTab.Location = new System.Drawing.Point(4, 25);
            this.executionTab.Name = "executionTab";
            this.executionTab.Size = new System.Drawing.Size(898, 371);
            this.executionTab.TabIndex = 2;
            this.executionTab.Text = "Execution";
            this.executionTab.UseVisualStyleBackColor = true;
            // 
            // testCaseGrid
            // 
            this.testCaseGrid.AllowUserToDeleteRows = false;
            this.testCaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testCaseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testCaseStatus,
            this.passPercentage,
            this.failPercentage,
            this.otherPercentage,
            this.tCNumber,
            this.tCName,
            this.tCSteps});
            this.testCaseGrid.Location = new System.Drawing.Point(4, 4);
            this.testCaseGrid.Name = "testCaseGrid";
            this.testCaseGrid.ReadOnly = true;
            this.testCaseGrid.RowTemplate.Height = 24;
            this.testCaseGrid.Size = new System.Drawing.Size(891, 364);
            this.testCaseGrid.TabIndex = 0;
            // 
            // testCaseStatus
            // 
            this.testCaseStatus.HeaderText = "Status";
            this.testCaseStatus.Name = "testCaseStatus";
            this.testCaseStatus.ReadOnly = true;
            // 
            // passPercentage
            // 
            this.passPercentage.HeaderText = "Pass %";
            this.passPercentage.Name = "passPercentage";
            this.passPercentage.ReadOnly = true;
            // 
            // failPercentage
            // 
            this.failPercentage.HeaderText = "Fail %";
            this.failPercentage.Name = "failPercentage";
            this.failPercentage.ReadOnly = true;
            // 
            // otherPercentage
            // 
            this.otherPercentage.HeaderText = "Other %";
            this.otherPercentage.Name = "otherPercentage";
            this.otherPercentage.ReadOnly = true;
            // 
            // tCNumber
            // 
            this.tCNumber.HeaderText = "TC #";
            this.tCNumber.Name = "tCNumber";
            this.tCNumber.ReadOnly = true;
            // 
            // tCName
            // 
            this.tCName.HeaderText = "TC Name";
            this.tCName.Name = "tCName";
            this.tCName.ReadOnly = true;
            // 
            // tCSteps
            // 
            this.tCSteps.HeaderText = "TC Steps";
            this.tCSteps.Name = "tCSteps";
            this.tCSteps.ReadOnly = true;
            // 
            // adminTab
            // 
            this.adminTab.Controls.Add(this.resetBtn);
            this.adminTab.Location = new System.Drawing.Point(4, 25);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(898, 371);
            this.adminTab.TabIndex = 3;
            this.adminTab.Text = "Admin";
            this.adminTab.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(14, 10);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 24);
            this.resetBtn.TabIndex = 0;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // mainPieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.mainPieChart.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.mainPieChart.Legends.Add(legend2);
            this.mainPieChart.Location = new System.Drawing.Point(3, 175);
            this.mainPieChart.Name = "mainPieChart";
            this.mainPieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.mainPieChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Purple};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.EmptyPointStyle.IsValueShownAsLabel = true;
            series2.IsValueShownAsLabel = true;
            series2.Label = "#VAL{N0}%";
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Status";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.mainPieChart.Series.Add(series2);
            this.mainPieChart.Size = new System.Drawing.Size(239, 238);
            this.mainPieChart.TabIndex = 10;
            this.mainPieChart.Text = "chart1";
            // 
            // emailBtn
            // 
            this.emailBtn.Location = new System.Drawing.Point(159, 13);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(75, 28);
            this.emailBtn.TabIndex = 11;
            this.emailBtn.Text = "Email";
            this.emailBtn.UseVisualStyleBackColor = true;
            this.emailBtn.Visible = false;
            this.emailBtn.Click += new System.EventHandler(this.emailBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 425);
            this.Controls.Add(this.emailBtn);
            this.Controls.Add(this.mainPieChart);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.failRateNumLbl);
            this.Controls.Add(this.failRateLbl);
            this.Controls.Add(this.passRateNumLbl);
            this.Controls.Add(this.passRateLbl);
            this.Controls.Add(this.progressNumLbl);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.totalNumLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.addTestGroupBtn);
            this.Name = "MainForm";
            this.Text = "QA Test Reports";
            this.tabControl1.ResumeLayout(false);
            this.testGroupTab.ResumeLayout(false);
            this.testCaseTab.ResumeLayout(false);
            this.executionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testCaseGrid)).EndInit();
            this.adminTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTestGroupBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label totalNumLbl;
        private System.Windows.Forms.Label progressLbl;
        private System.Windows.Forms.Label progressNumLbl;
        private System.Windows.Forms.Label passRateLbl;
        private System.Windows.Forms.Label passRateNumLbl;
        private System.Windows.Forms.Label failRateLbl;
        private System.Windows.Forms.Label failRateNumLbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage testGroupTab;
        private System.Windows.Forms.TabPage testCaseTab;
        private System.Windows.Forms.TabPage executionTab;
        private System.Windows.Forms.TabPage adminTab;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ListBox testCaseList;
        private System.Windows.Forms.DataGridView testCaseGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn testCaseStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn passPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn failPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCSteps;
        private System.Windows.Forms.ListBox testGroupList;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainPieChart;
        private System.Windows.Forms.Button emailBtn;
    }
}


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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.testGroupPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupFailRateNumLbl = new System.Windows.Forms.Label();
            this.projectTxtBox = new System.Windows.Forms.TextBox();
            this.groupLbl = new System.Windows.Forms.Label();
            this.groupFailRateLbl = new System.Windows.Forms.Label();
            this.totalTCsGroupNumLbl = new System.Windows.Forms.Label();
            this.groupTxtBox = new System.Windows.Forms.TextBox();
            this.groupPassRateNumLbl = new System.Windows.Forms.Label();
            this.totalTCsGroupLbl = new System.Windows.Forms.Label();
            this.projectLbl = new System.Windows.Forms.Label();
            this.groupPassRateLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.typeTxtBox = new System.Windows.Forms.TextBox();
            this.progressTCsGroupNumLbl = new System.Windows.Forms.Label();
            this.dateRangeLbl = new System.Windows.Forms.Label();
            this.grpStartMnForm = new System.Windows.Forms.DateTimePicker();
            this.progressTCsGroupLbl = new System.Windows.Forms.Label();
            this.toLbl = new System.Windows.Forms.Label();
            this.grpEndMnForm = new System.Windows.Forms.DateTimePicker();
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
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.testGroupTab.SuspendLayout();
            this.testGroupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupPieChart)).BeginInit();
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
            this.totalLbl.Size = new System.Drawing.Size(149, 17);
            this.totalLbl.TabIndex = 1;
            this.totalLbl.Text = "Total TC\'s under Test:";
            // 
            // totalNumLbl
            // 
            this.totalNumLbl.AutoSize = true;
            this.totalNumLbl.Location = new System.Drawing.Point(167, 55);
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
            this.progressLbl.Size = new System.Drawing.Size(102, 17);
            this.progressLbl.TabIndex = 3;
            this.progressLbl.Text = "TC\'s Executed:";
            // 
            // progressNumLbl
            // 
            this.progressNumLbl.AutoSize = true;
            this.progressNumLbl.Location = new System.Drawing.Point(114, 85);
            this.progressNumLbl.Name = "progressNumLbl";
            this.progressNumLbl.Size = new System.Drawing.Size(16, 17);
            this.progressNumLbl.TabIndex = 4;
            this.progressNumLbl.Text = "0";
            // 
            // passRateLbl
            // 
            this.passRateLbl.AutoSize = true;
            this.passRateLbl.Location = new System.Drawing.Point(37, 113);
            this.passRateLbl.Name = "passRateLbl";
            this.passRateLbl.Size = new System.Drawing.Size(77, 17);
            this.passRateLbl.TabIndex = 5;
            this.passRateLbl.Text = "Pass Rate:";
            // 
            // passRateNumLbl
            // 
            this.passRateNumLbl.AutoSize = true;
            this.passRateNumLbl.Location = new System.Drawing.Point(114, 113);
            this.passRateNumLbl.Name = "passRateNumLbl";
            this.passRateNumLbl.Size = new System.Drawing.Size(16, 17);
            this.passRateNumLbl.TabIndex = 6;
            this.passRateNumLbl.Text = "0";
            // 
            // failRateLbl
            // 
            this.failRateLbl.AutoSize = true;
            this.failRateLbl.Location = new System.Drawing.Point(46, 142);
            this.failRateLbl.Name = "failRateLbl";
            this.failRateLbl.Size = new System.Drawing.Size(68, 17);
            this.failRateLbl.TabIndex = 7;
            this.failRateLbl.Text = "Fail Rate:";
            // 
            // failRateNumLbl
            // 
            this.failRateNumLbl.AutoSize = true;
            this.failRateNumLbl.Location = new System.Drawing.Point(114, 142);
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
            this.tabControl1.Location = new System.Drawing.Point(268, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 400);
            this.tabControl1.TabIndex = 9;
            // 
            // testGroupTab
            // 
            this.testGroupTab.Controls.Add(this.testGroupPanel);
            this.testGroupTab.Controls.Add(this.testGroupList);
            this.testGroupTab.Location = new System.Drawing.Point(4, 25);
            this.testGroupTab.Name = "testGroupTab";
            this.testGroupTab.Padding = new System.Windows.Forms.Padding(3);
            this.testGroupTab.Size = new System.Drawing.Size(898, 371);
            this.testGroupTab.TabIndex = 0;
            this.testGroupTab.Text = "Test Groups";
            this.testGroupTab.UseVisualStyleBackColor = true;
            // 
            // testGroupPanel
            // 
            this.testGroupPanel.Controls.Add(this.button2);
            this.testGroupPanel.Controls.Add(this.button1);
            this.testGroupPanel.Controls.Add(this.groupPieChart);
            this.testGroupPanel.Controls.Add(this.groupFailRateNumLbl);
            this.testGroupPanel.Controls.Add(this.projectTxtBox);
            this.testGroupPanel.Controls.Add(this.groupLbl);
            this.testGroupPanel.Controls.Add(this.groupFailRateLbl);
            this.testGroupPanel.Controls.Add(this.totalTCsGroupNumLbl);
            this.testGroupPanel.Controls.Add(this.groupTxtBox);
            this.testGroupPanel.Controls.Add(this.groupPassRateNumLbl);
            this.testGroupPanel.Controls.Add(this.totalTCsGroupLbl);
            this.testGroupPanel.Controls.Add(this.projectLbl);
            this.testGroupPanel.Controls.Add(this.groupPassRateLbl);
            this.testGroupPanel.Controls.Add(this.typeLbl);
            this.testGroupPanel.Controls.Add(this.typeTxtBox);
            this.testGroupPanel.Controls.Add(this.progressTCsGroupNumLbl);
            this.testGroupPanel.Controls.Add(this.dateRangeLbl);
            this.testGroupPanel.Controls.Add(this.grpStartMnForm);
            this.testGroupPanel.Controls.Add(this.progressTCsGroupLbl);
            this.testGroupPanel.Controls.Add(this.toLbl);
            this.testGroupPanel.Controls.Add(this.grpEndMnForm);
            this.testGroupPanel.Location = new System.Drawing.Point(311, 6);
            this.testGroupPanel.Name = "testGroupPanel";
            this.testGroupPanel.Size = new System.Drawing.Size(581, 356);
            this.testGroupPanel.TabIndex = 1;
            this.testGroupPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "Email";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupPieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.groupPieChart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.groupPieChart.Legends.Add(legend1);
            this.groupPieChart.Location = new System.Drawing.Point(97, 143);
            this.groupPieChart.Name = "groupPieChart";
            this.groupPieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.groupPieChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.Purple};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Label = "#VAL{N0}%";
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "IdvGroupStatus";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.groupPieChart.Series.Add(series1);
            this.groupPieChart.Size = new System.Drawing.Size(248, 210);
            this.groupPieChart.TabIndex = 19;
            this.groupPieChart.Text = "chart1";
            // 
            // groupFailRateNumLbl
            // 
            this.groupFailRateNumLbl.AutoSize = true;
            this.groupFailRateNumLbl.Location = new System.Drawing.Point(513, 115);
            this.groupFailRateNumLbl.Name = "groupFailRateNumLbl";
            this.groupFailRateNumLbl.Size = new System.Drawing.Size(16, 17);
            this.groupFailRateNumLbl.TabIndex = 18;
            this.groupFailRateNumLbl.Text = "0";
            // 
            // projectTxtBox
            // 
            this.projectTxtBox.Location = new System.Drawing.Point(97, 3);
            this.projectTxtBox.Name = "projectTxtBox";
            this.projectTxtBox.Size = new System.Drawing.Size(246, 22);
            this.projectTxtBox.TabIndex = 6;
            // 
            // groupLbl
            // 
            this.groupLbl.AutoSize = true;
            this.groupLbl.Location = new System.Drawing.Point(43, 36);
            this.groupLbl.Name = "groupLbl";
            this.groupLbl.Size = new System.Drawing.Size(52, 17);
            this.groupLbl.TabIndex = 3;
            this.groupLbl.Text = "Group:";
            // 
            // groupFailRateLbl
            // 
            this.groupFailRateLbl.AutoSize = true;
            this.groupFailRateLbl.Location = new System.Drawing.Point(404, 115);
            this.groupFailRateLbl.Name = "groupFailRateLbl";
            this.groupFailRateLbl.Size = new System.Drawing.Size(112, 17);
            this.groupFailRateLbl.TabIndex = 17;
            this.groupFailRateLbl.Text = "Group Fail Rate:";
            // 
            // totalTCsGroupNumLbl
            // 
            this.totalTCsGroupNumLbl.AutoSize = true;
            this.totalTCsGroupNumLbl.Location = new System.Drawing.Point(513, 34);
            this.totalTCsGroupNumLbl.Name = "totalTCsGroupNumLbl";
            this.totalTCsGroupNumLbl.Size = new System.Drawing.Size(16, 17);
            this.totalTCsGroupNumLbl.TabIndex = 2;
            this.totalTCsGroupNumLbl.Text = "0";
            // 
            // groupTxtBox
            // 
            this.groupTxtBox.Location = new System.Drawing.Point(97, 31);
            this.groupTxtBox.Name = "groupTxtBox";
            this.groupTxtBox.Size = new System.Drawing.Size(246, 22);
            this.groupTxtBox.TabIndex = 4;
            // 
            // groupPassRateNumLbl
            // 
            this.groupPassRateNumLbl.AutoSize = true;
            this.groupPassRateNumLbl.Location = new System.Drawing.Point(513, 88);
            this.groupPassRateNumLbl.Name = "groupPassRateNumLbl";
            this.groupPassRateNumLbl.Size = new System.Drawing.Size(16, 17);
            this.groupPassRateNumLbl.TabIndex = 16;
            this.groupPassRateNumLbl.Text = "0";
            // 
            // totalTCsGroupLbl
            // 
            this.totalTCsGroupLbl.AutoSize = true;
            this.totalTCsGroupLbl.Location = new System.Drawing.Point(375, 34);
            this.totalTCsGroupLbl.Name = "totalTCsGroupLbl";
            this.totalTCsGroupLbl.Size = new System.Drawing.Size(141, 17);
            this.totalTCsGroupLbl.TabIndex = 1;
            this.totalTCsGroupLbl.Text = "Total TC\'s for Group:";
            // 
            // projectLbl
            // 
            this.projectLbl.AutoSize = true;
            this.projectLbl.Location = new System.Drawing.Point(39, 8);
            this.projectLbl.Name = "projectLbl";
            this.projectLbl.Size = new System.Drawing.Size(56, 17);
            this.projectLbl.TabIndex = 5;
            this.projectLbl.Text = "Project:";
            // 
            // groupPassRateLbl
            // 
            this.groupPassRateLbl.AutoSize = true;
            this.groupPassRateLbl.Location = new System.Drawing.Point(395, 88);
            this.groupPassRateLbl.Name = "groupPassRateLbl";
            this.groupPassRateLbl.Size = new System.Drawing.Size(121, 17);
            this.groupPassRateLbl.TabIndex = 15;
            this.groupPassRateLbl.Text = "Group Pass Rate:";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(51, 62);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(44, 17);
            this.typeLbl.TabIndex = 7;
            this.typeLbl.Text = "Type:";
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Location = new System.Drawing.Point(97, 59);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.Size = new System.Drawing.Size(246, 22);
            this.typeTxtBox.TabIndex = 8;
            // 
            // progressTCsGroupNumLbl
            // 
            this.progressTCsGroupNumLbl.AutoSize = true;
            this.progressTCsGroupNumLbl.Location = new System.Drawing.Point(513, 62);
            this.progressTCsGroupNumLbl.Name = "progressTCsGroupNumLbl";
            this.progressTCsGroupNumLbl.Size = new System.Drawing.Size(16, 17);
            this.progressTCsGroupNumLbl.TabIndex = 14;
            this.progressTCsGroupNumLbl.Text = "0";
            // 
            // dateRangeLbl
            // 
            this.dateRangeLbl.AutoSize = true;
            this.dateRangeLbl.Location = new System.Drawing.Point(7, 92);
            this.dateRangeLbl.Name = "dateRangeLbl";
            this.dateRangeLbl.Size = new System.Drawing.Size(88, 17);
            this.dateRangeLbl.TabIndex = 9;
            this.dateRangeLbl.Text = "Date Range:";
            // 
            // grpStartMnForm
            // 
            this.grpStartMnForm.Location = new System.Drawing.Point(97, 87);
            this.grpStartMnForm.Name = "grpStartMnForm";
            this.grpStartMnForm.Size = new System.Drawing.Size(246, 22);
            this.grpStartMnForm.TabIndex = 10;
            // 
            // progressTCsGroupLbl
            // 
            this.progressTCsGroupLbl.AutoSize = true;
            this.progressTCsGroupLbl.Location = new System.Drawing.Point(349, 62);
            this.progressTCsGroupLbl.Name = "progressTCsGroupLbl";
            this.progressTCsGroupLbl.Size = new System.Drawing.Size(167, 17);
            this.progressTCsGroupLbl.TabIndex = 13;
            this.progressTCsGroupLbl.Text = "TC\'s Executed for Group:";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(71, 118);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(20, 17);
            this.toLbl.TabIndex = 11;
            this.toLbl.Text = "to";
            // 
            // grpEndMnForm
            // 
            this.grpEndMnForm.Location = new System.Drawing.Point(97, 115);
            this.grpEndMnForm.Name = "grpEndMnForm";
            this.grpEndMnForm.Size = new System.Drawing.Size(246, 22);
            this.grpEndMnForm.TabIndex = 12;
            // 
            // testGroupList
            // 
            this.testGroupList.FormattingEnabled = true;
            this.testGroupList.ItemHeight = 16;
            this.testGroupList.Location = new System.Drawing.Point(6, 6);
            this.testGroupList.Name = "testGroupList";
            this.testGroupList.Size = new System.Drawing.Size(299, 356);
            this.testGroupList.TabIndex = 0;
            this.testGroupList.SelectedIndexChanged += new System.EventHandler(this.testGroupList_SelectedIndexChanged);
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
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
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
            this.mainPieChart.Size = new System.Drawing.Size(259, 238);
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
            // mainProgressBar
            // 
            this.mainProgressBar.Location = new System.Drawing.Point(3, 415);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(1179, 10);
            this.mainProgressBar.TabIndex = 12;
            this.mainProgressBar.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 429);
            this.Controls.Add(this.mainProgressBar);
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
            this.testGroupPanel.ResumeLayout(false);
            this.testGroupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupPieChart)).EndInit();
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
        private System.Windows.Forms.Label totalTCsGroupNumLbl;
        private System.Windows.Forms.Label totalTCsGroupLbl;
        private System.Windows.Forms.TextBox typeTxtBox;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.TextBox projectTxtBox;
        private System.Windows.Forms.Label projectLbl;
        private System.Windows.Forms.TextBox groupTxtBox;
        private System.Windows.Forms.Label groupLbl;
        private System.Windows.Forms.Label progressTCsGroupNumLbl;
        private System.Windows.Forms.Label progressTCsGroupLbl;
        private System.Windows.Forms.DateTimePicker grpEndMnForm;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.DateTimePicker grpStartMnForm;
        private System.Windows.Forms.Label dateRangeLbl;
        private System.Windows.Forms.Label groupFailRateNumLbl;
        private System.Windows.Forms.Label groupFailRateLbl;
        private System.Windows.Forms.Label groupPassRateNumLbl;
        private System.Windows.Forms.Label groupPassRateLbl;
        private System.Windows.Forms.Panel testGroupPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart groupPieChart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar mainProgressBar;
    }
}


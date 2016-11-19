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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.adminTab = new System.Windows.Forms.TabPage();
            this.resetBtn = new System.Windows.Forms.Button();
            this.mainPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.emailBtn = new System.Windows.Forms.Button();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.mainPassChkBox = new System.Windows.Forms.CheckBox();
            this.mainFailChkBox = new System.Windows.Forms.CheckBox();
            this.groupPassChkBox = new System.Windows.Forms.CheckBox();
            this.groupFailChkBox = new System.Windows.Forms.CheckBox();
            this.tCNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testCaseStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCSteps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gripProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTestType = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.addTestGroupBtn.Location = new System.Drawing.Point(10, 11);
            this.addTestGroupBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addTestGroupBtn.Name = "addTestGroupBtn";
            this.addTestGroupBtn.Size = new System.Drawing.Size(105, 23);
            this.addTestGroupBtn.TabIndex = 0;
            this.addTestGroupBtn.Text = "Add Test Group";
            this.addTestGroupBtn.UseVisualStyleBackColor = true;
            this.addTestGroupBtn.Click += new System.EventHandler(this.addTestGroupBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(9, 45);
            this.totalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(112, 13);
            this.totalLbl.TabIndex = 1;
            this.totalLbl.Text = "Total TC\'s under Test:";
            // 
            // totalNumLbl
            // 
            this.totalNumLbl.AutoSize = true;
            this.totalNumLbl.Location = new System.Drawing.Point(125, 45);
            this.totalNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalNumLbl.Name = "totalNumLbl";
            this.totalNumLbl.Size = new System.Drawing.Size(13, 13);
            this.totalNumLbl.TabIndex = 2;
            this.totalNumLbl.Text = "0";
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Location = new System.Drawing.Point(9, 69);
            this.progressLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(79, 13);
            this.progressLbl.TabIndex = 3;
            this.progressLbl.Text = "TC\'s Executed:";
            // 
            // progressNumLbl
            // 
            this.progressNumLbl.AutoSize = true;
            this.progressNumLbl.Location = new System.Drawing.Point(86, 69);
            this.progressNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressNumLbl.Name = "progressNumLbl";
            this.progressNumLbl.Size = new System.Drawing.Size(13, 13);
            this.progressNumLbl.TabIndex = 4;
            this.progressNumLbl.Text = "0";
            // 
            // passRateLbl
            // 
            this.passRateLbl.AutoSize = true;
            this.passRateLbl.Location = new System.Drawing.Point(28, 92);
            this.passRateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passRateLbl.Name = "passRateLbl";
            this.passRateLbl.Size = new System.Drawing.Size(59, 13);
            this.passRateLbl.TabIndex = 5;
            this.passRateLbl.Text = "Pass Rate:";
            // 
            // passRateNumLbl
            // 
            this.passRateNumLbl.AutoSize = true;
            this.passRateNumLbl.Location = new System.Drawing.Point(86, 92);
            this.passRateNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passRateNumLbl.Name = "passRateNumLbl";
            this.passRateNumLbl.Size = new System.Drawing.Size(13, 13);
            this.passRateNumLbl.TabIndex = 6;
            this.passRateNumLbl.Text = "0";
            // 
            // failRateLbl
            // 
            this.failRateLbl.AutoSize = true;
            this.failRateLbl.Location = new System.Drawing.Point(34, 115);
            this.failRateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.failRateLbl.Name = "failRateLbl";
            this.failRateLbl.Size = new System.Drawing.Size(52, 13);
            this.failRateLbl.TabIndex = 7;
            this.failRateLbl.Text = "Fail Rate:";
            // 
            // failRateNumLbl
            // 
            this.failRateNumLbl.AutoSize = true;
            this.failRateNumLbl.Location = new System.Drawing.Point(86, 115);
            this.failRateNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.failRateNumLbl.Name = "failRateNumLbl";
            this.failRateNumLbl.Size = new System.Drawing.Size(13, 13);
            this.failRateNumLbl.TabIndex = 8;
            this.failRateNumLbl.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.testGroupTab);
            this.tabControl1.Controls.Add(this.testCaseTab);
            this.tabControl1.Controls.Add(this.executionTab);
            this.tabControl1.Controls.Add(this.adminTab);
            this.tabControl1.Location = new System.Drawing.Point(201, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 394);
            this.tabControl1.TabIndex = 9;
            // 
            // testGroupTab
            // 
            this.testGroupTab.Controls.Add(this.testGroupPanel);
            this.testGroupTab.Controls.Add(this.testGroupList);
            this.testGroupTab.Location = new System.Drawing.Point(4, 22);
            this.testGroupTab.Margin = new System.Windows.Forms.Padding(2);
            this.testGroupTab.Name = "testGroupTab";
            this.testGroupTab.Padding = new System.Windows.Forms.Padding(2);
            this.testGroupTab.Size = new System.Drawing.Size(672, 368);
            this.testGroupTab.TabIndex = 0;
            this.testGroupTab.Text = "Test Groups";
            this.testGroupTab.UseVisualStyleBackColor = true;
            // 
            // testGroupPanel
            // 
            this.testGroupPanel.Controls.Add(this.groupFailChkBox);
            this.testGroupPanel.Controls.Add(this.groupPassChkBox);
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
            this.testGroupPanel.Location = new System.Drawing.Point(233, 5);
            this.testGroupPanel.Margin = new System.Windows.Forms.Padding(2);
            this.testGroupPanel.Name = "testGroupPanel";
            this.testGroupPanel.Size = new System.Drawing.Size(436, 359);
            this.testGroupPanel.TabIndex = 1;
            this.testGroupPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 126);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Email";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupPieChart
            // 
            chartArea5.Name = "ChartArea1";
            this.groupPieChart.ChartAreas.Add(chartArea5);
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            this.groupPieChart.Legends.Add(legend5);
            this.groupPieChart.Location = new System.Drawing.Point(73, 116);
            this.groupPieChart.Margin = new System.Windows.Forms.Padding(2);
            this.groupPieChart.Name = "groupPieChart";
            this.groupPieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.groupPieChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.Purple};
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Label = "#VAL{N0}%";
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Legend = "Legend1";
            series5.Name = "IdvGroupStatus";
            series5.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.groupPieChart.Series.Add(series5);
            this.groupPieChart.Size = new System.Drawing.Size(186, 171);
            this.groupPieChart.TabIndex = 19;
            this.groupPieChart.Text = "chart1";
            // 
            // groupFailRateNumLbl
            // 
            this.groupFailRateNumLbl.AutoSize = true;
            this.groupFailRateNumLbl.Location = new System.Drawing.Point(385, 93);
            this.groupFailRateNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupFailRateNumLbl.Name = "groupFailRateNumLbl";
            this.groupFailRateNumLbl.Size = new System.Drawing.Size(13, 13);
            this.groupFailRateNumLbl.TabIndex = 18;
            this.groupFailRateNumLbl.Text = "0";
            // 
            // projectTxtBox
            // 
            this.projectTxtBox.Location = new System.Drawing.Point(73, 2);
            this.projectTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.projectTxtBox.Name = "projectTxtBox";
            this.projectTxtBox.Size = new System.Drawing.Size(186, 20);
            this.projectTxtBox.TabIndex = 6;
            // 
            // groupLbl
            // 
            this.groupLbl.AutoSize = true;
            this.groupLbl.Location = new System.Drawing.Point(32, 29);
            this.groupLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupLbl.Name = "groupLbl";
            this.groupLbl.Size = new System.Drawing.Size(39, 13);
            this.groupLbl.TabIndex = 3;
            this.groupLbl.Text = "Group:";
            // 
            // groupFailRateLbl
            // 
            this.groupFailRateLbl.AutoSize = true;
            this.groupFailRateLbl.Location = new System.Drawing.Point(303, 93);
            this.groupFailRateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupFailRateLbl.Name = "groupFailRateLbl";
            this.groupFailRateLbl.Size = new System.Drawing.Size(84, 13);
            this.groupFailRateLbl.TabIndex = 17;
            this.groupFailRateLbl.Text = "Group Fail Rate:";
            // 
            // totalTCsGroupNumLbl
            // 
            this.totalTCsGroupNumLbl.AutoSize = true;
            this.totalTCsGroupNumLbl.Location = new System.Drawing.Point(385, 28);
            this.totalTCsGroupNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalTCsGroupNumLbl.Name = "totalTCsGroupNumLbl";
            this.totalTCsGroupNumLbl.Size = new System.Drawing.Size(13, 13);
            this.totalTCsGroupNumLbl.TabIndex = 2;
            this.totalTCsGroupNumLbl.Text = "0";
            // 
            // groupTxtBox
            // 
            this.groupTxtBox.Location = new System.Drawing.Point(73, 25);
            this.groupTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupTxtBox.Name = "groupTxtBox";
            this.groupTxtBox.Size = new System.Drawing.Size(186, 20);
            this.groupTxtBox.TabIndex = 4;
            // 
            // groupPassRateNumLbl
            // 
            this.groupPassRateNumLbl.AutoSize = true;
            this.groupPassRateNumLbl.Location = new System.Drawing.Point(385, 72);
            this.groupPassRateNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupPassRateNumLbl.Name = "groupPassRateNumLbl";
            this.groupPassRateNumLbl.Size = new System.Drawing.Size(13, 13);
            this.groupPassRateNumLbl.TabIndex = 16;
            this.groupPassRateNumLbl.Text = "0";
            // 
            // totalTCsGroupLbl
            // 
            this.totalTCsGroupLbl.AutoSize = true;
            this.totalTCsGroupLbl.Location = new System.Drawing.Point(281, 28);
            this.totalTCsGroupLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalTCsGroupLbl.Name = "totalTCsGroupLbl";
            this.totalTCsGroupLbl.Size = new System.Drawing.Size(105, 13);
            this.totalTCsGroupLbl.TabIndex = 1;
            this.totalTCsGroupLbl.Text = "Total TC\'s for Group:";
            // 
            // projectLbl
            // 
            this.projectLbl.AutoSize = true;
            this.projectLbl.Location = new System.Drawing.Point(29, 6);
            this.projectLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectLbl.Name = "projectLbl";
            this.projectLbl.Size = new System.Drawing.Size(43, 13);
            this.projectLbl.TabIndex = 5;
            this.projectLbl.Text = "Project:";
            // 
            // groupPassRateLbl
            // 
            this.groupPassRateLbl.AutoSize = true;
            this.groupPassRateLbl.Location = new System.Drawing.Point(296, 72);
            this.groupPassRateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupPassRateLbl.Name = "groupPassRateLbl";
            this.groupPassRateLbl.Size = new System.Drawing.Size(91, 13);
            this.groupPassRateLbl.TabIndex = 15;
            this.groupPassRateLbl.Text = "Group Pass Rate:";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(38, 50);
            this.typeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(34, 13);
            this.typeLbl.TabIndex = 7;
            this.typeLbl.Text = "Type:";
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Location = new System.Drawing.Point(73, 48);
            this.typeTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.Size = new System.Drawing.Size(186, 20);
            this.typeTxtBox.TabIndex = 8;
            // 
            // progressTCsGroupNumLbl
            // 
            this.progressTCsGroupNumLbl.AutoSize = true;
            this.progressTCsGroupNumLbl.Location = new System.Drawing.Point(385, 50);
            this.progressTCsGroupNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressTCsGroupNumLbl.Name = "progressTCsGroupNumLbl";
            this.progressTCsGroupNumLbl.Size = new System.Drawing.Size(13, 13);
            this.progressTCsGroupNumLbl.TabIndex = 14;
            this.progressTCsGroupNumLbl.Text = "0";
            // 
            // dateRangeLbl
            // 
            this.dateRangeLbl.AutoSize = true;
            this.dateRangeLbl.Location = new System.Drawing.Point(5, 75);
            this.dateRangeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateRangeLbl.Name = "dateRangeLbl";
            this.dateRangeLbl.Size = new System.Drawing.Size(68, 13);
            this.dateRangeLbl.TabIndex = 9;
            this.dateRangeLbl.Text = "Date Range:";
            // 
            // grpStartMnForm
            // 
            this.grpStartMnForm.Location = new System.Drawing.Point(73, 71);
            this.grpStartMnForm.Margin = new System.Windows.Forms.Padding(2);
            this.grpStartMnForm.Name = "grpStartMnForm";
            this.grpStartMnForm.Size = new System.Drawing.Size(186, 20);
            this.grpStartMnForm.TabIndex = 10;
            // 
            // progressTCsGroupLbl
            // 
            this.progressTCsGroupLbl.AutoSize = true;
            this.progressTCsGroupLbl.Location = new System.Drawing.Point(262, 50);
            this.progressTCsGroupLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressTCsGroupLbl.Name = "progressTCsGroupLbl";
            this.progressTCsGroupLbl.Size = new System.Drawing.Size(126, 13);
            this.progressTCsGroupLbl.TabIndex = 13;
            this.progressTCsGroupLbl.Text = "TC\'s Executed for Group:";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(53, 96);
            this.toLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(16, 13);
            this.toLbl.TabIndex = 11;
            this.toLbl.Text = "to";
            // 
            // grpEndMnForm
            // 
            this.grpEndMnForm.Location = new System.Drawing.Point(73, 93);
            this.grpEndMnForm.Margin = new System.Windows.Forms.Padding(2);
            this.grpEndMnForm.Name = "grpEndMnForm";
            this.grpEndMnForm.Size = new System.Drawing.Size(186, 20);
            this.grpEndMnForm.TabIndex = 12;
            // 
            // testGroupList
            // 
            this.testGroupList.FormattingEnabled = true;
            this.testGroupList.Location = new System.Drawing.Point(4, 5);
            this.testGroupList.Margin = new System.Windows.Forms.Padding(2);
            this.testGroupList.Name = "testGroupList";
            this.testGroupList.Size = new System.Drawing.Size(225, 355);
            this.testGroupList.TabIndex = 0;
            this.testGroupList.SelectedIndexChanged += new System.EventHandler(this.testGroupList_SelectedIndexChanged);
            // 
            // testCaseTab
            // 
            this.testCaseTab.Controls.Add(this.testCaseList);
            this.testCaseTab.Location = new System.Drawing.Point(4, 22);
            this.testCaseTab.Margin = new System.Windows.Forms.Padding(2);
            this.testCaseTab.Name = "testCaseTab";
            this.testCaseTab.Padding = new System.Windows.Forms.Padding(2);
            this.testCaseTab.Size = new System.Drawing.Size(672, 299);
            this.testCaseTab.TabIndex = 1;
            this.testCaseTab.Text = "Test Cases";
            this.testCaseTab.UseVisualStyleBackColor = true;
            // 
            // testCaseList
            // 
            this.testCaseList.FormattingEnabled = true;
            this.testCaseList.Location = new System.Drawing.Point(5, 6);
            this.testCaseList.Margin = new System.Windows.Forms.Padding(2);
            this.testCaseList.Name = "testCaseList";
            this.testCaseList.Size = new System.Drawing.Size(225, 290);
            this.testCaseList.TabIndex = 0;
            // 
            // executionTab
            // 
            this.executionTab.Controls.Add(this.testCaseGrid);
            this.executionTab.Location = new System.Drawing.Point(4, 22);
            this.executionTab.Margin = new System.Windows.Forms.Padding(2);
            this.executionTab.Name = "executionTab";
            this.executionTab.Size = new System.Drawing.Size(672, 368);
            this.executionTab.TabIndex = 2;
            this.executionTab.Text = "Execution";
            this.executionTab.UseVisualStyleBackColor = true;
            // 
            // testCaseGrid
            // 
            this.testCaseGrid.AllowUserToDeleteRows = false;
            this.testCaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testCaseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCNumber,
            this.tCName,
            this.testCaseStatus,
            this.passPercentage,
            this.failPercentage,
            this.otherPercentage,
            this.tCSteps,
            this.gripProject,
            this.gridGroup,
            this.gridTestType});
            this.testCaseGrid.Location = new System.Drawing.Point(3, 3);
            this.testCaseGrid.Margin = new System.Windows.Forms.Padding(2);
            this.testCaseGrid.Name = "testCaseGrid";
            this.testCaseGrid.ReadOnly = true;
            this.testCaseGrid.RowTemplate.Height = 24;
            this.testCaseGrid.Size = new System.Drawing.Size(668, 296);
            this.testCaseGrid.TabIndex = 0;
            // 
            // adminTab
            // 
            this.adminTab.Controls.Add(this.resetBtn);
            this.adminTab.Location = new System.Drawing.Point(4, 22);
            this.adminTab.Margin = new System.Windows.Forms.Padding(2);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(672, 299);
            this.adminTab.TabIndex = 3;
            this.adminTab.Text = "Admin";
            this.adminTab.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(10, 8);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(56, 20);
            this.resetBtn.TabIndex = 0;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // mainPieChart
            // 
            chartArea6.Name = "ChartArea1";
            this.mainPieChart.ChartAreas.Add(chartArea6);
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.Name = "Legend1";
            this.mainPieChart.Legends.Add(legend6);
            this.mainPieChart.Location = new System.Drawing.Point(0, 203);
            this.mainPieChart.Margin = new System.Windows.Forms.Padding(2);
            this.mainPieChart.Name = "mainPieChart";
            this.mainPieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.mainPieChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.Purple};
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.EmptyPointStyle.IsValueShownAsLabel = true;
            series6.IsValueShownAsLabel = true;
            series6.Label = "#VAL{N0}%";
            series6.LabelForeColor = System.Drawing.Color.White;
            series6.Legend = "Legend1";
            series6.Name = "Status";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series6.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.mainPieChart.Series.Add(series6);
            this.mainPieChart.Size = new System.Drawing.Size(194, 193);
            this.mainPieChart.TabIndex = 10;
            this.mainPieChart.Text = "chart1";
            // 
            // emailBtn
            // 
            this.emailBtn.Location = new System.Drawing.Point(119, 11);
            this.emailBtn.Margin = new System.Windows.Forms.Padding(2);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(56, 23);
            this.emailBtn.TabIndex = 11;
            this.emailBtn.Text = "Email";
            this.emailBtn.UseVisualStyleBackColor = true;
            this.emailBtn.Visible = false;
            this.emailBtn.Click += new System.EventHandler(this.emailBtn_Click);
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainProgressBar.Location = new System.Drawing.Point(0, 408);
            this.mainProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(890, 8);
            this.mainProgressBar.TabIndex = 12;
            this.mainProgressBar.Visible = false;
            // 
            // mainPassChkBox
            // 
            this.mainPassChkBox.AutoSize = true;
            this.mainPassChkBox.Location = new System.Drawing.Point(31, 144);
            this.mainPassChkBox.Name = "mainPassChkBox";
            this.mainPassChkBox.Size = new System.Drawing.Size(122, 17);
            this.mainPassChkBox.TabIndex = 13;
            this.mainPassChkBox.Text = "Include Pass Details";
            this.mainPassChkBox.UseVisualStyleBackColor = true;
            // 
            // mainFailChkBox
            // 
            this.mainFailChkBox.AutoSize = true;
            this.mainFailChkBox.Location = new System.Drawing.Point(31, 167);
            this.mainFailChkBox.Name = "mainFailChkBox";
            this.mainFailChkBox.Size = new System.Drawing.Size(115, 17);
            this.mainFailChkBox.TabIndex = 14;
            this.mainFailChkBox.Text = "Include Fail Details";
            this.mainFailChkBox.UseVisualStyleBackColor = true;
            // 
            // groupPassChkBox
            // 
            this.groupPassChkBox.AutoSize = true;
            this.groupPassChkBox.Location = new System.Drawing.Point(265, 197);
            this.groupPassChkBox.Name = "groupPassChkBox";
            this.groupPassChkBox.Size = new System.Drawing.Size(122, 17);
            this.groupPassChkBox.TabIndex = 22;
            this.groupPassChkBox.Text = "Include Pass Details";
            this.groupPassChkBox.UseVisualStyleBackColor = true;
            // 
            // groupFailChkBox
            // 
            this.groupFailChkBox.AutoSize = true;
            this.groupFailChkBox.Location = new System.Drawing.Point(265, 231);
            this.groupFailChkBox.Name = "groupFailChkBox";
            this.groupFailChkBox.Size = new System.Drawing.Size(115, 17);
            this.groupFailChkBox.TabIndex = 23;
            this.groupFailChkBox.Text = "Include Fail Details";
            this.groupFailChkBox.UseVisualStyleBackColor = true;
            // 
            // tCNumber
            // 
            this.tCNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.tCNumber.HeaderText = "TC #";
            this.tCNumber.Name = "tCNumber";
            this.tCNumber.ReadOnly = true;
            this.tCNumber.Width = 21;
            // 
            // tCName
            // 
            this.tCName.HeaderText = "TC Name";
            this.tCName.Name = "tCName";
            this.tCName.ReadOnly = true;
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
            // tCSteps
            // 
            this.tCSteps.HeaderText = "TC Steps";
            this.tCSteps.Name = "tCSteps";
            this.tCSteps.ReadOnly = true;
            // 
            // gripProject
            // 
            this.gripProject.HeaderText = "Project";
            this.gripProject.Name = "gripProject";
            this.gripProject.ReadOnly = true;
            // 
            // gridGroup
            // 
            this.gridGroup.HeaderText = "Group";
            this.gridGroup.Name = "gridGroup";
            this.gridGroup.ReadOnly = true;
            // 
            // gridTestType
            // 
            this.gridTestType.HeaderText = "Type";
            this.gridTestType.Name = "gridTestType";
            this.gridTestType.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 416);
            this.Controls.Add(this.mainFailChkBox);
            this.Controls.Add(this.mainPassChkBox);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.CheckBox mainPassChkBox;
        private System.Windows.Forms.CheckBox mainFailChkBox;
        private System.Windows.Forms.CheckBox groupFailChkBox;
        private System.Windows.Forms.CheckBox groupPassChkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn testCaseStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn passPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn failPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCSteps;
        private System.Windows.Forms.DataGridViewTextBoxColumn gripProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTestType;
    }
}


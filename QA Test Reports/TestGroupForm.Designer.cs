namespace QA_Test_Reports
{
    partial class TestGroupForm
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
            this.projectLbl = new System.Windows.Forms.Label();
            this.groupLbl = new System.Windows.Forms.Label();
            this.testTypLbl = new System.Windows.Forms.Label();
            this.dateRangeLbl = new System.Windows.Forms.Label();
            this.toLbl = new System.Windows.Forms.Label();
            this.grpStartDtPicker = new System.Windows.Forms.DateTimePicker();
            this.grpEndDtPicker = new System.Windows.Forms.DateTimePicker();
            this.selectTestCaseFolderBtn = new System.Windows.Forms.Button();
            this.groupTxtBox = new System.Windows.Forms.TextBox();
            this.projectTxtBox = new System.Windows.Forms.ComboBox();
            this.testTypeTxtBox = new System.Windows.Forms.ComboBox();
            this.groupAsterisk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projectLbl
            // 
            this.projectLbl.AutoSize = true;
            this.projectLbl.Location = new System.Drawing.Point(43, 15);
            this.projectLbl.Name = "projectLbl";
            this.projectLbl.Size = new System.Drawing.Size(56, 17);
            this.projectLbl.TabIndex = 0;
            this.projectLbl.Text = "Project:";
            // 
            // groupLbl
            // 
            this.groupLbl.AutoSize = true;
            this.groupLbl.Location = new System.Drawing.Point(47, 43);
            this.groupLbl.Name = "groupLbl";
            this.groupLbl.Size = new System.Drawing.Size(52, 17);
            this.groupLbl.TabIndex = 1;
            this.groupLbl.Text = "Group:";
            // 
            // testTypLbl
            // 
            this.testTypLbl.AutoSize = true;
            this.testTypLbl.Location = new System.Drawing.Point(23, 71);
            this.testTypLbl.Name = "testTypLbl";
            this.testTypLbl.Size = new System.Drawing.Size(76, 17);
            this.testTypLbl.TabIndex = 2;
            this.testTypLbl.Text = "Test Type:";
            // 
            // dateRangeLbl
            // 
            this.dateRangeLbl.AutoSize = true;
            this.dateRangeLbl.Location = new System.Drawing.Point(11, 96);
            this.dateRangeLbl.Name = "dateRangeLbl";
            this.dateRangeLbl.Size = new System.Drawing.Size(88, 17);
            this.dateRangeLbl.TabIndex = 3;
            this.dateRangeLbl.Text = "Date Range:";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(80, 129);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(20, 17);
            this.toLbl.TabIndex = 4;
            this.toLbl.Text = "to";
            // 
            // grpStartDtPicker
            // 
            this.grpStartDtPicker.Location = new System.Drawing.Point(105, 96);
            this.grpStartDtPicker.Name = "grpStartDtPicker";
            this.grpStartDtPicker.Size = new System.Drawing.Size(247, 22);
            this.grpStartDtPicker.TabIndex = 4;
            this.grpStartDtPicker.Value = new System.DateTime(2016, 11, 16, 0, 0, 0, 0);
            // 
            // grpEndDtPicker
            // 
            this.grpEndDtPicker.Location = new System.Drawing.Point(106, 124);
            this.grpEndDtPicker.Name = "grpEndDtPicker";
            this.grpEndDtPicker.Size = new System.Drawing.Size(246, 22);
            this.grpEndDtPicker.TabIndex = 5;
            this.grpEndDtPicker.Value = new System.DateTime(2016, 11, 16, 0, 0, 0, 0);
            // 
            // selectTestCaseFolderBtn
            // 
            this.selectTestCaseFolderBtn.Location = new System.Drawing.Point(14, 152);
            this.selectTestCaseFolderBtn.Name = "selectTestCaseFolderBtn";
            this.selectTestCaseFolderBtn.Size = new System.Drawing.Size(338, 28);
            this.selectTestCaseFolderBtn.TabIndex = 6;
            this.selectTestCaseFolderBtn.Text = "Select Test Case Folder";
            this.selectTestCaseFolderBtn.UseVisualStyleBackColor = true;
            this.selectTestCaseFolderBtn.Click += new System.EventHandler(this.selectTestCaseFolderBtn_Click);
            // 
            // groupTxtBox
            // 
            this.groupTxtBox.Location = new System.Drawing.Point(105, 40);
            this.groupTxtBox.Name = "groupTxtBox";
            this.groupTxtBox.Size = new System.Drawing.Size(247, 22);
            this.groupTxtBox.TabIndex = 2;
            // 
            // projectTxtBox
            // 
            this.projectTxtBox.FormattingEnabled = true;
            this.projectTxtBox.Items.AddRange(new object[] {
            "Online Registrar",
            "TMS"});
            this.projectTxtBox.Location = new System.Drawing.Point(106, 10);
            this.projectTxtBox.Name = "projectTxtBox";
            this.projectTxtBox.Size = new System.Drawing.Size(246, 24);
            this.projectTxtBox.TabIndex = 1;
            // 
            // testTypeTxtBox
            // 
            this.testTypeTxtBox.FormattingEnabled = true;
            this.testTypeTxtBox.Items.AddRange(new object[] {
            "System Integration Testing",
            "User Acceptance Testing"});
            this.testTypeTxtBox.Location = new System.Drawing.Point(105, 68);
            this.testTypeTxtBox.Name = "testTypeTxtBox";
            this.testTypeTxtBox.Size = new System.Drawing.Size(247, 24);
            this.testTypeTxtBox.TabIndex = 3;
            // 
            // groupAsterisk
            // 
            this.groupAsterisk.AutoSize = true;
            this.groupAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAsterisk.ForeColor = System.Drawing.Color.Red;
            this.groupAsterisk.Location = new System.Drawing.Point(27, 44);
            this.groupAsterisk.Name = "groupAsterisk";
            this.groupAsterisk.Size = new System.Drawing.Size(14, 18);
            this.groupAsterisk.TabIndex = 7;
            this.groupAsterisk.Text = "*";
            this.groupAsterisk.Visible = false;
            // 
            // TestGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 194);
            this.Controls.Add(this.groupAsterisk);
            this.Controls.Add(this.testTypeTxtBox);
            this.Controls.Add(this.projectTxtBox);
            this.Controls.Add(this.groupTxtBox);
            this.Controls.Add(this.selectTestCaseFolderBtn);
            this.Controls.Add(this.grpEndDtPicker);
            this.Controls.Add(this.grpStartDtPicker);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.dateRangeLbl);
            this.Controls.Add(this.testTypLbl);
            this.Controls.Add(this.groupLbl);
            this.Controls.Add(this.projectLbl);
            this.Name = "TestGroupForm";
            this.Text = "Test Group Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectLbl;
        private System.Windows.Forms.Label groupLbl;
        private System.Windows.Forms.Label testTypLbl;
        private System.Windows.Forms.Label dateRangeLbl;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.DateTimePicker grpStartDtPicker;
        private System.Windows.Forms.DateTimePicker grpEndDtPicker;
        private System.Windows.Forms.Button selectTestCaseFolderBtn;
        private System.Windows.Forms.TextBox groupTxtBox;
        private System.Windows.Forms.ComboBox projectTxtBox;
        private System.Windows.Forms.ComboBox testTypeTxtBox;
        private System.Windows.Forms.Label groupAsterisk;
    }
}
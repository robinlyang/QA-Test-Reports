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
            this.testTypeTxtBox = new System.Windows.Forms.TextBox();
            this.groupTxtBox = new System.Windows.Forms.TextBox();
            this.projectTxtBox = new System.Windows.Forms.TextBox();
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
            this.toLbl.Location = new System.Drawing.Point(316, 96);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(20, 17);
            this.toLbl.TabIndex = 4;
            this.toLbl.Text = "to";
            // 
            // grpStartDtPicker
            // 
            this.grpStartDtPicker.Location = new System.Drawing.Point(105, 96);
            this.grpStartDtPicker.Name = "grpStartDtPicker";
            this.grpStartDtPicker.Size = new System.Drawing.Size(200, 22);
            this.grpStartDtPicker.TabIndex = 5;
            this.grpStartDtPicker.Value = new System.DateTime(2016, 10, 3, 0, 0, 0, 0);
            // 
            // grpEndDtPicker
            // 
            this.grpEndDtPicker.Location = new System.Drawing.Point(342, 96);
            this.grpEndDtPicker.Name = "grpEndDtPicker";
            this.grpEndDtPicker.Size = new System.Drawing.Size(200, 22);
            this.grpEndDtPicker.TabIndex = 6;
            this.grpEndDtPicker.Value = new System.DateTime(2016, 10, 11, 0, 0, 0, 0);
            // 
            // selectTestCaseFolderBtn
            // 
            this.selectTestCaseFolderBtn.Location = new System.Drawing.Point(12, 129);
            this.selectTestCaseFolderBtn.Name = "selectTestCaseFolderBtn";
            this.selectTestCaseFolderBtn.Size = new System.Drawing.Size(530, 28);
            this.selectTestCaseFolderBtn.TabIndex = 7;
            this.selectTestCaseFolderBtn.Text = "Select Test Case Folder";
            this.selectTestCaseFolderBtn.UseVisualStyleBackColor = true;
            this.selectTestCaseFolderBtn.Click += new System.EventHandler(this.selectTestCaseFolderBtn_Click);
            // 
            // testTypeTxtBox
            // 
            this.testTypeTxtBox.Location = new System.Drawing.Point(105, 68);
            this.testTypeTxtBox.Name = "testTypeTxtBox";
            this.testTypeTxtBox.Size = new System.Drawing.Size(437, 22);
            this.testTypeTxtBox.TabIndex = 8;
            this.testTypeTxtBox.Text = "System Integration Testing";
            // 
            // groupTxtBox
            // 
            this.groupTxtBox.Location = new System.Drawing.Point(105, 40);
            this.groupTxtBox.Name = "groupTxtBox";
            this.groupTxtBox.Size = new System.Drawing.Size(437, 22);
            this.groupTxtBox.TabIndex = 9;
            this.groupTxtBox.Text = "Performance";
            // 
            // projectTxtBox
            // 
            this.projectTxtBox.Location = new System.Drawing.Point(105, 12);
            this.projectTxtBox.Name = "projectTxtBox";
            this.projectTxtBox.Size = new System.Drawing.Size(437, 22);
            this.projectTxtBox.TabIndex = 10;
            this.projectTxtBox.Text = "TMS";
            // 
            // TestGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 170);
            this.Controls.Add(this.projectTxtBox);
            this.Controls.Add(this.groupTxtBox);
            this.Controls.Add(this.testTypeTxtBox);
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
        private System.Windows.Forms.TextBox testTypeTxtBox;
        private System.Windows.Forms.TextBox groupTxtBox;
        private System.Windows.Forms.TextBox projectTxtBox;
    }
}
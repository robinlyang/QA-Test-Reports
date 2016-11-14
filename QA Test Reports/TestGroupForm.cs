using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_Test_Reports
{
    public partial class TestGroupForm : Form
    {
        public string frmProject
        {
            get { return projectTxtBox.Text; }
            set { projectTxtBox.Text = value; }
        }
        public string frmGroup
        {
            get { return groupTxtBox.Text; }
            set { groupTxtBox.Text = value; }
        }
        public string frmTestType
        {
            get { return testTypeTxtBox.Text; }
            set { testTypeTxtBox.Text = value; }
        }
        public DateTime frmStart
        {
            get { return Convert.ToDateTime(grpStartDtPicker.Text); }
            set { grpStartDtPicker.Text = value.ToLongDateString(); }
        }
        public DateTime frmEnd
        {
            get { return Convert.ToDateTime(grpEndDtPicker.Text); }
            set { grpEndDtPicker.Text = value.ToLongDateString(); }
        }

        public TestGroupForm()
        {
            InitializeComponent();
        }

        private void selectTestCaseFolderBtn_Click(object sender, EventArgs e)
        {
            MainForm.grpProject = this.frmProject;
            MainForm.grpGroup = this.frmGroup;
            MainForm.grpTestType = this.frmTestType;
            MainForm.grpStart = this.frmStart;
            MainForm.grpEnd = this.frmEnd;

            this.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace QA_Test_Reports
{
    public partial class MainForm : Form
    {
        //Class Attributes
        string testCaseLocation = "";
        FolderBrowserDialog fbd;
        DialogResult result;

        //Dashboard Attributes
        int TOTALtestCaseCount;
        double TOTALprogressCount;
        double TOTALprogressPercentage;
        double TOTALpassRatePercentage;
        double TOTALfailRatePercentage;
        double TOTALotherRate;
        double TOTALotherRatePercentage;

        double testCaseCount = 0;
        double progressCount = 0;
        double progressPercentage = 0;
        double passRate = 0;
        double passRatePercentage = 0;
        double failRate = 0;
        double failRatePercentage = 0;
        double otherRate = 0;
        double otherRatePercentage = 0;
        //Test Group Tab Attributes
        List<TestGroupExecution> testGroupExecutionList = new List<TestGroupExecution>();
        //Test Case Tab Attributes
        List<string> filesList = new List<string>();
        //Execution Tab Attributes

        //Admin Tab Attributes

        //Email Attributes
        string MainPieImagesDirectory = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void addTestGroupBtn_Click(object sender, EventArgs e)
        {
            //Open Test Group From
            TestGroupForm testGroupForm = new TestGroupForm();
            testGroupForm.ShowDialog();

            //Get Group information from TestGroupForm
            string singleGrpProject = grpProject;
            string singleGrpGroup = grpGroup;
            string singleGrpTestType = grpTestType;
            DateTime singleGrpStart = grpStart;
            DateTime singleGrpEnd = grpEnd;

            //Open Windows Explorer
            fbd = new FolderBrowserDialog();
            fbd.Reset();
            fbd.SelectedPath = @"O:\\staff\\Enterprise Information Management\\data\\Common" +
                "\\TMS\\4-Quality Assurance\\Performance\\Performance Year End\\SIT - Test Execution";
            result = fbd.ShowDialog();

            //Start Progress Bar
            mainProgressBar.Value = 0;
            mainProgressBar.Visible = true;

            //Populate...
            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                testCaseLocation = fbd.SelectedPath;
                string[] strFiles = Directory.GetFiles(fbd.SelectedPath, "*.xlsx");
                //Add strFiles to filesList
                for (int i = 0; i < strFiles.Length; i++)
                {
                    filesList.Add(strFiles[i]);
                }
                //Process Excel Test Cases
                List<TestCaseExecution> testCasesExecutionList = new List<TestCaseExecution>();
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;
                int fbdCount = fbd.SelectedPath.Length;
                for (int i = 0; i < strFiles.Length; i++)
                {
                    //Increment Progress Bar
                    double mainProgressBarValue = (Convert.ToDouble(i) / Convert.ToDouble(strFiles.Length)) * 100;
                    mainProgressBar.Value = Convert.ToInt32(mainProgressBarValue);

                    //Tase Case tab ListBox
                    string fileString = strFiles[i].ToString();
                    string displayFile = fileString.Substring(fbdCount + 1, strFiles[i].ToString().Length - fbdCount - 1);
                    if (!displayFile.StartsWith("~"))
                    {
                        testCaseList.Items.Add(displayFile);
                        testCaseCount = testCaseCount + 1;
                    }
                    //Execution Tab DataGridView
                    if (!fileString.Contains("~"))
                    {
                        Excel.Workbook workBook = excelApp.Workbooks.Open(fileString);
                        Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Sheets[1];
                        string tcNumber = (string)(workSheet.Cells[3, 2] as Excel.Range).Value;
                        string tcName = (string)(workSheet.Cells[4, 2] as Excel.Range).Value;
                        Excel.Range stepRange = (Excel.Range)workSheet.Range[workSheet.Cells[11, 1], workSheet.Cells[100, 1]];
                        var stepObject = stepRange.Cells.Value;
                        double stepCount = 0;
                        //Get number of Steps
                        foreach (var stepObj in stepObject)
                        {
                            if (stepObj != null)
                            {
                                stepCount = stepCount + 1;
                            }
                        }
                        //Get number of Passed
                        Excel.Range passRange = (Excel.Range)workSheet.Range[workSheet.Cells[11, 7], workSheet.Cells[100, 7]];
                        var passObject = passRange.Cells.Value;
                        double passCount = 0;
                        foreach (var passObj in passObject)
                        {
                            if (passObj != null && passObj.ToString() == "Passed")
                            {
                                passCount = passCount + 1;
                            }
                        }
                        double passPercentage = (passCount / stepCount) * 100;
                        //Get number of Failed
                        Excel.Range failRange = (Excel.Range)workSheet.Range[workSheet.Cells[11, 7], workSheet.Cells[100, 7]];
                        var failObject = failRange.Cells.Value;
                        double failCount = 0;
                        foreach (var failObj in failObject)
                        {
                            if (failObj != null && failObj.ToString() == "Failed")
                            {
                                failCount = failCount + 1;
                            }
                        }
                        double failPercentage = (failCount / stepCount) * 100;
                        //Get number of NOT Passed or NOT Failed
                        Excel.Range otherRange = (Excel.Range)workSheet.Range[workSheet.Cells[11, 7], workSheet.Cells[100, 7]];
                        var otherObject = otherRange.Cells.Value;
                        double otherCount = 0;
                        foreach (var otherObj in otherObject)
                        {
                            if (otherObj != null && (otherObj.ToString() != "Failed" && otherObj.ToString() != "Passed"))
                            {
                                otherCount = otherCount + 1;
                            }
                        }
                        double otherPercentage = (otherCount / stepCount) * 100;
                        //Get Status
                        string tcStatus = "";
                        if (failCount > 0)
                        {
                            tcStatus = "Failed";
                            progressCount = progressCount + 1;
                            failRate = failRate + 1;
                        }
                        if (passPercentage >= 100)
                        {
                            tcStatus = "Passed";
                            progressCount = progressCount + 1;
                            passRate = passRate + 1;
                        }
                        //Push to DataGridView
                        testCaseGrid.Rows.Add(tcNumber, tcName, tcStatus, passPercentage.ToString("0.00"), failPercentage.ToString("0.00"),
                            otherPercentage.ToString("0.00"), stepCount, singleGrpProject, singleGrpGroup,
                            singleGrpTestType);
                        workBook.Save();
                        workBook.Close();

                        //Create TestCaseExecution
                        TestCaseExecution newTestCaseExecution = new TestCaseExecution(tcStatus, passPercentage,
                            failPercentage, otherPercentage, tcNumber, tcName, Convert.ToInt32(stepCount));
                        //Add TestCaseExecution to TestCaseExecutionList
                        testCasesExecutionList.Add(newTestCaseExecution);
                    }
                    excelApp.Quit();
                }
                //Get TestGroupExecution Status, Pass, Fail, Other, and Number of Test Cases
                string newTestGroupExecutionStatus = "Passed";
                double newTestGroupExecutionPassed = 0.0;
                double newTestGroupExecutionFailed = 0.0;
                double newTestGroupExecutionOther = 0.0;
                for (int x = 0; x < testCasesExecutionList.Count; x++)
                {
                    if (testCasesExecutionList[x].status == "Passed")
                    {
                        newTestGroupExecutionPassed = newTestGroupExecutionPassed + 1;
                    }
                    else if (testCasesExecutionList[x].status == "Failed")
                    {
                        newTestGroupExecutionStatus = "Failed";
                        newTestGroupExecutionFailed = newTestGroupExecutionFailed + 1;
                    }
                    else
                    {
                        newTestGroupExecutionOther = newTestGroupExecutionOther + 1;
                    }
                }
                double newTGEPassRate = (newTestGroupExecutionPassed / testCasesExecutionList.Count) * 100;
                double newTGEFailRate = (newTestGroupExecutionFailed / testCasesExecutionList.Count) * 100;
                double newTGEOtherRate = (newTestGroupExecutionOther / testCasesExecutionList.Count) * 100;
                //Create TestGroupExecution
                TestGroupExecution newTestGroupExecution = new TestGroupExecution(singleGrpProject, singleGrpGroup,
                    singleGrpTestType, singleGrpStart, singleGrpEnd, testCasesExecutionList, newTestGroupExecutionStatus,
                    newTGEPassRate, newTGEFailRate, newTGEOtherRate, testCasesExecutionList.Count);
                //Add TestCaseExecutionList to TestGroupExecutionList
                testGroupExecutionList.Add(newTestGroupExecution);
                //Tase Case tab ListBox
                testGroupList.Items.Add(singleGrpGroup);
            }
            //Populate Main Dashboard
            populateMainDashBoard();
            //Load Main Pie Chart
            loadMainPieChart();

            //End Progress Bar
            mainProgressBar.Visible = false;
        }

        public void populateMainDashBoard()
        {
            int testCaseCount = 0;
            double progressCount = 0;
            double TOTALfailRate = 0;
            double TOTALpassRate = 0;

            for (int x = 0; x < testGroupExecutionList.Count; x++)
            {
                testCaseCount = testCaseCount + testGroupExecutionList[x].grpNumTests;
                //progressCount = (1 - testGroupExecutionList[x].grpOtherPercent / 100) * testCaseCount;
                TOTALpassRate = (TOTALpassRate + testGroupExecutionList[x].grpPassPercent);
                TOTALfailRate = (TOTALfailRate + testGroupExecutionList[x].grpFailPercent);
                TOTALotherRate = (TOTALotherRate + testGroupExecutionList[x].grpOtherPercent);

                //TOTALotherRate = 100 - (TOTALpassRate + TOTALfailRate);
                //TOTALprogressCount = TOTALtestCaseCount - (TOTALtestCaseCount * (TOTALotherRate / 100));
            }
            TOTALtestCaseCount = testCaseCount;
            //TOTALprogressCount = progressCount;
            TOTALprogressCount = (1 - (TOTALotherRate / testGroupExecutionList.Count) / 100) * TOTALtestCaseCount;
            TOTALpassRatePercentage = TOTALpassRate / testGroupExecutionList.Count;
            TOTALfailRatePercentage = TOTALfailRate / testGroupExecutionList.Count;
            //TOTALotherRatePercentage = TOTALpassRatePercentage + TOTALfailRatePercentage;

            totalNumLbl.Text = TOTALtestCaseCount.ToString("0");
            progressNumLbl.Text = TOTALprogressCount.ToString("0");
            passRateNumLbl.Text = (TOTALprogressCount * (TOTALpassRatePercentage/100)).ToString("0") +
                " (" + TOTALpassRatePercentage.ToString("0") + "%)";
            failRateNumLbl.Text = (TOTALprogressCount * (TOTALfailRatePercentage/100)).ToString("0") +
                " (" + TOTALfailRatePercentage.ToString("0") + "%)";
            //failRateNumLbl.Text = TOTALfailRate.ToString();

            //Make Email button visible
            emailBtn.Visible = true;

            //Make Group panel visible
            testGroupPanel.Visible = true;
        }

        public void loadMainPieChart()
        {
            foreach(var series in mainPieChart.Series)
            {
                series.Points.Clear();
            }

            this.mainPieChart.Series["Status"].Points.AddXY("Pass", TOTALpassRatePercentage);
            this.mainPieChart.Series["Status"].Points.AddXY("Fail", TOTALfailRatePercentage);
            this.mainPieChart.Series["Status"].Points.AddXY("Other", 100 - TOTALpassRatePercentage -
                TOTALfailRatePercentage);
            this.mainPieChart.Series["Status"].Points[0].LegendText = "Pass";
            this.mainPieChart.Series["Status"].Points[1].LegendText = "Fail";
            this.mainPieChart.Series["Status"].Points[2].LegendText = "Other";
            MainPieImagesDirectory = AppDomain.CurrentDomain.BaseDirectory + "MainPieChart.png";
            this.mainPieChart.SaveImage(MainPieImagesDirectory, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
        }

        public static string grpProject { get; internal set; }
        public static string grpGroup { get; internal set; }
        public static string grpTestType { get; internal set; }
        public static DateTime grpStart { get; internal set; }
        public static DateTime grpEnd { get; internal set; }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            string tableContent = "";
            for(int x = 0; x < testGroupExecutionList.Count; x++)
            {
                string statusString = "";
                if(testGroupExecutionList[x].grpStatus=="Failed")
                {
                    statusString =
                        "<tr>" +
                            "<td>Status</td>" + "<td style=\"color:red; \">" + testGroupExecutionList[x].grpStatus + "</td>" +
                        "</tr>";
                }
                else if (testGroupExecutionList[x].grpStatus=="Passed")
                {
                    statusString =
                        "<tr>" +
                            "<td>Status</td>" + "<td style=\"color:blue; \">" + testGroupExecutionList[x].grpStatus + "</td>" +
                        "</tr>";
                }
                tableContent +=
                    "<tr>" +
                        "<td colspan=\"2\" style=\"font-weight: bold; \">" + testGroupExecutionList[x].grpProject +
                            " - " + testGroupExecutionList[x].grpName + "</td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td colspan=\"2\">" + testGroupExecutionList[x].grpTestType + "</td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td colspan=\"2\" style=\"font-size:10.5px; \">" + "Schedule: " +
                            testGroupExecutionList[x].grpStart.ToShortDateString() + 
                            " - " + testGroupExecutionList[x].grpEnd.ToShortDateString() + "</td>" +
                    "</tr>" +
                    //Red Font if Status=Failed and Blue Font if Status=Passed
                    statusString +
                    "<tr>" +
                        "<td>Total</td>" + "<td>" + testGroupExecutionList[x].grpTestCases.Count.ToString() + "</td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td>Passed</td>" + "<td>" + testGroupExecutionList[x].grpPassPercent.ToString("0") + "%</td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td>Failed</td>" + "<td>" + testGroupExecutionList[x].grpFailPercent.ToString("0") + "%</td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td>In Progress</td>" + "<td>" + testGroupExecutionList[x].grpOtherPercent.ToString("0") + "%</td>" +
                    "</tr>";
            }
            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MailItem mail = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
            DateTime today = DateTime.Now;
            mail.Subject = today.ToLongDateString() + " - Testing Report";

            mail.HTMLBody =
                "<html>" +
                    "<head>" +

                    "</head>" +
                    "<body style=\"font-family:'titillium'; \">" +
                        "<br>" +
                        "<br>" +
                        "<table width=\"100%\">" +
                            "<tr>" +
                                "<table border=\"1\" align=\"center\">" +
                                    "<tr>" +
                                        "<td colspan=\"2\">Total # of Test Cases Planned: " + totalNumLbl.Text.ToString() + "</ td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td colspan=\"2\">Test Execution Progress: " + progressNumLbl.Text.ToString() + "</ td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td colspan=\"2\"><img src=\"" + MainPieImagesDirectory + "\"></td>" +
                                    "</tr>" +
                                        tableContent +
                                "</table>" +
                            "</tr>" +
                        "</table>" +
                    "</body>" +
                "</html>";

            mail.Display(true);

            //Delete Pie Charts
            //if (File.Exists(MainPieImagesDirectory))
            //{
            //    File.Delete(MainPieImagesDirectory);
            //}
        }

        private void testGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string groupSelected = testGroupList.GetItemText(testGroupList.SelectedItem);
            string projectSelected = "";
            string testTypeSelected = "";
            //start date
            //end date
            int totalTCSelected = 0;
            double progressTCSelected = 0.0;
            double passRateSelected = 0.0;
            double failRateSelected = 0.0;
            for(int x = 0; x < testGroupExecutionList.Count; x++)
            {
                if(testGroupExecutionList[x].grpName==groupSelected)
                {
                    projectSelected = testGroupExecutionList[x].grpProject;
                    testTypeSelected = testGroupExecutionList[x].grpTestType;
                    totalTCSelected = testGroupExecutionList[x].grpNumTests;
                    progressTCSelected = (1 - testGroupExecutionList[x].grpOtherPercent / 100) * totalTCSelected;
                    passRateSelected = testGroupExecutionList[x].grpPassPercent;
                    failRateSelected = testGroupExecutionList[x].grpFailPercent;
                }
            }
            projectTxtBox.Text = projectSelected;
            groupTxtBox.Text = groupSelected;
            typeTxtBox.Text = testTypeSelected;
            //start date
            //end date
            totalTCsGroupNumLbl.Text = totalTCSelected.ToString("0");
            progressTCsGroupNumLbl.Text = progressTCSelected.ToString("0");
            groupPassRateNumLbl.Text = (totalTCSelected * (passRateSelected / 100)).ToString("0") +
                " (" + passRateSelected.ToString("0") + "%)";
            groupFailRateNumLbl.Text = (totalTCSelected * (failRateSelected / 100)).ToString("0") +
                " (" + failRateSelected.ToString("0") + "%)";
            //GroupBarChart
            foreach (var series in groupPieChart.Series)
            {
                series.Points.Clear();
            }

            this.groupPieChart.Series["IdvGroupStatus"].Points.AddXY("Pass", passRateSelected);
            this.groupPieChart.Series["IdvGroupStatus"].Points.AddXY("Fail", failRateSelected);
            this.groupPieChart.Series["IdvGroupStatus"].Points.AddXY("Other", 100 - passRateSelected -
                failRateSelected);
            this.groupPieChart.Series["IdvGroupStatus"].Points[0].LegendText = "Pass";
            this.groupPieChart.Series["IdvGroupStatus"].Points[1].LegendText = "Fail";
            this.groupPieChart.Series["IdvGroupStatus"].Points[2].LegendText = "Other";
            //MainPieImagesDirectory = AppDomain.CurrentDomain.BaseDirectory + "MainPieChart.png";
            //this.mainPieChart.SaveImage(MainPieImagesDirectory, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
            //string groupSelected = testGroupList.GetItemText(testGroupList.SelectedItem);
            //for (int x = 0; x < testGroupExecutionList.Count; x++)
            //{
            //    if (testGroupExecutionList[x].grpName == groupSelected)
            //    {
            //        testGroupExecutionList.RemoveAt(x);
            //    }
            //}
            //testGroupList.SelectedItems.Remove(testGroupList.SelectedItem);
            //testGroupList.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }
    }
}
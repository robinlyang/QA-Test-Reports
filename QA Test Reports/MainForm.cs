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
                        testCaseGrid.Rows.Add(tcStatus, passPercentage.ToString("0.00"), failPercentage.ToString("0.00"),
                            otherPercentage.ToString("0.00"), tcNumber, tcName, stepCount);
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
                progressCount = (1 - testGroupExecutionList[x].grpOtherPercent / 100) * testCaseCount;
                TOTALpassRate = (TOTALpassRate + testGroupExecutionList[x].grpPassPercent);
                TOTALfailRate = (TOTALfailRate + testGroupExecutionList[x].grpFailPercent);
                TOTALotherRate = (TOTALotherRate + testGroupExecutionList[x].grpOtherPercent);

                //TOTALotherRate = 100 - (TOTALpassRate + TOTALfailRate);
                //TOTALprogressCount = TOTALtestCaseCount - (TOTALtestCaseCount * (TOTALotherRate / 100));
            }
            TOTALtestCaseCount = testCaseCount;
            TOTALprogressCount = progressCount;
            TOTALpassRatePercentage = TOTALpassRate / testGroupExecutionList.Count;
            TOTALfailRatePercentage = TOTALfailRate / testGroupExecutionList.Count;
            //TOTALotherRatePercentage = TOTALpassRatePercentage + TOTALfailRatePercentage;

            totalNumLbl.Text = TOTALtestCaseCount.ToString("0");
            progressNumLbl.Text = TOTALprogressCount.ToString("0");
            passRateNumLbl.Text = TOTALpassRatePercentage.ToString("0") + "%";
            failRateNumLbl.Text = TOTALfailRatePercentage.ToString("0") + "%";
            //failRateNumLbl.Text = TOTALfailRate.ToString();

            //Make Email button visible
            emailBtn.Visible = true;
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

        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            string tableContent = "";
            for(int x = 0; x < testGroupExecutionList.Count; x++)
            {
                tableContent +=
                    "<tr>" +
                        "<td colspan=\"2\"><button type=\"button\">" + testGroupExecutionList[x].grpName + "</button></td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td>Total</td>" + "<td>" + testGroupExecutionList[x].grpTestCases.Count.ToString() + "</td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td>Status</td>" + "<td>" + testGroupExecutionList[x].grpStatus + "</td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td>Passed</td>" + "<td>" + testGroupExecutionList[x].grpPassPercent + "</td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td>Failed</td>" + "<td>" + testGroupExecutionList[x].grpFailPercent + "</td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td>In Progress</td>" + "<td>" + testGroupExecutionList[x].grpOtherPercent + "</td>" +
                    "</tr>";
            }
            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MailItem mail = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
            DateTime today = DateTime.Now;
            mail.Subject = today.ToLongDateString() + " - Testing Report";

            mail.HTMLBody =
                "<html>" +
                    "<head>" +
                        "<style>" +
                            "body color: navy;" +
                        "</style>" +
                    "</head>" +
                    "<body>" +
                        "<h3>Total # of Test Cases Planned: " + totalNumLbl.Text.ToString() + "</h3>" +
                        "Test Execution Progress: " + progressNumLbl.Text.ToString() +
                        "<br>" +
                        "<img src=\""+ MainPieImagesDirectory + "\">" +
                        "<br>" +
                        "<table border=\"1\">" +
                            tableContent +
                        "</table>" +
                    "</body>" +
                "</html>";

            mail.Display(true);

            //Delete Pie Charts
            if (File.Exists(MainPieImagesDirectory))
            {
                File.Delete(MainPieImagesDirectory);
            }
        }
    }
}

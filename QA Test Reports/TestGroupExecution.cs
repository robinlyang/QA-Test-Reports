using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Test_Reports
{
    class TestGroupExecution
    {
        public string grpProject { get; set; }
        public string grpName { get; set; }
        public string grpTestType { get; set; }
        public DateTime grpStart { get; set; }
        public DateTime grpEnd { get; set; }
        public List<TestCaseExecution> grpTestCases { get; set; }
        public string grpStatus { get; set; }
        public double grpPassPercent { get; set; }
        public double grpFailPercent { get; set; }
        public double grpOtherPercent { get; set; }
        public int grpNumTests { get; set; }

        public TestGroupExecution()
        {

        }

        public TestGroupExecution(string grpProject, string grpName, string grpTestType, DateTime grpStart,
            DateTime grpEnd, List<TestCaseExecution> grpTestCases, string grpStatus, double grpPassPercent,
            double grpFailPercent, double grpOtherPercent, int grpNumTests)
        {
            this.grpProject = grpProject;
            this.grpName = grpName;
            this.grpTestType = grpTestType;
            this.grpStart = grpStart;
            this.grpEnd = grpEnd;
            this.grpTestCases = grpTestCases;
            this.grpStatus = grpStatus;
            this.grpPassPercent = grpPassPercent;
            this.grpFailPercent = grpFailPercent;
            this.grpOtherPercent = grpOtherPercent;
            this.grpNumTests = grpNumTests;
        }

        ~TestGroupExecution()
        {

        }
    }
}

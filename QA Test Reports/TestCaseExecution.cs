using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Test_Reports
{
    class TestCaseExecution
    {
        public string status { get; private set; }
        public double passPercent { get; private set; }
        public double failPercent { get; private set; }
        public double otherPercent { get; private set; }
        public string testCaseNumber { get; private set; }
        public string testCaseName { get; private set; }
        public int testCaseSteps { get; private set; }

        public TestCaseExecution()
        {

        }
        public TestCaseExecution(string status, double passPercent, double failPercent, double otherPercent,
            string testCaseNumber, string testCaseName, int testCaseSteps)
        {
            this.status = status;
            this.passPercent = passPercent;
            this.failPercent = failPercent;
            this.otherPercent = otherPercent;
            this.testCaseNumber = testCaseNumber;
            this.testCaseName = testCaseName;
            this.testCaseSteps = testCaseSteps;
        }

        ~TestCaseExecution()
        {

        }
    }
}

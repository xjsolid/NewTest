using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTSM2.Definitions
{
    public class TestResult
    {
        //public TestStatus TestStatus { get; set; }
        public string TestName { get; set; }
        public string Value { get; set; }
        public string LowLimit { get; set; }
        public string HighLimit { get; set; }
        public string Unit { get; set; }
    }
}

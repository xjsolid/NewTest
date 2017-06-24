using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTSM2.Definitions;

namespace TTSM2.TestEngine
{
    class TestModuleInfo
    {
        public TestModuleInfo(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public ITestModule Instance { get; set; }
        public string AssemblyPath { get; set; }
        public string Version { get; set; }
    }
}

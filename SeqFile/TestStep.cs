using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TTSM2.SeqFile
{
    public class TestStep
    {
        public TestStep()
        {

        }

        public TestStep(string testName, string assemblyName, string className, string methodName)
        {
            this.TestName = testName;
            this.AssemblyName = assemblyName;
            this.ClassName = className;
            this.MethodName = methodName;
        }

        List<TestParameter> tps = new List<TestParameter>();

        [XmlElement]
        public string TestName { get; set; }

        [XmlElement]
        public string AssemblyName { get; set; }

        [XmlElement]
        public string ClassName { get; set; }

        [XmlElement]
        public string MethodName { get; set; }

        [XmlElement]
        public int NumofParameters
        {
            get
            {
                return tps.Count;
            }
            set
            {

            }
        }

        [XmlArray(ElementName = "Parameters")]
        public List<TestParameter> TestParameters
        {
            get { return tps; }
            set { tps = value; }
        }
    }
}

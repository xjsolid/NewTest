using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TTSM2.SeqFile
{
    [XmlRoot("TestSequence")]
    public class TestSequence
    {
        public TestSequence()
        {

        }

        List<TestStep> testSteps = new List<TestStep>();

        [XmlElement]
        public string Name { get; set; }

        [XmlElement]
        public string ProjectName { get; set; }

        [XmlElement]
        public string Version { get; set; }

        [XmlElement]
        public string StationName { get; set; }

        [XmlArray(ElementName = "TestSteps")]
        public List<TestStep> TestSteps
        {
            get { return testSteps; }
            set { testSteps = value; }
        }
    }
}

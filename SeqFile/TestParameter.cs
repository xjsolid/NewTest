using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TTSM2.SeqFile
{
    public class TestParameter
    {
        public TestParameter()
        {

        }

        public TestParameter(string name, string value, string unit, string upperLimit, string lowerLimit, string type, string Mode)
        {
            this.Name = name;
            this.Value = value;
            this.Unit = unit;
            this.UpperLimit = upperLimit;
            this.LowerLimit = lowerLimit;
            this.DataType = type;
            this.Mode = Mode;
        }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Value { get; set; }

        [XmlAttribute]
        public string DataType { get; set; }

        [XmlAttribute]
        public string Unit { get; set; }

        [XmlAttribute]
        public string Mode { get; set; }

        [XmlAttribute]
        public string LowerLimit { get; set; }

        [XmlAttribute]
        public string UpperLimit { get; set; }

    }
}

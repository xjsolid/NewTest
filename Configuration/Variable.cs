using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TTSM2.Configuration
{
    [XmlRoot(ElementName = "Variable")]
    public class Variable
    {
        public Variable()
        {

        }

        public Variable(string name, object value)
        {
            this.Name = name;
            this.Value = value;
        }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlElement]
        public object Value { get; set; }

    }
}

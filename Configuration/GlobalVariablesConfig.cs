using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TTSM2.Configuration
{
    [XmlRoot(ElementName = "GlobalVariables")]
    public class GlobalVariablesConfig
    {
        List<Variable> variables = new List<Variable>();

        [XmlArray(ElementName = "GlobalVariables")]
        public List<Variable> GloblaVariables
        {
            get { return variables; }
            set { variables = value; }
        }
    }
}

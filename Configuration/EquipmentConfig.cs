using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TTSM2.Configuration
{
    [XmlRoot(ElementName = "EquipmentConfig")]
    public class EquipmentConfig
    {
        public EquipmentConfig()
        {

        }

        public EquipmentConfig(string identifier, string name, string instrumentType, ConnectionType connectionType, string address)
        {
            this.Identifier = identifier;
            this.Name = name;
            this.InstrumentType = instrumentType;
            this.ConnectionType = connectionType;
            this.Address = address;
            this.SubAddress = "";
        }

        public EquipmentConfig(string identifier, string name, string instrumentType, ConnectionType connectionType, string address, string subAddress)
        {
            this.Identifier = identifier;
            this.Name = name;
            this.InstrumentType = instrumentType;
            this.ConnectionType = connectionType;
            this.Address = address;
            this.SubAddress = subAddress;
        }

        [XmlAttribute]
        public string Identifier { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string InstrumentType { get; set; }

        [XmlAttribute]
        public ConnectionType ConnectionType { get; set; }

        [XmlAttribute]
        public string Address { get; set; }

        [XmlAttribute]
        public string SubAddress { get; set; }
    }

    public enum ConnectionType
    {
        GPIB,
        IP,
    }
}

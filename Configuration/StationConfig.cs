using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TTSM2.Configuration
{
    [XmlRoot(ElementName = "StationConfig")]
    public class StationConfig
    {
        List<EquipmentConfig> equipmentConfigs = new List<EquipmentConfig>();
        List<RFNetLossConfig> rfNetLossConfigs = new List<RFNetLossConfig>();

        // station configs
        [XmlElement]
        public string TesterName { get; set; }

        [XmlElement]
        public string DomainName { get; set; }

        [XmlElement]
        public string TesterType { get; set; }

        [XmlElement]
        public string QMSLLibraryMode { get; set; }

        [XmlElement]
        public string LastUsedSequencePath { get; set; }

        [XmlElement]
        public string EnableCallBoxDisplay { get; set; }

        // for multi dut
        [XmlElement]
        public string DutComport { get; set; }

        [XmlElement]
        public string DutIndex { get; set; }

        [XmlArray(ElementName = "Equipment_Configs")]
        public List<EquipmentConfig> EquipmentConfig
        {
            get { return equipmentConfigs; }
            set { equipmentConfigs = value; }
        }

        [XmlArray(ElementName = "RFNetLoss_Configs")]
        public List<RFNetLossConfig> RFNetLossConfigs
        {
            get { return rfNetLossConfigs; }
            set { rfNetLossConfigs = value; }
        }

    }
}

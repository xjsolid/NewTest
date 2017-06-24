using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TTSM2.Configuration
{
    [XmlRoot(ElementName = "RFNetLossConfig")]
    public class RFNetLossConfig
    {
        public RFNetLossConfig()
        {

        }

        public RFNetLossConfig(int bandNum, string bandName, int ulChannel, double ulLossMain, double dlLossMain)
        {
            this.BandNum = bandNum;
            this.BandName = bandName;
            this.UpLinkChannel = ulChannel;
            this.UplinkLossMain = ulLossMain;
            this.DownlinkLossMain = dlLossMain;
            this.UplinkLossDiv = 1;
            this.DownlinkLossDiv = 1;
        }

        public RFNetLossConfig(int bandNum, string bandName, int ulChannel, double ulLossMain, double dlLossMain, double ulLossDiv, double dlLossDiv)
        {
            this.BandNum = bandNum;
            this.BandName = bandName;
            this.UpLinkChannel = ulChannel;
            this.UplinkLossMain = ulLossMain;
            this.DownlinkLossMain = dlLossMain;
            this.UplinkLossDiv = ulLossDiv;
            this.DownlinkLossDiv = dlLossDiv;
        }

        [XmlAttribute]
        public int BandNum { get; set; }

        [XmlAttribute]
        public string BandName { get; set; }

        [XmlAttribute]
        public int UpLinkChannel { get; set; }

        [XmlAttribute]
        public double UplinkLossMain { get; set; }

        [XmlAttribute]
        public double DownlinkLossMain { get; set; }

        [XmlAttribute]
        public double UplinkLossDiv { get; set; }

        [XmlAttribute]
        public double DownlinkLossDiv { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TTSM2.Configuration;
using TTSM2.Utility;
using System.IO;

namespace TTSM2.UI
{
    public partial class StationSettings : Form
    {
        public StationSettings()
        {
            InitializeComponent();
            string pluginFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pluginFolderName);
            stationConfigFile = Path.Combine(pluginFolder, stationConfigFileName);
        }

        #region const
        const string stationConfigFileName = "StationConfig.xml";
        const string pluginFolderName = "Plugins";
        #endregion

        #region members
        StationConfig sc;
        EquipmentConfig cpEc;
        EquipmentConfig psEc;

        string stationConfigFile = string.Empty;
        #endregion

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            this.dataGridView_RFLossConfig.EndEdit();
            if (!CheckInstrAddr())
            {
                MessageBox.Show("输入仪表地址错误!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox_InstrAddr.SelectAll();
                return;
            }

            XmlConfigHelper.Save<StationConfig>(sc, stationConfigFile);
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.dataGridView_RFLossConfig.EndEdit();
            this.Close();
        }

        private void StationSettings_Shown(object sender, EventArgs e)
        {
            sc = XmlConfigHelper.Load<StationConfig>(stationConfigFile);
            this.textBox_Comport.Text = sc.DutComport;

            cpEc = sc.EquipmentConfig.Find(x => x.InstrumentType.Equals("CP"));
            this.comboBox_ConnectType.Text = cpEc.ConnectionType.ToString();
            this.textBox_InstrAddr.Text = cpEc.Address;

            psEc = sc.EquipmentConfig.Find(x => x.InstrumentType.Equals("PS"));
            this.textBox_PSAddr.Text = psEc.Address;

            foreach (var item in sc.RFNetLossConfigs)
            {
                string[] row = { item.BandName, item.UpLinkChannel.ToString(), item.UplinkLossMain.ToString("F2"), item.DownlinkLossMain.ToString("F2"),
                                    item.UplinkLossDiv.ToString("F2"), item.DownlinkLossDiv.ToString("F2") };
                this.dataGridView_RFLossConfig.Rows.Add(row);
            }
        }

        private void dataGridView_RFLossConfig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView_RFLossConfig.BeginEdit(false);

        }

        private void dataGridView_RFLossConfig_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow dgvRow = this.dataGridView_RFLossConfig.Rows[e.RowIndex];
            string bandName = dgvRow.Cells[0].Value.ToString();
            string channel = dgvRow.Cells[1].Value.ToString();
            double ulLossMain = double.Parse(dgvRow.Cells[2].Value.ToString());
            double dlLossMain = double.Parse(dgvRow.Cells[3].Value.ToString());
            double ulLossDiv = double.Parse(dgvRow.Cells[4].Value.ToString());
            double dlLossDiv = double.Parse(dgvRow.Cells[5].Value.ToString());

            RFNetLossConfig rfNetLossCfg = sc.RFNetLossConfigs.Find(x => (x.BandName.Equals(bandName) && x.UpLinkChannel.ToString().Equals(channel)));

            if (rfNetLossCfg == null)
            {
                return;
            }

            rfNetLossCfg.UplinkLossMain = ulLossMain;
            rfNetLossCfg.DownlinkLossMain = dlLossMain;
            rfNetLossCfg.UplinkLossDiv = ulLossDiv;
            rfNetLossCfg.DownlinkLossDiv = dlLossDiv;
        }

        private void textBox_Comport_TextChanged(object sender, EventArgs e)
        {
            sc.DutComport = this.textBox_Comport.Text;
        }

        private void textBox_PSAddr_TextChanged(object sender, EventArgs e)
        {
            psEc.Address = this.textBox_PSAddr.Text;
        }

        private void comboBox_ConnectType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.comboBox_ConnectType.Text.Equals(ConnectionType.IP.ToString()))
            {
                cpEc.ConnectionType = ConnectionType.IP;
            }
            else
            {
                cpEc.ConnectionType = ConnectionType.GPIB;
            }
        }

        private void textBox_InstrAddr_TextChanged(object sender, EventArgs e)
        {
            cpEc.Address = this.textBox_InstrAddr.Text;
        }

        bool CheckInstrAddr()
        {
            if (cpEc.ConnectionType == ConnectionType.IP)
            {
                if (cpEc.Address.Length > 7)
                {
                    return true;
                }
            }

            if (cpEc.ConnectionType == ConnectionType.GPIB)
            {
                if (cpEc.Address.Length < 3)
                {
                    return true;
                }
            }

            return false;
        }


    }
}

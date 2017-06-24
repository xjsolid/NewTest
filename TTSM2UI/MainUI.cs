using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TTSM2.PluginInterface;
using System.IO;
using TTSM2.SeqFile;

namespace TTSM2.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        #region members
        DebugLog debugLog;
        #endregion

        #region callbacks
        private void toolStripMenuItem_StationConfig_Click(object sender, EventArgs e)
        {
            StationSettings stationsettingsPanel = new StationSettings();
            stationsettingsPanel.FormClosing += new FormClosingEventHandler(stationsettingsPanel_FormClosing);
            stationsettingsPanel.ShowDialog();
        }

        void stationsettingsPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessengerEx.Notify(TestEngineMessages.StationConfigChanged);
        }

        private void toolStripMenuItem_LoadTestSequence_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            ofd.Filter = "xml files (*.xml)|*.xml|seq files (*.seq)|*.seq";
            ofd.RestoreDirectory = true;
            string seqPath = string.Empty;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                seqPath = ofd.FileName;
            }
            else
            {
                return;
            }

            MessengerEx.Notify(TestEngineMessages.LoadTestSequence, seqPath);
        }
        #endregion

        public void UpdateTestSequence(TestSequence testSeq)
        {
            this.textBox_ProjectName.Text = testSeq.ProjectName;
            this.textBox_StationName.Text = testSeq.StationName;
            this.textBox_SequenceFile.Text = testSeq.Name;
            this.textBox_Version.Text = testSeq.Version;

            this.dataGridView_TestSequence.Rows.Clear();
            for (int i = 0; i < testSeq.TestSteps.Count; i++)
            {
                // 序号-测试项-下限-上限
                TestStep ts = testSeq.TestSteps[i];
                string[] row = new string[] { i.ToString(), ts.TestName, "", "" };
                this.dataGridView_TestSequence.Rows.Add(row);
            }

        }

        public void AppendLog(string log)
        {
            if (debugLog != null)
            {
                debugLog.AppendLog(log);
            }
        }

        private void toolStripMenuItem_DebugLog_Click(object sender, EventArgs e)
        {
            debugLog = new DebugLog();
            debugLog.FormClosing += new FormClosingEventHandler(debugLog_FormClosing);
            debugLog.Show();
        }

        void debugLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            debugLog.Dispose();
            debugLog = null;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            MessengerEx.Notify(TestEngineMessages.StartTest);
        }

    }
}

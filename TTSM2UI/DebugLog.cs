using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TTSM2.UI
{
    public partial class DebugLog : Form
    {
        public DebugLog()
        {
            InitializeComponent();
        }

        public void AppendLog(string log)
        {
            this.textBox_DebugLog.AppendText(log);
            this.textBox_DebugLog.AppendText("\r\n");
        }
    }
}

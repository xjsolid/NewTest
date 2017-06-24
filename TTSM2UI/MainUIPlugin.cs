using TTSM2.PluginInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTSM2.SeqFile;

namespace TTSM2.UI
{
    public class MainUIPlugin : IPlugin
    {
        #region members
        MainUI mainUI;
        #endregion

        #region IPlugin implement
        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public string Description
        {
            get
            {
                return "MainUI";
            }
        }

        public void Initialize()
        {
            mainUI = new MainUI();
            mainUI.FormClosing += Tb_FormClosing;

            MessengerEx.Register<TestSequence>(TestEngineMessages.TestSequenceLoaded, OnTestSequenceLoaded);
            MessengerEx.Register<string>(TestEngineMessages.GetDebugLog, OnGetDebugLog);
            MessengerEx.Register<string>(TestEngineMessages.GetWarning, OnGetWarning);
            MessengerEx.Register<string>(TestEngineMessages.GetError, OnGetError);
        }

        private void Tb_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            MessengerEx.Notify(GolbalMessages.MainAppExit);
        }

        public void Start()
        {
            mainUI.Show();
        }

        public void Dispose()
        {
            mainUI.Dispose();
        }
        

        #endregion

        #region callbacks
        void OnTestSequenceLoaded(TestSequence testSeq)
        {
            mainUI.UpdateTestSequence(testSeq);
        }

        void OnGetDebugLog(string log)
        {
            mainUI.AppendLog(log);
        }

        void OnGetWarning(string log)
        {
            mainUI.AppendLog(log);

        }

        void OnGetError(string log)
        {
            mainUI.AppendLog(log);

        }
        #endregion
    }
}

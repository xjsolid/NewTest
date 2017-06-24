using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTSM2.PluginInterface;

namespace TTSM2.TestEngine
{
    public class TestEnginePlugin : IPlugin
    {
        #region imp of IPlugin
        public string Name
        {
            get { return this.GetType().Name; }
        }

        public string Description
        {
            get { return "TestEngine"; }
        }

        public void Initialize()
        {
            te = new TestEngine();
            te.LoadStationConfig();
            te.LoadGlobalVariables();

            MessengerEx.Register<string>(TestEngineMessages.LoadTestSequence, OnLoadTestSequence);
            MessengerEx.Register(TestEngineMessages.StationConfigChanged, OnStationCfgChanged);
            MessengerEx.Register(TestEngineMessages.StartTest, OnStartTest);
        }

        public void Start()
        {
        }

        public void Dispose()
        {
            te.Dispose();
        }
        #endregion

        #region members
        TestEngine te;
        #endregion

        #region callbacks
        void OnLoadTestSequence(string sequenceFilePath)
        {
            te.LoadTestSequence(sequenceFilePath);
        }

        void OnStationCfgChanged()
        {
            te.LoadStationConfig();
        }

        void OnStartTest()
        {
            te.StartTest();
        }
        #endregion
    }
}

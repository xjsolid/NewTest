using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTSM2.PluginInterface
{
    enum MessageEnum
    {
        #region MainUI messages
        MainAppExit,
        #endregion

        #region TestEngine messages
        
        #endregion
    }

    public class GolbalMessages
    {
        #region mainUI messages
        public static string MainAppExit
        {
            get { return MessageEnum.MainAppExit.ToString(); }
        }
        #endregion

    }

    enum TestEngineMessageEnum
    {
        LoadTestSequence,
        TestSequenceLoaded,
        StationConfigChanged,
        GetDebugLog,
        GetWarning,
        GetError,

        StartTest,
    }

    public class TestEngineMessages
    {
        public static string LoadTestSequence
        {
            get { return TestEngineMessageEnum.LoadTestSequence.ToString(); }
        }

        public static string StationConfigChanged
        {
            get {return TestEngineMessageEnum.StationConfigChanged.ToString(); }
        }

        public static string TestSequenceLoaded
        {
            get { return TestEngineMessageEnum.TestSequenceLoaded.ToString(); }

        }

        public static string GetDebugLog
        {
            get { return TestEngineMessageEnum.GetDebugLog.ToString(); }
        }

        public static string GetWarning
        {
            get { return TestEngineMessageEnum.GetWarning.ToString(); }
        }

        public static string GetError
        {
            get { return TestEngineMessageEnum.GetError.ToString(); }
        }

        public static string StartTest
        {
            get { return TestEngineMessageEnum.StartTest.ToString(); }
        }
    }
}

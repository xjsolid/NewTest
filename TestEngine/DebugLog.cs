using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTSM2.Definitions;
using TTSM2.Utility;

namespace TTSM2.TestEngine
{
    class DebugLog : ILogger
    {
        #region members
        List<string> logContent = new List<string>();
        #endregion

        #region ILogger imp
        public void LogDebug(string logContent)
        {
            string log = string.Format("[Debug][{0}]", logContent);
            this.logContent.Add(log);
            OnLogDebug(log);
        }

        public void LogWarning(string logContent)
        {
            string log = string.Format("[Warning][{0}]", logContent);
            this.logContent.Add(log);
            OnLogWarning(log);
        }

        public void LogError(string logError)
        {
            string log = string.Format("[Error][{0}]", logContent);
            this.logContent.Add(log);
            OnLogError(log);
        }

        public event EventHandler<LogEventArguments> LogingDebug;
        void OnLogDebug(string logContent)
        {
            if (LogingDebug != null)
            {
                LogingDebug(this, new LogEventArguments(logContent));
            }
        }

        public event EventHandler<LogEventArguments> LogingWarning;
        void OnLogWarning(string logContent)
        {
            if (LogingWarning != null)
            {
                LogingWarning(this, new LogEventArguments(logContent));
            }
        }

        public event EventHandler<LogEventArguments> LogingError;
        void OnLogError(string logContent)
        {
            if (LogingError != null)
            {
                LogingError(this, new LogEventArguments(logContent));
            }
        }
        #endregion

        public void Clear()
        {
            this.logContent.Clear();
        }

        public void SaveToFile(string logFilePath)
        {
            Logfile logFile = new Logfile(logFilePath, true);
            foreach (var item in logContent)
            {
                logFile.Log(item, "");
            }

        }
    }
}

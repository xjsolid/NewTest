using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTSM2.Definitions
{
    public interface ILogger
    {
        void LogDebug(string logContent);
        void LogWarning(string logContent);
        void LogError(string logError);

        event EventHandler<LogEventArguments> LogingDebug;
        event EventHandler<LogEventArguments> LogingWarning;
        event EventHandler<LogEventArguments> LogingError;
    }

    public class LogEventArguments : EventArgs
    {
        public LogEventArguments(string logContent)
        {
            this.LogContent = logContent;
        }

        public string LogContent { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTSM2.Definitions
{
    public interface ITestModule
    {
        ILogger Logger { get; }
        void SetLogger(ILogger logger);
        void SetGlobalVariables(Dictionary<string, object> GolbalVariables);
        void Initialize();
        void Cleanup();
    }
}

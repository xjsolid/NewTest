using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTSM2.Definitions;

namespace DemoDLL
{
    public class Calculate : TestModuleBase
    {
        #region base class overrides
        public override void Initialize()
        {
            base.Initialize();
            this.logger.LogDebug("Calculate testmodule initialized.");
        }

        public override void Cleanup()
        {
            base.Cleanup();
        }
        #endregion

        #region testMothods
        public bool AddTest(Dictionary<string,object>parameters, TestResult testResult)
        {
            logger.LogDebug("Performing add test.");
            int x = int.Parse(GetLocalParameter("x", parameters, 10).ToString());
            int y = int.Parse(GetLocalParameter("y", parameters).ToString());

            int lowLimit = int.Parse(GetLocalParameter("LowLimit", parameters).ToString());
            int highLimit = int.Parse(GetLocalParameter("HighLimit", parameters).ToString());
            testResult.LowLimit = lowLimit.ToString();
            testResult.HighLimit = highLimit.ToString();

            logger.LogDebug(string.Format("Find parameters: {0}:{1}, {2}:{3}", "x", x, "y", y));

            int resultValue = x + y;

            logger.LogDebug(string.Format("Add result is: {0}", resultValue));

            testResult.Value = resultValue.ToString();

            if (resultValue >= lowLimit && resultValue <= highLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SetGVTest(Dictionary<string, object> parameters, TestResult testResult)
        {
            this.logger.LogDebug("Performing Set global variables test.");

            string varName = "SN";
            object varValue = "111111";
            bool result = this.SetGolbalVariable(varName, varValue);
            if (result)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}

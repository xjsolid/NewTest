using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTSM2.Definitions;

namespace DemoDLL2
{
    public class Class1 : TestModuleBase
    {
        #region testMethods
        public bool GetGVTest(Dictionary<string, object> parameters, TestResult testResult)
        {
            this.logger.LogDebug("Performing Get global variables test.");

            string varName = "SN";
            object varValue = this.GetGolbalVariable(varName);
            if (varValue == null)
            {
                this.logger.LogError(string.Format("Not found variable:{0}", varName));
                return false;
            }

            if (varValue.ToString().Equals("111111"))
            {
                this.logger.LogDebug(string.Format("Found variable {0}:{1}", varName, varValue));
                testResult.Value = varValue.ToString();
                return true;
            }
            this.logger.LogError(string.Format("Found variable {0}:{1}, value not corrent!", varName, varValue));
            return false;
        }
        #endregion
    }
}

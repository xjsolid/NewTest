using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTSM2.Definitions;

namespace TTSM2.Definitions
{
    public class TestModuleBase : ITestModule
    {
        #region imp of ITestModule
        public virtual void SetLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public virtual void SetGlobalVariables(Dictionary<string, object> GlobalVariables)
        {
            this.globalVariables = GlobalVariables;
        }

        public virtual void Initialize()
        {
        }

        public virtual void Cleanup()
        {
        }

        public ILogger Logger
        {
            get { return logger; }
        }
        #endregion

        #region members
        protected ILogger logger;
        protected Dictionary<string, object> globalVariables;
        #endregion

        #region private methods
        protected virtual object GetLocalParameter(string parameterName, Dictionary<string, object> parameters, object defaultValue = null)
        {
            if (parameters.ContainsKey(parameterName))
            {
                return parameters[parameterName];
            }

            if (defaultValue != null)
            {
                return defaultValue;
            }

            throw new KeyNotFoundException(string.Format("Not found parameter: {0}", parameterName));
        }

        protected virtual bool SetGolbalVariable(string varName, object value)
        {
            if (this.globalVariables == null)
            {
                throw new NullReferenceException("Not set GlobalVariables!");
            }

            if (this.globalVariables.ContainsKey(varName))
            {
                this.globalVariables[varName] = value;
                return true;
            }
            return false;
        }

        protected virtual object GetGolbalVariable(string varName)
        {
            if (this.globalVariables == null)
            {
                throw new NullReferenceException("Not set GlobalVariables!");
            }

            if (this.globalVariables.ContainsKey(varName))
            {
                return this.globalVariables[varName];
            }

            return null;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTSM2.Utility;
using TTSM2.SeqFile;
using System.IO;
using TTSM2.Configuration;
using TTSM2.PluginInterface;
using System.Threading.Tasks;
using System.Threading;
using TTSM2.Definitions;
using System.Reflection;

namespace TTSM2.TestEngine
{
    class TestEngine : IDisposable
    {
        public TestEngine()
        {
            string pluginFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, plugInFolderName);

            stationConfigFile = Path.Combine(pluginFolder, stationConfigFileName);
            globalVariablesCfgFile = Path.Combine(pluginFolder, globalVariablesCfgFileName);
            testModulesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, testModulesFolderName);

            InitialLog();
            testModuleMgr = new TestModuleManager(this);
        }

        #region const
        const string plugInFolderName = "Plugins";
        const string stationConfigFileName = "StationConfig.xml";
        const string globalVariablesCfgFileName = "GlobalVariables.xml";
        const string testModulesFolderName = "TestModules";
        #endregion

        #region members
        GlobalVariablesConfig gvCfg;
        StationConfig sc;
        TestSequence testSequence;

        Dictionary<string, object> globalVars = new Dictionary<string, object>();
        List<string> testModules = new List<string>();
        TestModuleManager testModuleMgr;

        Logfile testEngineLogger;
        DebugLog debugLogger;
        string stationConfigFile = string.Empty;
        string globalVariablesCfgFile = string.Empty;
        string testModulesFolder = string.Empty;

        Task testTask;
        #endregion

        #region props
        public Logfile TestEngineLogger
        {
            get { return testEngineLogger; }
        }

        public DebugLog DebugLogger
        {
            get { return debugLogger; }
        }

        public Dictionary<string, object> GlobalVariables
        {
            get { return globalVars; }
        }


        #endregion

        #region methods
        public void LoadStationConfig()
        {
            testEngineLogger.Log(string.Format("Loading station cfg file: {0}", Path.GetFullPath(stationConfigFile)), "LoadStationConfig");
            sc = XmlConfigHelper.Load<StationConfig>(stationConfigFile);
            testEngineLogger.Log("Success.", "LoadStationConfig");

        }

        public void LoadGlobalVariables()
        {
            testEngineLogger.Log(string.Format("Loading global variables: {0}", Path.GetFullPath(globalVariablesCfgFile)), "LoadGlobalVariables");

            gvCfg = XmlConfigHelper.Load<GlobalVariablesConfig>(globalVariablesCfgFile);
            foreach (var item in gvCfg.GloblaVariables)
            {
                globalVars.Add(item.Name, item.Value);
            }
            testEngineLogger.Log("Success", "LoadGlobalVariables");

        }

        public void LoadTestSequence(string sequenceFilePath)
        {
            testEngineLogger.Log(string.Format("Loading TestSequence: {0}", sequenceFilePath), "LoadTestSequence");

            testSequence = XmlConfigHelper.Load<TestSequence>(sequenceFilePath);
            testModules.Clear();
            testModuleMgr.UnloadTestModules();
            // fetch used test modules of the sequence
            foreach (var item in testSequence.TestSteps)
            {
                if (!testModules.Contains(item.AssemblyName))
                {
                    testModules.Add(item.AssemblyName);
                }
            }
            LoadTestModules();
            MessengerEx.Notify(TestEngineMessages.TestSequenceLoaded, testSequence);
            testEngineLogger.Log("Success", "LoadTestSequence");

        }

        void LoadTestModules()
        {
            testModuleMgr.LoadTestModules(testModules, testModulesFolder);
        }

        void InitialLog()
        {
            string testEngineLogFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log-TestEngine");
            Directory.CreateDirectory(testEngineLogFolder);
            string logPath = Path.Combine(testEngineLogFolder, DateTime.Now.ToString("yyyyMMdd-hhmmss"));
            testEngineLogger = new Logfile(logPath, true);

            debugLogger = new DebugLog();
            debugLogger.LogingDebug += new EventHandler<Definitions.LogEventArguments>(debugLogger_LogingDebug);
            debugLogger.LogingWarning += new EventHandler<Definitions.LogEventArguments>(debugLogger_LogingWarning);
            debugLogger.LogingError += new EventHandler<Definitions.LogEventArguments>(debugLogger_LogingError);
        }

        public void Dispose()
        {
            testModuleMgr.UnloadTestModules();
        }

        public void StartTest()
        {
            if (testSequence == null)
            {
                return;
            }

            testTask = new Task(ExecuteAllProgress);
            testTask.Start();
            Thread.Sleep(1);
        }

        void ExecuteAllProgress()
        {
            testEngineLogger.Log(string.Format("Start test, Sequence Name:{0}", testSequence.Name), "ExecuteAllProgress");
            foreach (var item in testSequence.TestSteps)
            {
                TestResult testResult = new TestResult();
                bool result = ExecuteTestStep(item, testResult);
            }
        }

        bool ExecuteTestStep(TestStep ts, TestResult testResult)
        {
            testEngineLogger.Log(string.Format("Executing test step:{0}", ts.TestName), "ExecuteAllProgress");
            string testStepAssemblyPath = Path.Combine(testModulesFolder, string.Format("{0}.dll", ts.AssemblyName));
            Assembly assembly = Assembly.LoadFrom(testStepAssemblyPath);
            Type[] types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.Name.Equals(ts.ClassName))
                {
                    MethodInfo[] mis = type.GetMethods(BindingFlags.Public);
                    foreach (var mi in mis)
                    {
                        if (mi.Name.Equals(ts.MethodName))
                        {
                            //mi.in
                        }
                    }
                }
            }


            return true;
        }

        #endregion

        #region log callbacks
        void debugLogger_LogingError(object sender, Definitions.LogEventArguments e)
        {
            MessengerEx.Notify(TestEngineMessages.GetError, e.LogContent);
        }

        void debugLogger_LogingWarning(object sender, Definitions.LogEventArguments e)
        {
            MessengerEx.Notify(TestEngineMessages.GetWarning, e.LogContent);
        }

        void debugLogger_LogingDebug(object sender, Definitions.LogEventArguments e)
        {
            MessengerEx.Notify(TestEngineMessages.GetDebugLog, e.LogContent);
        }
        #endregion
    }
}

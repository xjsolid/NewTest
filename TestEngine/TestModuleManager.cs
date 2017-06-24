using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using TTSM2.Definitions;
using System.IO;
using TTSM2.Utility;

namespace TTSM2.TestEngine
{
    class TestModuleManager
    {
        #region ctor
        public TestModuleManager(TestEngine te)
        {
            this.te = te;
        }
        #endregion

        #region members
        Dictionary<string, TestModuleInfo> testModules = new Dictionary<string, TestModuleInfo>();
        TestEngine te;
        #endregion

        #region props
        public Dictionary<string, TestModuleInfo> TestModules
        {
            get { return testModules; }
        }
        #endregion

        #region methods
        public void LoadTestModules(List<string> testModuleNames, string testModulesFolder)
        {
            te.TestEngineLogger.Log(string.Format("Loading testmodules from:{0}", testModulesFolder), "LoadTestModules");
            if (string.IsNullOrEmpty(testModulesFolder))
            {
                throw new ArgumentNullException("plugDirectory");
            }
            Directory.CreateDirectory(testModulesFolder);

            foreach (var item in testModuleNames)
            {
                string testModulePath = Path.Combine(testModulesFolder, string.Format("{0}.dll", item));
                if (File.Exists(testModulePath))
                {
                    FileInfo fileInfo = new FileInfo(testModulePath);
                    AddTestModule(testModulePath);
                }
                else
                {
                    te.TestEngineLogger.Log(string.Format("Not find test module:{0}", testModulePath), "LoadTestModules");
                }
            }
        }

        public void UnloadTestModules()
        {
            foreach (var item in testModules)
            {
                TestModuleInfo pi = item.Value;
                pi.Instance.Cleanup();
                pi.Instance = null;
            }
            testModules.Clear();
        }

        void AddTestModule(string filePath)
        {
            Assembly assembly = Assembly.LoadFrom(filePath);
            foreach (Type type in assembly.GetTypes())
            {
                if (type.IsPublic)
                {
                    if (!type.IsAbstract)
                    {
                        Type typeInterface = type.GetInterface("TTSM2.Definitions.ITestModule", true);
                        if (typeInterface != null)
                        {
                            TestModuleInfo tmi = FindTestModule(type.Name);
                            if (tmi != null)
                            {
                                continue;
                            }
                            tmi = new TestModuleInfo(type.Name);
                            tmi.AssemblyPath = filePath;
                            object instance = Activator.CreateInstance(assembly.GetType(type.ToString()));
                            //object instance = assembly.CreateInstance(type.FullName);
                            tmi.Instance = (ITestModule)instance;
                            tmi.Instance.SetLogger(te.DebugLogger);
                            tmi.Instance.SetGlobalVariables(te.GlobalVariables);
                            tmi.Instance.Initialize();
                            testModules.Add(type.Name, tmi);
                        }
                    }
                }
            }
        }

        TestModuleInfo FindTestModule(string name)
        {
            if (testModules.ContainsKey(name))
            {
                return testModules[name];
            }
            return null;
        }
        #endregion
    }
}

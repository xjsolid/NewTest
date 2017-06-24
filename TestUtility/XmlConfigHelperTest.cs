using TTSM2.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TTSM2.TestEngine;

namespace TestUtility
{
    
    
    /// <summary>
    ///这是 XmlConfigHelperTest 的测试类，旨在
    ///包含所有 XmlConfigHelperTest 单元测试
    ///</summary>
    [TestClass()]
    public class XmlConfigHelperTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Load 的测试
        ///</summary>
        public void LoadTestHelper<T>()
        {
            string filePath = @"D:\SVN\Platform\TTSM2_Code\TestFramework\ConfigFiles\StationConfig.xml";
            StationConfig sc = XmlConfigHelper.Load<StationConfig>(filePath);
            Assert.IsNotNull(sc);
        }

        [TestMethod()]
        public void XmlConfigHelperLoadTest()
        {
            LoadTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///Save 的测试
        ///</summary>
        public void SaveTestHelper<T>()
        {
            GlobalVariablesConfig gvcfg = new GlobalVariablesConfig();
            gvcfg.GloblaVariables.Add(new Variable("SN", ""));
            XmlConfigHelper.Save<GlobalVariablesConfig>(gvcfg, "GlobalVariables.xml");
        }

        [TestMethod()]
        public void XmlConfigHelperSaveTest()
        {
            SaveTestHelper<GenericParameterHelper>();
        }
    }
}

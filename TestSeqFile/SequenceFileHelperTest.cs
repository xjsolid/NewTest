using TTSM2.SeqFile;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSeqFile
{
    
    
    /// <summary>
    ///这是 SequenceFileHelperTest 的测试类，旨在
    ///包含所有 SequenceFileHelperTest 单元测试
    ///</summary>
    [TestClass()]
    public class SequenceFileHelperTest
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
        ///Save 的测试
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            TestSequence ts = new TestSequence();
            string xmlPath = "TestSeq.xml";

            // fill testSequence props
            ts.ProjectName = "TestProject";
            ts.StationName = "TestStation";
            ts.Version = "1.0.0.0";

            TestStep addtestStep = new TestStep();
            addtestStep.TestName = "AddTest";
            addtestStep.AssemblyName = "DemoDLL";
            addtestStep.ClassName = "Calculate";
            addtestStep.MethodName = "AddTest";

            TestParameter xPar = new TestParameter("x", "10", "", "", "", "Int", "Input");
            addtestStep.TestParameters.Add(xPar);
            TestParameter yPar = new TestParameter("y", "20", "", "", "", "Int", "Input");
            addtestStep.TestParameters.Add(yPar);
            TestParameter resultLowLimPar = new TestParameter("LowLimit", "-1000", "", "", "", "Int", "Input");
            addtestStep.TestParameters.Add(resultLowLimPar);
            TestParameter resultHighLimPar = new TestParameter("HighLimit", "1000", "", "", "", "Int", "Input");
            addtestStep.TestParameters.Add(resultHighLimPar);

            ts.TestSteps.Add(addtestStep);

            TestStep setGVStep = new TestStep("SetGlobalVar", "DemoDLL", "Calculate", "SetGVTest");
            ts.TestSteps.Add(setGVStep);

            TestStep getGVStep = new TestStep("GetGlobalVar", "DemoDLL2", "Class1", "GetGVTest");
            ts.TestSteps.Add(getGVStep);

            SequenceFileHelper.Save(ts, xmlPath);
            
        }
    }
}

using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sdet.Auto.TestHelper;
using Sdet.Auto.AUTLayer;

namespace Sdet.Auto.CodedUiTests
{

    [CodedUITest(CodedUITestType.WindowsStore)]
    public class TestBaseClass
    {
        public TestAssert TestAssert;
        public GuiHelper GuiHelper;

        [TestInitialize]
        public void MyTestInitialize()
        {
            TestAssert = new TestAssert();
            GuiHelper = new GuiHelper();
            const string calcProcess = "ApplicationFrameHost";
            IoLibrary.KillProcess(calcProcess);
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            Assert.IsTrue(TestAssert.Pass);
        }
    }
}

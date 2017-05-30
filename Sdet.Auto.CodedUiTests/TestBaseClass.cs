using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
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
            IoLibrary.KillProcess();
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            Assert.IsTrue(TestAssert.Pass);
        }
    }
}

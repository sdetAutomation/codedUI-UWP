using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sdet.Auto.AUTLayer;

namespace Sdet.Auto.CodedUiTests
{

    [CodedUITest(CodedUITestType.WindowsStore)]
    public class CalculatorTest : TestBaseClass
    {

        [TestMethod]
        public void Calc_TC0001_Smoketest()
        {
            GuiService.LaunchCalculator();
            GuiHelper.calculatorWindow.VerifyWindowExist(TestAssert);
            GuiHelper.calculatorWindow.CloseWindow();
        }
    }
}

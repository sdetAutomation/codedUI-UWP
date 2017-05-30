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
            GuiHelper.calculatorWindowToolbar.VerifyWindowExist(TestAssert);
            GuiHelper.calculatorWindowMain.VerifyWindowExist(TestAssert);
            GuiHelper.calculatorWindowToolbar.CloseWindow();
        }

        [TestMethod]
        public void Calc_TC0002_Add()
        {
            const string baseline = "Display is 4";

            GuiService.LaunchCalculator();
            GuiHelper.calculatorWindowMain.ClickOne();
            GuiHelper.calculatorWindowMain.ClickPlus();
            GuiHelper.calculatorWindowMain.ClickThree();
            GuiHelper.calculatorWindowMain.ClickEquals();
            GuiHelper.calculatorWindowMain.VerifyResults(TestAssert, baseline);
            GuiHelper.calculatorWindowToolbar.CloseWindow();
        }

        [TestMethod]
        public void Calc_TC0003_Subtract()
        {
            const string baseline = "Display is 1";

            GuiService.LaunchCalculator();
            GuiHelper.calculatorWindowMain.ClickTwo();
            GuiHelper.calculatorWindowMain.ClickMinus();
            GuiHelper.calculatorWindowMain.ClickOne();
            GuiHelper.calculatorWindowMain.ClickEquals();
            GuiHelper.calculatorWindowMain.VerifyResults(TestAssert, baseline);
            GuiHelper.calculatorWindowToolbar.CloseWindow();
        }

        [TestMethod]
        public void Calc_TC0004_Multiply()
        {
            const string baseline = "Display is 6";

            GuiService.LaunchCalculator();
            GuiHelper.calculatorWindowMain.ClickTwo();
            GuiHelper.calculatorWindowMain.ClickMultiply();
            GuiHelper.calculatorWindowMain.ClickThree();
            GuiHelper.calculatorWindowMain.ClickEquals();
            GuiHelper.calculatorWindowMain.VerifyResults(TestAssert, baseline);
            GuiHelper.calculatorWindowToolbar.CloseWindow();
        }

        [TestMethod]
        public void Calc_TC0005_Divide()
        {
            const string baseline = "Display is 1.5";

            GuiService.LaunchCalculator();
            GuiHelper.calculatorWindowMain.ClickThree();
            GuiHelper.calculatorWindowMain.ClickDivide();
            GuiHelper.calculatorWindowMain.ClickTwo();
            GuiHelper.calculatorWindowMain.ClickEquals();
            GuiHelper.calculatorWindowMain.VerifyResults(TestAssert, baseline);
            GuiHelper.calculatorWindowToolbar.CloseWindow();
        }
    }
}

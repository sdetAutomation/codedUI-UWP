using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sdet.Auto.AUTLayer;
using System.Threading;

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
            GuiHelper.calulatorWindowMain.VerifyWindowExist(TestAssert);
            GuiHelper.calculatorWindowToolbar.CloseWindow();
        }

        [TestMethod]
        public void Calc_TC0002_Add()
        {
            const string baseline = "Display is 4";

            GuiService.LaunchCalculator();
            GuiHelper.calulatorWindowMain.ClickOne();
            GuiHelper.calulatorWindowMain.ClickPlus();
            GuiHelper.calulatorWindowMain.ClickThree();
            GuiHelper.calulatorWindowMain.ClickEquals();
            GuiHelper.calulatorWindowMain.VerifyResults(TestAssert, baseline);
            GuiHelper.calculatorWindowToolbar.CloseWindow();
        }

        [TestMethod]
        public void Calc_TC0003_Subtract()
        {
            const string baseline = "Display is 1";

            GuiService.LaunchCalculator();
            GuiHelper.calulatorWindowMain.ClickTwo();
            GuiHelper.calulatorWindowMain.ClickMinus();
            GuiHelper.calulatorWindowMain.ClickOne();
            GuiHelper.calulatorWindowMain.ClickEquals();
            GuiHelper.calulatorWindowMain.VerifyResults(TestAssert, baseline);
            GuiHelper.calculatorWindowToolbar.CloseWindow();
        }

        [TestMethod]
        public void Calc_TC0004_Multiply()
        {
            const string baseline = "Display is 6";

            GuiService.LaunchCalculator();
            GuiHelper.calulatorWindowMain.ClickTwo();
            GuiHelper.calulatorWindowMain.ClickMultiply();
            GuiHelper.calulatorWindowMain.ClickThree();
            GuiHelper.calulatorWindowMain.ClickEquals();
            GuiHelper.calulatorWindowMain.VerifyResults(TestAssert, baseline);
            GuiHelper.calculatorWindowToolbar.CloseWindow();
        }

        [TestMethod]
        public void Calc_TC0005_Divide()
        {
            const string baseline = "Display is 1.5";

            GuiService.LaunchCalculator();
            GuiHelper.calulatorWindowMain.ClickThree();
            GuiHelper.calulatorWindowMain.ClickDivide();
            GuiHelper.calulatorWindowMain.ClickTwo();
            GuiHelper.calulatorWindowMain.ClickEquals();
            GuiHelper.calulatorWindowMain.VerifyResults(TestAssert, baseline);
            GuiHelper.calculatorWindowToolbar.CloseWindow();
        }
    }
}

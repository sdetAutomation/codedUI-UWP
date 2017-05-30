using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Sdet.Auto.TestHelper;

namespace Sdet.Auto.AUTLayer
{
    public class CalculatorWindow_Toolbar : UITestControl
    {
        public CalculatorWindow_Toolbar()
        {
            this.TechnologyName = "UIA";
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Calculator";
        }

        public void VerifyWindowExist(TestAssert testAssert)
        {
            IoLibrary.WriteLine("Verifying Calculator Window Toolbar Exists.");
            testAssert.Pass = LoggingLibrary.CompareResult(this.Exists, true);
        }

        public void CloseWindow()
        {
            Mouse.Click(this.BtnClose);
        }

        #region Controls
        public UITestControl BtnClose
        {
            get
            {
                this.mBtnClose = new UITestControl(this);
                this.mBtnClose.SearchProperties["AutomationId"] = "Close";
                return this.mBtnClose;
            }
        }
        private UITestControl mBtnClose;

 
        #endregion

    }
}

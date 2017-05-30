using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using System.Threading;
using Sdet.Auto.TestHelper;

namespace Sdet.Auto.AUTLayer
{
    public class CalculatorWindow : UITestControl
    {
        public CalculatorWindow()
        {
            this.TechnologyName = "UIA";
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Calculator";
        }

        public void VerifyWindowExist(TestAssert testAssert)
        {
            IoLibrary.WriteLine("Verifying Calculator Window Exists.");
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

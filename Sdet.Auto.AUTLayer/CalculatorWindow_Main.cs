using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Sdet.Auto.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.AUTLayer
{
    public class CalculatorWindow_Main : XamlWindow
    {

        public CalculatorWindow_Main()
        {
            this.SearchProperties[XamlControl.PropertyNames.Name] = "Calculator";
            this.SearchProperties[XamlControl.PropertyNames.ClassName] = "Windows.UI.Core.CoreWindow";
        }

        public void ClickPlus()
        {
            Mouse.Click(BtnPlus);
        }

        public void ClickMinus()
        {
            Mouse.Click(BtnMinus);
        }

        public void ClickMultiply()
        {
            Mouse.Click(BtnMultiply);
        }
        public void ClickDivide()
        {
            Mouse.Click(BtnDivide);
        }
        public void ClickOne()
        {
            Mouse.Click(BtnOne);
        }
        public void ClickTwo()
        {
            Mouse.Click(BtnTwo);
        }

        public void ClickThree()
        {
            Mouse.Click(BtnThree);
        }

        public void ClickEquals()
        {
            Mouse.Click(BtnEqual);
        }

        public void VerifyWindowExist(TestAssert testAssert)
        {
            IoLibrary.WriteLine("Verifying Calculator Window Main Exists.");
            testAssert.Pass = LoggingLibrary.CompareResult(this.Exists, true);
        }

        public void VerifyResults(TestAssert testAssert, String expectedResult)
        {
            IoLibrary.WriteLine("Verifying Calculator Results.");
            testAssert.Pass = LoggingLibrary.CompareResult(this.TxtResult.DisplayText, expectedResult);
        }

        #region Controls
        public XamlText TxtResult
        {
            get
            {
                this.mTxtResult = new XamlText(this);
                this.mTxtResult.SearchProperties[XamlText.PropertyNames.AutomationId] = "CalculatorResults";
                return this.mTxtResult;
            }
        }
        private XamlText mTxtResult;

        public XamlButton BtnPlus
        {
            get
            {
                this.mBtnPlus = new XamlButton(this);
                this.mBtnPlus.SearchProperties[XamlButton.PropertyNames.AutomationId] = "plusButton";
                return this.mBtnPlus;
            }
        }
        private XamlButton mBtnPlus;

        public XamlButton BtnMinus
        {
            get
            {
                this.mBtnMinus = new XamlButton(this);
                this.mBtnMinus.SearchProperties[XamlButton.PropertyNames.AutomationId] = "minusButton";
                return this.mBtnMinus;
            }
        }
        private XamlButton mBtnMinus;

        public XamlButton BtnMultiply
        {
            get
            {
                this.mBtnMultiply = new XamlButton(this);
                this.mBtnMultiply.SearchProperties[XamlButton.PropertyNames.AutomationId] = "multiplyButton";
                return this.mBtnMultiply;
            }
        }
        private XamlButton mBtnMultiply;

        public XamlButton BtnDivide
        {
            get
            {
                this.mBtnDivide = new XamlButton(this);
                this.mBtnDivide.SearchProperties[XamlButton.PropertyNames.AutomationId] = "divideButton";
                return this.mBtnDivide;
            }
        }
        private XamlButton mBtnDivide;

        public XamlButton BtnEqual
        {
            get
            {
                this.mBtnEqual = new XamlButton(this);
                this.mBtnEqual.SearchProperties[XamlButton.PropertyNames.AutomationId] = "equalButton";
                return this.mBtnEqual;
            }
        }
        private XamlButton mBtnEqual;

        public XamlButton BtnOne
        {
            get
            {
                this.mBtnOne = new XamlButton(this);
                this.mBtnOne.SearchProperties[XamlButton.PropertyNames.AutomationId] = "num1Button";
                return this.mBtnOne;
            }
        }
        private XamlButton mBtnOne;

        public XamlButton BtnTwo
        {
            get
            {
                this.mBtnTwo = new XamlButton(this);
                this.mBtnTwo.SearchProperties[XamlText.PropertyNames.AutomationId] = "num2Button";
                return this.mBtnTwo;
            }
        }
        private XamlButton mBtnTwo;
    
        public XamlButton BtnThree
        {
            get
            {
                this.mBtnThree = new XamlButton(this);
                this.mBtnThree.SearchProperties[XamlText.PropertyNames.AutomationId] = "num3Button";
                return this.mBtnThree;
            }
        }
        private XamlButton mBtnThree;

        #endregion
    }
}

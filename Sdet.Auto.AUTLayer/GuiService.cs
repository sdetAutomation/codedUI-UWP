using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.AUTLayer
{
    public class GuiService : UITestControl
    {
        public static void LaunchCalculator()
        {
            XamlWindow.Launch("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        }
        
    }
}

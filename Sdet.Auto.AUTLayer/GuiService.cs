using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;

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

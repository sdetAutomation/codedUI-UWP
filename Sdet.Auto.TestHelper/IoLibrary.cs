using System;
using System.Diagnostics;
using System.Reflection;

namespace Sdet.Auto.TestHelper
{
    public class IoLibrary
    {
        public static void WriteLine(string text)
        {
            Console.WriteLine(" ");
            Console.WriteLine(string.Format("### {0} ###", text));
        }

        public static void WritelineEnd()
        {
            Console.WriteLine("############");
            Console.WriteLine(" ");
        }

        public static string GetBinPath()
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembl‌​y().Location);
            return path;
        }

        public static void KillProcess(String processName)
        {
            var processes = Process.GetProcesses();

            foreach (var process in Process.GetProcessesByName(processName))
            {
                process.Kill();
            }
        }
    }
}

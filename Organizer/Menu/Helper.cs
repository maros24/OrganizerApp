using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Helper
    {
        public static void CloseProgram()
        {
            Process.GetCurrentProcess().Kill();
        }
        public static void TapAny()
        {
            Console.WriteLine("Tap any button to return");
        }
    }
}

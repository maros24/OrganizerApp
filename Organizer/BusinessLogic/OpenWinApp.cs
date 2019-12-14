using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class OpenWinApp
    {
        public void StartApp()
        {
            while (true) {
                Console.Clear();
                Console.WriteLine("1. Notebook");
                Console.WriteLine("2. Calculator");
                Console.WriteLine("3. Paint");
                Console.WriteLine("4. Excel");
                Console.WriteLine("5. Return to Main menu");
                int input = int.Parse(Console.ReadLine());
                if (input == 5) {
                    return;
                }
                string[] programs = { "Notepad.exe", "calc", "mspaint", "excel" };
                Process.Start(programs[input - 1]);
            }
        }
    }
}

using BusinessLogic;
using System;
using System.Diagnostics;

namespace Menu
{
    public class Helper
    {
        static int numberLine;

        public static void CloseProgram()
        {
            Process.GetCurrentProcess().Kill();
        }

        public static void TapAny()
        {
            Console.WriteLine("Tap any button to return");
        }

        public static void DeleteLineFromFile()
        {
            Console.WriteLine("Please, enter the number of line to delete");
            try
            {
                numberLine = Int32.Parse(Console.ReadLine());
                Console.Clear();
                FileActions.DeleteLine(numberLine);
            }
            catch
            {
                Console.WriteLine("Incorrect value. Tap any button to try again!");
            }
        }
    }
}

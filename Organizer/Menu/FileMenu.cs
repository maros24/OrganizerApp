using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Menu
{
    public class FileMenu
    {
        public static void OpenFileMenu()
        {
            int i;
            bool flag = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Work with files!");
                Console.Write(
                    "1) Write to File\n" +
                    "2) Read from file\n" +
                    "3) Return to Main menu\n");

                int.TryParse(Console.ReadLine(), out i);
                switch (i)
                {
                    case 1:
                        Console.Clear();
                        FileActions.Write();
                        Helper.TapAny();
                        break;
                    case 2:
                        Console.Clear();
                        FileActions.Read();
                        Helper.TapAny();
                        break;
                    case 3:
                        MainMenu.Run();
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect number. Please try again!");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            while (flag);
            Console.ReadKey();
        }
    }
}

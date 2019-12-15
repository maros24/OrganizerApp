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
            int numberLine;
            do
            {
                Console.Clear();
                Console.WriteLine(" Work with files!");
                Console.WriteLine(" Please select an item from Menu\n");
                Console.Write(
                    " 1) Write to File\n" +
                    " 2) Read from file\n" +
                    " 3) Delete selected line\n" +
                    " 4) Delete file\n" +
                    " 5) Return to Main menu\n"+
                    " \nEnter the nubmer of item: ");

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
                        Console.Clear();
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
                        break;

                    case 4:
                        Console.Clear();
                        FileActions.DeleteFile();
                        break;
                    case 5:
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

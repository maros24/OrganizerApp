
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu
{
    public class MainMenu
    {
        public static void Run()
        {
            int i;
            bool flag = true;
            do
            {
                Console.Clear();
                Console.WriteLine("\n{0,50}", "WELCOME TO ORGANIZER, " + Environment.UserName + "!\n");
                Console.WriteLine(" Please select an item from Menu\n");
                Console.Write(
                    " 1) Run Windows Application\n" +
                    " 2) Work with files\n" +
                    " 3) View current weather\n" +
                    " 4) Send an e-mail\n" +
                    " 5) Exit\n" +
                    " \nEnter the nubmer of item: ");

                int.TryParse(Console.ReadLine(), out i);
                switch (i)
                {
                    case 1:
                        Console.Clear();
                        OpenWinApp openWinApp = new OpenWinApp();
                        openWinApp.StartApp();
                        break;
                    case 2:
                        FileMenu.OpenFileMenu();
                        Helper.TapAny();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        WeatherData.GetWeather();
                        Helper.TapAny();
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        SendMailMenu.StartSendMail();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Good bye!");
                        Thread.Sleep(2000);
                        Helper.CloseProgram();
                        break;
                    default:
                        Console.WriteLine("Incorrect number. Please try again!");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            }
            while (flag);
            Console.ReadKey();
        }
    }
}

using System;
using System.Diagnostics;

namespace BusinessLogic
{
    public class OpenWinApp
    {
        public void StartApp()
        {
            while (true) {
                Console.Clear();
                Console.WriteLine(" Please select the program from list\n");
                Console.Write(
                    " 1) Notebook\n" +
                    " 2) Calculator\n" +
                    " 3) Paint\n" +
                    " 4) Excel\n" +
                    " 5) Return to Main menu\n"+
                    " \nEnter the nubmer of item: ");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input == 5)
                    {
                        return;
                    }
                    string[] programs = { "Notepad.exe", "calc", "mspaint", "excel" };
                    Process.Start(programs[input - 1]);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("\n Incorrect number. Try again!");
                    Console.WriteLine(" Tap any button to return");
                    Console.ReadKey();
                }
            }
        }
    }
}

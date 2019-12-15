using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class SendMailMenu
    {
        public static void StartSendMail()
        {
            string defaultEmailAddr = "t.testeracc1@gmail.com";
            string defaultPassword = "Test#Test1";
            string defaultUserName = "Tester";
            string ownEmailAddr;
            string ownPasswd;
            string ownUserName;
            bool exit = true;
            while (exit)
            {
                Console.Write(
                    "1. Send e-mail from default account\n" +
                    "2. Send e-mail from own account\n" +
                    "3. Exit to main menu\n" +
                    "Input number of operations: ");
                string i = Console.ReadLine();
                Console.Clear();
                switch (i)
                {
                    case "1":
                        SendMail.SendMessage(defaultEmailAddr, defaultPassword, defaultUserName);
                        break;
                    case "2":
                        Console.WriteLine("Warning!Your account must have permission enabled for <<Untrusted Applications>>");
                        Console.Write("Input your gmail address: ");
                        ownEmailAddr = Console.ReadLine();
                        Console.Write("Input your name: ");
                        ownUserName = Console.ReadLine();
                        Console.Write("Input your password: ");
                        ownPasswd = Console.ReadLine();
                        SendMail.SendMessage(ownEmailAddr, ownPasswd, ownUserName);
                        break;
                    case "3":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid data, try again..");
                        break;
                }
            }
        }
    }
}

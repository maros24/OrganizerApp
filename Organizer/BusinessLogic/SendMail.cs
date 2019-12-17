using System;
using System.Net;
using System.Net.Mail;

namespace BusinessLogic
{
    public class SendMail
    {
        public static void SendMessage(string emailAddr, string password, string userName)
        {
            string recipientEmail;
            Console.Write(" Input recipient's gmail address: ");
            recipientEmail = Console.ReadLine();
            try
            {
                MailAddress fromMailAddress = new MailAddress(emailAddr, userName);
                MailAddress toMailAddress = new MailAddress(recipientEmail);
                using (MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress))
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    Console.Write(" Input subject: ");
                    mailMessage.Subject = Console.ReadLine();
                    Console.Write(" Input your message: ");
                    mailMessage.Body = Console.ReadLine();
                    Console.Clear();
                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, password);
                    smtpClient.Send(mailMessage);
                    Console.WriteLine(" Message has send!");
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                string s= e.StackTrace;
                Console.WriteLine(" Error: " + e.Message);
                Console.WriteLine("\nTap any button to return");
                Console.ReadKey();
            }
        }
    }
}

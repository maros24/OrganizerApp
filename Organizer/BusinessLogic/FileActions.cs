using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class FileActions
    {
        static string path = System.IO.Path.GetFullPath(@"file.txt");
        public static void Write()
        {
            Console.WriteLine("Please enter the text for saving");
            string textToWrite = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(textToWrite);
            }
            Console.WriteLine("\nFile saved to: " + path);

        }

        public static void Read()
        {
            Console.WriteLine("The text from the file is below:");
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine();
            }
        }
    }
}

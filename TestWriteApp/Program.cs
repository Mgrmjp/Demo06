using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWriteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"E:\Olio-ohjelmointi\Demo06\test.txt");
            int i = 0;

            do
            {
                Console.Write("Give a text line (press enter to end) : ");
                outputFile.WriteLine(Console.ReadLine());
                i++;
            } while (i < 6);
            outputFile.Close();

            string text = System.IO.File.ReadAllText(@"E:\Olio-ohjelmointi\Demo06\test.txt");
            Console.WriteLine("Contents of file:\n" + text);
        }
    }
}

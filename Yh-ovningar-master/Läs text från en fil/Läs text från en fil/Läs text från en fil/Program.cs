using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Läs_text_från_en_fil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("test.txt", "Det här är en testfil.");
            Console.Write("Sökväg till filen: ");
            string path = @"C:\Systemutveckling .Net och AI (YH)\Läs text från en fil\Läs text från en fil\Läs text från en fil\bin\Debug\test.txt""";
            string input = Console.ReadLine();
            File.ReadAllText(path);
            File.Exists(path);


            Console.WriteLine(input);
        }
    }
}

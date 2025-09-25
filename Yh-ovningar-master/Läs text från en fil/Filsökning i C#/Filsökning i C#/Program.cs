using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filsökning_i_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Systemutveckling .Net och AI (YH)\Läs text från en fil\Filsökning i C#\Filsökning i C#\bin\Debug"; // Ange sökvägen till mappen här
            File.WriteAllText("Test.txt", "Detta är en testfil.");
            string Search = "Test.txt"; // ange filnamnet att söka efter här
            Console.Write("Ange sökväg: ");
            string inputPath = Console.ReadLine();
            File.Exists("Test.txt");

        }
    }
}

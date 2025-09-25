using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundläggande_LINQ
{
    internal class Result
    {
        public void res(List<int>numbers)
        {
            
            var sum = numbers.Sum();
            var avrage = numbers.Average();
            var min = numbers.Min();
            var max = numbers.Max();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"------ Resultat------\n" +
                    $"Summan av alla siffror är: {sum}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Medelvärdet av alla siffror är: {avrage}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Minsta siffran är: {min}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Största siffran är: {max}\n" +
                    $"------Hej då------");
            Console.ResetColor(); 
            

        }
       
    }
}

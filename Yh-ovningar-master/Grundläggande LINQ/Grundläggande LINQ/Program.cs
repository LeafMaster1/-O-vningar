using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundläggande_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            numbers.OrderBy(x => x).ToList();
            // sorterar listan i stigande ordning

            foreach ( var number in numbers) // går igenom listan och skriver ut varje 
                // för varje nummer i listan så skrivs numret ut
            {
                Console.WriteLine(number);
            }
            */

            
            
            
            /*--------------------------------
             * skapa en lista för ta in siffror
             * skriv ut en instruktion till användaren att skriva in siffror
             * i instruktionen ska det stå att användaren avslutar när den inte sriver en siffra
             * den ska vara i en loop 
             * sluta loopen när användaren skriver inte skriver en siffra
             * räkna ut summan av alla siffror
             * räkna ut medelvärdet av alla siffror.
             * räkna ut minsta siffran
             * räkna ut största siffran.
             ----------------------------------*/

            var numbers = new List<int>();
            Console.WriteLine("Skriv in siffror. ( för att avsluta programmet skriv vad som helst annat än en siffra )");
            var input = Console.ReadLine();
            while (int.TryParse(input, out int number))
            {
                numbers.Add(number);
                input = Console.ReadLine();
                
            }
            Result result = new Result();
            // skapar ett objekt av klassen Result som räknar ihop resultatet

            result.res(numbers);

            //resulta.res(numbers) är för att anropa metoden för att skriva ut resultatet


            /*
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
            Console.ResetColor();*/



        }
    }
}

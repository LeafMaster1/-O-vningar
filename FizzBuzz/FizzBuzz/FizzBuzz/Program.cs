using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            int ans = int.Parse(Console.ReadLine());

            for (int i = 1; i <= ans;i++)
            {
                if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("FizzBuzz"); }
                else if (i % 3 == 0) { Console.WriteLine("Fizz"); }
                else if (i % 5 == 0) { Console.WriteLine("Buzz"); }
                else { Console.WriteLine(i); }
                
                
            }
        }
    }
}

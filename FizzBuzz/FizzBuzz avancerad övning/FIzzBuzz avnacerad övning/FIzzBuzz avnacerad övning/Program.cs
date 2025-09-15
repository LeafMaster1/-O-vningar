using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIzzBuzz_avnacerad_övning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett annat ord för Fizz");
            string Fizz = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ange ett annat ord för Buzz");
            string Buzz = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Skriv ett tal:");  // användaren skriver in ett tal
            int ans = int.Parse(Console.ReadLine()); // program ta in användarens tal   
            
            Console.WriteLine("Välj Fizz tal: ");   // användaren väljer Fizz tal            
            int Fizztal = int.Parse(Console.ReadLine());       // användarens inmatning i variabel Hej            
            
            Console.WriteLine("Välj Buzz tal: ");   //användaren väljer Buzz tal
            int Buzztal = int.Parse(Console.ReadLine()); // användarens inmatning i variabel Då            
            Console.WriteLine();    // För att få ett rad hopp mellan svar och loopen

            for (int i = 1; i <= ans; i++)      // forloop för att ränkna ut hur många rader det ska vara samt plussar på varje rad
            {
                if (i % Fizztal == 0 && i % Buzztal == 0) {   Console.WriteLine(Fizz + Buzz); }   // koden kollar om variabel Hej och variabel DÅ är delbara med 0
                else if (i % Fizztal == 0) {  Console.WriteLine(Fizz); }    // här går koden kollar variabel Då för användarens Fizz tal.
                else if (i % Buzztal == 0) { Console.WriteLine(Buzz); }      // koden kollar variabel Då användarens val av tal för Buzz.
                else {Console.WriteLine(i); }   // koden skriver ut hur många rader användaren har valt.
                }
                }
                }
}

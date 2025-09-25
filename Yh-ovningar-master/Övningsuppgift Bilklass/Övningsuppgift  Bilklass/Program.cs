using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Övningsuppgift__Bilklass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bil> cars = new List<Bil>(3); // skapar en lista med plats för 3 bilar
            var car = new Bil(); // skapar ett objekt av klassen Bil
            var brandInput = ""; // variabel för att ta in bilmärke
            var yearInput = 0; // variabel för att ta in årsmodell
            var modelInput = "";    // variabel för att ta in bilmodell
            
            for (int i = 0; i < 3; i++)
                /* loop för att ta in 3 bilar
                 * där i är räknaren som börjar på 0
                 * slutar när i är 3
                 * och ökar med 1 varje gång loopen körs
                 */
            {
                Console.Write("Ange bilmärke: \n" );
                brandInput = Console.ReadLine();
                Console.Write("Ange bilmodell: \n");
                modelInput = Console.ReadLine();
                Console.Write("Ange årsmodell: \n");
                yearInput = Convert.ToInt32(Console.ReadLine());
                car.ListAdd(brandInput, modelInput, yearInput, cars);
            }
            Console.Clear(); // rensar konsolen för att skriva ut bilarna snyggt
            Console.ForegroundColor = ConsoleColor.Green; // ändrar textfärgen till grön
            Console.WriteLine("Du har lagt till följande bilar: "); // rubrik innan bilarna skrivs ut
            
            foreach (var item in cars)
            // loop för att skriva ut alla bilar i listan
            {
                item.printf(); // anropar printf metoden för varje bil i listan
            }
            Console.ResetColor(); // återställer textfärgen till standardfärgen


            /*var car = new Bil();
            var brandInput = "";
            var yearInput = 0;
            var modelInput = "";
            Console.WriteLine("Ange bilmärke: ");
            brandInput = Console.ReadLine();
            car.brand = brandInput;
            Console.WriteLine("Ange bilmodell: ");
            modelInput = Console.ReadLine();
            car.model = modelInput;
            Console.WriteLine("Ange årsmodell: ");
            yearInput = Convert.ToInt32(Console.ReadLine());
            car.year = yearInput;
            car.printf();
            /*Console.WriteLine($"Märke: {car.brand}\n" +
                $"Modell: {car.model}\n" +
                $"Årsmodell: {car.year}");
            */

        }




    }
}


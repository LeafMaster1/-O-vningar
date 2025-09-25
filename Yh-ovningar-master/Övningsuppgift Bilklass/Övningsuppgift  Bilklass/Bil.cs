using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Övningsuppgift__Bilklass
{
    public class Bil
    {

        public string brand{ get; set; }
        // tar in info från användaren till bilens märke

        public string model { get; set; }
        // tar in info från användaren till bilens modell
        public int year { get; set; }
        // tar in info från användaren till bilens årsmodell
        public void ListAdd(string b, string m, int y, List<Bil> cars)
        // b = brand, m = model, y = year
        /* lista för att lägga till bilar
         */
        {
            var car = new Bil();
            car.brand = b;
            car.model = m;
            car.year = y;
            cars.Add(car);
        }
        public void printf()
        // här skrivs bilens info ut för varje bil 
        /* läggs till i en loop 
         * för att skriva ut alla bilar i listan
         * Brand, model, year
         */
        {
            Console.Write($"Märke: {brand}\n" +
                $"Modell: {model}\n" +
                $"Årsmodell: {year}");
        }


        // ----- ett sätt man kan göra det på -----
        // om man vill hårdkoda information i klassen
        /*
        public string brand = "Volvo";
        public string model = "V70";
        public int year = 1999;
        public void PrintInfo()
        {
            Console.WriteLine($"Märke: {brand}\n" +
                $"Modell: {model}\n" +
                $"Årsmodell: {year}");
        }*/
    }

}

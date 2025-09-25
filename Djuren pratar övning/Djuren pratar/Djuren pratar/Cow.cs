using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djuren_pratar
{
    public class Cow: IAnimal
    {
        // namn på kon
        private string name;
        private string farm;
        // konstruktor
        public Cow(string name, string farm)
        {
            this.name = name;
            this.farm = farm;
        }

        // implementerar Speak metoden från IAnimal interfacet
        public void Speak() 
        {
            Console.WriteLine($"{farm}, {name} says Moo!");
        }

        // statisk metod som skapar en lista med kor från en lista med namn
        // OBS! behövs för  att använda sätt 3 och 2.
        /*public static List<Cow> CreatCows(List<string> names)
        {
            var cows = new List<Cow>();
            foreach (var name in names)
            {
               cows.Add(new Cow(name));
            }
            return cows; //     returnerar listan med kor
        }
        */

    }
}

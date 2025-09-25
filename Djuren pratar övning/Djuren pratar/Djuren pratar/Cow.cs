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
        
        // konstruktor
        public Cow(string name)
        {
            this.name = name;
        }

        // statisk metod som skapar en lista med kor från en lista med namn
        public static List<Cow> CreatCows(List<string> names)
        {
            var cows = new List<Cow>();
            foreach (var name in names)
            {
               cows.Add(new Cow(name));
            }
            return cows; //     returnerar listan med kor
        }

        // implementerar Speak metoden från IAnimal interfacet
        public void Speak() 
        {
            Console.WriteLine($"{name} Moo!");
        }
    }
}

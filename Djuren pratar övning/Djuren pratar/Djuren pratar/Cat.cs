using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djuren_pratar
{
    public class Cat : IAnimal
    {
        // namn på katten
        private string name;
        private string sleepingPlace;
        
        // konstruktor
        public Cat(string name, string sleepingPlace)
        {
            this.sleepingPlace = sleepingPlace;
            this.name = name;
        }
        
        // implementerar Speak metoden från IAnimal interfacet
        public void Speak()
        {
            Console.WriteLine($"{name} says Meow! while lounging on the {sleepingPlace}" );
        }

        // statisk metod som skapar en lista med katter från en lista med namn
        // OBS! behövs för  att använda sätt 3 och 2.
       /* public static List<Cat> CreatCats(List<string> names) 
        {
            var cats = new List<Cat>();
            foreach (var name in names)
            {
                cats.Add(new Cat(name));
            }
            return cats; // returnerar listan med katter
        }

        */

    }
    
}

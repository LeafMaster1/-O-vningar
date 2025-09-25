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

        // konstruktor
        public Cat(string name)
        {
            this.name = name;
        }

        // statisk metod som skapar en lista med katter från en lista med namn
        public static List<Cat> CreatCats(List<string> names)
        {
            var cats = new List<Cat>();
            foreach (var name in names)
            {
                cats.Add(new Cat(name));
            }
            return cats; // returnerar listan med katter
        }

        // implementerar Speak metoden från IAnimal interfacet
        public void Speak()
        {
            Console.WriteLine($"{name} says Meow!");
        }
    }
    
}

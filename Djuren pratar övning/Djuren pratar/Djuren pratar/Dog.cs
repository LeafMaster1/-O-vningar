using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djuren_pratar
{
    public class Dog:IAnimal
    {
        // namn på hunden
        private string name;
        private string toy;

        // konstruktor
        public Dog(string name, string toy)
        {
            this.name = name;
            this.toy = toy;
        }
        
        // implementerar Speak metoden från IAnimal interfacet
        public void Speak()
        {
            Console.WriteLine($"{name}, who likes {toy} says Woof!");
        }

        // statisk metod som skapar en lista med hundar från en lista med namn
        // OBS! behövs för  att använda sätt 3 och 2.
        /*public static List<Dog> CreateDogs(List<string> names)
        {
            var dogs = new List<Dog>();
            foreach (var name in names)
            {
                dogs.Add(new Dog(name));
            }
            return dogs;  //    returnerar listan med hundar
        }
        */


        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djuren_pratar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------ - 3 sätt att göra det på ---
             * List<string> dogNames = new List<string> { "Sir Barks-a-Lot", "Droolius Caesar" };
            List<IAnimal> animals = Dog.CreateDogs(dogNames).Cast<IAnimal>().ToList();
            List<string> catNames = new List<string> { "Waffleton", "Meowstro" };
            animals.AddRange(Cat.CreatCats(catNames).Cast<IAnimal>());
            list<string> cowNames = new List<string> { "Cowabunga", "Oreo" };
            animals.AddRange(Cow.CreatCows(cowNames).Cast<IAnimal>());
             ---------------*/



            //--- 2 sätt att göra det på ---
            /*List<IAnimal> animals = new List<IAnimal>();
            Dog.CreateDogs(new List<string> { "Sir Barks-a-Lot", "Droolius Caesar" }).ForEach(d => animals.Add(d));
            Cat.CreatCats(new List<string> { "Waffleton", "Meowstro" }).ForEach(c => animals.Add(c));
            Cow.CreatCows(new List<string> { "Cowabunga", "Oreo", }).ForEach(cw => animals.Add(cw));
            */

            //------- 1 sätt att göra det på --- men får inte ut all 6 djuren
            List<IAnimal> animals = new List<IAnimal>
            {    new Dog("Sir Barks-a-Lot", "Pizza,"),
                 new Dog("Droolius Caesar", "Bones,"),
                 new Cat("Waffleton", "Windsill"),
                 new Cat("Meowstro", "bed"),
                 new Cow("Cowabunga","Hay Fever Farms"),
                 new Cow("Oreo", "Hay Fever Farms")
            };

            //----------

            // för att skriva ut vad alla djuren säger
            foreach (var animal in animals) 
            {
                animal.Speak();
            }
        }
    }
}

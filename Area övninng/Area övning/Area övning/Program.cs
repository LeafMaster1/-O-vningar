using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_övning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Rectangle("Rektangel", 10, 25),
                new Rectangle("Kvadrat", 15),
                new Triangle("Liksidig triangel", 8),
                new Triangle("Likbent triangel", 10, 12),
                new Circle(13)
            };

            for (int i = 0; i < shapes.Count; i++)
            {
                // Avstånd mellan de olika formernas information
                if (i > 0) Console.WriteLine();

                // Skriv ut info för den givna formen
                shapes[i].PrintInfo();


            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formritare
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IShape> shapes = new List<IShape>{
            new Square(),
            new Triangle(),
            new Cross(),
            };

            Console.Write("Storlek: ");
            var size = int.Parse(Console.ReadLine());
            Console.WriteLine();

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetName() + " ser ut såhär:");
                Console.WriteLine(shape.GetShape(size));
            }


        }
    }
}

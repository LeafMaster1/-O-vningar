using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Area_övning
{
    public abstract class Shape
    {
        public string name = "";
        public int size = 0;

        public virtual int NumberOfCorners()
        {
            return 0;
        }

        public virtual float GetArea()
        {
            return 0;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{name} har följande information");
            Console.WriteLine($" * {NumberOfCorners()} hörn");
            Console.WriteLine($" * En area på {GetArea()}");
        }
    }
}

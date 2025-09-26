using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_övning
{
    internal class Circle : Shape
    {
        public double radius = 0;
        public Circle(double radius)
        {
            this.radius = radius;
            name = "Cirkel";

        }
      /*  public override int NumberOfCorners()
        {
            return 0;
        }*/

        public override float GetArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return (float)area;
        }

    }
}

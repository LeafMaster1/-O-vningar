using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_övning
{
    internal class Rectangle: Shape
    {
        private int height = 0;
        private int width = 0;
        public override float GetArea()
        {
            int area = height * width;
            return area;
        }
        public Rectangle(string name, int size)
        {

            this.name = name;
            this.height = size;
            this.width = size;
        }
        public Rectangle(string name, int height, int width)
        {
            this.name = name;
            this.height = height;
            this.width = width;
        }

        public override int NumberOfCorners()
        {
            return 4;
        }
    }
}

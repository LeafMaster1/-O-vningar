using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Area_övning
{
    internal class Triangle : Shape
    {
        private int height = 0;
        private int width = 0;
        public override float GetArea()
        {
            int area = (height * width) / 2;
            return area;
        }
        public Triangle(string name, int size)
        {

            this.name = name;
            this.height = size;
            this.width = size;
        }
        public Triangle(string name, int height, int width)
        {
            this.name = name;
            this.height = height;
            this.width = width;
        }

        public override int NumberOfCorners()
        {
            return 3;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formritare
{
    public class Triangle : IShape
    {
        public string GetName()
        {
            return "Triangel";
        }
        public string GetShape(int size)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= size; i++)
            {
                sb.AppendLine(new string('*', i));
            }
            return sb.ToString();
        }
    }
}

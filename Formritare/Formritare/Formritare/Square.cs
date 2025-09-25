using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formritare
{
    public class Square : IShape
    {
        public string GetName()
        {
            return "Kvadrat";
        }

        public string GetShape(int size)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                sb.AppendLine(new string('*', size));
            }
            return sb.ToString();
        }
    }
}

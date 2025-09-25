using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formritare
{
    public  class Cross : IShape
    {
        public string GetName()
        {
            return "Kors";
        }
        public string GetShape(int size)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == i || j == size - i - 1)
                    {
                        sb.Append('*');
                    }
                    else
                    {
                        sb.Append(' ');
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString();




        }
    }
}

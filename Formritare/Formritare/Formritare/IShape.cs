using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formritare
{
    public interface IShape
    {
        string GetName();
        string GetShape(int size);
    }
}

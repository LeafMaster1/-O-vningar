using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sökning_på_fil
{
    internal class Program
    {
        public bool Exists(string[] path)
        {
            File.WriteAllText("text.text", "hej hej");
            
            File.Exists();
            Console.Write("Sökväg till filen: ");
            string Search = Console.ReadLine();
            File.Exists(Search);

            if (File.Exists(Search))
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}

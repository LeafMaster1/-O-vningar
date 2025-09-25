using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace bok_klass
{
    internal class Program
    {


        //------ Gorde en variant för att använda interface ------
        // det är inte uppgiften men jag gjorde det för att öva
        static void Main(string[] args)
        {
            List<IBook> books = new List<IBook>
            {
                new BokName("Okänd", "Okänd", 0),
                new BokName($"Pancakes", "Mabel Sirrup",199),
                new BokName("Are You Dancing?", "R. U. Asking", 399),
                new BokName("Bricklaying", "Bill Jerome Wall",0)
            };



            foreach (var book in books)
            {
                book.speak();
            }


        }
    }
}

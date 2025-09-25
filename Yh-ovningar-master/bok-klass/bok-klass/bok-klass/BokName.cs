using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bok_klass
{
    internal class BokName : IBook
    {
        public string name;
        public string Author;
        public int price;
        

        public BokName(string name, string Author, int price)
        {   this.Author= Author;
            this.name = name;
            this.price = price;
            if (price >0)
            {
                this.price = price;
            }
            else
            {
                this.price = 199;
            }
        }
        public void speak()
        {
            Console.WriteLine($"The name of the book is {name}, Author is {Author}, pirce is {price} kr");
        }
    }
}

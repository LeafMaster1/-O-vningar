using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_hantering_Bike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * exempel 1
            var bike = new Bike();
            
            bike.name = "Trek";
            bike.age = 3;
            bike.color = "röd";
            Console.WriteLine($"Din cyckel heter :{bike.name}\n" +
                $"Ålder : {bike.age} \n" +
                $"Fär på cyckeln: {bike.color}");

            // -------------

            //--------------------
            //* exempel 2

            /* var bike = new Bike
             {
                 name = "Trek",
                 age = 5,
                 color = "röd",
             }; 

             Console.WriteLine($"Din cyckel heter :{bike.name}\n" +
                 $"Ålder : {bike.age} \n" +
                 $"Fär på cyckeln: {bike.color}");
            */


            //--------------------

            // * exempel 3


            /*
            Bike bike = new Bike()
            {
                name = "Trek",
                age = 5,
                color = "röd",
            };
            */

        }
    }
}

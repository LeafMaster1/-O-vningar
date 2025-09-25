using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_Farenhiet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //
            // Användning av metoden

            float celcius = 25.5f; // Ger celcuis ett värde
            float asFahrenheit = CelciusToFahrenheit(celcius); // anropar metoden för att räkna om till fahrenheit
            float backAsCelcius = FahrenheitToCelcius(asFahrenheit);    // anropar metoden för att räkna tillbaka till celcius
            Math.Round(backAsCelcius,1); // rundar av värdet till 2 decimaler

            // TODO: Deklarera metoden CelciusToFahrenheit
            //       Tar emot ett flyttal som motsvarar celcius värdet
            //       Returnerar ett flyttal som motsvarar fahrenheit värdet
            //       Formula: °F = (°C × 1.8) + 32

            // TODO: Deklarera metoden FahrenheitToCelcius
            //       Tar emot ett flyttal som motsvarar fahrenheit värdet
            //       Returnerar ett flyttal som motsvarar celcius värdet
            //       Formula: °C = ((°F - 32) × 5) / 9

            float CelciusToFahrenheit(float cel)  // metod för celcius till fahrenheit
            {
                float fahrenheit = (cel * 1.8f)+ 32f; // formulan för att räkna om celcius till fahrenheit
                return fahrenheit;
                //return (celcius * 1.8f) + 32; // formulan för att räkna om celcius till fahrenheit
            }

            float FahrenheitToCelcius(float fah) // metod för fahrenheit till celcius
            {   
                float Celcius = ((fah - 32f) * 5f) / 9f; // formulan för att räkna om fahrenheit till celcius
                return Celcius;
                //return ((fah - 32f) * 5f) / 9f;    // formulan för att räkna om fahrenheit till celcius
            }


            Console.WriteLine($"Originalvärde (celcius): {celcius}");   //skriver ut originalvärdet i celcius
            Console.WriteLine($"Fahrenheit: {asFahrenheit}");           //skriver ut metiden för att räkna om till fahrenheit
            Console.WriteLine($"Celcius igen: {backAsCelcius}");        //skriver ut metoden för att räkna tillbaka till celcius
        
        }
    }
}

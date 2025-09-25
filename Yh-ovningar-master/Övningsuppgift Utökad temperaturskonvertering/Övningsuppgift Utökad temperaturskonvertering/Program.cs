using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningsuppgift_Utökad_temperaturskonvertering
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Eftersom klassen är static så måste vi anropa metoderna med klassnamnet 
                * och inte anropa på en instans av klassen. Vi kan alltså inte göra så här:
                * ConvertTemp convertTemp = new ConvertTemp();
                * man måste göra så här:
                * convertTemp.FromCelsiusToFahrenheit(celsius); 
                * eftersom FromCelsiusToFahrenheit är en static metod
                * CenvertTemp är klassenamnet och metoden anropas med .FromCelsiusToFahrenheit()
             */
            float celsius = GetTemperature("Celsius");
            Console.WriteLine("I Fahrenheit: " + ConvertTemp.FromCelsiusToFahrenheit(celsius));
            Console.WriteLine("I Kelvin: " + ConvertTemp.FromCelsiusToKelvin(celsius));
            Console.WriteLine();
            float fahrenheit = GetTemperature("Fahrenheit");
            Console.WriteLine("I Celsius: " + ConvertTemp.FromFahrenheitToCelsius(fahrenheit));
            Console.WriteLine("I Kelvin: " + ConvertTemp.FromFahrenheitToKelvin(fahrenheit));
            Console.WriteLine();
            
            
            float kelvin = GetTemperature("Kelvin");
            Console.WriteLine("I Celsius: " + ConvertTemp.FromKelvinToCelsius(kelvin));
            Console.WriteLine("I Fahrenheit: " + ConvertTemp.FromKelvinToFahrenheit(kelvin));
            Console.WriteLine();
            
            
            

            float GetTemperature(string name)
            {
                while (true)
                {
                    Console.Write($"Temperatur i {name}: ");
                    if (float.TryParse(
                        Console.ReadLine().Replace(',', '.'),
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture,
                        out float temp)
                    )
                    {
                        return temp;

                    }
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningsuppgift_Utökad_temperaturskonvertering
{
    public static class ConvertTemp
    {
        // Eftersom klassen är static så måste vi anropa metoderna med klassnamnet 

        public static float FromKelvinToCelsius(float kelvin)
        { // metod för omvandling från Kelvin till Celsius
            
            return kelvin - 273.15f;
        }
        public static float FromKelvinToFahrenheit(float kelvin)
        {   // metod för omvandling från Kelvin till Fahrenheit
            return (kelvin - 273.15f) * 9 / 5 + 32;
        }
        public static float FromFahrenheitToKelvin(float fahrenheit)
        {   // metod för omvandling från Fahrenheit till Kelvin
            return (fahrenheit - 32) * 5 / 9 + 273.15f;
        }
        public static float FromCelsiusToCelsius(float celsius)
        {   // metod för omvandling från Celsius till Celsius (returnerar samma värde)
            return celsius;
        }
        public static float FromCelsiusToFahrenheit(float celsius)
        {   // metod för omvandling från Celsius till Fahrenheit
            return (celsius * 9 / 5) + 32;
        }
        public static float FromCelsiusToKelvin(float celsius)
        {   // metod för omvandling från Celsius till Kelvin
            return celsius + 273.15f;
        }
        public static float FromFahrenheitToCelsius(float fahrenheit)
        {   //  metod för omvandling från Fahrenheit till Celsius
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}

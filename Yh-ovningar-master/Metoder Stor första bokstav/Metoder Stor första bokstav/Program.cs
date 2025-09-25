using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Metoder_Stor_första_bokstav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var CapitalizeFirstLetter = new Func<string, string>(s => char.ToUpper(s[0]) + s.Substring(1));
            Console.Write("Ange mejl: ");
            var email = Console.ReadLine();
            var nameAndDomain = email.Split('@');

            --- Slarvig metod ----
            var fullName = nameAndDomain[0].Split('.');
            var firstName = char.ToUpper(fullName[0][0]) + fullName[0].Substring(1);
            var lastName = char.ToUpper(fullName[1][0]) + fullName[1].Substring(1);
            var domain = nameAndDomain[1];

            Console.WriteLine("Du angav följande information:");
            Console.WriteLine($" * Namn: {firstName} {lastName}");
            Console.WriteLine($" * Domän: {domain}");
            */


            Console.Write("Ange mejl: ");
            var email = Console.ReadLine();
            var nameAndDomain = email.Split('@');

            var fullName = nameAndDomain[0].Split('.');
            var firstName = Capitalize(fullName[0]); // Mycket tydligare!
            var lastName = Capitalize(fullName[1]);  // Och enklare att göra två gånger!
            var domain = nameAndDomain[1];

            Console.WriteLine("Du angav följande information:");
            Console.WriteLine($" * Namn: {firstName} {lastName}");
            Console.WriteLine($" * Domän: {domain}");

            // TODO: Definera metoden Capitalize
            //       Den ska ta emot en sträng
            //       Den ska returnera samma sträng, men med stor första bokstav

            
        

            string Capitalize(string text)
            {
                return char.ToUpper(text[0]) + text.Substring(1);
            }
        }
    }
}

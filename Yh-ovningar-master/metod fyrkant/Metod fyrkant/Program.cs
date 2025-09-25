using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_fyrkant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Storlek: ");
            int antalFyrkanter = int.Parse(Console.ReadLine());

            for (int storlek = 1; storlek <= antalFyrkanter; storlek++)
            {
                Console.WriteLine();
                RitaFyrkant(storlek);
            }

            void RitaFyrkant(int storlek)
            {
                for (int radnummer = 0; radnummer < storlek; radnummer++)
                {
                    Console.Write("#");
                    Console.WriteLine(new string( '#', storlek));
                }
            }

            // TODO: Deklarera RitaFyrkant
            //       Den ska ta emot storleken på fyrkanten
            //       Den ska inte returnera något
            //       Den ska skriva ut # tecken:
            //        * Storlek 1 betyder #
            //        * Storlek 2 betyder ##\n##
            //        * Storlek 3 betyder ###\n###\n### osv


        }
    }
}

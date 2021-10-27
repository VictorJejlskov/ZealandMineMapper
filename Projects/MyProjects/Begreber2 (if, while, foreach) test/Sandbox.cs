using System;
using System.Collections.Generic;
using System.Text;

namespace Begreber2__if__while__foreach__test
{
    class Sandbox
    {
        public static void RunCode()
        {
            Console.WriteLine("Opg R.");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Tal: {i}");
            }


            Console.WriteLine($"\nOpg S");
            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine($"Tal: {i}");
            }

            Console.WriteLine($"\nOpg T");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Tal: {i}");
            }


            Console.WriteLine($"\nOpg U");
            int u = 1;
            while (u <= 10)
            {
                Console.WriteLine($"Tal: {u}");
                u++;
            }

            Console.WriteLine($"\nOpg V");
            int v = 2;
            while (v <= 10)
            {
                Console.WriteLine($"Tal: {v}");
                v
                    +=2;
            }
            Console.WriteLine($"\nOpg W");
            int w = 10;
            while (w >= 0)
            {
                Console.WriteLine($"Tal: {w}");
                w--;
            }

            //Opg X - For løkker er bedst når du vil have at koden kører præcis den her mængde gange
            //Opg Y - While løkker er gode når man vil køre et stykke kode indtil et kriterie er mødt, men ikke nødvendigvis ved hvor mange gang det køres før det sker.
            //Opg Z - Foreach er bedst når man har med Lister at gøre, så kan man køre et stykke kode, for hver variabel i ens liste


        }
    }
}

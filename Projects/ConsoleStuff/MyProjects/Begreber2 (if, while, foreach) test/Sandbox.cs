using System;
using System.Collections.Generic;
using System.Text;

namespace Begreber2__if__while__foreach__test
{
    class Sandbox
    {
        public static void RunCode()
        {

            //A. Hvad udskriver:
            Console.WriteLine("Mit gæt: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("tal " + i);
            }
            // B.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("tal " + i);
            }

            //C.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: 1, 2, 3, 4, 5, 6, 7, 8, 9");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("tal " + i);
            }

            //D.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: 10, 9, 8, 7, 6, 5, 4, 3, 2, 1");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("tal " + i);
            }

            //E.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: 10, 20, 30, 40, 50, 60, 70, 80, 90");
            for (int i = 10; i < 100; i = i + 10)
            {
                Console.WriteLine("tal " + i);
            }

            //While løkker
            //F.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9");
            int f = 0;
            while (f < 10)
            {
                Console.WriteLine("tal " + f);
                f++;
            }

            //G.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: 10, 9, 8, 7, 6, 5, 4, 3, 2, 1");
            int g = 10;
            while (g > 0)
            {
                Console.WriteLine("tal " + g);
                g--;
            }
            //H.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: 10, 20, 30, 40, 50, 60, 70, 80, 90");
            int h = 10;
            while (h < 100)
            {
                Console.WriteLine("tal " +h);
                h += 10;
            }
            //I.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: 1, 2, 4, 8, 16, 32, 64");
            int opgi = 1;
            while (opgi < 100)
            {
                Console.WriteLine("tal " + opgi);
                opgi = opgi * 2;
            }
            //J.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine("tal " +j);
                j++;
            }
            //If sætninger
            //Variable


            int x = 8;
            double d = 8.5;
            //K.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: sandt");
            if (x < 10)
            {

                Console.WriteLine("Sandt");
            }
            else
            {
                Console.WriteLine("Falsk");
            }
            //L.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: Sandt");
            if (x < 10 && x > 5)
            {

                Console.WriteLine("Sandt");
            }
            else
            {
                Console.WriteLine("Falsk");
            }
            //M.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: Falsk");
            if (x < 3 && x > 10)
            {

                Console.WriteLine("Sandt");
            }
            else
            {
                Console.WriteLine("Falsk");
            }

            //N.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: Falsk");
            if (x < 3 || x > 10)
            {

                Console.WriteLine("Sandt");
            }
            else
            {
                Console.WriteLine("Falsk");
            }

            //O.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: Sandt");
            if((d - 8.5) == 0)
            {
                Console.WriteLine("Sandt");
            }
            else
            {
                Console.WriteLine("Falsk");
            }

            //P.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: Falsk");
            if (d > 0 && x < 0)
            {

                Console.WriteLine("Sandt");
            }
            else
            {
                Console.WriteLine("Falsk");
            }

            //Q.Hvad udskriver:
            Console.WriteLine();
            Console.WriteLine("Mit gæt: Sandt");
            if (d > 0 && x < 0 || d > x)
            {

                Console.WriteLine("Sandt");
            }
            else
            {
                Console.WriteLine("Falsk");
            }


            Console.WriteLine($"\nOpg R.");
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

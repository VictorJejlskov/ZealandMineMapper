using System;

namespace CalculatePrice
{
    class Program
    {
        public static void Main(string[] args)
        {
            double grundPris = 100;
            double endePris = 0;

            int alder = 0;
            double currAlderRabat = 1;
            double ungeRabat = 0.50;
            double seniorRabat = 0.60;
            bool erStuderende = false;
            double studieRabat = 0.80;

            int sesson = 0;
            string sessonType;
            double currSessonRabat = 1;
            double lavSessonRabat = 0.80;
            double hojSessonRabat = 1.20;

            int tidspunkt = 00;
            double currTidsRabat = 1;
            double lavTidRabat = 0.90;
            double hojTidRabat = 1.10;

            int gruppeSize = 0;
            double currGruppeRabat = 1;
            double mediumGruppeRabat = 0.90;
            double storGruppeRabat = 0.85;

            string[] lavSesson = {"jan", "januar", "fab", "februar"};
            string[] hojSesson = {"maj", "jun", "juni", "jul", "juli", "aug", "august"};
            

            Console.WriteLine("Velkommen til Knuttenborg");
            Console.WriteLine("Er du alene eller i en gruppe? (Skrive 'alene' eller 'gruppe')");
            string userInput = Console.ReadLine();
            if(userInput == "alene")
            {
                gruppeSize = 1;
            }
            else if (userInput == "gruppe")
            {
                Console.Clear();
                Console.WriteLine("Hvor mange i gruppen er I?");
                gruppeSize = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Det er ikke hvad jeg bad dig om :)");
            }

            if (gruppeSize == 1)
            {
                Console.Clear();
                Console.WriteLine("Hvor gammel er du, i tal");
                alder = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (alder >= 17)
                {
                    Console.WriteLine("Er du studerende? Tryk Y/N");
                    userInput = Console.ReadLine();
                    if (userInput == "Y" || userInput == "y")
                    {
                        erStuderende = true;
                    }
                    else if (userInput == "N" || userInput == "n")
                    {
                        erStuderende = false;
                    }

                }
            }

            Console.Clear();
            Console.WriteLine("Hvilken måned vil du besøge os i, skriv med småt");
            userInput = Console.ReadLine();
            if (userInput == lavSesson[0] || userInput == lavSesson[1] || userInput == lavSesson[2] ||
                userInput == lavSesson[3])
            {
                sesson = 1;
                sessonType = "lav sesson";
                //lav sesson
            }
            else if (userInput == hojSesson[0] || userInput == hojSesson[1] || userInput == hojSesson[2] ||
                     userInput == hojSesson[3] || userInput == hojSesson[4] || userInput == hojSesson[5])
            {
                sesson = 2;
                sessonType = "høj sesson";
                //høj sesson
            }
            else
            {
                sesson = 0;
                sessonType = "normal sesson";
                //normal sesson
            }

            Console.Clear();
            Console.WriteLine("Hvilket tid på døgnet vil du besøge os? I hele tal, militærtid");
            Console.WriteLine("Åbningstider er: 8-24");
            tidspunkt = Convert.ToInt32(Console.ReadLine());


            if (alder <= 2 && alder >= 1)
            {
                currAlderRabat = 0;
            }
            else if (alder >= 3 && alder < 13)
            {
                currAlderRabat = 0.5;
            }
            else if (alder >= 17 && erStuderende == true)
            {
                currAlderRabat = 0.8;
            }
            else if (alder >= 68)
            {
                currAlderRabat = 0.6;
            }
            else
            {
                currAlderRabat = 1;
            }

            if (sesson == 1)
            {
                currSessonRabat = 0.8;
            }
            else if (sesson == 2)
            {
                currSessonRabat = 1.2;
            }
            else
            {
                currSessonRabat = 1;
            }

            if (tidspunkt >= 8 && tidspunkt <= 10)
            {
                currTidsRabat = 0.9;
            }
            else if (tidspunkt >= 15 && tidspunkt <= 20)
            {
                currTidsRabat = 1.1;
            }
            else
            {
                currTidsRabat = 1;
            }

            if (gruppeSize >= 10 && gruppeSize <= 19)
            {
                currGruppeRabat = 0.9;
            }
            else if (gruppeSize >= 20)
            {
                currGruppeRabat = 0.85;
            }
            else
            {
                currGruppeRabat = 1;
            }

            endePris = (grundPris * gruppeSize) * currAlderRabat * currGruppeRabat * currSessonRabat * currTidsRabat;
            Console.Clear();

            Console.WriteLine("Gruppestørrelsen er: " + gruppeSize);
            Console.WriteLine($"Din nuværende rabat baseret på gruppestørrelse: {100 - (currGruppeRabat*100)}%");
            Console.WriteLine();
            if (gruppeSize <= 1)
            {
                Console.WriteLine("Din alder er: " + alder);
                Console.WriteLine("Du er studerende: " + erStuderende);
                Console.WriteLine($"Den gældende alders/studie-rabat: {100 - (currAlderRabat*100)}&");
                Console.WriteLine();
            }
            Console.WriteLine("Du besøger os i denne sesson: " + sessonType);
            Console.WriteLine($"Den gældende sessonrabat/tillæg: {100-(Math.Round(currSessonRabat,2)*100)}%");
            Console.WriteLine();
            Console.WriteLine("Du vil besøge os klokken: " + tidspunkt);
            Console.WriteLine($"Den gældende tidsbaserede rabat/tillæg: {100-Math.Round(currTidsRabat,2)*100}%");
            Console.WriteLine();
            Console.WriteLine($"Endeprisen er: {Math.Round(endePris,2)}dkk");
            Console.ReadKey();
        }
    }
}

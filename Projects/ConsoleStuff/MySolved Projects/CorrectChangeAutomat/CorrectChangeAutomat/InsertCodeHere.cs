using System;

namespace CorrectChangeAutomat
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            int pris = 266;
            int pengeBetalt = 500;
            int byttePenge = pengeBetalt - pris;

            ByttePenge(byttePenge);
        }

        public void ByttePenge(int byttePenge)
        {
            int etTusindSedler = 0;
            int femHundredeSedler = 0;
            int toHundredeSedler = 0;
            int etHundredeSedler = 0;
            int halvtredsSedler = 0;
            int tyveMønter = 0;
            int tiMønter = 0;
            int femMønter = 0;
            int toMønter = 0;
            int enMønter = 0;
            //1000
            for (int i = byttePenge; i >= 1000; i -= 1000)
            {
                byttePenge -= 1000;
                etTusindSedler++;
            }
            //500
            for (int i = byttePenge; i >= 500; i -= 500)
            {
                byttePenge -= 500;
                femHundredeSedler++;
            }
            //200
            for (int i = byttePenge; i >= 200; i -= 200)
            {
                byttePenge -= 200;
                toHundredeSedler++;
            }
            //100
            for (int i = byttePenge; i >= 100; i -= 100)
            {
                byttePenge -= 100;
                etHundredeSedler++;
            }
            //50
            for (int i = byttePenge; i >= 50; i -= 50)
            {
                byttePenge -= 50;
                halvtredsSedler++;
            }
            //20
            for (int i = byttePenge; i >= 20; i -= 20)
            {
                byttePenge -= 20;
                tyveMønter++;
            }
            //10
            for (int i = byttePenge; i >= 10; i -= 10)
            {
                byttePenge -= 10;
                tiMønter++;
            }
            //5
            for (int i = byttePenge; i >= 5; i -= 5)
            {
                byttePenge -= 5;
                femMønter++;
            }
            //2
            for (int i = byttePenge; i >= 2; i -= 2)
            {
                byttePenge -= 2;
                toMønter++;
            }
            //1
            for (int i = byttePenge; i >= 1; i -= 1)
            {
                byttePenge -= 1;
                enMønter++;
            }
            if(etTusindSedler != 0)
            {
                Console.WriteLine($"Du får {etTusindSedler} 1000kr-sedler tilbage");
            }

            if (femHundredeSedler != 0)
            {
                Console.WriteLine($"Du får {femHundredeSedler} 500kr-sedler tilbage");
            }

            if (toHundredeSedler != 0)
            {
                Console.WriteLine($"Du får {toHundredeSedler} 200kr-sedler tilbage");
            }

            if (etHundredeSedler != 0)
            {
                Console.WriteLine($"Du får {etHundredeSedler} 100kr-sedler tilbage");
            }

            if (halvtredsSedler != 0)
            {
                Console.WriteLine($"Du får {halvtredsSedler} 50kr-sedler tilbage");
            }

            if (tyveMønter != 0)
            {
                Console.WriteLine($"Du får {tyveMønter} Tyvekroner-mønter tilbage");
            }

            if (tiMønter != 0)
            {
                Console.WriteLine($"Du får {tiMønter} Tikroner-mønter tilbage");
            }

            if (femMønter != 0)
            {
                Console.WriteLine($"Du får {femMønter} Femkroner-mønter tilbage");
            }

            if (toMønter != 0)
            {
                Console.WriteLine($"Du får {toMønter} Tokroner-mønter tilbage");
            }

            if (enMønter != 0)
            {
                Console.WriteLine($"Du får {enMønter} Enkrone-mønter tilbage");
            }

        }
    }
}
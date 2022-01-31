using System;

namespace LilleOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            int currTask = 0;
            int tal = 0;
            int tal2 = 0;
            Console.WriteLine("Opgave 1 eller 2?");
            currTask = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (currTask == 1)
            {
                Console.WriteLine("Test det tal, du vil test om er positivet, negativt eller 0!");
                tal = Convert.ToInt32(Console.ReadLine());
                int isPositive = IsPositive(tal);
                if (isPositive == 1) Console.WriteLine("Tallet er positivt");
                if (isPositive == -1) Console.WriteLine("Tallet er negativt!");
                if (isPositive == 0) Console.WriteLine("Tallet er nul");
            }
            else if (currTask == 2)
            {
                Console.WriteLine("Indtast 2 tal, for at tjekke hvilket der er højest!");
                tal2 = Convert.ToInt32(Console.ReadLine());
                tal = Convert.ToInt32(Console.ReadLine());
                int isLargest = IsLargest(tal, tal2);
                if (isLargest == 1) Console.WriteLine($"{tal} er højere end {tal2}");
                if (isLargest == -1) Console.WriteLine($"{tal2} er højere end {tal}");
                if (isLargest == 0) Console.WriteLine($"{tal} og {tal2} er lige høje");
            }
            else
            {
                Console.WriteLine("Du gjorde ikke hva' jeg bad om :(");
            }
        }

        public static int IsPositive(int tal)
        {
            if (tal > 0) return 1;
            if (tal < 0) return -1;
            return 0;
        }

        public static int IsLargest(int tal, int tal2)
        {
            if (tal > tal2) return 1;
            if (tal < tal2) return -1;
            return 0;
        }

    }
}

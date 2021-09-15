using System;

namespace LilleOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tast to tal!");
            int tal = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());
            //int isPositive = IsPositive(tal);
            //if (isPositive == 1) Console.WriteLine("Tallet er positivt");
            //if (isPositive == -1) Console.WriteLine("Tallet er negativt!");
            //if (isPositive == 0) Console.WriteLine("Tallet er nul");
            int isLargest = IsLargest(tal,tal2);
            if (isLargest == 1) Console.WriteLine($"{tal} er højere end {tal2}");
            if (isLargest == -1) Console.WriteLine($"{tal2} er højere end {tal}");
            if (isLargest == 0) Console.WriteLine($"{tal} og {tal2} er lige høje");
        }

        //public static int IsPositive(int tal)
        //{
        //    if (tal > 0) return 1;
        //    if (tal < 0) return -1;
        //    return 0;
        //}

        public static int IsLargest(int tal, int tal2)
        {
            if (tal > tal2) return 1;
            if (tal < tal2) return -1;
            return 0;
        }

    }
}

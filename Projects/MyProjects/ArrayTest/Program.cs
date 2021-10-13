using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayTest
{
    class Program
    {

        public static List<string> TestStringList = new List<string>()
        {
            "lol";
        }
        static void Main(string[] args)
        {
            int[] TestArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 125 };
            List<int> testList = new List<int>()
            {
                1,
                2,
                6,
                8,
                5,
                9,
                15,
                19
            };
            testList.Add(25);
            testList.Add(28);

            //Fjerner index 0 (tallet 1)
            testList.Remove(testList[0]);
            //Fjerner tallet 15 
            testList.Remove(15);

            Console.WriteLine("Her starter listen:");
            foreach (int i in testList)
            {
                Console.Write($"{i},");
            }




            Console.WriteLine($"\n\nHer starter Arrayet");
            foreach (int i in TestArray)
            {
                Console.Write($"{i},");
            }

            Console.WriteLine();
            Console.WriteLine($"array length: {TestArray.Length}");

            int indexToRemove = 5;
            //Int for hvor i mit index, at tallet skal fjernes med Where funktionen

            Console.WriteLine();

            //Ikke gør det her =)
            //MitArraY er lig med MitArray hvor index ikke er lig med IndexToRemove.toArray
            TestArray = TestArray.Where((source, Index) =>Index!= indexToRemove).ToArray();


            Console.WriteLine("\nEfter Where for at fjerne index 5 (tallet 6) funktionen");
            foreach (int i in TestArray)
            {
                Console.Write($"{i},");
            }

            Console.WriteLine();
            Console.WriteLine($"array length: {TestArray.Length}");
            //Som du kan se, er tallet (6) med Indexet 5 i min liste, fjernet


            Console.WriteLine($"\n\n\n\nDen laveste værdi er: {ArrayHelper.LowValue(TestArray)}");
            Console.WriteLine($"Den højeste værdi er: {ArrayHelper.MaxValue(TestArray)}");
            Console.WriteLine($"Gennemsnitsværdien er: {ArrayHelper.AverageValue(TestArray)}");



            //int upper = TestArray.GetUpperBound(0);
            //int lower = TestArray.GetLowerBound(0);
            //Console.WriteLine($"GetLowerBound: {lower}\n" +
            //                  $"GetUpperBound: {upper}");
        }
    }
}

﻿using System;

namespace AnimalBehavior
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester aTester = new Tester();
            aTester.Run();

            Wait();
        }

        private static void Wait()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Done, press any key to close application");
            Console.ReadKey();
        }
    }
}

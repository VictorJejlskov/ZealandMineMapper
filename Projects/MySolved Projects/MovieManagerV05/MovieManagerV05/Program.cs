﻿using System;

namespace MovieManagerV05
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertCodeHere theCode = new InsertCodeHere();
            theCode.MyCode();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("If you wanna try again, click R");
            Console.WriteLine();
            Console.WriteLine("If not, press any other key to close the program...");
            Console.ReadKey();
        }
    }
}

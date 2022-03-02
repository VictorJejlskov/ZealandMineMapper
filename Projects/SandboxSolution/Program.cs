using System;

namespace SandboxSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            ImaginaryNumber in1 = new ImaginaryNumber(10, 10);
            ImaginaryNumber in2 = new ImaginaryNumber(10, 10);
            ImaginaryNumber in3 = new ImaginaryNumber(10, 20);
            //Case 1 : 1 == 2
            Console.WriteLine(in1.Equals(in2));
            //Case 2 : 1 == 3
            Console.WriteLine(in1.Equals(in3));
            //Case 3 : Hashcodes
            Console.WriteLine(in1.GetHashCode());
            Console.WriteLine(in2.GetHashCode());
            Console.WriteLine(in3.GetHashCode());
        }
    }
}

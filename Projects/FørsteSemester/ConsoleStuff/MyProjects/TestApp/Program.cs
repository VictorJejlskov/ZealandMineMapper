using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            int x = 3;

            while (x > 0)
            {
                if (x > 2)
                {
                    result = result + "a";
                }

                result = result + "-";
                x = x - 1;

                if (x == 2)
                {
                    result = result + "b c";
                }
                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}

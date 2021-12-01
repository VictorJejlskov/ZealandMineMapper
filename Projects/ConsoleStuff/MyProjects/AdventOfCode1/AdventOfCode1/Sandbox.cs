using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
    class Sandbox
    {
        public static void RunAdvent1()
        {
            int CurrNumber = 100000;
            int Counter = 0;
            foreach (string line in System.IO.File.ReadLines(@"C:\Users\Victur\Desktop\ZealandMineMapper\Projects\ConsoleStuff\MyProjects\AdventOfCode1\Numbers.txt"))
            {
                if (Convert.ToInt32(line) > CurrNumber)
                {
                    Counter++;
                }
                CurrNumber = Convert.ToInt32(line);
            }
            Console.WriteLine(Counter);
        }

        public static void RunAdvent2()
        {
            List<int> numbers = new List<int>();
            foreach (string line in System.IO.File.ReadLines(@"C:\Users\Victur\Desktop\ZealandMineMapper\Projects\ConsoleStuff\MyProjects\AdventOfCode1\Numbers.txt"))
            {
                numbers.Add(Convert.ToInt32(line));
            }

            int[] numbersArray = numbers.ToArray();
            int numberA = numbersArray[0];
            int numberB = numbersArray[1];
            int numberC = numbersArray[2];
            int CurrNumber = 3;
            int counter = 0;
            int total = 100000;
            try
            {
                while (true)
                {
                    if (total < numberA + numberB + numberC)
                    {
                        counter++;
                    }
                    total = numberA + numberB + numberC;
                    numberA = numberB;
                    numberB = numberC;
                    numberC = numbersArray[CurrNumber];
                    CurrNumber++;
                }
            }
            catch
            {
                Console.WriteLine("Program closed cus array outta bounds :)");
                Console.WriteLine(counter);
            }

        }
    }
}

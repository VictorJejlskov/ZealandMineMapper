using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
    class Day3
    {
        public static void Run1()
        {
            int count = 0;

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;
            int num9 = 0;
            int num10 = 0;
            int num11 = 0;
            int num12 = 0;


            foreach (string line in System.IO.File.ReadLines(
                @"C:\Users\Victur\Desktop\ZealandMineMapper\Projects\ConsoleStuff\MyProjects\AdventOfCode1\Binary.txt"))
            {
                count += 1;
                num1 += Convert.ToInt32(line.Substring(0,1));
                num2 += Convert.ToInt32(line.Substring(1, 1));
                num3 += Convert.ToInt32(line.Substring(2, 1));
                num4 += Convert.ToInt32(line.Substring(3, 1));
                num5 += Convert.ToInt32(line.Substring(4, 1));
                num6 += Convert.ToInt32(line.Substring(5, 1));
                num7 += Convert.ToInt32(line.Substring(6, 1));
                num8 += Convert.ToInt32(line.Substring(7, 1));
                num9 += Convert.ToInt32(line.Substring(8, 1));
                num10 += Convert.ToInt32(line.Substring(9, 1));
                num11 += Convert.ToInt32(line.Substring(10, 1));
                num12 += Convert.ToInt32(line.Substring(11, 1));
            }

            string result = $"{num1}" +
                            $"\n{num2}" +
                            $"\n{num3}" +
                            $"\n{num4}" +
                            $"\n{num5}" +
                            $"\n{num6}" +
                            $"\n{num7}" +
                            $"\n{num8}" +
                            $"\n{num9}" +
                            $"\n{num10}" +
                            $"\n{num11}" +
                            $"\n{num12}";
            Console.WriteLine($"Total count: {count}");
            Console.WriteLine(result);


            if (num1 > (count / 2))
            {
                num1 = 1;
            }
            else
            {
                num1 = 0;
            }
            if (num2 > (count / 2))
            {
                num2 = 1;
            }
            else
            {
                num2 = 0;
            }
            if (num3 > (count / 2))
            {
                num3 = 1;
            }
            else
            {
                num3 = 0;
            }
            if (num4 > (count / 2))
            {
                num4 = 1;
            }
            else
            {
                num4 = 0;
            }
            if (num5 > (count / 2))
            {
                num5 = 1;
            }
            else
            {
                num5 = 0;
            }
            if (num6 > (count / 2))
            {
                num6 = 1;
            }
            else
            {
                num6 = 0;
            }
            if (num7 > (count / 2))
            {
                num7 = 1;
            }
            else
            {
                num7 = 0;
            }
            if (num8 > (count / 2))
            {
                num8 = 1;
            }
            else
            {
                num8 = 0;
            }
            if (num9 > (count / 2))
            {
                num9 = 1;
            }
            else
            {
                num9 = 0;
            }
            if (num10 > (count / 2))
            {
                num10 = 1;
            }
            else
            {
                num10 = 0;
            }
            if (num11 > (count / 2))
            {
                num11 = 1;
            }
            else
            {
                num11 = 0;
            }
            if (num12 > (count / 2))
            {
                num12 = 1;
            }
            else
            {
                num12 = 0;
            }

            Console.WriteLine("After binarying-ifying them");
            result = $"{num1}{num2}{num3}{num4}{num5}{num6}{num7}{num8}{num9}{num10}{num11}{num12}";
            Console.WriteLine($"Total count: {count}");
            Console.WriteLine(result);
            Console.WriteLine(654* 3441);
        }
    }
}

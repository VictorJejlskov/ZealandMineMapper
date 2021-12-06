using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
    class Day2
    {
        public static void Run1()
        {
            int depth = 0;
            int horizontal = 0;
            foreach (string line in System.IO.File.ReadLines(@"C:\Users\Victur\Desktop\ZealandMineMapper\Projects\ConsoleStuff\MyProjects\AdventOfCode1\Directions.txt"))
            {
                if (line.Contains("forward"))
                {
                    horizontal += Convert.ToInt32(line.Substring(8, 1));
                }
                if (line.Contains("up"))
                {
                    depth -= Convert.ToInt32(line.Substring(3, 1));
                }
                if (line.Contains("down"))
                {
                    depth += Convert.ToInt32(line.Substring(5, 1));
                }
            }

            Console.WriteLine($"Depth: {depth} ---- Horizontal: {horizontal}");
            Console.WriteLine($"multiplied: {depth * horizontal}");
        }
        public static void Run2()
        {
            int aim = 0;
            int depth = 0;
            int horizontal = 0;
            foreach (string line in System.IO.File.ReadLines(@"C:\Users\Victur\Desktop\ZealandMineMapper\Projects\ConsoleStuff\MyProjects\AdventOfCode1\Directions.txt"))
            {
                if (line.Contains("forward"))
                {
                    horizontal += Convert.ToInt32(line.Substring(8, 1));
                    depth += aim*Convert.ToInt32(line.Substring(8, 1));

                }
                if (line.Contains("up"))
                {
                    aim -= Convert.ToInt32(line.Substring(3, 1));
                }
                if (line.Contains("down"))
                {
                    aim += Convert.ToInt32(line.Substring(5, 1));
                }
            }

            Console.WriteLine($"Depth: {depth} ---- Horizontal: {horizontal}");
            Console.WriteLine($"multiplied: {depth * horizontal}");
        }

    }
}

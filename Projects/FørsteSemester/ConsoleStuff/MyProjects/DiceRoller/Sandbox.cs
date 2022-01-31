using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Sandbox
    {
        public static void Roll()
        {
            int ones = 0;
            int twos = 0;
            int threes = 0;
            int fours = 0;
            int fives = 0;
            int sixes = 0;
            double totalSides = 0;
            Random rng = new Random();
            //This will run the code 100 times, yours will run "numberOfRolls times"
            for (int i = 0; i < 100; i++)
            {
                //Switch Case is basically a lot of If statements, but theyre easier to read
                //i do rng.Next, in c++ you do "rand() % 7" instead
                switch (rng.Next(1, 7))
                {
                    //Case 1: means if the Switch statement = 1
                    case 1:
                        ones += 1;
                        totalSides += 1;
                        break;
                    case 2:
                        twos += 1;
                        totalSides += 2;
                        break;
                    case 3:
                        threes += 1;
                        totalSides += 3;
                        break;
                    case 4:
                        fours += 1;
                        totalSides += 4;
                        break;
                    case 5:
                        fives += 1;
                        totalSides += 5;
                        break;
                    case 6:
                        sixes += 1;
                        totalSides += 6;
                        break;
                }
            }

            Console.WriteLine($"Times rolled 1: {ones}\nTimes rolled 2: {twos}\nTimes rolled 3: {threes}\nTimes rolled 4: {fours}\nTimes rolled 5: {fives}\nTimes rolled 6: {sixes}\n");
            Console.WriteLine($"Average: {totalSides/100}");
        }
    }
}

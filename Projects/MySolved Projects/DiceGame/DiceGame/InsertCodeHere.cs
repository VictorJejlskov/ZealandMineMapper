using System;

namespace DiceGame
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            DiceCup cup = new DiceCup();
            Console.WriteLine($"The value of the first roll: {cup.TotalValue}");

            cup.Shake();
            Console.WriteLine($"The value of the second roll: {cup.TotalValue}");

            cup.Shake();
            Console.WriteLine($"The value of the third roll: {cup.TotalValue}");

            cup.Shake();
            Console.WriteLine($"The value of the fourth roll: {cup.TotalValue}");

            BigDie d100 = new BigDie();
            d100.NumberOfSides = 100;
            d100.Roll();
            Console.WriteLine($"The value of the d100 is: {d100.FaceValue}");


            // The LAST line of code should be ABOVE this line
        }
    }
}
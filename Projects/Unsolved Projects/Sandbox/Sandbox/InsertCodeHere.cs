using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Console.WriteLine("Hello world!");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("you clicked y :)");
            }
            else if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("you clicked n :)");
            }
            else
            {
                Console.WriteLine("You clicked neither Y or N");
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}
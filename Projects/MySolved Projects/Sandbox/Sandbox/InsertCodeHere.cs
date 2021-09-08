using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            
            Console.WriteLine("Insert how many times you want the word 'Skrrt' to be pasted");

            int myInt = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < myInt; i++)
            {
                Console.WriteLine("Skrrt");
            }
            Console.WriteLine("Hello world!");
            
            // The LAST line of code should be ABOVE this line
        }
    }
}
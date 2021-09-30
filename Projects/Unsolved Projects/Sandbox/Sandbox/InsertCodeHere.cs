using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            string userInput = Convert.ToString(Console.ReadKey().KeyChar);
            Console.WriteLine(userInput);
            if (Convert.ToInt32(userInput)>1)
            {
                Console.WriteLine("lol den er over 1");
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}
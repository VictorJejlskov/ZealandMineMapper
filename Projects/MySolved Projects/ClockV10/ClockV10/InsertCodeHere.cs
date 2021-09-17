using System;
using System.Security.Cryptography.X509Certificates;

namespace ClockV10
{
    public class InsertCodeHere
    {
        private string shownHour;
        private string shownMinute;
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Clock clock = new Clock();
            if (clock.CurrHour < 10)
            {
                shownHour = ($"0{clock.CurrHour}");
            }
            else if (clock.CurrHour >= 10)
            {
                shownHour = $"{clock.CurrHour}";
            }
            if (clock.CurrMinute < 10)
            {
                shownMinute = $"0{clock.CurrMinute}";
            }
            else if (clock.CurrMinute >= 10)
            {
                shownMinute = $"{clock.CurrMinute}";
            }
            Console.Clear();
            Console.WriteLine($"The time is currently {shownHour}:{shownMinute}");
            Console.WriteLine("Click H to increase the Hour by 1");
            Console.WriteLine("Click M to increase the Minute by 1");
            Console.WriteLine("Click K to increase the Minute by 15");
            Console.WriteLine();
            Console.WriteLine(clock.CurrHour);
            Console.WriteLine(clock.CurrMinute);
            string userInput = Convert.ToString(Console.ReadKey().Key);
            if (userInput == Convert.ToString(ConsoleKey.H))
            {
                clock.AddHour();
            }
            else if (userInput == Convert.ToString(ConsoleKey.M))
            {
                clock.AddMinute();
            }
            else if (userInput == Convert.ToString(ConsoleKey.K))
            {
                for (int i = 0; i < 15; i++)
                {
                    clock.AddMinute();
                }
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}
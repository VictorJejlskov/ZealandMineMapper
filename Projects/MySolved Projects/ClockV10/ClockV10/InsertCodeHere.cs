using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ClockV10
{
    public class InsertCodeHere
    {
        private string shownHour;
        private string shownMinute;
        Clock clock = new Clock();

        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

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
            DisplayTime();
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
            else if (userInput == Convert.ToString(ConsoleKey.A))
            {
                SetHour();
            }
            else if (userInput == Convert.ToString(ConsoleKey.B))
            {
                SetMinute();
            }
            // The LAST line of code should be ABOVE this line
        }

        public void DisplayTime()
        {
            Console.Clear();
            Console.WriteLine($"The time is currently {shownHour}:{shownMinute}");
            Console.WriteLine("Click H to increase the Hour by 1");
            Console.WriteLine("Click M to increase the Minute by 1");
            Console.WriteLine("Click K to increase the Minute by 15");
            Console.WriteLine("Click A to set the current hour manually");
            Console.WriteLine("Click B to set the current hour manually");
        }

        public void SetHour()
        {
            Console.Clear();
            Console.WriteLine("Insert the current hour");
            string userInput = Console.ReadLine();
            clock.CurrHour = Convert.ToInt32(userInput);
        }
        public void SetMinute()
        {
            Console.Clear();
            Console.WriteLine("Insert the current minute");
            string userInput = Console.ReadLine();
            clock.CurrMinute = Convert.ToInt32(userInput);
        }
    }
}
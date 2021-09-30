using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Postpurchase
    {
        public static void Kvittering()
        {
            Cart.ListCart();
            Cart.EndePrisen();
        }

        public static void TidTilMad()
        {
            int currHour = DateTime.Now.Hour;
            int currMinute = DateTime.Now.Minute;
            currMinute += 25;
            if (currMinute >= 60)
            {
                currMinute -= 60;
                currHour += 1;
            }

            string shownHour = "";
            string shownMinute = "";
            if (currMinute < 10)
            {
                shownMinute = $"0{currMinute}";
            }
            else
            {
                shownMinute = $"{currMinute}";
            }
            if (currHour < 10)
            {
                shownHour = $"0{currHour}";
            }
            else
            {
                shownHour = $"{currHour}";
            }
            Console.WriteLine($"Planlagt ankomst: {shownHour}:{shownMinute}");
        }
    }
}

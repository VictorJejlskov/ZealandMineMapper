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
        }

        public static void TidTilMad()
        {
            int currHour = DateTime.Now.Hour;
            int currMinute = DateTime.Now.Minute;
            currMinute += 25;
            if (currMinute >= 25)
            {
                currMinute -= 35;
                currHour += 1;
            }

            Console.WriteLine($"Planlagt ankomst: {currHour}:{currMinute}");
        }
    }
}

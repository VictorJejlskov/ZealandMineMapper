using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Logud
    {
        public static void LogUd()
        {
            Console.Clear();
            Login.IsMember = false;
            Console.WriteLine($"Du er blevet logget ud\n" +
                              $"Tryk en vilkårlig taste for at gå videre");
            Console.ReadKey();
        }
    }
}

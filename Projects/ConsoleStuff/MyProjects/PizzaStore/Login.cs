using System;
using System.Collections.Generic;
using System.Text;
using Console = System.Console;

namespace PizzaStore
{
    class Login
    {
        public static bool IsMember { get; set; }
        public static string Name { get; set; } = "Ny Bruger";

        public static void LogIn()
        {
            Console.Clear();
            Console.WriteLine($"Venligst indtast dit navn: ");
            Name = Console.ReadLine();
            Console.WriteLine($"\nOg dit kodeord:");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Velkommen tilbage: {Name}\n" +
                              $"Tryk på en vilkårlig tast for at gå videre");
            IsMember = true;
            Console.ReadKey();
        }
    }
}

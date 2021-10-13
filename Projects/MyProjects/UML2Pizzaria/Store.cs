using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UML2Pizzaria
{
    class Store
    {
        public static List<string> StartMenu = new List<string>
        {
            "1. Add new pizza to the menu",
            "2. Delete pizza",
            "3. Update pizza",
            "4. Search pizza",
            "5. Display pizza menu"
        };
        public static int MenuChoice(List<string> menuItems)
        {
            try 
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(menuItems[userInput-1]);
                return userInput;
            }
            catch 
            {
                Console.WriteLine("Dit valg var ikke gyldigt");
                return 0;
            }
        }
        public static void RunStore()
        {
            PrintMenu(StartMenu);
            
            MenuCatalog.Menu(MenuChoice(StartMenu));


            //tilføjer pizzaer til listen.
            //MenuCatalog.AddPizza(new Pizza(1, "Skinke", 80));
            //MenuCatalog.AddPizza(new Pizza(2, "Pepperoni", 754));
            //MenuCatalog.AddPizza(new Pizza(3, "Kødsauce", 56));
            //MenuCatalog.AddPizza(new Pizza(4, "Salat med kylling", 76));
            //MenuCatalog.AddPizza(new Pizza(5, "Salat med kebab", 94));
            //MenuCatalog.AddPizza(new Pizza(6, "Magarita", 80));
            //MenuCatalog.AddPizza(new Pizza(7, "Kødboller", 67));
            //MenuCatalog.PrintPizza();
            //Console.ReadKey();
            //Console.Clear();

            //// Opdaterer prisen og navn på pizzaen med ID 6.
            //MenuCatalog.UpdatePizza(6, "Meat", 76);
            //MenuCatalog.PrintPizza();
            //Console.ReadKey();
            //Console.Clear();

            ////Fjerner pizza med ID 7.
            //MenuCatalog.RemovePizza(7);
            //MenuCatalog.PrintPizza();
            //Console.ReadKey();
            //Console.Clear();

            ////Søger efter pizza.
            //MenuCatalog.SearchPizza("Salat med kylling");
        }

        public static void PrintMenu(List<string> menu)
        {
            Console.Clear();
            foreach (string mn in menu)
            {
                Console.WriteLine(mn);
            }
        }
    }
}

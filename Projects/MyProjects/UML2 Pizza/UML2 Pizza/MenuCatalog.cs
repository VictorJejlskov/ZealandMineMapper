using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace UML2_Pizza
{
    class MenuCatalog
    {
        public static List<Pizza> myPizzas = new List<Pizza>()
        {
            new Pizza("Kød1", 10),
            new Pizza("Kød2", 10),
            new Pizza("Kød3", 10),
            new Pizza("Kød4", 10)
        };

        public static void AssignID()
        {
            foreach (Pizza piz in myPizzas)
            {
                piz.PizzaID = myPizzas.IndexOf(piz) + 1;
            };
        }
        public static void ListPizza()
        {
            AssignID();
            foreach (Pizza piz in myPizzas)
            {
                Console.WriteLine(piz);
            }
        }
    }
}

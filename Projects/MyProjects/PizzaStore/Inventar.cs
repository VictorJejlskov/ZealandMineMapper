using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Inventar
    {
        public int PizzaID { get; set; }
        public Pizza MyPizza { get; set; }

        public static List<Pizza> myPizzas = new List<Pizza>()
        {
            new Pizza("Salat med kebab", 01, 75, "normal"),
            new Pizza("Salat med kebab", 02, 90, "Deep Pan"),
            new Pizza ("Salat med kebab", 03, 109, "Familie"),
            new Pizza("Kød Tornado", 04, 90, "normal"),
            new Pizza("Kød Tornado", 05, 109, "Deep Pan"),
            new Pizza("Kød Tornado", 06, 130, "Familie"),
            new Pizza ("Salat med kylling", 07, 78, "Normal"),
            new Pizza("Salat med kylling", 08, 90, "Deep Pan"),
            new Pizza("Salat med kylling", 09, 110,"Familie"),
            new Pizza("Durum med kebab", 10, 45,"Normal"),
            new Pizza("Durum med kylling", 11, 45,"Normal"),
            new Pizza("Durum med kebabmix", 12, 55,"Normal"),
        };

        public static void MenuKort()
        {
            List<Pizza> listPizza = new List<Pizza>();
            listPizza = Inventar.myPizzas;
            foreach (Pizza pizz in listPizza)
            {
                Console.WriteLine(pizz);
            }
        }
    }
}

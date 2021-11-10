using System;
using System.Collections.Generic;
using System.Text;

namespace BigMamaPizzaStore
{
    class Order
    {
        public string Name { get; set; }
        public Pizza MyPizza { get; set; }

        public static int TotalPris { get; set; }
        public static Random rnd = new Random();

        public Order(string name)
        {
            Name = name;
            MyPizza = Pizza.myPizza[rnd.Next(0,Pizza.myPizza.Count)];
            //TotalPris += MyPizza.Price;
        }

        public override string ToString()
        {
            return $"{Name} bestilte en: {MyPizza}";
        }
    }
}

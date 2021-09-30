using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BigMamaPizzaStore
{
    class Pizza
    {
        public string Name { get; }
        public int Price { get; }
        public string Size { get; }

        public Pizza(string name, int price, string size)
        {
            Name = name;
            Price = price;
            Size = size;
        }
        public static List<Pizza> myPizza= new List<Pizza>()
        {
            new Pizza("Hawaii", 55, "Normal"),
            new Pizza("Salatpizza med kebab", 75, "normal"),
            new Pizza("Salatpizza med kebab", 90, "Deep Pan"),
            new Pizza("Salatpizza med kebab", 109, "Familie"),
            new Pizza("Kød Tornado", 90, "normal"),
            new Pizza("Kød Tornado", 109, "Deep Pan"),
            new Pizza("Kød Tornado", 130, "Familie"),
            new Pizza("Salat med kylling", 78, "Normal"),
            new Pizza("Salat med kylling", 90, "Deep Pan"),
            new Pizza("Salat med kylling", 110, "Familie"),
            new Pizza("Durum med kebab", 45, "Normal"),
            new Pizza("Durum med kylling", 45, "Normal"),
            new Pizza("Durum med kebabmix", 55, "Normal")
        };

        public override string ToString()
        {
            return $"{Name} - {Price},-";
        }
    }
}

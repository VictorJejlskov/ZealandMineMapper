using System;

namespace UML2Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuCatalog.AddPizza(new Pizza("Skinke", 80));
            MenuCatalog.AddPizza(new Pizza("Pepperoni", 754));
            MenuCatalog.AddPizza(new Pizza("Kødsauce", 56));
            MenuCatalog.AddPizza(new Pizza("Salat med kylling", 76));
            MenuCatalog.AddPizza(new Pizza("Salat med kebab", 94));
            MenuCatalog.AddPizza(new Pizza("Magarita", 80));
            MenuCatalog.AddPizza(new Pizza("Kødboller", 67));
            Store.RunStore();

        }
    }
}

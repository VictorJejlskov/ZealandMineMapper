using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PizzaOven pizzaOven = new PizzaOven();
            PizzaMan pizzaMan = new PizzaMan(pizzaOven);
            var ingredients = new string[]
            {
                "Ham",
                "Pepperoni",
                "Bacon"
            };
            pizzaMan.TakeOrder(ingredients);

            ingredients = new string[]
            {
                "Pepperoni"
            };
            pizzaMan.TakeOrder(ingredients);


            ingredients = new string[]
            {
                "Pepperoni"
            };
            pizzaMan.TakeOrder(ingredients);

            ingredients = new string[]
            {
                "Ham",
                "Bacon"
            };
            pizzaMan.TakeOrder(ingredients);

            ingredients = new string[]
            {
                "Pepperoni",
                "Bacon"
            };
            pizzaMan.TakeOrder(ingredients);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UML2MyOwn
{
    class Pizza
    {
        public string PizzaName { get; set; }
        public int PizzaPrice { get; set; }
        public int PizzaNumber { get; set; }
        public List<string> PizzaToppings { get; set; }
        public Pizza(string pizzaName, int pizzaPrice, List<string> pizzaToppings)
        {
            PizzaName = pizzaName;
            PizzaPrice = pizzaPrice;
            PizzaToppings = pizzaToppings;
        }


        public override string ToString()
        {
            return $"{PizzaNumber}. {PizzaName} - {PizzaPrice},-";
        }

        public void PrintToppings()
        {
            foreach (string pizzaTopping in PizzaToppings)
            {
                Console.WriteLine($"{PizzaToppings.IndexOf(pizzaTopping) + 1}. {pizzaTopping}");
            }
        }
    }
}

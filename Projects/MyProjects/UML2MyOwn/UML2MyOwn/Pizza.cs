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
    }
}

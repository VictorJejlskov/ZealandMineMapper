using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    class PizzaFactory : IPizzaFactory
    {
        public AbstractPizza MakePizza(string[] input)
        {
            AbstractPizza pizza = new PlainPizza();
            if (input != null)
            {
                foreach (var str in input)
                {
                    pizza = AddIngredients(str, pizza);
                }
            }
            return pizza;
        }

        private AbstractPizza AddIngredients(string input, AbstractPizza pizza)
        {
            switch (input)
            {
                case "Ham":
                    return new HamDecorator(pizza);
                case "Pepperoni":
                    return new PepperoniDecorator(pizza);
                case "Bacon":
                    return new BaconDecorator(pizza);
                default:
                    return pizza;
            }
        }
    }
}

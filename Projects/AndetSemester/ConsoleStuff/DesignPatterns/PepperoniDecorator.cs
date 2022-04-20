using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class PepperoniDecorator : AbstractPizzaDecorator
    {
        public PepperoniDecorator(AbstractPizza pizza)
        {
            Pizza = pizza;
            Price = pizza.Price + 7;
            Ingredients = pizza.Ingredients + " and Pepperoni";
        }

        public override string ToString()
        {
            return $"Pizza with: " + Ingredients;
        }
    }
}

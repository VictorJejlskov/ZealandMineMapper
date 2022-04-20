using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class BaconDecorator : AbstractPizzaDecorator
    {
        public BaconDecorator(AbstractPizza pizza)
        {
            Pizza = pizza;
            Price = pizza.Price + 7;
            Ingredients = pizza.Ingredients + " and Bacon";
        }
        public override string ToString()
        {
            return $"Pizza with: " + Ingredients;
        }
    }
}

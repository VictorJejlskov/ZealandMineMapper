using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class HamDecorator : AbstractPizzaDecorator
    {
        public HamDecorator(AbstractPizza pizza)
        {
            Pizza = pizza;
            Price = pizza.Price + 7;
            Ingredients = pizza.Ingredients + " and Ham";
        }
        public override string ToString()
        {
            return $"Pizza with: " + Ingredients;
        }
    }
}

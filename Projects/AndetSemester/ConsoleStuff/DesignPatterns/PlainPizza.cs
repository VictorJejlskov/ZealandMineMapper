using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class PlainPizza : AbstractPizza
    {
        public PlainPizza()
        {
            Price = 50;
            Ingredients = "Tomato & Cheese";
        }

        public override string ToString()
        {
            return $"Pizza with: " + Ingredients;
        }
    }
}

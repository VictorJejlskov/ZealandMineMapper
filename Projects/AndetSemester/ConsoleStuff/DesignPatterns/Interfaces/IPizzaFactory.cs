using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interfaces
{
    interface IPizzaFactory
    {
        AbstractPizza MakePizza(string[] input);
    }
}

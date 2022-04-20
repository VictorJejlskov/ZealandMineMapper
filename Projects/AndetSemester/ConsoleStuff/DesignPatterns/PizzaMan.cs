using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    class PizzaMan : IObserver
    {
        public PizzaOven PizzaOven { get; set; }
        public IPizzaFactory PizzaFactory { get; set; }

        public PizzaMan(PizzaOven pizzaOven)
        {
            PizzaFactory = new PizzaFactory();
            PizzaOven = pizzaOven;
            pizzaOven.AddObserver(this);
        }

        public void TakeOrder(string[] extras)
        {
            AbstractPizza pizza = PizzaFactory.MakePizza(extras);
            PizzaOven.PreparePizza(pizza);
        }

        public void Notify(AbstractPizza piz)
        {
            Console.WriteLine("Your pizza is ready!");
            Console.WriteLine(piz);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pizza_StoreV1.MockData;
using Pizza_StoreV1.Models;

namespace Pizza_StoreV1.Service
{
    public class PizzaService : IPizzaService
    {
        private Dictionary<int, Pizza> _pizzas;

        public PizzaService()
        {
            _pizzas = MockPizzas.AllPizzas();
        }
        public Dictionary<int, Pizza> GetPizzas()
        {
            return _pizzas;
        }

        public void AddPizza(Pizza pizza)
        {
            _pizzas.Add(pizza.Id, pizza);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pizza_StoreV1.Models;

namespace Pizza_StoreV1.Service
{
    interface IPizzaService
    {
        public Dictionary<int, Pizza> GetPizzas();
        public void AddPizza(Pizza pizza);
    }
}

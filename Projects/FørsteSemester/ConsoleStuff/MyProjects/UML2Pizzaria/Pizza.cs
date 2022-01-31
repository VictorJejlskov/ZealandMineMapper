using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace UML2Pizzaria
{
    class Pizza
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int PizzaId { get; set; }

        public Pizza(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{PizzaId}. {Name} - {Price},-";
        }

        public void UpdatePrice(int inputPrice)
        {
            Price = inputPrice;
        }

        public void UpdateName(string inputName)
        {
            Name = inputName;
        }
    }


}

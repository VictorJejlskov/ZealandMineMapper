using System;
using System.Collections.Generic;
using System.Text;

namespace UML2_Pizza
{
    class Pizza
    {
        public string Name { get; set; }
        public int Price { get; set;  }
        public int PizzaID { get; set; }
        public Pizza(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{PizzaID}. {Name} - {Price}";
        }
    }
}

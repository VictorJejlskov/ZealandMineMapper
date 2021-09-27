using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Pizza : IEquatable<Pizza>
    {
        public string Name { get; set; }
        public int PizzaID { get; set; }
        public int Pris { get; set; }
        public string Size { get; set; }
        public Pizza(string name, int pizzaID, int pris, string size)
        {
            Name = name;
            PizzaID = pizzaID;
            Pris = pris;
            Size = size;
        }
        public bool Equals(Pizza other)
        {
            if (other == null) return false;
            return (this.PizzaID.Equals(other.PizzaID));
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Pizza objAsPart = obj as Pizza;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public override string ToString()
        {
            return $"{(PizzaID < 10 ? $"0{PizzaID}":$"{PizzaID}")} - Pizzanavn {Name} - {Size}\n" +
                   $"Pris: {Pris},-";
        }
    }
}

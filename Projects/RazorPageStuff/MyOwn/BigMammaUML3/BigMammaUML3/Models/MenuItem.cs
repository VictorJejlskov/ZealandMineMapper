using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BigMammaUML3.Models
{
    public abstract class MenuItem
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public MenuItem()
        {
            
        }
        public MenuItem(int number, string name, string description, double price)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"{nameof(Number)}: {Number}, {nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Price)}: {Price}";
        }

        public abstract void UpdateDescription();
    }


}

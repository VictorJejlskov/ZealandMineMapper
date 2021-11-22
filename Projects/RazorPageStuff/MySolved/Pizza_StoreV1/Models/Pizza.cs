using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV1.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageName { get; set; }

        public Pizza()
        {
            
        }

        public Pizza(int id, string name, string description, decimal price, string imageName)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ImageName = imageName;
        }
    }
}

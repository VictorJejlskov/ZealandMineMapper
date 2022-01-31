using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCoolerCatchup
{
    class Wine
    {
        public string WineType { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Wine()
        {
            
        }

        public Wine(string wineType, string name, double price)
        {
            WineType = wineType;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"WineType: {WineType}, Name: {Name}, Price: {Price}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCoolerCatchup
{
    class WineCooler
    {
        private int _id = 1;

        public int Id
        {
            get { return _id;}
            set { _id = value; }
        }

        public double Temperature { get; set; }
        public int Capacity { get; set; }
        public List<Wine> Wines { get; set; }

        public WineCooler(double temperature, int capacity)
        {
            Temperature = temperature;
            Capacity = capacity;
            Wines = new List<Wine>();
            Id = _id++;
        }

        public void Add(Wine wine)
        {
            Wines.Add(wine);
        }

        public void PrintAll()
        {
            foreach (Wine wine in Wines)
            {
                Console.WriteLine(wine);
            }
        }

        public List<Wine> GetWhiteWine()
        {
            List<Wine> tempList = new List<Wine>();
            foreach (Wine wine in Wines)
            {
                if (wine.WineType == "Hvidvin")
                {
                    tempList.Add(wine);
                }
            }

            return tempList;
        }

    }
}

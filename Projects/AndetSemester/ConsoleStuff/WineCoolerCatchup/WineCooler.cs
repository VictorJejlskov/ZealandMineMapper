using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCoolerCatchup
{
    class WineCooler
    {
        private static int _id = 1;

        public int Id { get; set; }

        public double Temperature { get; set; }
        public int Capacity { get; set; }
        private List<Wine> _wines;

        public WineCooler(double temperature, int capacity)
        {
            Temperature = temperature;
            Capacity = capacity;
            _wines = new List<Wine>();
            Id = _id++;
        }

        public void Add(Wine wine)
        {
            _wines.Add(wine);
        }

        public void PrintAll()
        {
            foreach (Wine wine in _wines)
            {
                Console.WriteLine(wine);
            }
        }

        public List<Wine> GetWhiteWine()
        {
            List<Wine> tempList = new List<Wine>();
            foreach (Wine wine in _wines)
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

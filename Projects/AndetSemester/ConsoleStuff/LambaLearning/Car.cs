using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaLearning
{
    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Car()
        { }
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Year: {Year}";
        }

    }
}

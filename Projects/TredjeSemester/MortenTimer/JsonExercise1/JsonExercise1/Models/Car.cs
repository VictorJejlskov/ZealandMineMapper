using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercise1.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int Mileage { get; set; }



        public Car()
        {
            
        }

        public Car(string brand, string model, string colour, int mileage)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            Mileage = mileage;
        }
        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, Colour: {Colour}, Mileage: {Mileage}";
        }

    }
}

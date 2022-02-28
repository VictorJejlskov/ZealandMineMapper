using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCarExercise
{
    class Car : IComparable<Car>
    {
        public int RegNo { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car()
        {
            
        }
        public Car(int regNo, string model, int year)
        {
            RegNo = regNo;
            Model = model;
            Year = year;
        }
        public int CompareTo(Car other)
        {
            return RegNo - other.RegNo;
        }

        public override string ToString()
        {
            return $"RegNo: {RegNo}, Model: {Model}, Year: {Year}";
        }
    }
}

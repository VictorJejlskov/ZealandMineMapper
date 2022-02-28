using System;
using System.Collections.Generic;

namespace SortCarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Car> cars = new List<Car>()
            {
                new Car(1, "A", 11),
                new Car(7, "C", 44),
                new Car(3, "B", 22),
                new Car(2, "D", 33)
            };

            Console.WriteLine("Unsorted");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            cars.Sort();
            Console.WriteLine("list.sort by RegNo, as shown in the Car class");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            cars.Sort(new CarModelComparator());
            Console.WriteLine("list.sort by Model, as shown in the CarModelComparator class");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            cars.Sort(new CarYearComparator());
            Console.WriteLine("list.sort by Year, as shown in the CarYearComparator class");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
        }
    }
}

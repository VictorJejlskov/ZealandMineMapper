using System;
using System.Collections.Generic;
using System.Linq;

namespace LambaLearning
{
    class Program
    {
        private static string _searchCriteria = "BBBB";

        static bool CarModelSearch(Car car)
        {
            return car.Model.Equals(_searchCriteria);
        }

        static Predicate<Car> carPred = CarModelSearch;
        static void Main(string[] args)
        {
            Car car1 = new Car("AAAA", 1995);
            Car car2 = new Car("BBBB", 1996);
            Car car3 = new Car("CCCC", 1997);
            Car car4 = new Car("DDDD", 1998);
            Car car5 = new Car("AAAA", 1995);

            List<Car> carList = new List<Car>();
            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);
            carList.Add(car4);
            carList.Add(car5);

            Console.WriteLine("Case 1: Ghetto method of Making a pred, and such.. ew");
            Console.WriteLine(carList.Find(carPred));

            Console.WriteLine("Case 2: Smoother method, but still kinda ewuhh");
            Console.WriteLine(carList.Find(delegate(Car c)
            {
                return c.Model.Equals(_searchCriteria);
            }));

            Console.WriteLine("Case 3: Love this =)");
            Console.WriteLine(carList.Find(c => c.Model.Equals(_searchCriteria)));

            Console.WriteLine("Case 4: FindAll model equals AAAA");
            List<Car> newList = carList.FindAll(c => c.Model.Equals("AAAA"));
            foreach (Car car in newList)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("Find Index of Model CCCC (should be 2)");
            Console.WriteLine(carList.FindIndex(c => c.Model.Equals("CCCC")));

            var alsoNewList = carList.FindAll(c => c.Model.Equals("AAAA"));
            foreach (var car in alsoNewList)
            {
                Console.WriteLine(car);
            }
        }
    }
}

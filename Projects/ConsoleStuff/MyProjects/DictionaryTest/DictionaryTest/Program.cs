using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            cars.Add("testplade1", new Car("Søren Hansen",1996, "Hyundai", "i20", "testplade1"));
            cars.Add("testplade2", new Car("Britta Henriksen",2001, "Kia", "Niro E", "testplade2"));
            cars.Add("testplade3", new Car("Tobias Larsen",2005, "Fiat", "500", "testplade3"));
            cars.Add("testplade4", new Car("Andreas Frederiksen",2008, "Volvo", "XC60", "testplade4"));
            cars.Add("testplade5", new Car("Victor Jejlskov",2009, "Tesla", "Model S", "testplade5"));
            cars.Add("testplade6", new Car("Rasmus Palludan", 2010, "Mazda", "MazdaSUV", "testplade6"));
            cars.Add("testplade7", new Car("Morten Petersen",2012, "Ferrari", "F430", "testplade7"));
            cars.Add("testplade8", new Car("Zenia Svenstrup",2015, "Jaguar", "XFR", "testplade8"));
            cars.Add("testplade9", new Car("Rose Boye",2017, "Rolls Royce", "Phantom", "testplade9"));


            //Politimanden indtaster nummerplade 1 i systemet:
            Console.WriteLine(cars["testplade1"]);


            Console.WriteLine();
            Console.WriteLine("ContainsKey nedenunder:");
            if (cars.ContainsKey("testplade3"))
            {
                Console.WriteLine(cars["testplade3"]);
            }



            Console.WriteLine();
            Console.WriteLine("TryGetValue nedenunder:");
            Car result;
            if (cars.TryGetValue("testplade7", out result))
            {
                Console.WriteLine(result);
            }



            Console.WriteLine();
            Console.WriteLine("For loop med antal i mit dictionary");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine("{0}",
                    cars.ElementAt(i).Value);
            }
        }
    }
}

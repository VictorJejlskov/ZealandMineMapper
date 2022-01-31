using System;

namespace Opgave___Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car myOtherCar = new Car();
            try
            {
                myCar.Doors = 3;
                myCar.RegNo = "DX32547";
                myCar.Brand = "Smart";
                myCar.Model = "Model S";
                myCar.HorsePower = 90;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(myOtherCar);
            Console.WriteLine(myCar);
            Console.ReadKey();
        }
    }
}

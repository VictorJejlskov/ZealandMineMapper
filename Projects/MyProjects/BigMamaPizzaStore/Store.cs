using System;
using System.Collections.Generic;
using System.Text;

namespace BigMamaPizzaStore
{
    class Store
    {

        public void Start()
        { 

            Customer customer1 = new Customer("Alex", 29);
            Customer customer2 = new Customer("Svend", 43);
            Customer customer3 = new Customer("Henriette", 53);
            Order order1 = new Order(customer1.ToString());
            Order order2 = new Order(customer2.ToString());
            Order order3 = new Order(customer3.ToString());
            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);
            Console.WriteLine($"Totalpris for alle 3: {CalcutelateTotalPrice(order1.MyPizza.Price, order2.MyPizza.Price, order3.MyPizza.Price)}");
        }

        public int CalcutelateTotalPrice(int prisA, int prisB, int PrisC)
        {
            return prisA + prisB + PrisC;
        }
    }
}

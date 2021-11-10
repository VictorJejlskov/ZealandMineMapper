using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Orders
    {
        #region instancefields

        public static int OrderID { get; set; }
        public static double TotalPris { get; set; }
        public double Discount { get; set; }

        public string UserName { get; set; }
        public int OrdrePris { get; set; }
        public List<Pizza> loggedList { get; set; } = new List<Pizza>();
        #endregion

        #region methods

        public static List<Pizza> finishedPurchase = new List<Pizza>();


        public static void AddToOrders(List<Pizza> pizzaList)
        {
            finishedPurchase.AddRange(pizzaList);
        }

        public Orders(string name, List<Pizza> pizzas, int totalPris)
        {
            OrderID = OrderID + 1;
            UserName = name;
            loggedList.AddRange(pizzas);
            OrdrePris = totalPris;
        }
        
        public static List<Orders> FinishedOrdersList = new List<Orders>()
        {
            
        };

        public static void PrintOrderList()
        {
            foreach (Orders orderid in FinishedOrdersList)
            {
                Console.WriteLine(orderid.UserName);
                Console.WriteLine();
                foreach (Pizza pizz in orderid.loggedList)
                {
                    Console.WriteLine($"{(pizz.PizzaID < 10 ? $"0{pizz.PizzaID}" : $"{pizz.PizzaID}")}-Pizzanavn {pizz.Name}-{pizz.Size}-Pris: { pizz.Pris},-");
                }
                Console.WriteLine($"Totalpris: {orderid.OrdrePris}\n");
            }
        }

        #endregion
        //foreach (Pizza pizz in myCart)
        //{
        //    Console.WriteLine(pizz);
        //    TotalPris += pizz.Pris;
        //}



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UML2MyOwn
{
    class OrderCatalog
    {
        public static List<Order> OrderList { get; set; }= new List<Order>();

        public static void AddOrder(Order inputOrder)
        {
            OrderList.Add(inputOrder);
        }
    }
}

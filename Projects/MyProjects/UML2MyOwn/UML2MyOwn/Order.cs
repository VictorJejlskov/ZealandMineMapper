using System;
using System.Collections.Generic;
using System.Text;

namespace UML2MyOwn
{
    class Order
    {
        public List<Pizza> OrderPizzaList { get; set; }
        public Customer OrderCustomer { get; set; }
        public int OrderTotalPrice { get; set; }

        public Order(List<Pizza> orderPizzaList, Customer orderCustomer, int orderTotalPrice)
        {
            OrderPizzaList = orderPizzaList;
            OrderCustomer = orderCustomer;
            OrderTotalPrice = orderTotalPrice;
        }
        

    }
}

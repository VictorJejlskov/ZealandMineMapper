using System;
using System.Collections.Generic;
using System.Text;

namespace UML2MyOwn
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int CustomerAge { get; set; }
        public Pizza FavouritePizza { get; set; }
        public bool HasFavourite;

        public Customer(string customerName, int customerAge, Pizza favouritePizza)
        {
            CustomerName = customerName;
            CustomerAge = customerAge;
            FavouritePizza = favouritePizza;
            HasFavourite = true;
        }

        public Customer(string customerName, int customerAge)
        {
            CustomerName = customerName;
            CustomerAge = customerAge;
            HasFavourite = false;
        }

        public override string ToString()
        {
            if (HasFavourite)
            {
                return $"Customer: {CustomerID}. {CustomerName}, age {CustomerAge} has '{FavouritePizza.PizzaName}' as their favourite pizza";
            }
            else
            {
                return $"Customer: {CustomerID}. {CustomerName}, age {CustomerAge} and doesn't have a favourite pizza";
            }
        }
    }
}

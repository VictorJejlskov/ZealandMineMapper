using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Cart
    {
        //public int TotalPris { get; set; } 
        public static List<Pizza> myCart = new List<Pizza>();
        public static void AddToCart(Pizza pizza)
        {
            myCart.Add(pizza);
        }
        public static void ListCart()
        {
            int TotalPris = 0;
            Console.WriteLine($"Din kurv:");
            foreach (Pizza pizz in myCart)
            {
                Console.WriteLine(pizz);
                TotalPris += pizz.Pris;
            }
            Console.WriteLine($"\nDen samlede pris: {TotalPris}");
        }
    }
}

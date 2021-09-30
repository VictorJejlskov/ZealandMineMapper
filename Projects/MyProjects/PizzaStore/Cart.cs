using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Cart
    {
        public static int TotalPris { get; set; }
        //public int TotalPris { get; set; } 
        public static List<Pizza> myCart = new List<Pizza>();
        public static void AddToCart(Pizza pizza)
        {
            myCart.Add(pizza);
        }
        public static void ListCart()
        {
            TotalPris = 0;   
            Console.WriteLine($"Din kurv:");
            foreach (Pizza pizz in myCart)
            {
                Console.WriteLine(pizz);
                TotalPris += pizz.Pris;
            }
        }

        public static void EndePrisen()
        {
            Console.WriteLine($"Pris for pizzaerne: {TotalPris}kr (inklusiv moms)");
            Console.WriteLine($"Pris for levering: 40kr");
            Console.WriteLine($"\nDen endelige totale pris: {TotalPris+40}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class PaymentCustomer
    {
        public static void FinishPurchase()
        {
            Console.Clear();
            Console.WriteLine("Velkommen til betalingen");
            Cart.ListCart();
            Console.WriteLine($"Den endelige pris: {Cart.TotalPris}");
            Console.WriteLine($"\nTryk på en vilkårlig tast for at færdiggøre betalingen");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Velkommen til betalingen");
            Cart.ListCart();
            Console.WriteLine($"\nKortnr: 12345678 - cvc: 111");


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Postpurchase.Kvittering();
            Postpurchase.TidTilMad();

            Orders.AddToOrders(Cart.myCart);
            Orders.FinishedOrdersList.Add(new Orders(Login.Name, Cart.myCart, Cart.TotalPris));
            Cart.myCart.Clear();
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Totale Ordre inklusiv forrige:");
            Orders.PrintOrderList();
            Console.ReadKey();

        }
    }
}

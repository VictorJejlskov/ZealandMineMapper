using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class SandboxCode
    {
        public void MyCode()
        {
            Console.Clear();
            Console.WriteLine($"Velkommen til Papa's Pizza, nedenunder kan du se vores menu\n");
            Inventar.MenuKort();
            Console.WriteLine("\n" +
                              $"Indtast tallet for mad-genstanden du vil købe\n" +
                              $"Eller tryk 'B' for at gå til betaling\n" +
                              $"{(Login.IsMember ? $"{Login.Name} - tryk 'L' igen for at logge ud." : "For gentagende kunder, tryk L for 'login'" )}");

            string userInput = Convert.ToString(Console.ReadKey().KeyChar);
            try
            {
                if (userInput == "b")
                {
                    PaymentCustomer.FinishPurchase();
                    MyCode();
                }
                else if (userInput == "l")
                {
                    if (Login.IsMember)
                    {
                        Logud.LogUd();
                        MyCode();
                    }
                    else
                    {
                        Login.LogIn();
                        MyCode();
                    }

                }
                else if (Convert.ToInt32(userInput) <= Convert.ToInt32(Inventar.myPizzas.Count))
                {
                    Cart.AddToCart(Inventar.myPizzas[Convert.ToInt32(userInput) - 1]);
                    Console.Clear();
                    Console.WriteLine(
                        $"Pizza tilføjet til kurven: \n{Inventar.myPizzas[Convert.ToInt32(userInput) - 1]}\n");
                    Cart.ListCart();
                    Console.WriteLine(
                        "For at gå til betaling, tryk 'B' - ellers, tryk en vilkårlig tast for at bestille mere");
                    userInput = Convert.ToString(Console.ReadKey().Key);
                    if (userInput == Convert.ToString(ConsoleKey.B))
                    {
                        PaymentCustomer.FinishPurchase();
                        MyCode();
                    }
                    else
                    {
                        MyCode();
                    }
                }
            }
            catch
            {
                MyCode();
            }

        }
    }
}

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

        public void ExtaTopping(Pizza inputPizza)
        {
            foreach (Pizza piz in OrderPizzaList)
            {
                if (piz == inputPizza)
                {
                    Console.WriteLine("Hver topping koster 5kr ekstra");
                    Console.WriteLine("Vælg hvilken topping du vil tilføje:");
                    MenuCatalog.PrintToppings();

                    bool isEditingToppings = true;
                    while (isEditingToppings)
                    {
                        try
                        {
                            Console.WriteLine($"Tryk en vilkårlig tast, som ikke er et tal, for at indikere at du er færdig");
                            Console.WriteLine("Available toppings:");
                            foreach (string pizzaTopping in MenuCatalog.AvailableToppings)
                            {
                                //"{AvailableToppings.IndexOf(toppingList)+1}. {toppingList}"
                                Console.WriteLine($"{MenuCatalog.AvailableToppings.IndexOf(pizzaTopping) + 1}. {pizzaTopping}");
                            }

                            Console.WriteLine($"\nCurrent Toppings:");
                            foreach (string pizzaTopping in piz.PizzaToppings)
                            {
                                try
                                {
                                    int test = Convert.ToInt32(pizzaTopping);
                                }
                                catch
                                {
                                    Console.WriteLine($"{piz.PizzaToppings.IndexOf(pizzaTopping) + 1}. {pizzaTopping}");
                                }

                            }

                            Console.WriteLine($"Tryk på tallet for toppingen du vil tilføje, hvis pizzaen allerede har denne topping på, vil systemet fjerne den");
                            int userToppingInput = Convert.ToInt32(Console.ReadLine());
                            if (piz.PizzaToppings.Contains(MenuCatalog.AvailableToppings[userToppingInput - 1]))
                            {
                                piz.PizzaToppings[userToppingInput - 1] = $"{userToppingInput}";
                                Console.Clear();
                            }
                            else
                            {
                                try
                                {
                                    piz.PizzaToppings[userToppingInput - 1] = $"{MenuCatalog.AvailableToppings[userToppingInput - 1]}";
                                }
                                catch
                                {
                                    piz.PizzaToppings.Add(MenuCatalog.AvailableToppings[userToppingInput - 1]);
                                }

                                Console.Clear();
                            }
                        }
                        catch
                        {
                            isEditingToppings = false;
                            Console.WriteLine("Du valgte at stoppe eller indtastede et ugyldigt nummer");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }

    }
}

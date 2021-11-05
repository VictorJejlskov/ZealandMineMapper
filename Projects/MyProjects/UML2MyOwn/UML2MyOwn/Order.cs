using System;
using System.Collections.Generic;
using System.Text;

namespace UML2MyOwn
{
    class Order
    {
        public int OrderID { get; set; }
        public List<Pizza> OrderPizzaList { get; set; }
        public Customer OrderCustomer { get; set; }
        public int OrderTotalPrice { get; set; }

        public Order(List<Pizza> orderPizzaList, Customer orderCustomer, int orderTotalPrice)
        {
            OrderPizzaList = orderPizzaList;
            OrderCustomer = orderCustomer;
            OrderTotalPrice = orderTotalPrice;
        }
        public string PizzaListInOrder()
        {
            string tempString = "";
            foreach (Pizza piz in OrderPizzaList)
            {
                tempString += $"{piz}\n";
            }

            return tempString;
        }

        public override string ToString()
        {
            return $"Customer: {OrderCustomer.CustomerName}\n" +
                   $"{PizzaListInOrder()}\n" +
                   $"Total price: {OrderTotalPrice}";
        }
        //public void ExtaTopping(Pizza inputPizza)
        //{
        //    Console.Clear();
        //    Console.WriteLine($"Press 1 to add more toppings\nPress 2 to remove toppings");
        //    foreach (Pizza piz in OrderPizzaList)
        //    {
        //        if (piz == inputPizza)
        //        {
        //            while (piz.PizzaToppings.Count <= MenuCatalog.AvailableToppings.Count)
        //            {
        //                piz.PizzaToppings.Add($"{piz.PizzaToppings.Count+1}");
        //            }
        //            bool isEditingToppings = true;
        //            while (isEditingToppings)
        //            {
        //                try
        //                {
        //                    Console.WriteLine("Hver topping koster 5kr ekstra");
        //                    Console.WriteLine("Vælg hvilken topping du vil tilføje:");
        //                    Console.WriteLine($"Tryk en vilkårlig tast, som ikke er et tal, for at indikere at du er færdig");
        //                    Console.WriteLine($"Nuværende pris: {piz.PizzaPrice}");
        //                    Console.WriteLine("Available toppings:");
        //                    foreach (string pizzaTopping in MenuCatalog.AvailableToppings)
        //                    {
        //                        //"{AvailableToppings.IndexOf(toppingList)+1}. {toppingList}"
        //                        Console.WriteLine($"{MenuCatalog.AvailableToppings.IndexOf(pizzaTopping) + 1}. {pizzaTopping}");
        //                    }

        //                    Console.WriteLine($"\nCurrent Toppings:");
        //                    //Ghetto løsning til at tjekke om min liste er et tal (filler indhold)
        //                    //Hvis ikke et tal, skriv toppingen ud

        //                    foreach (string pizzaTopping in piz.PizzaToppings)
        //                    {
        //                        Console.WriteLine(pizzaTopping);
        //                        //try
        //                        //{
        //                        //    int test = Convert.ToInt32(pizzaTopping);
        //                        //}
        //                        //catch
        //                        //{
        //                        //    Console.WriteLine($"{MenuCatalog.AvailableToppings.IndexOf(pizzaTopping) + 1}. {pizzaTopping}");
        //                        //}

        //                    }

        //                    Console.WriteLine($"Tryk på tallet for toppingen du vil tilføje, hvis pizzaen allerede har denne topping på, vil systemet fjerne den");
        //                    int userToppingInput = Convert.ToInt32(Console.ReadLine());
        //                    //Hvis en pizza vi ændrer i's liste af toppings, indeholder en topping, som er på listen over 
        //                    //Toppings som er tilgængelige, så sæt toppingen til at være et tal, som min ghetto løsning
        //                    //ovenover så reagerer på
        //                    if (piz.PizzaToppings.Contains(MenuCatalog.AvailableToppings[userToppingInput - 1]))
        //                    {
        //                        try
        //                        {
        //                            piz.PizzaToppings[userToppingInput-1] = $"{userToppingInput}";
        //                            piz.PizzaPrice -= 5;
        //                        }
        //                        catch (Exception e)
        //                        {
        //                            Console.WriteLine(e);
        //                            Console.ReadKey();
        //                        }
                                
        //                        Console.Clear();
        //                    }
        //                    else
        //                    {

        //                        try
        //                        {
        //                            piz.PizzaToppings.Insert(userToppingInput - 1, $"{MenuCatalog.AvailableToppings[userToppingInput - 1]}");
        //                            piz.PizzaPrice += 5;
        //                        }
        //                        catch
        //                        {
        //                            piz.PizzaToppings.Add(MenuCatalog.AvailableToppings[userToppingInput - 1]);
        //                            piz.PizzaPrice += 5;
        //                        }

        //                        Console.Clear();
        //                    }
        //                }
        //                catch (Exception e)
        //                {
        //                    isEditingToppings = false;
        //                    Console.WriteLine("Du valgte at stoppe eller indtastede et ugyldigt nummer");
        //                    Console.ReadKey();
        //                }
        //            }
        //        }
        //    }
        //}

    }
}

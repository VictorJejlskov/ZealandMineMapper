using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;

namespace UML2MyOwn
{
    class OrderCatalog
    {
        public static List<Order> OrderList { get; set; }= new List<Order>()
        {
            new Order(MenuCatalog.PizzaList, CustomerCatalog.CustomerList[0], CalculateTotalPrice(MenuCatalog.PizzaList))
        };

        public static void AddOrder(Order inputOrder)
        {
            OrderList.Add(inputOrder);
            AssignOrderID();
        }

        public static int CalculateTotalPrice(List<Pizza> inputList)
        {
            int totalPrice = 0;
            foreach (Pizza piz in inputList)
            {
                totalPrice += piz.PizzaPrice;
            }

            return totalPrice;
        }
        public static void AssignOrderID()
        {
            foreach (Order ord in OrderList)
            {
                ord.OrderID = OrderList.IndexOf(ord) + 1;
            }
        }
        public static void StartPurchase()
        {
            Console.Clear();
            bool isAddingPizzas = true;
            List<Pizza> NewOrderPizzas = new List<Pizza>();
            while (isAddingPizzas)
            {
                Console.Clear();
                Console.WriteLine($"Click any other button to proceed with purchase\n" +
                                  $"Select which pizza you want to buy:");
                Console.WriteLine($"Available Pizzas:");
                MenuCatalog.PrintPizza();
                Console.WriteLine($"\nYour selected pizzas");
                PrintNewOrder(NewOrderPizzas);
                int userPizzaInput = PizzaChoice(MenuCatalog.PizzaList);
                if (userPizzaInput != 0)
                {
                    NewOrderPizzas.Add(NewPizzaOrder(userPizzaInput));
                }
                else
                {
                    isAddingPizzas = false;
                }

                
            }
            Console.Clear();
            Console.WriteLine($"Are you a: \n" +
                              $"1: Returning customer\n" +
                              $"2: Guest");
            Customer newOrderCustomer = NewOrderCustomer();
            int newOrderTotalPrice = 0;
            foreach (Pizza piz in NewOrderPizzas)
            {
                newOrderTotalPrice += piz.PizzaPrice;
            }

            AddOrder(new Order(NewOrderPizzas, newOrderCustomer, newOrderTotalPrice));
            Console.WriteLine(OrderList[OrderList.Count-1]);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static Customer NewOrderCustomer()
        {
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Which customer are you?");
                        try
                        {
                            CustomerCatalog.PrintCustomer();
                            userInput = Convert.ToInt32(Console.ReadLine());
                            return CustomerCatalog.SelectCustomer(userInput);
                        }
                        catch
                        {
                            Console.WriteLine("Error, try again");
                            Console.ReadKey();
                            Console.Clear();
                            NewOrderCustomer();
                        }
                        break;
                    case 2:
                        return CustomerCatalog.CustomerList[0];
                }
            }
            catch
            {
                Console.WriteLine("Error, try again");
                Console.ReadKey();
                NewOrderCustomer();
            }

            return CustomerCatalog.CustomerList[0];
        }
        
        public static Pizza NewPizzaOrder(int userPizzaInput)
        {
            foreach (Pizza piz in MenuCatalog.PizzaList)
            {
                if (userPizzaInput == piz.PizzaNumber)
                {
                    return piz;
                }
            }

            Console.WriteLine("No pizza matched.. somehow");
            Console.ReadKey();
            return null;
        }
        public static int PizzaChoice(List<Pizza> pizzaItems)
        {
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (Pizza piz in MenuCatalog.PizzaList)
                {
                    if (userInput == MenuCatalog.PizzaList.IndexOf(piz) + 1)
                    {
                        return userInput;
                    }
                }
            }
            catch
            {
                return 0;
            }
            return 0;
        }

        public static void PrintNewOrder(List<Pizza> inputList)
        {
            foreach (Pizza piz in inputList)
            {
                Console.WriteLine(piz);
            }
        }

        public static void PrintOrders()
        {
            Console.Clear();
            Console.WriteLine($"Here are the previous orders:");
            foreach (Order ord in OrderList)
            {
                Console.WriteLine($"{ord}\n");
                Console.WriteLine("=================================");
            }
        }

        //public static Order SelectOrder()
        //{
        //    AssignOrderID();
        //    foreach (Order ord in OrderList)
        //    {
        //        Console.WriteLine($"{ord.OrderID} - {ord.OrderCustomer.CustomerName}" +
        //                          $"\nAntal Pizzaer: {ord.OrderPizzaList.Count}" +
        //                          $"\nTotalpris: {ord.OrderTotalPrice}");
        //    }

        //    try
        //    {
        //        int userInput = Convert.ToInt32(Console.ReadLine());
        //        foreach (Order ord in OrderList)
        //        {
        //            if (ord.OrderID == userInput)
        //            {
        //                return ord;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        SelectOrder();
        //    }

        //    SelectOrder();
        //    return null;
        //}
        //public static void EditOrder()
        //{
        //    Console.WriteLine($"Which order do you want to edit?");
        //    Order editOrder = SelectOrder();
        //    Console.Clear();
        //    Console.WriteLine("Which pizza do you want to edit?");
        //    Pizza editPizza = EditPizza(editOrder);
        //    Console.Clear();
        //    Console.WriteLine($"Pizza selected: {editPizza}");
        //    editPizza.PrintToppings();
        //    editOrder.ExtaTopping(editPizza);
        //}

        //public static Pizza EditPizza(Order inputOrder)
        //{
        //    foreach (Pizza piz in inputOrder.OrderPizzaList)
        //    {
        //        Console.WriteLine($"{inputOrder.OrderPizzaList.IndexOf(piz)} - {piz.PizzaName}");
        //    }

        //    try
        //    {
        //        int userInput = Convert.ToInt32(Console.ReadLine());
        //        foreach (Pizza piz in inputOrder.OrderPizzaList)
        //        {
        //            if (userInput == inputOrder.OrderPizzaList.IndexOf(piz))
        //            {
        //                return piz;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //    }

        //    return null;
        //}

        

    }
}

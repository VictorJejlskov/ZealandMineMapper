using System;
using System.Collections.Generic;
using System.Text;

namespace UML2MyOwn
{
    class Store
    {
        public static List<string> StartMenu = new List<string>()
        {
            "1. Add a new pizza to the menu.",
            "2. Delete a pizza from the menu.",
            "3. Update a given pizza on the menu",
            "4. Search for a pizza on the menu",
            "5. Diplay the available pizzas",
            "6. Add a new customer",
            "7. Delete a customer",
            "8. Update a customer",
            "9. Display the list of current customers",
            "10. Buy a pizza",
            "11. Display previous orders"
        };

        public static int MenuChoice(List<string> menuItems)
        {
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (string listString in menuItems)
                {
                    if (userInput == menuItems.IndexOf(listString)+1)
                    {
                        return userInput;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ugyldigt input");
                Console.ReadKey();
                Console.Clear();
                RunStore();
            }
            return 0;
        }
        public static void RunStore()
        {
            MenuCatalog.AssignPizzaNumber();
            CustomerCatalog.AssignCustomerNumber();
            Console.Clear();
            foreach (string menuValg in StartMenu)
            {
                Console.WriteLine(menuValg);
            }

            int userMenuChoice = MenuChoice(StartMenu);
            switch (userMenuChoice)
            {
                // Incase an invalid input was selected
                case 0:
                    Console.WriteLine("Ugyldigt input");
                    Console.ReadKey();
                    Console.Clear();
                    RunStore();
                    break; 
                //"1. Add a new pizza to the menu.",
                case 1:
                    Console.Clear();
                    MenuCatalog.ManuallyAddPizza();
                    break;
                //"2. Delete a pizza from the menu.",
                case 2:
                    Console.Clear();
                    MenuCatalog.DeletePizza();
                    break;
                //"3. Update a given pizza on the menu",
                case 3:
                    Console.Clear();
                    MenuCatalog.UpdatePizza();
                    break;
                //"4. Search for a pizza on the menu",
                case 4:
                    Console.Clear();
                    MenuCatalog.SearchPizza();
                    break;
                //"5. Diplay the available pizzas"
                case 5:
                    Console.Clear();
                    MenuCatalog.PrintPizza();
                    Console.ReadKey();
                    Console.Clear();
                    RunStore();
                    break;
                //"6. Add a new customer to the list of customers"
                case 6:
                    Console.Clear();
                    CustomerCatalog.ManuallyAddCustomer();
                    break;
                //"7. Delete a customer from the list of customers"
                case 7:
                    Console.Clear();
                    CustomerCatalog.DeleteCustomer();
                    break;

                //"8. Update a given customer from the list of customers"
                case 8:
                    Console.Clear();
                    CustomerCatalog.UpdateCustomer();
                    break;

                //"9. Display the list of current customers"
                case 9:
                    Console.Clear();
                    CustomerCatalog.PrintCustomer();
                    Console.ReadKey();
                    Console.Clear();
                    RunStore();
                    break;
                //"10. Buy a pizza"
                //Ask for customer / guest
                case 10:
                    OrderCatalog.StartPurchase();
                    RunStore();
                    break;
                //"11. Edit order"
                //case 11:
                //    OrderCatalog.EditOrder();
                //    break;
                case 11:
                    OrderCatalog.PrintOrders();
                    break;
            }
        }
    }
}

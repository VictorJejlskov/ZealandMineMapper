using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace UML2MyOwn
{
    class CustomerCatalog
    {
        public static Random rnd = new Random();
        public static List<Customer> CustomerList = new List<Customer>()
        {
            new Customer("Guest", 0),
            new Customer("Allan", 30, MenuCatalog.PizzaList[rnd.Next(0,10)]),
            new Customer("Thomas", 86),
            new Customer("Connor", 19, MenuCatalog.PizzaList[rnd.Next(0,10)]),
            new Customer("Søren", 53),
            new Customer("Sarah", 32, MenuCatalog.PizzaList[rnd.Next(0,10)])
        };

        public static void AssignCustomerNumber()
        {
            foreach (Customer cus in CustomerList)
            {
                cus.CustomerID = CustomerList.IndexOf(cus) + 1;
            }
        }

        ////"6. Add a new customer to the list of customers"
        //case 6:
        //Console.Clear();
        //CustomerCatalog.ManuallyAddCustomer();
        //break;
        public static void ManuallyAddCustomer()
        {
            int newCustomerAge = 0;
            Pizza newCustomerPizza = null;
            Console.WriteLine("Hvad kedder kunden?");
            string newCustomerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hvor gammel er kunden?");
            try
            {
                newCustomerAge = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ugyldigt input");
                Console.ReadKey();
                Store.RunStore();
            }
            Console.Clear();
            Console.WriteLine("Vælg kundens favorit pizza ved at taste tallet svarende til pizzaen\nHvis ikke kunden har en, indtast noget, som ikke er på listen");
            MenuCatalog.PrintPizza();
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                try
                {
                    foreach (Pizza piz in MenuCatalog.PizzaList)
                    {
                        if (userInput == piz.PizzaNumber)
                        {
                            newCustomerPizza = piz;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Ugyldigt input");
                    Console.ReadKey();
                    Store.RunStore();
                }
            }
            catch
            {
                Console.Clear();
                CustomerList.Add(new Customer(newCustomerName,newCustomerAge));
                Console.WriteLine($"Added customer: {newCustomerName}, age {newCustomerAge}, who has no favourite pizza, to the list");
                Console.ReadKey();
                Store.RunStore();
            }
            Console.Clear();
            CustomerList.Add(new Customer(newCustomerName, newCustomerAge, newCustomerPizza));
            Console.WriteLine($"Added customer: {newCustomerName}, age {newCustomerAge}, whose favourite pizza is '{newCustomerPizza.PizzaName}', to the list");
            Console.ReadKey();
            Store.RunStore();

        }
        ////"7. Delete a customer from the list of customers"
        //case 7:
        //Console.Clear();
        //CustomerCatalog.DeleteCustomer();
        //break;
        public static void DeleteCustomer()
        {
            PrintCustomer();
            Console.WriteLine("Hvilken kunde vil du slette, tryk på det gældende tal");
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                CustomerList.RemoveAt(userInput - 1);
                AssignCustomerNumber();
                Store.RunStore();
            }
            catch
            {
                Console.WriteLine("Ugyldigt input");
                Console.ReadKey();
                Store.RunStore();
            }
        }

        ////"8. Update a given customer from the list of customers"
        //case 8:
        //Console.Clear();
        //CustomerCatalog.UpdateCustomer();
        //break;
        public static void UpdateCustomer()
        {
            PrintCustomer();
            Console.WriteLine("Hvilken Kunde vil du opdatere? (Indtast nummeret for pizzaen)");
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (Customer cus in CustomerList)
                {
                    if (cus.CustomerID == userInput)
                    {
                        Console.WriteLine(cus);
                        Console.WriteLine("Hvad ønsker du at opdatere ved Kunden? 1: Navn | 2: Alder | 3: Favorit Pizza");
                        try
                        {
                            int userResponse = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (userResponse)
                            {
                                case 1:
                                    Console.WriteLine("Indtast det nye navn");
                                    cus.CustomerName = Console.ReadLine();
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.WriteLine("Indtast den nye alder");
                                        cus.CustomerAge = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ugyldigt input");
                                        Console.ReadKey();
                                        Store.RunStore();
                                    }
                                    break;
                                case 3:
                                    MenuCatalog.PrintPizza();
                                    Console.WriteLine("Indtast tallet for pizzaen, som kunden har som favorit");
                                    try
                                    {
                                        userInput = Convert.ToInt32(Console.ReadLine());
                                        foreach (Pizza piz in MenuCatalog.PizzaList)
                                        {
                                            if (userInput == piz.PizzaNumber)
                                            {
                                                cus.FavouritePizza = piz;
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ugyldigt input");
                                        Console.ReadKey();
                                        Store.RunStore();
                                    }
                                    Store.RunStore();
                                    break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Ugyldigt input");
                            Console.ReadKey();
                            Store.RunStore();
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ugyldigt input");
                Console.ReadKey();
                Store.RunStore();
            }
        }

        ////"9. Display the list of current customers"
        //case 9:
        //Console.Clear();
        //CustomerCatalog.PrintCustomer();

        public static void PrintCustomer()
        {
            foreach (Customer cus in CustomerList)
            {
                Console.WriteLine(cus);
            }
        }

        public static Customer AddNewCustomer()
        {
            Console.WriteLine($"Vil du købe som gæst, eller ny kunde\n1: Gæst | 2: ny kunde");
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    //Gæst
                    case 1:
                        return CustomerList[0];
                    case 2:
                        //Navn, Alder, FavoritPizza(ikke et must)
                        Console.WriteLine("Hvad er dit navn?");
                        string newCusName = Console.ReadLine();
                        Console.WriteLine("Hvor gammel er du?");
                        try
                        {
                            int newCusAge = Convert.ToInt32(Console.ReadLine());
                            Customer newCustomer = new Customer(newCusName, newCusAge);
                            return newCustomer;
                        }
                        catch
                        {
                            Console.WriteLine("Ugyldigt input");
                            Console.ReadKey();
                            return null;
                        }
                    default:
                        Console.WriteLine("Ugyldigt input");
                        Console.ReadKey();
                        return null;
                }
            }
            catch
            { 
                Console.WriteLine("Ugyldigt input");
                return null;
            }

        }

    }


}

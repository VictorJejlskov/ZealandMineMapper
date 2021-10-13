using System;
using System.Collections.Generic;
using System.Text;

namespace UML2Pizzaria
{
    class MenuCatalog
    {
        public static List<Pizza> PizzaList = new List<Pizza>();

        public static void AddPizza(Pizza newPizza)
        {
            PizzaList.Add(newPizza);
            AssignId();
        }

        public static void AssignId()
        {
            foreach (Pizza piz in PizzaList)
            {
                piz.PizzaId = PizzaList.IndexOf(piz) + 1;
            }
        }

        public static void UserAddPizza()
        {
            Console.WriteLine("Skriv pizzaens navn");
            string newPizzaName = Console.ReadLine();
            Console.WriteLine("Hvad koster pizzaen?");
            try
            {
                int newPizzaPrice = Convert.ToInt32(Console.ReadLine());
                PizzaList.Add(new Pizza(newPizzaName, newPizzaPrice));
                AssignId();
                Console.ReadKey();
                Store.RunStore();
            }
            catch
            {
                Console.WriteLine("Ugyldigt input");
                Console.ReadKey();
                Store.RunStore();
            }
        }

        public static void PrintPizza()
        {
            foreach (Pizza piz in PizzaList)
            {
                Console.WriteLine(piz);
            }
        }

        public static void UpdatePizza(int inputId, string newName, int newPrice)
        {
            foreach (Pizza piz in PizzaList)
            {
                if (piz.PizzaId == inputId)
                {
                    piz.UpdateName(newName);
                    piz.UpdatePrice(newPrice);
                }
            }
        }

        public static void RemovePizza(int inputId)
        {
            PizzaList.RemoveAt(inputId-1);
            AssignId();
        }

        public static void UserRemovePizza()
        {
            Console.Clear();
            PrintPizza();
           Console.WriteLine("Hvilken pizza skal slettes?");
           try
           {
               PizzaList.RemoveAt(Convert.ToInt32(Console.ReadLine())-1);
               AssignId(); 
               Console.Clear();
               PrintPizza();
               Console.ReadKey();
               Store.RunStore();
           }
           catch
           {
               Console.WriteLine("Ugyldigt input");
               Console.ReadKey();
               Store.RunStore();
           }
        }

        public static void UserUpdatePizza()
        {
            Console.Clear();
            PrintPizza();
            Console.WriteLine("Hvilken pizza skal opdateres?");
            try
            {
                int pizzaId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hvad skal pizzaen hedde?");
            }
            catch
            {
                Console.WriteLine("Ugyldigt input");
            }
            
            string newPizzaName = Console.ReadLine();
            Console.WriteLine("Hvad koster pizzaen?");
            try
            {
                int newPizzaPrice = Convert.ToInt32(Console.ReadLine());
                PizzaList.Add(new Pizza(newPizzaName, newPizzaPrice));
                AssignId();
                Console.ReadKey();
                Store.RunStore();
            }
            catch
            {
                Console.WriteLine("Ugyldigt input");
            }
        }

        public static void UserSearchPizza()
        {
            Console.Clear();
            PrintPizza();
            Console.WriteLine("Hvad hedder pizzaen?");
            try
            {

            }
            catch
            {
                Console.WriteLine("Ugyldigt input");
            }
        }
        public static void SearchPizza(string inputName)
        {
            foreach (Pizza piz in PizzaList)
            {
                if (piz.Name == inputName)
                {
                    Console.WriteLine(piz);
                }
            }
        }

        public static void Menu(int userInput)
        {
            switch (userInput)
            {
                case 1: 
                    UserAddPizza();
                    break;
                case 2: 
                    UserRemovePizza();
                    break;
                case 3: 
                    UserUpdatePizza();
                    break;
                case 4:
                    UserSearchPizza();
                    break;
                case 5: 
                    Console.Clear();
                    PrintPizza();
                    Console.ReadKey();
                    Store.RunStore();
                    break;
            }
        }
    }
    
}

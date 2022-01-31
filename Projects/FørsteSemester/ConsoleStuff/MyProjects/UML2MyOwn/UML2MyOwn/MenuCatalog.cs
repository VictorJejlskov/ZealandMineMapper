using System;
using System.Collections.Generic;
using System.Text;

namespace UML2MyOwn
{
    class MenuCatalog
    {
        public static List<string> AvailableToppings = new List<String>()
        {
            "Cheese", "Tomato Sauce", "Vegetables", "Pepperoni", "Chicken", "Ham", "Kebab", "Beef", "Pineapple", "Salad", "Dressing"
        };
        public static List<Pizza> PizzaList = new List<Pizza>()
        {
            new Pizza("Cheese Pizza", 35, new List<string>()
            {
                "Cheese", "Tomato Sauce"
            }),
            new Pizza("Veggie Pizza", 45,new List<string>()
            {
                "Cheese", "Tomato Sauce", "Vegetables"
            }),
            new Pizza("Pepperoni Pizza", 45,new List<string>()
            {
                "Cheese", "Tomato Sauce", "Pepperoni"
            }),
            new Pizza("Meatlovers Pizza", 55,new List<string>()
            {
                "Cheese", "Tomato Sauce", "Chicken", "Ham", "Kebab"
            }),
            new Pizza("Margherita Pizza", 45,new List<string>()
            {
                "Cheese", "Tomato Sauce"
            }),
            new Pizza("BBQ Chicken Pizza", 65,new List<string>()
            {
                "Cheese", "Tomato Sauce", "Chicken"
            }),
            new Pizza("Hawaiian Pizza", 45,new List<string>()
            {
                "Cheese", "Tomato Sauce", "Pineapple"
            }),
            new Pizza("Buffalo Pizza", 45,new List<string>()
            {
                "Cheese", "Tomato Sauce", "Ham"
            }),
            new Pizza("Supreme Pizza", 75,new List<string>()
            {
                "Cheese", "Tomato Sauce", "Vegetables", "Ham", "Beef"
            }),
            new Pizza("Salatpizza med Kebab", 65,new List<string>()
            {
                "Cheese", "Tomato Sauce", "Kebab", "Salad", "Dressing"
            }),
            new Pizza("Salatpizza med Kylling", 65,new List<string>()
            {
                "Cheese", "Tomato Sauce", "Chicken", "Salad", "Dressing"
            })
        };
        public static void AssignPizzaNumber()
        {
            foreach (Pizza piz in PizzaList)
            {
                piz.PizzaNumber = PizzaList.IndexOf(piz) + 1;
            }
        }
        public static void ManuallyAddPizza()
        {
            Console.WriteLine("Navnet på pizzaen?");
            string newPizzaName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hvad skal der på pizzaen? - tryk 'b' når du er færdig");
            foreach (string toppingList in AvailableToppings)
            {
                Console.WriteLine($"{AvailableToppings.IndexOf(toppingList)+1}. {toppingList}");
            }


            bool isAddingToppings = true;
            List<string> newPizzaToppingList = new List<string>();
            while (isAddingToppings)
            {
                string userInput = Console.ReadLine();
                try
                {
                    int toppingNumber = Convert.ToInt32(userInput);
                    if (toppingNumber <= AvailableToppings.Count)
                    {
                        newPizzaToppingList.Add(AddTopping(toppingNumber));
                        Console.WriteLine($"Added: {AddTopping(toppingNumber)} to the pizza");
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                catch
                {
                    if (userInput == "b" || userInput == "B")
                    {
                        isAddingToppings = false;
                    }
                }
            }
            Console.WriteLine("Hvad koster pizzaen?");
            try
            {
                int newPizzaPrice = Convert.ToInt32(Console.ReadLine());
                AddPizza(newPizzaName,newPizzaPrice,newPizzaToppingList);
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

        public static void AddPizza(string newPizzaName, int newPizzaPrice, List<string> newPizzaToppings)
        {
            PizzaList.Add(new Pizza(newPizzaName, newPizzaPrice, newPizzaToppings));
            AssignPizzaNumber();
        }

        public static void PrintPizza()
        {
            foreach (Pizza piz in PizzaList)
            {
                Console.WriteLine(piz);
            }
        }

        public static string AddTopping(int toppingNumber)
        {
            foreach (string pizzaTopping in AvailableToppings)
            {
                if (toppingNumber == AvailableToppings.IndexOf(pizzaTopping) + 1)
                {
                    return pizzaTopping;
                }
            }
            return "Error";
        }
        public static void UpdatePizza()
        {
            PrintPizza();
            Console.WriteLine("Hvilken Pizza vil du opdatere? (Indtast nummeret for pizzaen)");
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (Pizza piz in PizzaList)
                {
                    if (piz.PizzaNumber == userInput)
                    {
                        Console.WriteLine(piz);
                        Console.WriteLine("Hvad ønsker du at opdatere ved Pizzaen? 1: Navn | 2: Pris | 3: Toppings | 4: Navn & Pris");
                        try
                        {
                            int userResponse = Convert.ToInt32(Console.ReadLine());
                            switch (userResponse)
                            {
                                case 1:
                                    Console.WriteLine("Indtast det nye navn");
                                    piz.PizzaName = Console.ReadLine();
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.WriteLine("Indtast den nye pris");
                                        piz.PizzaPrice = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ugyldigt input");
                                        Console.ReadKey();
                                        Store.RunStore();
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine($"Selected pizza:\n{piz}\n");
                                    bool isEditingToppings = true;
                                    while (isEditingToppings)
                                    {
                                        try
                                        {
                                            Console.WriteLine($"Tryk en vilkårlig tast, som ikke er et tal, for at indikere at du er færdig");
                                            Console.WriteLine("Available toppings:");
                                            foreach (string pizzaTopping in AvailableToppings)
                                            {
                                                //"{AvailableToppings.IndexOf(toppingList)+1}. {toppingList}"
                                                Console.WriteLine($"{AvailableToppings.IndexOf(pizzaTopping)+1}. {pizzaTopping}");
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
                                            if (piz.PizzaToppings.Contains(AvailableToppings[userToppingInput-1]))
                                            {
                                                piz.PizzaToppings[userToppingInput-1] = $"{userToppingInput}";
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    piz.PizzaToppings[userToppingInput - 1] = $"{AvailableToppings[userToppingInput - 1]}";
                                                }
                                                catch
                                                {
                                                    piz.PizzaToppings.Add(AvailableToppings[userToppingInput-1]);
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
                                    Store.RunStore();

                                    break;
                                case 4:
                                    Console.WriteLine("Indtast det nye navn");
                                    piz.PizzaName = Console.ReadLine();
                                    Console.WriteLine("Indtast den nye pris");
                                    try
                                    {   
                                        piz.PizzaPrice = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ugyldigt input");
                                        Console.ReadKey();
                                        Store.RunStore();
                                    }
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
                Store.RunStore();
            }
            catch
            {
                Console.WriteLine("Ugyldigt input");
                Console.ReadKey();
                Store.RunStore();
            }
        }

        public static void DeletePizza()
        {
            PrintPizza();
            Console.WriteLine("Hvilken pizza vil du slette? (Indtast nummered for pizzaen)");
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                PizzaList.RemoveAt(userInput - 1);
                AssignPizzaNumber();
                Store.RunStore();
            }
            catch
            {
                Console.WriteLine("Ugyldigt input");
                Console.ReadKey();
                Store.RunStore();
            }
        }

        public static void SearchPizza()
        {
            Console.WriteLine("Søg på et del af et pizza-navn, fuldt pizza-navn eller en topping, eller dets tal\nHer er listen af mulige toppings:");
            foreach (string pizzaTopping in AvailableToppings)
            {
                Console.WriteLine($"{AvailableToppings.IndexOf(pizzaTopping) + 1}. {pizzaTopping}");
            }

            string userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Pizzaer baseret på pizzanavnet:");
            foreach (Pizza piz in PizzaList)
            {
                if (piz.PizzaName.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(piz);
                }
            }

            Console.WriteLine($"\nPizzaer baseret på ingredienser:");
            foreach (string topping in AvailableToppings)
            {
                if (topping.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    foreach (Pizza piz in PizzaList)
                    {
                        if (piz.PizzaToppings.Contains(topping))
                        {
                            Console.WriteLine(piz);
                        }
                    }
                }
            }
            try
            {
                foreach (Pizza piz in PizzaList)
                {
                    if (piz.PizzaToppings.Contains(AvailableToppings[Convert.ToInt32(userInput) - 1]))
                    {
                        Console.WriteLine(piz);
                    }
                }
            }
            catch
            {

            }

            Console.ReadKey();
            Store.RunStore();
        }

        public static void PrintToppings()
        {
            foreach (string pizzaTopping in AvailableToppings)
            {
                Console.WriteLine($"{AvailableToppings.IndexOf(pizzaTopping) + 1}. {pizzaTopping}");
            }
        }

    }
}

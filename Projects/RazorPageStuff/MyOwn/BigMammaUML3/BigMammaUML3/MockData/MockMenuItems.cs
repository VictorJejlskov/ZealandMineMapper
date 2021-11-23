using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using BigMammaUML3.Models;

namespace BigMammaUML3.MockData
{
    public class MockMenuItems
    {
        private static List<MenuItem> _menuItems = new List<MenuItem>()
        {
            new Pizza(false, 1, "Magherita", "Tomato & Cheese", 69),
            new Pizza(false, 2, "Vesuvio", "Tomato, cheese & ham", 75),
            new Pizza(false, 3, "Capricciosa", "Tomato, cheese, ham & mushrooms", 80),
            new Pizza(false, 4, "Calzone", "Baked Pizza with tomato, cheese, ham & mushrooms", 80),
            new Pizza(false, 5, "Quattro Stagioni", "Tomato, cheese, ham, mushrooms, shrimp & peppers", 85),
            new Pizza(false, 6, "Marinara", "Tomator, cheese, shrimp, mussels & garlic", 85),
            new Pizza(false, 7, "Vegetarian", "Tomato, cheese & vegetables", 80),
            new Pizza(false, 8, "Italiana", "Tomato, cheese, onion & meat sauce", 75),
            new Pizza(false, 9, "Gorgonzola", "Tomato gorgonzola, onion & mushroom", 85),
            new Pizza(false, 10, "Contadina", "Tomato, cheese, mushrooms & olives", 75),
            new Pizza(false, 11, "Naples", "Tomato, cheese, anchovies & olives", 79),
            new Pizza(false, 12, "Vichinga", "Tomato, cheese, ham, mushrooms, peppers, garlic & chili (strong)", 80),
            new Pizza(false, 13, "Calzone Special", "(Not Baked) tomato, cheese, shrimp, ham & meat sauce", 80),
            new Pizza(false, 14, "Esotica", "Tomato, cheese, ham, shrimp & pineapple", 80),
            new Pizza(false, 15, "Tonno", "Tomato, cheese, tuna & shrimp", 85),
            new Pizza(false, 16, "Sardegna", "Tomato, cheese, cocktail sausages, bacon, onions & eggs", 80),
            new Pizza(false, 17, "Romana", "Tomato, cheese, ham, bacon & onion", 78),
            new Pizza(false, 18, "Sole", "Tomato, cheese, ham, bacon & eggs", 78),
            new Pizza(false, 19, "Big Mamma", "Tomato, gorgonzola, shrimp, aspargus & parma ham", 90),
            new Pizza(true, 20, "Magherita", "Tomato & Cheese", 69),
            new Pizza(true, 21, "Vesuvio", "Tomato, cheese & ham", 75),
            new Pizza(true, 22, "Capricciosa", "Tomato, cheese, ham & mushrooms", 80),

            new Beverage(false, 23, "Sodavand 0.33 L dåse", "Valg af: Coca-Cola, Coca-Cola Zero, Egekilde, Fanta, Faxe Kondi og flere.", 16),
            new Beverage(false, 24, "Sodavand 0.50 L", "Valg af: Coca-Cola, Coca-Cola Zero, Fanta, Faxe Kondi og flere.", 26),
            new Beverage(false, 25, "Sodavand 1.50 L", "Valg af: Coca-Cola, Coca-Cola Zero, Fanta, Faxe Kondi og flere.", 36),
            new Beverage(false, 26, "Cocio", "Chokolade-drik", 21),
            new Beverage(false, 27, "Red Bull", "Energi-drik", 21),
            new Beverage(true, 28, "Øl Dåse", "Tuborg", 21),
            new Beverage(true, 29, "Vin Flaske", "Valg af: Hvidvin eller Rødvin", 60),
        };

        public static List<MenuItem> GetMenuItems()
        {
            return _menuItems;
        }
    }
}

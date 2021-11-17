using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV1.PizzaCatalogs;

namespace Pizza_StoreV1
{
    public class GetAllPizzasModel : PageModel
    {
        private PizzaCatalog catalog;

        public GetAllPizzasModel()
        {
            catalog = new PizzaCatalog();
        }
        public Dictionary<int, Models.Pizza> Pizzas { get; set; }

        public IActionResult OnGet()
        {
            Pizzas = catalog.AllPizzas();
            return Page();
        }
    }
}
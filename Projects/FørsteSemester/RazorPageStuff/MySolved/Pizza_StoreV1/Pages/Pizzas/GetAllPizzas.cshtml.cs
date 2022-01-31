using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV1.Models;
using Pizza_StoreV1.Service;

namespace Pizza_StoreV1
{
    public class GetAllPizzasModel : PageModel
    {
        private PizzaService _pizzaService;
        public GetAllPizzasModel(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        public Dictionary<int, Pizza> Pizzas { get; private set; }



        public IActionResult OnGet()
        {
            Pizzas = _pizzaService.GetPizzas();
            return Page();
        }
    }
}
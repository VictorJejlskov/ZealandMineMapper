using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV1.Models;
using Pizza_StoreV1.Service;

namespace Pizza_StoreV1.Pages.Pizzas
{
    public class CreatePizzaModel : PageModel
    {
        [BindProperty] public Pizza Pizza { get; set; }
        private PizzaService _pizzaService;

        public CreatePizzaModel(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _pizzaService.AddPizza(Pizza);
            return RedirectToPage("GetAllPizzas");
        }
    }
}

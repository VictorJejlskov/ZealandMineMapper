﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Pizza_StoreV7.Interfaces;
using Pizza_StoreV7.Models;

namespace Pizza_StoreV7
{
    public class DeletePizzaModel : PageModel
    {
       
        [BindProperty]
        public Pizza Pizza { get; set; }
        private IPizzaRepository catalog;
        public DeletePizzaModel(IPizzaRepository repository)
        {
            catalog = repository;
        }
        public IActionResult OnGet(int id)
        {
            Pizza = catalog.GetPizza(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            catalog.DeletePizza(Pizza);
            return  RedirectToPage("GetAllPizzas");
        }
    }
}
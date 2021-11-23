using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigMammaUML3.Models;
using BigMammaUML3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMammaUML3.Pages.MenuItems
{
    public class CreateBeverageModel : PageModel
    {

        private MenuCatalog _menuCatalog;
        public CreateBeverageModel(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }
        [BindProperty] public Beverage NewBeverage { get; set; }

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
            _menuCatalog.Add(NewBeverage);
            return RedirectToPage("GetAllMenuItems");
        }
    }
}

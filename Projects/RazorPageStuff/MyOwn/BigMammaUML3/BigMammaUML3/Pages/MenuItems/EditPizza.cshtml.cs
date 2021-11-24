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
    public class EditPizzaModel : PageModel
    {
        private MenuCatalog _menuCatalog;

        public EditPizzaModel(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }
        [BindProperty] public MenuItem MenuItem { get; set; }
        public void OnGet(int number)
        {
            MenuItem = _menuCatalog.Search(number);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigMammaUML3.Models;
using BigMammaUML3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BigMammaUML3.Pages.MenuItems
{
    public class CreateMenuItemModel : PageModel
    {
        public int TypeID { get; set; }
        public List<SelectListItem> NewItemType { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem {Value = "1", Text = "Pizza"},
            new SelectListItem {Value = "2", Text = "Beverage"}
        };
        private MenuCatalog _menuCatalog;

         public MenuItem NewMenuItem { get; set; }

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

            if (TypeID == 1)
            {
                Pizza piz = (Pizza)NewMenuItem;
                _menuCatalog.Add(piz);
                return RedirectToPage("GetAllMenuItems");
            }
            Beverage bev = (Beverage) NewMenuItem;
            _menuCatalog.Add(bev);
            return RedirectToPage("GetAllMenuItems");
        }
    }
}

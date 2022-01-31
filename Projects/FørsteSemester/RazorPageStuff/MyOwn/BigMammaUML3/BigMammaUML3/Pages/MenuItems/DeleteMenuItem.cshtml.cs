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
    public class DeleteMenuItemModel : PageModel
    {
        private MenuItem _searchedItem;
        public MenuItem SearchedItem { get; private set; }
        private MenuCatalog _menuCatalog;

        public DeleteMenuItemModel(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }

        public IActionResult OnGet(int id)
        {
            _searchedItem = _menuCatalog.Search(id);
            SearchedItem = _searchedItem;
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            _menuCatalog.Delete(id);
            return RedirectToPage("GetAllMenuItems");
        }
    }
}

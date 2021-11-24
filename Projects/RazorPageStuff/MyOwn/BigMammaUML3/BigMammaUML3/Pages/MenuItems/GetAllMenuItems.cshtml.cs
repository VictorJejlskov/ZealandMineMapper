using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigMammaUML3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMammaUML3.Pages.MenuItems
{
    public class GetAllMenuItemsModel : PageModel
    {
        public List<Models.MenuItem> MenuItems { get; private set; }
        private MenuCatalog _menuCatalog;
        [BindProperty] public string SearchInput { get; set; }
        public GetAllMenuItemsModel(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }
        public void OnGet()
        {
            MenuItems = _menuCatalog.GetAll();
        }

        public void OnPostShowAll()
        {
            MenuItems = _menuCatalog.GetAll();
        }        
        public void OnPostFindDeepPan()
        {
            MenuItems = _menuCatalog.FindAllDeepPan();
        }        
        public void OnPostAlcoholic()
        {
            MenuItems = _menuCatalog.FindAllNonAlcoholic();
        }        
        public void OnPostMostExpensive()
        {
            MenuItems = _menuCatalog.MostExpensiveMenuItem();
        }
        public void OnPostNameSearch()
        {
            MenuItems = _menuCatalog.SearchByName(SearchInput);
        }
        public void OnPostDescriptionSearch()
        {
            MenuItems = _menuCatalog.SearchByDescription(SearchInput);
        }
    }
}

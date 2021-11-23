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

        public GetAllMenuItemsModel(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }
        public void OnGet()
        {
            MenuItems = _menuCatalog.GetAll();
        }

        public void OnPostMethod1()
        {
            MenuItems = _menuCatalog.GetAll();
        }        
        public void OnPostMethod2()
        {
            MenuItems = _menuCatalog.FindAllDeepPan();
        }        
        public void OnPostMethod3()
        {
            MenuItems = _menuCatalog.FindAllNonAlcoholic();
        }        
        public void OnPostMethod4()
        {
            MenuItems = _menuCatalog.MostExpensiveMenuItem();
        }
    }
}

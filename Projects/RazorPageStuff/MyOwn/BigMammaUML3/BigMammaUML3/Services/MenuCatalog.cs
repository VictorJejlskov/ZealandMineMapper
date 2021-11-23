using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigMammaUML3.MockData;
using BigMammaUML3.Models;

namespace BigMammaUML3.Services
{
    public class MenuCatalog : IMenuCatalog
    {

        private List<MenuItem> _menuItems;

        public MenuCatalog()
        {
            _menuItems = MockMenuItems.GetMenuItems();
        }

        public List<MenuItem> GetAll()
        {
            return _menuItems;
        }

        public void Add(MenuItem aMenuItem)
        {
            _menuItems.Add(aMenuItem);
        }

        public MenuItem Search(int number)
        {
            throw new NotImplementedException();
        }

        public void Delete(int number)
        {
            throw new NotImplementedException();
        }


        public void Update(int number, MenuItem theMenuItem)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> FindAllDeepPan()
        {
            List<MenuItem> tempList = new List<MenuItem>();
            foreach (MenuItem menuItem in GetAll())
            {
                if (menuItem is Pizza && ((Pizza)menuItem).DeepPan)
                {
                    tempList.Add(menuItem);
                }
            }
            return tempList;
        }

        public List<MenuItem> FindAllNonAlcoholic()
        {
            List<MenuItem> tempList = new List<MenuItem>();
            foreach (MenuItem menuItem in GetAll())
            {
                if (menuItem is Beverage && ((Beverage)menuItem).Alcohol)
                {
                    tempList.Add(menuItem);
                }
            }
            return tempList;
        }

        public List<MenuItem> MostExpensiveMenuItem()
        {
            List<MenuItem> tempList = new List<MenuItem>();
            MenuItem tempItem = GetAll()[0];
            foreach (MenuItem menuItem in GetAll())
            {
                if (tempItem.Price < menuItem.Price)
                {
                    tempItem = menuItem;
                }
            }
            tempList.Add(tempItem);
            return tempList;
        }


    }
}

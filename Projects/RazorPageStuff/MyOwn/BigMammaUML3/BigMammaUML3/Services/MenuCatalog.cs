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
        private JsonFileItemService JsonFileItemService { get; set; }

        public MenuCatalog(JsonFileItemService jsonFileItemService)
        {
            JsonFileItemService = jsonFileItemService;
            //_menuItems = MockMenuItems.GetMenuItems();
            _menuItems = JsonFileItemService.GetJsonItems().ToList();
        }

        public List<MenuItem> GetAll()
        {
            return _menuItems;
        }

        public void AssignID()
        {
            foreach (MenuItem menIt in _menuItems)
            {
                menIt.Number = _menuItems.IndexOf(menIt)+1;
            }
        }

        public void SortByID(List<MenuItem> menuItems)
        {
            menuItems.Sort();
        }

        public void Add(MenuItem aMenuItem)
        {
            _menuItems.Add(aMenuItem);
            AssignID();
            JsonFileItemService.SaveJsonItems(_menuItems);
        }

        public MenuItem Search(int number)
        {
            foreach (MenuItem menuItem in _menuItems)
            {
                if (number == menuItem.Number)
                {
                    return menuItem;
                }
            }
            return null;
        }

        public List<MenuItem> SearchByName(string str)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> SearchByDescription(string str)
        {
            List<MenuItem> searchList = new List<MenuItem>();
            if (string.IsNullOrEmpty(str)) return _menuItems;
            foreach (MenuItem menuItem in _menuItems)
            {
                if (menuItem.Description.ToLower().Contains(str.ToLower()))
                {
                    searchList.Add(menuItem);
                }
            }
            return searchList;
        }

        public void Delete(int number)
        {
            _menuItems.RemoveAt(number-1);
            AssignID();
            JsonFileItemService.SaveJsonItems(_menuItems);
        }


        public void Update(int number, MenuItem theMenuItem)
        {
            MenuItem searchitem = Search(number);
            searchitem = theMenuItem;
            searchitem.UpdateDescription();
            JsonFileItemService.SaveJsonItems(_menuItems);
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

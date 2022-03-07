using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemRazor.Comperators;
using ItemRazor.Models;
using ItemRazor.MockData;


namespace ItemRazor.Services
{
    public class ItemService : IItemService
    {

        private List<Item> items;
        private JsonFileItemService JsonFileItemService { get; set; }

        public ItemService(JsonFileItemService jsonFileItemService)
        {
            JsonFileItemService = jsonFileItemService;
            //items = MockItems.GetMockItems();
            items = JsonFileItemService.GetJsonItems().ToList();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            JsonFileItemService.SaveJsonItems(items);
        }

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(int id)
        {
            foreach (Item item in items)
            {
                if (item.Id == id) return item;
            }
            return null;
        }

        public Item DeleteItem(int itemId)
        {
            Item itemToBeDeleted = null;
            foreach (Item i in items)
            {
                if (i.Id == itemId)
                {
                    itemToBeDeleted = i;
                    break;
                }
            }
            if (itemToBeDeleted != null)
            {
                items.Remove(itemToBeDeleted);
                JsonFileItemService.SaveJsonItems(items);
            }
            return itemToBeDeleted;
        }


        public void UpdateItem(Item item)
        {
            if (item != null)
            {
                foreach (Item i in items)
                {
                    if (i.Id == item.Id)
                    {
                        i.Name = item.Name;
                        i.Price = item.Price;
                    }
                }
                JsonFileItemService.SaveJsonItems(items);
            }
        }

        public IEnumerable<Item> NameSearch(string str)
        {
            var nameSearch = items.Where(i => i.Name.ToLower().Contains(str.ToLower()));
            return nameSearch;
        }

        public IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0)
        {
            var filterList = items.Where(i => (i.Price >= maxPrice && i.Price <= minPrice));
            return filterList;
        }

        public IEnumerable<Item> SortById()
        {
            var sortedList = items.OrderBy(it => it.Id);
            return sortedList;
        }

        public IEnumerable<Item> SortByIdDescending()
        {
            var sortedList = items.OrderByDescending(it => it.Id);
            return sortedList;
        }
        public IEnumerable<Item> SortByName()
        {
            var sortedList = items.OrderBy(it => it.Name);
            return sortedList;
        }

        public IEnumerable<Item> SortByNameDescending()
        {
            var sortedList = items.OrderByDescending(it => it.Name);
            return sortedList;
        }

        public IEnumerable<Item> SortByPrice()
        {
            var sortedList = items.OrderBy(it => it.Price);
            return sortedList;
        }

        public IEnumerable<Item> SortByPriceDescending()
        {
            var sortedList = items.OrderByDescending(it => it.Price);
            return sortedList;
        }




        //Page Pagination
        public async Task<List<Item>> GetPaginatedResult(int currentPage, int pageSize = 10)
        {
            var data = items;
            return data.OrderBy(d => d.Id).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public async Task<int> GetCount()
        {
            return items.Count;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemRazorV1.MockData;
using ItemRazorV1.Models;

namespace ItemRazorV1.Service
{
    public class ItemService : IItemService
    {
        private List<Item> _items;

        public ItemService()
        {
            _items = MockItems.GetAllItems();
        }

        public List<Item> GetItems()
        {
            return _items;
        }

        public void AddItem(Item inputItem)
        {
            _items.Add(inputItem);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemRazorV1.MockData;
using ItemRazorV1.Models;

namespace ItemRazorV1.Service
{
    interface IItemService
    {
        public List<Item> GetItems();
        public void AddItem(Item inputItem);
    }
}

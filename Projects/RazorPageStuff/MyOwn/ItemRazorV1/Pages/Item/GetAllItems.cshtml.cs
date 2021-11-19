using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemRazorV1.MockData;
using ItemRazorV1.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV1.Pages.Item
{
    public class GetAllItemsModel : PageModel
    {
        public List<Models.Item> Items { get; private set; }
        private ItemService _itemService;

        public GetAllItemsModel(ItemService itemService)
        {
            _itemService = itemService;
        }
        public void OnGet()
        {
            Items = _itemService.GetItems();
        }
    }
}

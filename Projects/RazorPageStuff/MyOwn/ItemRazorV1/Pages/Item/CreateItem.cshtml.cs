using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemRazorV1.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV1.Pages.Item
{
    public class CreateItemModel : PageModel
    {
        private ItemService _itemService;
        [BindProperty] public Models.Item Item { get; set; }

        public CreateItemModel(ItemService itemService)
        {
            _itemService = itemService;
        }
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
            _itemService.AddItem(Item);
            return RedirectToPage("GetAllItems");
        }
    }
}

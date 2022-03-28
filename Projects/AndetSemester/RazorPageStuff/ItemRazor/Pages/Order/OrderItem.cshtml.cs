using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemRazor.Models;
using ItemRazor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazor.Pages.Order
{
    public class OrderItemModel : PageModel
    {
        private ItemService _itemService;
        private UserService _userService;
        private OrderService _orderService;
        public Models.User OrderUser { get; set; }
        public Models.Item Item { get; set; }
        public Models.Order Order { get; set; } = new Models.Order();
        [BindProperty]public int Count { get; set; }

        public OrderItemModel(ItemService itemService, UserService userService, OrderService orderService)
        {
            _itemService = itemService;
            _userService = userService;
            _orderService = orderService;
        }
        public void OnGet(int id)
        {
            Item = _itemService.GetItem(id);
            OrderUser = _userService.GetUserByUserName(HttpContext.User.Identity.Name);
        }

        public async Task<IActionResult> OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Item = _itemService.GetItem(id);
            OrderUser = _userService.GetUserByUserName(HttpContext.User.Identity.Name);
            Order.UserId = OrderUser.UserId;
            Order.ItemId = Item.Id;
            Order.Date = DateTime.Now;
            Order.Count = Count;
            await _orderService.AddOrder(Order);
            return RedirectToPage("../Item/GetAllItems");
        }
    }
}

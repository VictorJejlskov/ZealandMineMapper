using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemRazor.DAO;
using ItemRazor.Models;
using ItemRazor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazor.Pages.Order
{
    public class MyOrdersModel : PageModel
    {
        private UserService _userService;
        public List<OrderDAO> Orders { get; set; }

        public MyOrdersModel(UserService userService)
        {
            _userService = userService;
        }
        public void OnGet()
        {
            User currentUser = _userService.GetUserByUserName(HttpContext.User.Identity.Name);
            Orders = _userService.GetUserOrders(currentUser);
        }
    }
}

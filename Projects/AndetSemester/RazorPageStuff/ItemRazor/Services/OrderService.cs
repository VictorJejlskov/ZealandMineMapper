using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemRazor.Models;

namespace ItemRazor.Services
{
    public class OrderService
    {
        public List<Order> Orders { get; set; }
        private DbGenericService<Order> _orderService;

        public OrderService(DbGenericService<Order> orderService)
        {
            _orderService = orderService;
            Orders = _orderService.GetObjectsAsync().Result.ToList();
        }

        public async Task AddOrder(Order ord)
        {
            Orders.Add(ord);
            //using (var context = new ItemDbContext())
            //{
            //    ord.Items.Remove(ord.Items[0]);
            //    context.Set<Order>().Add(ord);
            //    await context.SaveChangesAsync();
            //}
            await _orderService.AddObjectAsync(ord);
        }

    }
}

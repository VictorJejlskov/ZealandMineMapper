using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemRazor.DAO;
using ItemRazor.Models;

namespace ItemRazor.Services
{
    public class UserDbService : DbGenericService<User>
    {
        public async Task<List<OrderDAO>> GetOrdersByIdAsync(int id)
        {
            using (var context = new ItemDbContext())
            {
                var orders = from order in context.Orders
                    join item in context.Items on order.ItemId equals item.Id
                    join user in context.Users on order.UserId equals user.UserId
                    where user.UserId == id
                    select new OrderDAO()
                    {
                        OrderId = order.OrderId,
                        Date = order.Date,
                        UserId = user.UserId,
                        UserName = user.UserName,
                        ItemId = item.Id,
                        ItemName = item.Name,
                        Price = item.Price,
                        Count = order.Count
                    };
                List<OrderDAO> orderList = new List<OrderDAO>();
                foreach (var ord in orders)
                {
                    orderList.Add(ord);
                }

                return orderList;
            }
        }
    }
}

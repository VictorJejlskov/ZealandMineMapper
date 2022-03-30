using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemRazor.Models;

namespace ItemRazor.DAO
{
    public class OrderDAO
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public List<OrderLine> Items { get; set; }
    }
}

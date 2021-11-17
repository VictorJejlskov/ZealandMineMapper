using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemRazorV1.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public Item()
        {
            
        }

        public Item(int itemId, string itemName, double itemPrice)
        {
            ItemID = itemId;
            ItemName = itemName;
            ItemPrice = itemPrice;
        }
    }
}

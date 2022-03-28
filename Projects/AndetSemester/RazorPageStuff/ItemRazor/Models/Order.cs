using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItemRazor.Models
{
    public class Order
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy")]
        public DateTime Date { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int ItemId { get; set; }
        public Item Item { get; set; }
        [Range(1, 10000)]
        public int Count { get; set; }

        public Order()
        {
            
        }

        public Order(User user, Item item)
        {
            Date = DateTime.Now;
            User = user;
            Item = item;
        }
    }
}

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
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

        public Order()
        {
            
        }

        public Order(User user, List<OrderLine> items)
        {
            Date = DateTime.Now;
            User = user;
            OrderLines = items;
        }
    }
}

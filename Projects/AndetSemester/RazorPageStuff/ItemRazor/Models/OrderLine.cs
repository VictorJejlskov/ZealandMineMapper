using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItemRazor.Models
{
    public class OrderLine
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderLineId { get; set; }
        [Required]
        public int ItemId { get; set; }
        [NotMapped]
        public Item Item { get; set; }
        [Range(1, 10000)]
        public int Count { get; set; }
    }
}

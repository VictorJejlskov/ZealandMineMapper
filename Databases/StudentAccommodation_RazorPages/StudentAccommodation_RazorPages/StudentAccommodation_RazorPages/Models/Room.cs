using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAccommodation_RazorPages.Models
{
    public class Room
    {
        [Required]
        public int Room_No { get; set; }

        [Required]
        public int Dormitory_No { get; set; }

        public char Types { get; set; }
        public float Price { get; set; }
    }
}

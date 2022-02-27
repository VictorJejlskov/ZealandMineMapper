using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAccommodation_RazorPages.Models
{
    public class Leasing
    {
        public int Leasing_No { get; set; }
        public int Dormitory_No { get; set; }
        public int Student_No { get; set; }
        public DateTime Date_From { get; set; }
        public string DateFromString { get; set; }
        public DateTime Date_To { get; set; }
        public string DateToString { get; set; }
        public int Room_No { get; set; }
    }
}

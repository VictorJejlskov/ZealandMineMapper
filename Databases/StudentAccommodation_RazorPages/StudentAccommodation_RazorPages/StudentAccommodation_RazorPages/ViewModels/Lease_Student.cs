using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAccommodation_RazorPages.ViewModels
{
    public class Lease_Student
    {
        public string DormName { get; set; }
        public int RoomId { get; set; }
        public DateTime DateStart { get; set; }
        public string DateStartString { get; set; }
        public DateTime DateEnd { get; set; }
        public string DateEndString { get; set; }
        public string StudentName { get; set; }
        public char RoomTypes { get; set; }
        public float RoomPrice { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAccommodation_RazorPages.ViewModels
{
    public class Student_Room
    {
        public string StudentName { get; set; }
        public int RoomNo { get; set; }
        public char RoomType { get; set; }
        public DateTime StartDate { get; set; }
        public string DateString { get; set; }
        public string DormName { get; set; }
    }
}
using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAccommodation_RazorPages.Services.RoomService;

namespace StudentAccommodation_RazorPages.Services.DormitoryService
{
    public class DormitoryService : IDormitoryService

    {
        public IEnumerable<Dormitory> GetDormitories()
        {
            return ADO_Dormitory.GetDormitories();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAccommodation_RazorPages.Models;

namespace StudentAccommodation_RazorPages.Services.Interfaces
{
    public interface IRoomService
    {
        IEnumerable<Room> GetRooms();
    }
}

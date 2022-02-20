using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAccommodation_RazorPages.Services.RoomService
{
    public class RoomService : IRoomService
    {
        public IEnumerable<Room> GetRooms()
        {
            return ADO_Room.GetRooms();
        }
    }
}

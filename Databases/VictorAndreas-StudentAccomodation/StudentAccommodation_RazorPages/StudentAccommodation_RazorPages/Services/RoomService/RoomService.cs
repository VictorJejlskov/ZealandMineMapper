using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAccommodation_RazorPages.ViewModels;

namespace StudentAccommodation_RazorPages.Services.RoomService
{
    public class RoomService : IRoomService
    {
        public IEnumerable<Room> GetRooms()
        {
            return ADO_Room.GetRooms();
        }
        public IEnumerable<Room> GetRoomsPerDormitory(int dormId)
        {
            List<Room> tempList = new List<Room>();
            foreach (Room room in ADO_Room.GetRooms())
            {
                if (room.Dormitory_No == dormId)
                {
                    tempList.Add(room);
                }
            }
            return tempList;
        }
    }
}

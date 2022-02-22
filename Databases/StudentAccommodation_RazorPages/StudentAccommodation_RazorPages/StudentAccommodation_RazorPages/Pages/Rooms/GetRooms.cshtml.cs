using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.Models;

namespace StudentAccommodation_RazorPages.Pages.Rooms
{
    public class GetRoomsModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public string FilterCriteria { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
        private IRoomService _roomService;

        public GetRoomsModel(IRoomService roomService)
        {
            _roomService = roomService;
        }


        public void OnGet()
        {
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                //FilterMethod
            }
            else
                Rooms = _roomService.GetRooms();
        }

        public void OnGetDormRooms(int id)
        {
            Rooms = _roomService.GetRoomsPerDormitory(id);
        }

        public void OnGetSpecificDorm(List<string> test)
        {

        }
    }
}

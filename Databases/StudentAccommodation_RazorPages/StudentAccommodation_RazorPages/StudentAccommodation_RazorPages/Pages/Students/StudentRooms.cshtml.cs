using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.ViewModels;

namespace StudentAccommodation_RazorPages.Pages.Students
{
    public class StudentRoomsModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public string FilterCriteria { get; set; }
        public IEnumerable<Student_Room> StudentRooms { get; set; }
        private IStudentService _studentService;
        public void OnGet()
        {
        }
    }
}

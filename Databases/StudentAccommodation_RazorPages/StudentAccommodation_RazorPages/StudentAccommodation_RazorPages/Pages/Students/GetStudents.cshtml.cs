using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.Models;

namespace StudentAccommodation_RazorPages.Pages.Students
{
    public class GetStudentsModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public string FilterCriteria { get; set; }
        public IEnumerable<Student> Students { get; set; }
        private IStudentService _studentService;

        public GetStudentsModel(IStudentService studentService)
        {
            _studentService = studentService;
        }


        public void OnGet()
        {
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                //FilterMethod
            }
            else
                Students = _studentService.GetStudents();
        }

        public void OnGetDeleteStudent(int id)
        {
            _studentService.DeleteStudent(_studentService.GetStudentById(id));
            Students = _studentService.GetStudents();
        }
    }
}

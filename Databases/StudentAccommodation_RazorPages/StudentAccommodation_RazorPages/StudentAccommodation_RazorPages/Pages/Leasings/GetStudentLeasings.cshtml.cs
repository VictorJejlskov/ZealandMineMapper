using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.ViewModels;

namespace StudentAccommodation_RazorPages.Pages.Leasings
{
    public class GetStudentLeasingsModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public string FilterCriteria { get; set; }
        public IEnumerable<Lease_Student> LeaseStudents { get; set; }
        private IStudentService _studentService;

        public GetStudentLeasingsModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public void OnGet()
        {
        }

        public void OnGetLeasingsAndStudents(int did, int rid)
        {
            LeaseStudents = _studentService.GetLeasesStudents(did, rid);
        }
    }
}

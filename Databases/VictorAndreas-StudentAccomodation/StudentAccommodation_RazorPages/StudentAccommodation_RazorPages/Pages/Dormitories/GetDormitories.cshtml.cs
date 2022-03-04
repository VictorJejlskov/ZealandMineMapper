using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.CompilerServices;
using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.Models;

namespace StudentAccommodation_RazorPages.Pages.Dormitories
{
    public class GetDormitoriesModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public string FilterCriteria { get; set; }
        [BindProperty(SupportsGet = true)] public string Semester { get; set; }
        public IEnumerable<Dormitory> Dormitories { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        private IDormitoryService _dormitoryService;

        public GetDormitoriesModel(IDormitoryService dormitoryService)
        {
            _dormitoryService = dormitoryService;
        }


        public void OnGet()
        {
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                //FilterMethod
            }
            else
                Dormitories = _dormitoryService.GetDormitories();
        }

        public IActionResult OnPost()
        {
            List<string> filterList = new List<string>();
            filterList.Add(FilterCriteria);
            switch (Semester)
            {
                case "1stSemester":
                    filterList.Add("20190101");
                    break;
                case "2ndSemester":
                    filterList.Add("20190701");
                    break;
                case "3rdSemester":
                    filterList.Add("20200101");
                    break;
                case "4thSemester":
                    filterList.Add("20200701");
                    break;
            }
            return RedirectToPage("/Students/StudentRooms", "SpecificDorm", new { filterList });

        }
    }
}

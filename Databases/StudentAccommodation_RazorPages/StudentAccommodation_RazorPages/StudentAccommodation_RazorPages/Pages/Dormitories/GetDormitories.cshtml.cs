using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.Models;

namespace StudentAccommodation_RazorPages.Pages.Dormitories
{
    public class GetDormitoriesModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public string FilterCriteria { get; set; }
        public IEnumerable<Dormitory> Dormitories { get; set; }
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
    }
}

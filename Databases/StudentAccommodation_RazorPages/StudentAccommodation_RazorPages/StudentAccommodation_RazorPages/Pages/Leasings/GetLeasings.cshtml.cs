using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.Models;

namespace StudentAccommodation_RazorPages.Pages.Leasings
{
    public class GetLeasingsModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public string FilterCriteria { get; set; }
        public IEnumerable<Leasing> Leasings { get; set; }
        private ILeasingService _leasingService;

        public GetLeasingsModel(ILeasingService leasingService)
        {
            _leasingService = leasingService;
        }

        public void OnGet()
        {
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                //FilterMethod
            }
            else
                Leasings = _leasingService.GetLeasings();
        }
    }
}

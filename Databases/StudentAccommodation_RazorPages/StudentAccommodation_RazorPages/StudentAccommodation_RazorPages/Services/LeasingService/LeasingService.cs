using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAccommodation_RazorPages.Services.LeasingService
{
    public class LeasingService : ILeasingService
    {
        public IEnumerable<Leasing> GetLeasings()
        {
            return ADO_Leasing.GetLeasing();
        }
    }
}

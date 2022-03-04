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

        public IEnumerable<Leasing> GetLeasingPerStudent(int id)
        {
            List<Leasing> tempList = new List<Leasing>();
            foreach (Leasing lease in GetLeasings())
            {
                if (lease.Student_No == id)
                {
                    tempList.Add(lease);
                }
            }

            return tempList;
        }
    }
}

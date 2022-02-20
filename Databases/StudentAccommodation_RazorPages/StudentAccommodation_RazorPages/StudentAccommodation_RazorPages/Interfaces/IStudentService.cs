using StudentAccommodation_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAccommodation_RazorPages.Interfaces
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetStudents();
    }
}

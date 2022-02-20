using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAccommodation_RazorPages.Services.StudentService
{
    public class StudentService : IStudentService
    {
        public IEnumerable<Student> GetStudents()
        {
            return ADO_Student.GetStudents();
        }
    }
}

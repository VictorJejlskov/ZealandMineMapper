using StudentAccommodation_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAccommodation_RazorPages.ViewModels;

namespace StudentAccommodation_RazorPages.Interfaces
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetStudents();
        public IEnumerable<Student_Room> GetRoomPerStudent(int dormId);
        public List<Lease_Student> GetLeasesStudents(int dormId, int roomNo);
    }
}

using StudentAccommodation_RazorPages.Interfaces;
using StudentAccommodation_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAccommodation_RazorPages.ViewModels;

namespace StudentAccommodation_RazorPages.Services.StudentService
{
    public class StudentService : IStudentService
    {
        public IEnumerable<Student> GetStudents()
        {
            return ADO_Student.GetStudents();
        }

        public IEnumerable<Student_Room> GetRoomPerStudent(int dormId)
        {
            return ADO_Student.GetRoomPerStudent(dormId);
        }

        public List<Lease_Student> GetLeasesStudents(int dormId, int roomNo)
        {
            return ADO_Student.GetLeasesStudents(dormId, roomNo);
        }

        public List<Student_Room> GetStudentRoomsPerDorm(string dormName, string dateStart)
        {
            return ADO_Student.GetStudentRoomsPerDorm(dormName, dateStart);
        }

        public void DeleteStudent(Student student)
        {
            ADO_Student.DeleteStudent(student);
        }

        public Student GetStudentById(int id)
        {
            foreach (var stud in GetStudents())
            {
                if (stud.Student_No == id)
                {
                    return stud;
                }
            }
            return null;
        }
    }
}

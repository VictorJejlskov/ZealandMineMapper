using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using StudentAccommodation_RazorPages.Models;
using StudentAccommodation_RazorPages.ViewModels;

namespace StudentAccommodation_RazorPages.Services.StudentService
{
    public class ADO_Student
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAccommodationDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Student> GetStudents()
        {
            List<Student> studentList = new List<Student>();
            string query = "Select * from Student";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.Student_No = Convert.ToInt32(reader[0]);
                        student.Name = Convert.ToString(reader[1]);
                        student.Address = Convert.ToString(reader[2]);
                        studentList.Add(student);
                    }

                    return studentList;
                }
            }
        }

        public static List<Student_Room> GetRoomPerStudent(int dormId)
        {
            List<Student_Room> studRoomList = new List<Student_Room>();
            string query = $"Select Student.Name, Room.Room_No, Room.Types, Room.Dormitory_No, Leasing.Date_To from Leasing inner join Room on Leasing.Room_No = Room.Room_No and Leasing.Dormitory_No = Room.Dormitory_No inner join Student on Student.Student_No = Leasing.Student_No where Room.Dormitory_No = '{dormId}' ORDER BY Student.Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student_Room stuRoom = new Student_Room();
                        stuRoom.StudentName = Convert.ToString(reader[0]);
                        stuRoom.RoomNo = Convert.ToInt32(reader[1]);
                        stuRoom.RoomType = Convert.ToChar(reader[2]);
                        stuRoom.DormitoryNo = Convert.ToInt32(reader[3]);
                        stuRoom.EndDate = Convert.ToDateTime(reader[4]);
                        studRoomList.Add(stuRoom);
                    }
                    return studRoomList;
                }
            }
        }
    }
}

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
            string query = $"Select Student.Name, Room.Room_No, Room.Types, Dormitory.Name, Leasing.Date_From from Leasing inner join Room on Leasing.Room_No = Room.Room_No and Leasing.Dormitory_No = Room.Dormitory_No inner join Student on Student.Student_No = Leasing.Student_No inner join Dormitory on Room.Dormitory_No = Dormitory.Dormitory_No where Room.Dormitory_No = @dormId and Leasing.Date_From between '2019-06-30' and '2019-12-30' ORDER BY Student.Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dormId", dormId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student_Room stuRoom = new Student_Room();
                        stuRoom.StudentName = Convert.ToString(reader[0]);
                        stuRoom.RoomNo = Convert.ToInt32(reader[1]);
                        stuRoom.RoomType = Convert.ToChar(reader[2]);
                        stuRoom.DormName = Convert.ToString(reader[3]);
                        stuRoom.StartDate = Convert.ToDateTime(reader[4]);
                        stuRoom.DateString = stuRoom.StartDate.ToShortDateString();
                        //stuRoom.DateString = stuRoom.EndDate.Date.ToString("dd/MM/yyyy");
                        studRoomList.Add(stuRoom);
                    }
                    return studRoomList;
                }
            }
        }

        public static List<Lease_Student> GetLeasesStudents(int dormId, int roomNo)
        {
            List<Lease_Student> leaseStudList = new List<Lease_Student>();
            string query = $"select Dormitory.Name, Room.Room_No, Leasing.Date_From, Leasing.Date_To, Student.Name, Room.Types, Room.Price from Leasing inner join Dormitory on Leasing.Dormitory_No = Dormitory.Dormitory_No inner join Room on Leasing.Room_No = Room.Room_No and Dormitory.Dormitory_No = Room.Dormitory_No inner join Student on Leasing.Student_No = Student.Student_No where Room.Dormitory_No = @dormId and Room.Room_No = @roomNo";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dormId", dormId);
                command.Parameters.AddWithValue("@roomNo", roomNo);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lease_Student leaseStud = new Lease_Student();
                        leaseStud.DormName = Convert.ToString(reader[0]);
                        leaseStud.RoomId = Convert.ToInt32(reader[1]);
                        leaseStud.DateStart = Convert.ToDateTime(reader[2]);
                        leaseStud.DateStartString = leaseStud.DateStart.ToShortDateString();
                        leaseStud.DateEnd = Convert.ToDateTime(reader[3]);
                        leaseStud.DateEndString = leaseStud.DateEnd.ToShortDateString();
                        leaseStud.StudentName = Convert.ToString(reader[4]);
                        leaseStud.RoomTypes = Convert.ToChar(reader[5]);
                        leaseStud.RoomPrice = Convert.ToInt32(reader[6]);
                        leaseStudList.Add(leaseStud);
                    }

                    return leaseStudList;
                }
            }
        }
        public static List<Student_Room> GetStudentRoomsPerDorm(string dormName, string dateStart)
        {
            List<Student_Room> studRoomList = new List<Student_Room>();
            string query = $"Select Student.Name, Room.Room_No, Room.Types, Dormitory.Name, Leasing.Date_From from Leasing inner join Room on Leasing.Room_No = Room.Room_No and Leasing.Dormitory_No = Room.Dormitory_No inner join Student on Student.Student_No = Leasing.Student_No inner join Dormitory on Room.Dormitory_No = Dormitory.Dormitory_No where (Dormitory.Name LIKE '%{dormName}%') and (Leasing.Date_From = CONVERT(date, '{dateStart}', 1)) ORDER BY Student.Name";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine(query);
                    while (reader.Read())
                    {
                        Student_Room stuRoom = new Student_Room();
                        stuRoom.StudentName = Convert.ToString(reader[0]);
                        stuRoom.RoomNo = Convert.ToInt32(reader[1]);
                        stuRoom.RoomType = Convert.ToChar(reader[2]);
                        stuRoom.DormName = Convert.ToString(reader[3]);
                        stuRoom.StartDate = Convert.ToDateTime(reader[4]);
                        stuRoom.DateString = stuRoom.StartDate.ToShortDateString();
                        //stuRoom.DateString = stuRoom.EndDate.Date.ToString("dd/MM/yyyy");
                        studRoomList.Add(stuRoom);
                    }
                    return studRoomList;
                }
            }
        }
    }
}

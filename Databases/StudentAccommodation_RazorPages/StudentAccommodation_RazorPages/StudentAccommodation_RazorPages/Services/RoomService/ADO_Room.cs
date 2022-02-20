using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using StudentAccommodation_RazorPages.Models;

namespace StudentAccommodation_RazorPages.Services.RoomService
{
    public class ADO_Room
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAccommodationDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Room> GetRooms()
        {
            List<Room> roomList = new List<Room>();
            string query = "Select * from Room";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room room = new Room();
                        room.Room_No = Convert.ToInt32(reader[0]);
                        room.Dormitory_No = Convert.ToInt32(reader[1]);
                        room.Types = Convert.ToChar(reader[2]);
                        room.Price = Convert.ToSingle(reader[3]);
                        roomList.Add(room);
                    }

                    return roomList;
                }
            }
        }
    }
}

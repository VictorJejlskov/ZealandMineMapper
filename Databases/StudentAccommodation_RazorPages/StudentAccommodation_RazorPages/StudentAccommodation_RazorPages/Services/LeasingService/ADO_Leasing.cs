using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using StudentAccommodation_RazorPages.Models;

namespace StudentAccommodation_RazorPages.Services.LeasingService
{
    public class ADO_Leasing
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAccommodationDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Leasing> GetLeasing()
        {
            List<Leasing> leasingList = new List<Leasing>();
            string query = "Select * from Leasing";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Leasing lease = new Leasing();
                        lease.Leasing_No = Convert.ToInt32(reader[0]);
                        lease.Dormitory_No = Convert.ToInt32(reader[1]);
                        lease.Student_No = Convert.ToInt32(reader[2]);
                        lease.Date_From = Convert.ToDateTime(reader[3]);
                        lease.Date_To = Convert.ToDateTime(reader[4]);
                        lease.Room_No = Convert.ToInt32(reader[5]);
                        leasingList.Add(lease);
                    }
                    return leasingList;
                }
            }
        }
    }
}

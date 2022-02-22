using StudentAccommodation_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using StudentAccommodation_RazorPages.ViewModels;

namespace StudentAccommodation_RazorPages.Services.DormitoryService
{
    public class ADO_Dormitory
    {
       static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAccommodationDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

       public static List<Dormitory> GetDormitories()
       {
           List<Dormitory> dormList = new List<Dormitory>();
           string query = "select * from Dormitory";
           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               connection.Open();
               SqlCommand command = new SqlCommand(query, connection);
               using (SqlDataReader reader = command.ExecuteReader())
               {
                   while (reader.Read())
                   {
                       Dormitory dorm = new Dormitory();
                       dorm.Dormitory_No = Convert.ToInt32(reader[0]);
                       dorm.Name = Convert.ToString(reader[1]);
                       dorm.Address = Convert.ToString(reader[2]);
                       dormList.Add(dorm);
                   }

                   return dormList;
               }
           }
       }
    }
}

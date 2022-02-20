using ADONetMovie_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ADONetMovie_RazorPages.Services.ADONetServices.DBActor;

namespace ADONetMovie_RazorPages.Services.ADONetServices.DBMovie
{
    public class ADO_Movie
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MovieDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Movie> GetMovies()
        {
            List<Movie> movieList = new List<Movie>();
            string query = "select * from Movie";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Movie movie = new Movie();
                        movie.Id = Convert.ToInt32(reader[0]);
                        movie.Title = Convert.ToString(reader[1]);
                        movie.Year = Convert.ToInt32(reader[2]);
                        movie.Country = Convert.ToString(reader[3]);
                        movie.ActorId = Convert.ToInt32(reader[4]);
                        movieList.Add(movie);
                    }

                    return movieList;
                }
            }
        }

        public static List<Movie> GetMoviesByTitle(string title)
        {
            List<Movie> movieList = new List<Movie>();
            string query = $"select * from Movie where Title like '{title}%'";
            //string query = $"select * from Movie where Title like @title";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@title", title + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Movie movie = new Movie();
                        movie.Id = Convert.ToInt32(reader[0]);
                        movie.Title = Convert.ToString(reader[1]);
                        movie.Year = Convert.ToInt32(reader[2]);
                        movie.Country = Convert.ToString(reader[3]);
                        movie.ActorId = Convert.ToInt32(reader[4]);
                        movieList.Add(movie);
                    }
                    return movieList;
                }
            }
        }

        public static List<Movie> GetMoviesByActor(int aid)
        {
            List<Movie> movieList = new List<Movie>();
            //string query = $"select * from Movie inner join Actor on (Movie.ActorId = Actor.Id) and(Actor.Name like '{actor}%')";
            string query = $"select * from Movie where Movie.ActorId = '{aid}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@title", title + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Movie movie = new Movie();
                        movie.Id = Convert.ToInt32(reader[0]);
                        movie.Title = Convert.ToString(reader[1]);
                        movie.Year = Convert.ToInt32(reader[2]);
                        movie.Country = Convert.ToString(reader[3]);
                        movie.ActorId = Convert.ToInt32(reader[4]);
                        movieList.Add(movie);
                    }
                    return movieList;
                }
            }
        }

        public static List<Movie> GetMoviesBySearchActor(string actor)
        {
            List<Movie> movieList = new List<Movie>();
            string query = $"select * from Movie inner join Actor on (Movie.ActorId = Actor.Id) and(Actor.Name like '{actor}%')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@title", title + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Movie movie = new Movie();
                        movie.Id = Convert.ToInt32(reader[0]);
                        movie.Title = Convert.ToString(reader[1]);
                        movie.Year = Convert.ToInt32(reader[2]);
                        movie.Country = Convert.ToString(reader[3]);
                        movie.ActorId = Convert.ToInt32(reader[4]);
                        movieList.Add(movie);
                    }
                    return movieList;
                }
            }
        }
    }
}

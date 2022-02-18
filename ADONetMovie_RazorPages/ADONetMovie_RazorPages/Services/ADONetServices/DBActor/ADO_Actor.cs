using ADONetMovie_RazorPages.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ADONetMovie_RazorPages.ViewModels;

namespace ADONetMovie_RazorPages.Services.ADONetServices.DBActor
{
    public class ADO_Actor
    {
        // implement during the workshop
        //Højreklik på din Database, Properties og så er der en box der hedder ConnectionString
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MovieDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Actor> GetActors()
        {
            List<Actor> actorList = new List<Actor>();
            string query = "select * from Actor";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Actor actor = new Actor();
                        actor.Id = Convert.ToInt32(reader[0]);
                        actor.Name = Convert.ToString(reader[1]);
                        actor.Country = Convert.ToString(reader[2]);
                        actor.Birth_year = Convert.ToDateTime(reader[3]);
                        actor.Alive = Convert.ToBoolean(reader[4]);
                        actorList.Add(actor);
                    }
                    return actorList;
                }
            }
        }
        public static List<Actor> GetActorsByCountry(string country)
        {
            List<Actor> actorList = new List<Actor>();
            string query = "select * from Actor where Country = @country";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@country", country);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Actor actor = new Actor();
                        actor.Id = Convert.ToInt32(reader[0]);
                        actor.Name = Convert.ToString(reader[1]);
                        actor.Country = Convert.ToString(reader[2]);
                        actor.Birth_year = Convert.ToDateTime(reader[3]);
                        actor.Alive = Convert.ToBoolean(reader[4]);
                        actorList.Add(actor);
                    }
                    return actorList;
                }
            }
        }

        public static List<Actor_Movies> GetActorsAlongWithTheirMovies()
        {
            List<Actor_Movies> actorMovieList = new List<Actor_Movies>();
            string query = "select Actor.name, Actor.Country, Movie.title, Movie.Year from Actor, Movie where Movie.ActorId = Actor.Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Actor_Movies actorMovie = new Actor_Movies();
                        actorMovie.Name = Convert.ToString(reader[0]);
                        actorMovie.Country = Convert.ToString(reader[1]);
                        actorMovie.Title = Convert.ToString(reader[2]);
                        actorMovie.Year = Convert.ToInt32(reader[3]);
                        actorMovieList.Add(actorMovie);
                    }
                    return actorMovieList;
                }
            }
        }

    }
}

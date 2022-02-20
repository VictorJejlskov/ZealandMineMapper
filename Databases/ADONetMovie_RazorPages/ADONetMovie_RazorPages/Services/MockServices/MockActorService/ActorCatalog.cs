using ADONetMovie_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADONetMovie_RazorPages.Services.MockActorService
{
    public class ActorCatalog
    {
        static List<Actor> actors = new List<Actor>()
        {
            new Actor() { Id = 1, Name = "name", Country = "USA", Birth_year = new DateTime (1911-06-04), Alive = false },
            new Actor() { Id = 2, Name = "Chow-Yun fat", Country = "HK", Birth_year = new DateTime(1959 - 12 - 11), Alive = true},
           new Actor() { Id = 3, Name = "Karl Steger", Country = "Denmark", Birth_year = new DateTime(1922 - 10 - 10), Alive = false },
            new Actor() { Id = 4, Name = "Jean Reno", Country = "France", Birth_year = new DateTime(1949 - 09 - 10), Alive = true },
            new Actor() { Id = 5, Name = "Julia", Country = "USA", Birth_year = new DateTime(1980 - 06 - 04), Alive = true },
            new Actor() { Id = 6, Name = "Marc Duret", Country = "France", Birth_year = new DateTime(1966 - 01 - 08), Alive = true }
        };
        public static List<Actor> GetActors()
        {
            return actors;
        }
     }
}

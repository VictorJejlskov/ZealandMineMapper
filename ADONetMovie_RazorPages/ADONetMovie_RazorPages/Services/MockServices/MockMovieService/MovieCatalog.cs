using ADONetMovie_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADONetMovie_RazorPages.Services.MockMovieService
{
    public class MovieCatalog
    {
        static List<Movie> movies= new List<Movie>()
        {     
            new Movie() {  Id= 1, Title="E.T", Year= 1982, Country="USA"  ,  ActorId=1},
            new Movie() { Id = 2, Title = "Taxi", Year = 1998, Country = "France", ActorId =2},
            new Movie() { Id = 3, Title = "Hunger", Year =1966 , Country = "Denmark", ActorId =1},
           new Movie() { Id = 4, Title = "Leon", Year = 1994, Country = "USA", ActorId =3},
           new Movie() { Id = 5, Title = "Hard Boiled", Year = 1992, Country = "HK", ActorId =4},
           new Movie() { Id = 6, Title = "1984", Year = 1984, Country = "UK", ActorId =2},
          new Movie() { Id = 7, Title = "Seven", Year = 1995, Country = "USA", ActorId =1},
        };

        public static  List<Movie> GetMovies()
        {
            return movies;
        }
        
    }
}

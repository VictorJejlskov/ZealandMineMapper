using ADONetMovie_RazorPages.Models;
using ADONetMovie_RazorPages.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADONetMovie_RazorPages.Services.MockMovieService
{
    public class MovieService : IMovieService
    {
        private List<Movie> movies;
       public MovieService()
        {
            movies=MovieCatalog.GetMovies();
            
        }
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public IEnumerable<Movie> FilterMoviesByTitle(string filter)
        {
            List<Movie> lst = new List<Movie>();
            foreach (var m in movies)
            {
                if (m.Title.StartsWith(filter))
                    lst.Add(m);
            }

            return lst;
        }

        public IEnumerable<Movie> GetMovies()
        {
            
            return movies;

        }

         public Movie GetMovieById(int id)
        {
            foreach (var movie in movies)
            {
                if (movie.Id == id)
                    return movie;
            }

            return null;
        }

         public IEnumerable<Movie> GetMoviesBySearchActor(string actor)
         {
             throw new NotImplementedException();
         }

         public void DeleteMovie(Movie movie)
        {
            movies.Remove(movie);
        }       
        public void DeleteMoviesByActorId(Actor actor)
        {
            movies.RemoveAll(m => m.ActorId == actor.Id);
        }

        public IEnumerable<Movie> GetMoviesByActor(int aid)
        {
            List<Movie> lst = new List<Movie>();
            foreach (var m in movies)
            {
                if (m.ActorId == aid)
                    lst.Add(m);
            }
            return lst;
        }
    }
}


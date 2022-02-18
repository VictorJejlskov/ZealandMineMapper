using ADONetMovie_RazorPages.Models;
using ADONetMovie_RazorPages.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADONetMovie_RazorPages.Services.ADONetServices.DBMovie
{
    public class DBMovieService : IMovieService
    {
        public IEnumerable<Movie> GetMoviesByActor(int aid)
        {
            return ADO_Movie.GetMoviesByActor(aid);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return ADO_Movie.GetMovies();
        }

        public IEnumerable<Movie> FilterMoviesByTitle(string filter)
        {
            return ADO_Movie.GetMoviesByTitle(filter);
        }

        public void AddMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMoviesBySearchActor(string actor)
        {
            return ADO_Movie.GetMoviesBySearchActor(actor);
        }
    }
}

using ADONetMovie_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADONetMovie_RazorPages.Services.Interfaces
{
    public interface IMovieService
    {
        
          IEnumerable<Movie> GetMoviesByActor(int aid);
          IEnumerable<Movie> GetMovies();
        IEnumerable<Movie> FilterMoviesByTitle(string filter);
        void AddMovie(Movie movie);
        void DeleteMovie(Movie movie);
        Movie  GetMovieById(int id);

        IEnumerable<Movie> GetMoviesBySearchActor(string actor);

    }
}

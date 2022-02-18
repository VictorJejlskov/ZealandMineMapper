using ADONetMovie_RazorPages.Models;
using ADONetMovie_RazorPages.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADONetMovie_RazorPages.ViewModels;

namespace ADONetMovie_RazorPages.Services.ADONetServices.DBActor
{
    public class DBActorService : IActorService
    {
        public IEnumerable<Actor> GetActors()
        {
            return ADO_Actor.GetActors();
        }

        public void AddActor(Actor actor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetActorsByCountry(string country)
        {

            return ADO_Actor.GetActorsByCountry(country);
        }

        public Actor GetActorById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteActor(Actor actor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor_Movies> GetActorWithMovies()
        {
            return ADO_Actor.GetActorsAlongWithTheirMovies();
        }
    }
}

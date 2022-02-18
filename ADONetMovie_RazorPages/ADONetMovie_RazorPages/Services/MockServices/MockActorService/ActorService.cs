using ADONetMovie_RazorPages.Models;
using ADONetMovie_RazorPages.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADONetMovie_RazorPages.ViewModels;

namespace ADONetMovie_RazorPages.Services.MockActorService
{
    public class ActorService : IActorService
    {

        private List<Actor> actors;
        public ActorService()
        {
            actors = ActorCatalog.GetActors();

        }

        public void AddActor(Actor actor)
        {
            actors.Add(actor);
        }
        public IEnumerable<Actor> GetActors()
        {
            return actors;
        }
        public Actor  GetActorById(int id)
        {
            foreach (var actor in actors)
            {
                if (actor.Id == id)
                    return actor;
            }

            return null;
        }

        public void DeleteActor(Actor actor)
        {
            foreach (var a in actors)
            {
                if (a.Id == actor.Id)
                {
                    actors.Remove(a);
                    break;
                }
            }
        }

        public IEnumerable<Actor_Movies> GetActorWithMovies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetActorsByCountry(string country)
        {
            List<Actor> lst = new List<Actor>();
            foreach (var a in actors)
            {
                if (a.Country.StartsWith(country))
                    lst.Add(a);
            }
            return lst;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADONetMovie_RazorPages.Services.Interfaces;
using ADONetMovie_RazorPages.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ADONetMovie_RazorPages.Pages.Actors
{
    public class ActorMoviesModel : PageModel
    {
        public IEnumerable<Actor_Movies> ActorMovies { get; set; }
        private IActorService actorService;

        public ActorMoviesModel(IActorService actorService)
        {
            this.actorService = actorService;
        }
        public void OnGet()
        {
            ActorMovies = actorService.GetActorWithMovies();
        }
    }
}

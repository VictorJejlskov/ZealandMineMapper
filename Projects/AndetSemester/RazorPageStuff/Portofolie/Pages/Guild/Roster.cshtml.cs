using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portofolie.Models.GuildStuff;
using Portofolie.Services;

namespace Portofolie.Pages.Guild
{
    public class RosterModel : PageModel
    {
        private APIService _apiService;
        public RosterModel(APIService apiService)
        {
            _apiService = apiService;
        }

        public GuildInfo GuildInfo { get; set; }
        public List<Member> Members { get; set; } = new List<Member>();
        public List<Member> SortedMembers { get; set; } = new List<Member>();
        public async Task<IActionResult> OnGet()
        {
            GuildInfo = await _apiService.GetGuildInfo("phoenix", "silvermoon");
            SortedMembers = GuildInfo.members.OrderBy(m => m.rank).ToList();
            Members.AddRange(SortedMembers.Where(x => x.rank == 0));
            Members.AddRange(SortedMembers.Where(x => x.rank == 1));
            Members.AddRange(SortedMembers.Where(x => x.rank == 3));
            Members.AddRange(SortedMembers.Where(x => x.rank == 4));
            Members.AddRange(SortedMembers.Where(x => x.rank == 2));
            Members.AddRange(SortedMembers.Where(x => x.rank == 5));
            Members.AddRange(SortedMembers.Where(x => x.rank == 6));
            Members.AddRange(SortedMembers.Where(x => x.rank == 7));
            Members.AddRange(SortedMembers.Where(x => x.rank == 8));
            Members.AddRange(SortedMembers.Where(x => x.rank == 9));
            return Page();
        }

        public string IdAsRank(int id)
        {
            return _apiService.IdAsRank(id);
        }

        public string IdAsClass(int id)
        {
            return _apiService.IdAsClass(id);
        }

        public string IdAsRace(int id)
        {
            return _apiService.IdAsRace(id);
        }



    }
}

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
        private GuildService _guildService;
        public RosterModel(APIService apiService, GuildService guildService)
        {
            _apiService = apiService;
            _guildService = guildService;
        }

        public GuildInfo GuildInfo { get; set; }
        public List<Member> Members { get; set; } = new List<Member>();
        public List<Member> SortedMembers { get; set; } = new List<Member>();
        public async Task<IActionResult> OnGet()
        {
            GuildInfo = await _apiService.GetGuildInfo("phoenix", "silvermoon");
            Members = _guildService.SortByRank(GuildInfo.members);
            return Page();
        }

        public async Task<IActionResult> OnGetSortByRank()
        {
            GuildInfo = await _apiService.GetGuildInfo("phoenix", "silvermoon");
            Members = _guildService.SortByRank(GuildInfo.members);
            return Page();
        }
        public async Task<IActionResult> OnGetSortByRankDescending()
        {
            GuildInfo = await _apiService.GetGuildInfo("phoenix", "silvermoon");
            Members = _guildService.SortByRankDescending(GuildInfo.members);
            return Page();
        }
        public async Task<IActionResult> OnGetSortByName()
        {
            GuildInfo = await _apiService.GetGuildInfo("phoenix", "silvermoon");
            Members = _guildService.SortByName(GuildInfo.members);
            return Page();
        }
        public async Task<IActionResult> OnGetSortByNameDescending()
        {
            GuildInfo = await _apiService.GetGuildInfo("phoenix", "silvermoon");
            Members = _guildService.SortByNameDescending(GuildInfo.members);
            return Page();
        }
        public async Task<IActionResult> OnGetSortByClass()
        {
            GuildInfo = await _apiService.GetGuildInfo("phoenix", "silvermoon");
            Members = _guildService.SortByClass(GuildInfo.members);
            return Page();
        }
        public async Task<IActionResult> OnGetSortByClassDescending()
        {
            GuildInfo = await _apiService.GetGuildInfo("phoenix", "silvermoon");
            Members = _guildService.SortByClassDescending(GuildInfo.members);
            return Page();
        }
        public async Task<IActionResult> OnGetSortByRace()
        {
            GuildInfo = await _apiService.GetGuildInfo("phoenix", "silvermoon");
            Members = _guildService.SortByRace(GuildInfo.members);
            return Page();
        }
        public async Task<IActionResult> OnGetSortByRaceDescending()
        {
            GuildInfo = await _apiService.GetGuildInfo("phoenix", "silvermoon");
            Members = _guildService.SortByRaceDescending(GuildInfo.members);
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

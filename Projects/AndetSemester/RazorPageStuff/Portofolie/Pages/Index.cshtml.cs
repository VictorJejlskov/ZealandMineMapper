using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Portofolie.Models;
using Portofolie.Services;

namespace Portofolie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private HttpClient _client;
        private APIService _apiService;

        private string _reqUrl = $"https://eu.api.blizzard.com/profile/wow/character/silvermoon/terondashi/character-media?namespace=profile-eu&locale=en_US&access_token=USlEUoaX7H1Mrt6vjqFrjYtfSPkAseloh5";
        private string oauthToken;
        public string ImgStr { get; set; }
        [Display(Name = "Character Name"), Required(ErrorMessage = "Name is required!")]
        [BindProperty] public string SearchName { get; set; } = "terondashi";
        [Display(Name = "Realm Name"), Required(ErrorMessage = "Name is required!")]
        [BindProperty] public string SearchRealm { get; set; } = "silvermoon";
        public IndexModel(ILogger<IndexModel> logger, HttpClient client, APIService apiService)
        {
            _logger = logger;
            _client = client;
            _apiService = apiService;
        }

        public async Task<IActionResult> OnGet()
        {
            ImgStr = await _apiService.GetCharacterImgString(SearchRealm, SearchName);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ImgStr = await _apiService.GetCharacterImgString(SearchRealm, SearchName); 
            return Page();
        }
    }
}




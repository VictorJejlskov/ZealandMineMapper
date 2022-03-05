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

namespace Portofolie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private HttpClient _client;

        private string _reqUrl = $"https://eu.api.blizzard.com/profile/wow/character/silvermoon/terondashi/character-media?namespace=profile-eu&locale=en_US&access_token=USZjXDprFQClIuu7dDr4Yi7ETRR5WbEcCC";
        public string ImgStr { get; set; }
        [Display(Name = "Character Name"), Required(ErrorMessage = "Name is required!")]
        [BindProperty] public string SearchName { get; set; } = "terondashi";
        [Display(Name = "Realm Name"), Required(ErrorMessage = "Name is required!")]
        [BindProperty] public string SearchRealm { get; set; } = "silvermoon";
        public IndexModel(ILogger<IndexModel> logger, HttpClient client)
        {
            _logger = logger;
            _client = client;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            _reqUrl =
                $"https://eu.api.blizzard.com/profile/wow/character/{SearchRealm.ToLower()}/{SearchName.ToLower()}/character-media?namespace=profile-eu&locale=en_US&access_token=USZjXDprFQClIuu7dDr4Yi7ETRR5WbEcCC";
            var response =
                await _client.GetAsync(_reqUrl);
            var result = await response.Content.ReadAsStringAsync();
            if (response.StatusCode != HttpStatusCode.OK)
            {
                _reqUrl = $"https://eu.api.blizzard.com/profile/wow/character/silvermoon/terondashi/character-media?namespace=profile-eu&locale=en_US&access_token=USZjXDprFQClIuu7dDr4Yi7ETRR5WbEcCC";
                response =
                    await _client.GetAsync(_reqUrl);
                result = await response.Content.ReadAsStringAsync();
                CharacterResponseList jsonAssets = JsonConvert.DeserializeObject<CharacterResponseList>(result);
                ImgStr = jsonAssets.Assets.FirstOrDefault(asset => asset.Key.Equals("main-raw")).Value;
            }
            else
            {
                CharacterResponseList jsonAssets = JsonConvert.DeserializeObject<CharacterResponseList>(result);
                ImgStr = jsonAssets.Assets.FirstOrDefault(asset => asset.Key.Equals("main-raw")).Value;
            }

            
            
            //var test = obj["assets"][3]["value"];
            //ImgStr = test.ToString();
            //JsonSerializer.Deserialize<DeliveryDriver[]>(jsonFileReader.ReadToEnd());
            return Page();
        }
    }
}

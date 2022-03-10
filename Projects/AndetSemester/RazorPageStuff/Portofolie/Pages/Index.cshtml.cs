using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;
using Portofolie.Models;
using Portofolie.Models.CharacterStuff;
using Portofolie.Models.EquipmentStuff;
using Portofolie.Services;

namespace Portofolie.Pages
{
    public class IndexModel : PageModel
    {
        private APIService _apiService;
        public IndexModel(APIService apiService)
        {
            _apiService = apiService;
        }

        private string _reqUrl = $"https://eu.api.blizzard.com/profile/wow/character/silvermoon/terondashi/character-media?namespace=profile-eu&locale=en_US&access_token=USlEUoaX7H1Mrt6vjqFrjYtfSPkAseloh5";
        public string ImgStr { get; set; }
        [Display(Name = "Character Name"), Required(ErrorMessage = "Name is required!")]
        [BindProperty] public string SearchName { get; set; } = "terondashi";
        [Display(Name = "Realm Name"), Required(ErrorMessage = "Name is required!")]
        [BindProperty] public string SearchRealm { get; set; } = "silvermoon";

        public CharInfo CharInfo { get; set; }
        public string CharSpecMedia { get; set; }
        public EquipmentInfo Equipment { get; set; }

        public string SpecIcon { get; set; } =
            "https://render-eu.worldofwarcraft.com/icons/56/spell_shadow_metamorphosis.jpg";
       

        public async Task<IActionResult> OnGet()
        {
            
            Equipment = await _apiService.GetCharacterEquipment(SearchRealm, SearchName);
            CharInfo = await _apiService.GetCharacterInfo(SearchRealm, SearchName);
            CharSpecMedia = await _apiService.GetSpecMedia(SearchRealm, SearchName);
            ImgStr = await _apiService.GetCharacterImgString(SearchRealm, SearchName);
            return Page();
        }
        public async Task<IActionResult> OnGetSpecific(string sr, string sn)
        {
            SearchName = sn;
            SearchRealm = sr;
            Equipment = await _apiService.GetCharacterEquipment(sr.ToLower(), sn.ToLower());
            CharInfo = await _apiService.GetCharacterInfo(sr.ToLower(), sn.ToLower());
            CharSpecMedia = await _apiService.GetSpecMedia(sr.ToLower(), sn.ToLower());
            ImgStr = await _apiService.GetCharacterImgString(sr.ToLower(), sn.ToLower());
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Equipment = await _apiService.GetCharacterEquipment(SearchRealm, SearchName);
            CharInfo = await _apiService.GetCharacterInfo(SearchRealm, SearchName);
            CharSpecMedia = await _apiService.GetSpecMedia(SearchRealm, SearchName);
            ImgStr = await _apiService.GetCharacterImgString(SearchRealm, SearchName); 
            return Page();
        }
    }
}




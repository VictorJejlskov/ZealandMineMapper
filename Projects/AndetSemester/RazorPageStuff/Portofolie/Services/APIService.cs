using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using Portofolie.Models;
using Portofolie.Models.CharacterStuff;
using Portofolie.Models.CharacterStuff.ClassStuff;
using Portofolie.Models.EquipmentStuff;
using Portofolie.Models.GuildStuff;
using RestSharp;

namespace Portofolie.Services
{
    public class APIService
    {
        private string bnet_client_id = "c5bb4327df624a9eb378f9377a0cd9ae";
        private string bnet_client_secret = "uUPWqvMD2XzD0H1WWF4TBytxFx3lq2Dh";
        private string bnet_url = "https://eu.battle.net";

        private string wcl_client_id = "95c37eb9-cb0a-4100-82ed-dd299c18966a";
        private string wcl_client_secret = "maD85EBmmoljvdiIxC2SuqFE1KMSL4WdzHqJL5xy";
        private string wcl_url = "https://www.warcraftlogs.com";

        private HttpClient _client;

        public APIService(HttpClient client)
        {
            _client = client;
        }
        public async Task<string> GetBnetOAuth()
        {
            var restclient = new RestClient(bnet_url);
            RestRequest request = new RestRequest("oauth/token") {Method = Method.Post};
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("client_id", bnet_client_id);
            request.AddParameter("client_secret", bnet_client_secret);
            request.AddParameter("grant_type", "client_credentials");
            var tResponse = await restclient.ExecuteAsync(request);
            var responseJson = tResponse.Content;
            var token = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseJson)["access_token"]
                .ToString();
            return token;
        }

        public async Task<string> GetCharacterImgString(string searchRealm, string searchName)
        {
            string imgString = "";
            string oauthToken = await GetBnetOAuth();
            string reqUrl =
                $"https://eu.api.blizzard.com/profile/wow/character/{searchRealm.ToLower()}/{searchName.ToLower()}/character-media?namespace=profile-eu&locale=en_US&access_token={oauthToken}";
            var response =
                await _client.GetAsync(reqUrl);
            var result = await response.Content.ReadAsStringAsync();
            CharacterResponseList jsonAssets = JsonConvert.DeserializeObject<CharacterResponseList>(result);
            imgString = jsonAssets.assets.FirstOrDefault(asset => asset.key.Equals("main-raw")).value;
            return imgString;
        }

        public async Task<CharInfo> GetCharacterInfo(string searchRealm, string searchCharacter)
        {
            string oauthToken = await GetBnetOAuth();
            string reqUrl =
                $"https://eu.api.blizzard.com/profile/wow/character/{searchRealm}/{searchCharacter}?namespace=profile-eu&locale=en_US&access_token={oauthToken}";
            var response = await _client.GetAsync(reqUrl);
            var result = await response.Content.ReadAsStringAsync();
            CharInfo charInfo = JsonConvert.DeserializeObject<CharInfo>(result);
            return charInfo;
        }

        public async Task<string> GetSpecMedia(string searchRealm, string searchCharacter)
        {
            string oauthToken = await GetBnetOAuth();
            string reqUrl =
                $"https://eu.api.blizzard.com/data/wow/media/playable-specialization/{GetCharacterInfo(searchRealm, searchCharacter).Result.active_spec.id}?namespace=static-eu&locale=en_US&access_token={oauthToken}";
            var response = await _client.GetAsync(reqUrl);
            var result = await response.Content.ReadAsStringAsync();
            CharSpecMedia specMedia = JsonConvert.DeserializeObject<CharSpecMedia>(result);
            string specMediaString = specMedia.assets.FirstOrDefault(asset => asset.key.Equals("icon")).value;
            return specMediaString;
        }

        public async Task<EquipmentInfo> GetCharacterEquipment(string searchRealm, string searchCharacter)
        {
            string oauthToken = await GetBnetOAuth();
            string reqUrl =
                $"https://eu.api.blizzard.com/profile/wow/character/{searchRealm}/{searchCharacter}/equipment?namespace=profile-eu&locale=en_US&access_token={oauthToken}";
            var response = await _client.GetAsync(reqUrl);
            var result = await response.Content.ReadAsStringAsync();
            EquipmentInfo equipment = JsonConvert.DeserializeObject<EquipmentInfo>(result);
            return equipment;
        }

        public async Task<string> GetEquipmentMedia(int equipId)
        {
            string oauthToken = await GetBnetOAuth();
            string reqUrl =
                $"https://eu.api.blizzard.com/data/wow/media/item/{equipId}?namespace=static-eu&locale=en_US&access_token={oauthToken}";
            var response = await _client.GetAsync(reqUrl);
            var result = await response.Content.ReadAsStringAsync();
            EquippedItemMedia mediaJson = JsonConvert.DeserializeObject<EquippedItemMedia>(result);
            string mediastr = mediaJson.assets[0].value;
            return mediastr;
        }

        public async Task<GuildInfo> GetGuildInfo(string guildName, string guildRealm)
        {
            string oauthToken = await GetBnetOAuth();
            string reqUrl =
                $"https://eu.api.blizzard.com/data/wow/guild/{guildRealm}/{guildName}/roster?namespace=profile-eu&locale=en_US&access_token={oauthToken}";
            var response = await _client.GetAsync(reqUrl);
            var result = await response.Content.ReadAsStringAsync();
            GuildInfo guildInfo = JsonConvert.DeserializeObject<GuildInfo>(result);
            return guildInfo;
        }

        public async Task<string> GetClassName(int id)
        {
            string oauthToken = await GetBnetOAuth();
            string reqUrl =
                $"https://eu.api.blizzard.com/data/wow/playable-class/{id}?namespace=static-eu&locale=en_US&access_token={oauthToken}";
            var response = await _client.GetAsync(reqUrl);
            var result = await response.Content.ReadAsStringAsync();
            ClassInfo classInfo = JsonConvert.DeserializeObject<ClassInfo>(result);
            return classInfo.name;
        }
        public string IdAsClass(int id)
        {
            switch (id)
            {
                case 1:
                    return "Warrior";
                case 2:
                    return "Paladin";
                case 3:
                    return "Hunter";
                case 4:
                    return "Rogue";
                case 5:
                    return "Priest";
                case 6:
                    return "Death Knight";
                case 7:
                    return "Shaman";
                case 8:
                    return "Mage";
                case 9:
                    return "Warlock";
                case 10:
                    return "Monk";
                case 11:
                    return "Druid";
                case 12:
                    return "Demon Hunter";
            }
            return "Warrior";
        }

        public string IdAsRank(int id)
        {
            switch (id)
            {
                case 0:
                    return "Council";
                case 1:
                    return "Council";
                case 2:
                    return "Council Alts";
                case 3:
                    return "Member";
                case 4:
                    return "Trialist";
                case 5:
                    return "Member Alt";
                case 6:
                    return "Trialist Alt";
                case 7:
                    return "Mememaster";
                case 8:
                    return "Shit Name M8";
                case 9:
                    return "Friend";
            }
            return "Member";
        }
        public string IdAsRace(int id)
        {
            switch (id)
            {
                case 1:
                    return "Human";
                case 2:
                    return "Orc";
                case 3:
                    return "Dwarf";
                case 4:
                    return "Night Elf";
                case 5:
                    return "Undead";
                case 6:
                    return "Tauren";
                case 7:
                    return "Gnome";
                case 8:
                    return "Troll";
                case 9:
                    return "Goblin";
                case 10:
                    return "Blood Elf";
                case 11:
                    return "Draenei";
                case 22:
                    return "Worgen";
                case 24:
                    return "Pandaren";
                case 25:
                    return "Pandaren";
                case 26:
                    return "Pandaren";
                case 27:
                    return "Nightborne";
                case 28:
                    return "Highmountain Tauren";
                case 29:
                    return "Void Elf";
                case 30:
                    return "Lightforged Draenei";
                case 31:
                    return "Zandalari Troll";
                case 32:
                    return "Kul Tiran";
                case 34:
                    return "Dark Iron Dwarf";
                case 35:
                    return "Vulpera";
                case 36:
                    return "Mag'har Orc";
                case 37:
                    return "Mechagnome";
            }

            return "Human";
        }

    }
}

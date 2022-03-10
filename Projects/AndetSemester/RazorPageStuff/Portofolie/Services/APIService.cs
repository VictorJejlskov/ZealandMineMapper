﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Portofolie.Models;
using Portofolie.Models.CharacterStuff;
using Portofolie.Models.EquipmentStuff;
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
    }
}

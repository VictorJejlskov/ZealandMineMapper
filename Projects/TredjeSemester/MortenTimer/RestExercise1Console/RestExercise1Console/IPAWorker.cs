using RestExercise1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestExercise1Console
{
    public class IPAWorker
    {
        private readonly string URL = "http://localhost:5203/IPAs";
        public void DoWork()
        {
            IEnumerable<IPA> ipas = GetAll().Result;
            foreach(IPA ip in ipas)
            {
                Console.WriteLine(ip.Name);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Post:");
            IPA newIPA = new IPA { Brand = "Carlsberg", Proof = 8, Name = "My New IPA", Grain = "Humle"};
            newIPA = Post(newIPA).Result;
            Console.WriteLine($"New ipa has name: {newIPA.Name} and ID: {newIPA.Id}");
            Console.WriteLine("\n\n");
            Console.WriteLine("Delete");
            var deleteIPA = Delete(newIPA.Id).Result;
            Console.WriteLine($"Deleted IPA name: {deleteIPA.Name} & it's IP: {deleteIPA.Id}");
            Console.WriteLine("\nNewest one is now deleted, proof:");
            ipas = GetAll().Result;
            foreach (IPA ip in ipas)
            {
                Console.WriteLine(ip.Name);
            }

            Console.WriteLine("\n");


        }
        public async Task<IEnumerable<IPA>> GetAll()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("amount", "50");
                var response = await client.GetAsync(URL);
                Console.WriteLine("Status kode: " + response.StatusCode);
                //Console.WriteLine("Content: " + response.Content.ReadAsStringAsync().Result);
                IEnumerable<IPA> IPAs = await response.Content.ReadFromJsonAsync<IEnumerable<IPA>>();
                return IPAs;
            }   
        }

        public async Task<IPA> Post(IPA ipa)
        {
            JsonContent serializedIPA = JsonContent.Create(ipa);
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(URL, serializedIPA);
                Console.WriteLine("Status kode: " + response.StatusCode);
                //Console.WriteLine("Content: " + response.Content.ReadAsStringAsync().Result);
                return await response.Content.ReadFromJsonAsync<IPA>();
            }
        }
        public async Task<IPA> Delete(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync(URL + "/" + id);
                Console.WriteLine("Status kode: " + response.StatusCode);
                //Console.WriteLine("Content: " + response.Content.ReadAsStringAsync().Result);
                return await response.Content.ReadFromJsonAsync<IPA>();
            }
        }
        public async Task<IPA> Put(int id, IPA updatedIPA)
        {
            var ipa = Get(id).Result;
            if(updatedIPA.Brand != null) ipa.Brand = updatedIPA.Brand;
            if(updatedIPA.Proof != 0) ipa.Proof = updatedIPA.Proof;
            if(updatedIPA.Name != null) ipa.Name = updatedIPA.Name;
            if(updatedIPA.Grain != null) ipa.Grain = updatedIPA.Grain;
            JsonContent serializedIPA = JsonContent.Create(ipa);
            using (var client = new HttpClient())
            {
                var response = await client.PutAsync(URL + "/" + id, serializedIPA);
                Console.WriteLine("Status kode: " + response.StatusCode);
                if(!response.IsSuccessStatusCode) Console.WriteLine("Content: " + response.Content.ReadAsStringAsync().Result);
                return await response.Content.ReadFromJsonAsync<IPA>();

            }
        }
        public async Task<IPA> Get(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(URL + "/" + id);
                Console.WriteLine("Status kode: " + response.StatusCode);
                if (!response.IsSuccessStatusCode) Console.WriteLine("Content: " + response.Content.ReadAsStringAsync().Result);
                return await response.Content.ReadFromJsonAsync<IPA>();
            }
        }
    }
}

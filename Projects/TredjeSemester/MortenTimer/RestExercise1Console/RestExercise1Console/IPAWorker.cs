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
            IPA newIPA = new IPA { Brand = "Carlsberg", Proof = 8, Name = "NY IPA LOL XD", Grain = "Humle"};
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

        }
        public async Task<IEnumerable<IPA>> GetAll()
        {
            using (HttpClient client = new HttpClient())
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
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync(URL, serializedIPA);
                Console.WriteLine("Status kode: " + response.StatusCode);
                //Console.WriteLine("Content: " + response.Content.ReadAsStringAsync().Result);
                return await response.Content.ReadFromJsonAsync<IPA>();
            }
        }
        public async Task<IPA> Delete(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync(URL + "/" + id);
                Console.WriteLine("Status kode: " + response.StatusCode);
                //Console.WriteLine("Content: " + response.Content.ReadAsStringAsync().Result);
                return await response.Content.ReadFromJsonAsync<IPA>();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BigMammaUML3.Models;
using Microsoft.AspNetCore.Hosting;

namespace BigMammaUML3.Services
{
    public class JsonFileItemService
    {
        private List<Pizza> _pizzas = new List<Pizza>();
        private List<Beverage> _beverages = new List<Beverage>();

        public List<MenuItem> Combine(List<Pizza> pizzas, List<Beverage> beverages)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (Pizza piz in pizzas)
            {
                menuItems.Add(piz);
            }
            foreach (Beverage bev in beverages)
            {
                menuItems.Add(bev);
            }
            return menuItems;
        }

        public void Split(List<MenuItem> menuItems)
        {
            foreach (MenuItem menItem in menuItems)
            {
                if (menItem is Pizza)
                {
                    _pizzas.Add((Pizza)menItem);
                }

                if (menItem is Beverage)
                {
                    _beverages.Add((Beverage)menItem);
                }
            }
        }

        public IWebHostEnvironment WebHostEnvironment { get;}

        public JsonFileItemService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonPizzaFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "PizzaItems.json"); }
        }
        private string JsonBeverageFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "BeverageItems.json"); }
        }

        public void SavePizzaItems(List<Pizza> pizzaItems)
        {
            using (FileStream jsonFileWriter = File.Create(JsonPizzaFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Pizza[]>(jsonWriter, _pizzas.ToArray());
            }
        }
        public void SaveBeverageItems(List<Beverage> beverageItems)
        {
            using (FileStream jsonFileWriter = File.Create(JsonBeverageFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Beverage[]>(jsonWriter, _beverages.ToArray());
            }
        }

        public void SaveJsonItems(List<MenuItem> menuItems)
        {
            Split(menuItems);
            SavePizzaItems(_pizzas);
            SaveBeverageItems(_beverages);
            _pizzas.Clear();
            _beverages.Clear();
        }

        public IEnumerable<Pizza> GetPizzaItems()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonPizzaFileName))
            {
                return JsonSerializer.Deserialize<Pizza[]>(jsonFileReader.ReadToEnd());
            }
        }
        public IEnumerable<Beverage> GetBeverageItems()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonBeverageFileName))
            {
                return JsonSerializer.Deserialize<Beverage[]>(jsonFileReader.ReadToEnd());
            }
        }

        public List<MenuItem> GetJsonItems()
        {
            return Combine(GetPizzaItems().ToList(), GetBeverageItems().ToList());
        }

    }
}

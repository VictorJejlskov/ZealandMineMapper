using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TilbudsFinder
{
    internal class SearchEngine
    {
        static string url = "https://www.tilbudsugen.dk/tilbudsavis";
        static IWebDriver _driver = new ChromeDriver(System.IO.Directory.GetCurrentDirectory());
        static string filePath = System.IO.Directory.GetCurrentDirectory() + "\\Resultater";
        public string TextPath(string input)
        {
            return filePath + "\\" + input + ".txt";
        }
        public void Start()
        {
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
            
            try
            {
                var files = System.IO.Directory.GetFiles(filePath);
                foreach (var file in files) System.IO.File.Delete(file);

            }
            catch
            {
                System.IO.Directory.CreateDirectory(filePath);
            }
            foreach(string line in GetInputs())
            {
                Search(line);
            }
        }
        public List<string> GetInputs()
        {
            List<string> inputs = new List<string>();
            foreach(string line in System.IO.File.ReadLines(System.IO.Directory.GetCurrentDirectory() + "\\SøgeKriterier.txt"))
            {
                inputs.Add(line);
            }
            return inputs;
        }
        public void Search(string input)
        {
            var searchBox = _driver.FindElement(By.XPath("//*[@id=\"search_box\"]/form/input"));

            searchBox.SendKeys(input);
            Thread.Sleep(100);
            searchBox.SendKeys(Keys.Enter);
            Thread.Sleep(500);
            while (true)
            {
                try
                {
                    var element = _driver.FindElement(By.Id("offerAgentSpinner"));
                    if(element.Location.Y < 2000 && element.Location.Y != 0)
                    {
                        Console.WriteLine("I repeated: " + element.Location.Y);
                        Thread.Sleep(200);
                    }
                    else
                    {
                        Console.WriteLine("I broke: " + element.Location.Y);
                        break;
                    }
                }
                catch
                {
                    break;
                }
            }

            var allResults = _driver
                    .FindElements(By.ClassName("search-result-item"));
            var allDetails = _driver.FindElements(By.ClassName("details-product-name"));

            List<string> results = new List<string>();
            foreach (var detail in allDetails)
            {
                results.Add(detail.GetAttribute("data-chain"));
            }
            var allProductNames = _driver.FindElements(By.ClassName("details-product-name"));
            var allPrices = _driver.FindElements(By.ClassName("offer-action-price"));

            using StreamWriter file = new(TextPath(input), append: true);

            string topLine = "";
            topLine = allResults.Count == 0 ? "Søgeresultat for: " + input + " gav 0 resultater" : "Søgeresultat for: " + input + "\n";
            file.WriteLine(topLine);

            var allValidities = _driver.FindElements(By.ClassName("order-validity"));
            for (int i = 0; i < CheckNumber(allResults.Count); i++)
            {
                if (IsValid(allValidities[i].Text))
                {
                    file.WriteLine("Kæde: " + results[i]);
                    file.WriteLine(allProductNames[i].Text);
                    file.WriteLine(allPrices[i].Text);
                    file.WriteLine("__________________");
                }
                else
                {
                    file.WriteLine("TILBUD IKKE GYLDIGT ENDNU\nGyldigt fra: " + allValidities[i].Text);
                    file.WriteLine("Kæde: " + results[i]);
                    file.WriteLine(allProductNames[i].Text);
                    file.WriteLine(allPrices[i].Text);
                    file.WriteLine("__________________");
                }
            }

        }
        public void Close()
        {
            _driver.Quit();
        }
        public bool IsValid(string input)
        {
            var newStringArray = input.Split(" - ");
            var time = DateTime.Parse(newStringArray[0]);
            if (time < DateTime.Now) return true;
            return false;

        }
        public int CheckNumber(int input)
        {
            if (input > 10) return 10;
            return input;
        }
    }
}

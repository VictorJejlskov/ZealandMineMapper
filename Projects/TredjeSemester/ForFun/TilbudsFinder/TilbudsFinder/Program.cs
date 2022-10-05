// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TilbudsFinder;

SearchEngine SearchEngine = new SearchEngine();
SearchEngine.Start();

SearchEngine.Close();
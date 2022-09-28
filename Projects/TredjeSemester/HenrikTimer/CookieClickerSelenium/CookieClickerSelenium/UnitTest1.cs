using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using System.Diagnostics;

namespace CookieClickerSelenium
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly string DriverDirectory = "C:\\webDrivers";
        private static IWebDriver _driver;
        private static IWebElement cookie;
        private static IWebElement language;
        private static IWebElement buy;
        private static IWebElement price;
        private static IWebElement balance;
        private static IWebElement upgrade;



        [ClassInitialize]
        public static void TestSetup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory);
            string url = "https://orteil.dashnet.org/cookieclicker/";
            _driver.Navigate().GoToUrl(url);
            
        }
        [TestMethod]
        public void TestMethod1()
        {
            
            
            Thread.Sleep(2000);
            language = _driver.FindElement(By.Id("langSelect-EN"));
            language.Click();
            Thread.Sleep(5000);
            balance = _driver.FindElement(By.Id("cookies"));
            price = _driver.FindElement(By.Id("productPrice0"));

            int balanceAmount = UpdateBalance();
            int priceAmount = UpdatePrice();
            for(int i = 0; i< 20; i++)
            {
                Thread.Sleep(100);
                //try
                //{
                //    upgrade = _driver.FindElement(By.Id("upgrade0"));
                //    upgrade.Click();
                //}
                //catch
                //{

                //}
                

                Debug.WriteLine($"Current Balance: {balanceAmount} | Current price: {priceAmount}");
                while (balanceAmount <= priceAmount)
                {
                    ClickTimes(16);
                    balance = _driver.FindElement(By.Id("cookies"));
                    balanceAmount = UpdateBalance();
                    priceAmount = UpdatePrice();
                }
                Thread.Sleep(20);
                Buy(0);
                balanceAmount = UpdateBalance();
                priceAmount = UpdatePrice();
            }
            Assert.AreEqual("test", "test");
        }

        public void Click()
        {
            Thread.Sleep(10);
            cookie = _driver.FindElement(By.Id("bigCookie"));
            cookie.Click();
        }
        public void ClickTimes(int times)
        {
            cookie = _driver.FindElement(By.Id("bigCookie"));
            for(int i = 0; i< times; i++)
            {
                Thread.Sleep(10);
                cookie.Click();
            }
        }
        public void Buy(int id)
        {
            Thread.Sleep(5);
            buy = _driver.FindElement(By.Id("product"+id));
            buy.Click();
            Debug.WriteLine("I bought one!");
        }
        public int UpdateBalance()
        {
            balance = _driver.FindElement(By.Id("cookies"));
            string[] balanceArray = balance.Text.Split(" co");
            int balanceAmount = Convert.ToInt32(balanceArray[0]);
            return balanceAmount;
        }
        public int UpdatePrice()
        {
            price = _driver.FindElement(By.Id("productPrice0"));
            int priceAmount = Convert.ToInt32(price.Text);
            return priceAmount;
        }
    }
}
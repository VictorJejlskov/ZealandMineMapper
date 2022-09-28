using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace CollectWordsTest
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly string DriverDirectory = "C:\\webDrivers";
        private static IWebDriver _driver;

        private static IWebElement inputElement;
        private static IWebElement outputElement;
        private static IWebElement saveButton;
        private static IWebElement clearButton;

        [ClassInitialize]
        public static void TestSetup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory);
            //_driver = new FirefoxDriver(DriverDirectory);
            string url = "file:///C:/Users/victo/Desktop/CollectWords/index.html";
            _driver.Navigate().GoToUrl(url);
            inputElement = _driver.FindElement(By.Id("inputWord"));
            outputElement = _driver.FindElement(By.Id("outputWord"));
            saveButton = _driver.FindElement(By.Id("buttonSave"));
            clearButton = _driver.FindElement(By.Id("buttonClear"));
        }
        [TestMethod]
        public void TestMethod()
        {
            Thread.Sleep(1000);
            Assert.AreEqual("Collect Words", _driver.Title);

            Thread.Sleep(1000);
            inputElement.SendKeys("This is a test");
            saveButton.Click();
            string text = outputElement.Text;
            Assert.AreEqual("This is a test", text);

            Thread.Sleep(1000);
            clearButton.Click();
            text = outputElement.Text;
            Assert.AreEqual("empty", text);


        }
    }
}
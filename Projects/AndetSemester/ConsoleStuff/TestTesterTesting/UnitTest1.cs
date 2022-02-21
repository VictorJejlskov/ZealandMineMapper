using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExceptions;

namespace TestTesterTesting
{
    [TestClass]
    public class UnitTest1
    {
        private Book _book;

        [TestInitialize]
        public void BeforeTest()
        {
            _book = new Book("Moby Dick", 1920);
        }
        [TestMethod]
        public void TestTitle()
        {
            Assert.AreEqual("Moby Dick", _book.Title);
            _book.Title = "Skrt";
            Assert.AreEqual("Skrt", _book.Title);

            try
            {
                _book.Title = null;
            }
            catch (Exception e)
            {
                Assert.AreEqual("Title is null or empty", e.Message);
            }
        }
        [TestMethod]
        public void TestYear()
        {
            Assert.AreEqual(1920, _book.Year);
            _book.Year = 1800;
            Assert.AreEqual(1800, _book.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestYearException()
        {
            _book.Year = 1000;
        }
    }
}

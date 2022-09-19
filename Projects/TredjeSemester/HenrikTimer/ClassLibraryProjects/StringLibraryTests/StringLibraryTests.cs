using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibraries.Tests
{
    [TestClass()]
    public class StringLibraryTests
    {
        [TestMethod()]
        public void StartsWithUpperTest()
        {
            string[] words = { "Alphabet", "Zebra", "ABC", "Ælling", "Martin", "Lugter" };
            foreach(var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result);
            }
        }
        [TestMethod()]
        public void DoesNotStartWithUpperTest()
        {
            string[] words = { "alphabet", "zebra", "aBC", "ælling", "martin", "lugter" };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result);
            }
        }
    }
}
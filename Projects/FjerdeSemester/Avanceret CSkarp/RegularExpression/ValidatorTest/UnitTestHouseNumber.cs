using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLib.Validation;

namespace ValidatorTest
{
    [TestClass]
    public class UnitTestHouseNumber
    {
        [TestMethod]
        [DataRow("4")]
        [DataRow("167")]
        [DataRow("167 B")]
        [DataRow("167B")]
        [DataRow("1 1")]
        [DataRow("17 1 tv")]
        [DataRow("17X 1tv")]
        [DataRow("17 1.tv")]
        public void TestHouseNumberAccept(string houseNumber)
        {
            //assert
            Assert.IsTrue(Validator.CheckHouseNumber(houseNumber));
        }


        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("a17 1 tv")]
        [DataRow("17 1#")]
        public void TestHouseNumberNotAccept(string houseNumber)
        {
            //assert
            Assert.IsFalse(Validator.CheckHouseNumber(houseNumber));
        }

        
    }
}

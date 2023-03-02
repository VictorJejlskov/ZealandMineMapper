using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLib.Validation;

namespace ValidatorTest
{
    [TestClass]
    public class UnitTestZip
    {

        [TestMethod]
        [DataRow("1234")]
        public void TestZipAccept(String zip)
        {
            //assert
            Assert.IsTrue(Validator.CheckZip(zip));
        }


        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("123")]
        [DataRow("12345")]
        [DataRow(" 4567")]
        [DataRow("4567 ")]
        [DataRow("a1234")]
        [DataRow("567#")]
        public void TestZipNotAccept(String zip)
        {
            //assert
            Assert.IsFalse(Validator.CheckZip(zip));
        }
        
    }

}


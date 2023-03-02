using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLib.Validation;

namespace ValidatorTest
{
    [TestClass]
    public class UnitTestPhone
    {
        [TestMethod]
        [DataRow("12345678")]
        [DataRow("+45 12345678")]
        [DataRow("+4512345678")]
        public void TestPhoneAccept(String phone)
        {
            //assert
            Assert.IsTrue(Validator.CheckPhone(phone));
        }


        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("1234567")]
        [DataRow("123456789")]
        [DataRow(" 12345678")]
        [DataRow("1234m678")]
        [DataRow("-45 12345678")]
        [DataRow("+45 123456789")]
        [DataRow("+ab 12345678")]
        public void TestPhoneNotAccept(String phone)
        {
            //assert
            Assert.IsFalse(Validator.CheckPhone(phone));
        }
        
    }
}

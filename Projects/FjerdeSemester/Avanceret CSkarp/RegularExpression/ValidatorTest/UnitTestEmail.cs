using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLib.Validation;

namespace ValidatorTest
{
    [TestClass]
    public class UnitTestEmail
    {
        [TestMethod]
        [DataRow("peter@mail.dk")]
        [DataRow("peter-levinsky@mail.dk")]
        [DataRow("peter56@mail.dk")]
        [DataRow("peter.levinsky@mail.dk")]
        [DataRow("p@f.g.h")]
        [DataRow("p.p.p.p@m.dk")]
        public void TestEMailAccept(string email)
        {
            //assert
            Assert.IsTrue(Validator.CheckEmail(email));
        }


        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow(" peter56@mail.dk")] // starts with space
        [DataRow("p.l@dk")]
        [DataRow("p.mail.dk")]
        [DataRow("p@mail.longTopDomain")]
        public void TestEMailNotAccept(string email)
        {
            //assert
            Assert.IsFalse(Validator.CheckEmail(email));
        }
        


    }
}

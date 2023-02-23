using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexAssignment2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RegexAssignment2.Tests
{
    [TestClass()]
    public class MyValidatorTests
    {
        [TestMethod()]
        [DataRow("Victor")]
        [DataRow("Martin")]
        [DataRow("wfwef")]
        [DataRow("Frederik")]
        [DataRow("Mads")]
        [DataRow("Andy")]
        public void ValidateFirstNameTest(string name)
        {
            Assert.IsTrue(MyValidator.ValidateFirstName(name));
        }
        [TestMethod()]
        [DataRow("Vic34523")]
        [DataRow("")]
        [DataRow("r23gge")]
        public void ValidateFirstNameTestBad(string name)
        {
            Assert.IsFalse(MyValidator.ValidateFirstName(name));
        }

        [TestMethod()]
        [DataRow("Jejlskov")]
        [DataRow("Lylloff")]
        [DataRow("wfwef")]
        [DataRow("Bressendorff")]
        [DataRow("Tobiasen")]
        [DataRow("Kanjegikkehuske")]
        public void ValidateSurnameTest(string surname)
        {
            Assert.IsTrue(MyValidator.ValidateSurname(surname));
        }
        [TestMethod()]
        [DataRow("Vic34523")]
        [DataRow("")]
        [DataRow("r23gge")]
        public void ValidateSurnameTestBad(string surname)
        {
            Assert.IsFalse(MyValidator.ValidateSurname(surname));
        }

        [TestMethod()]
        [DataRow("Bakkesvinget")]
        [DataRow("Vedjegikke")]
        [DataRow("gewgwe")]
        [DataRow("gwegw")]
        [DataRow("wefwefwef")]
        [DataRow("rwerrewewr")]
        public void ValidateStreetTest(string street)
        {
            Assert.IsTrue(MyValidator.ValidateStreet(street));
        }
        [TestMethod()]
        [DataRow("Vic34523")]
        [DataRow("")]
        [DataRow("r23gge")]
        public void ValidateStreetTestBad(string street)
        {
            Assert.IsFalse(MyValidator.ValidateStreet(street));
        }

        [TestMethod()]
        [DataRow("Roskilde")]
        [DataRow("Køge")]
        [DataRow("Herning")]
        [DataRow("København")]
        [DataRow("Store Heddinge")]
        [DataRow("Lille Heddinge")]
        public void ValidatePostalCityTest(string city)
        {
            Assert.IsTrue(MyValidator.ValidatePostalCity(city));
        }
        [TestMethod()]
        [DataRow("Vic34523")]
        [DataRow("")]
        [DataRow("r23gge")]
        public void ValidatePostalCityTestBad(string city)
        {
            Assert.IsFalse(MyValidator.ValidatePostalCity(city));
        }

        [TestMethod()]
        [DataRow(4000)]
        [DataRow(4925)]
        [DataRow(5235)]
        [DataRow(4355)]
        [DataRow(2095)]
        [DataRow(3465)]
        public void ValidateZipTest(int zip)
        {
            Assert.IsTrue(MyValidator.ValidateZip(zip));
        }
        [TestMethod()]
        [DataRow(343)]
        [DataRow(234236)]
        [DataRow(234232)]
        public void ValidateZipTestBad(int zip)
        {
            Assert.IsFalse(MyValidator.ValidateZip(zip));
        }

        [TestMethod()]
        [DataRow("+4581611117")]
        [DataRow("81611117")]
        [DataRow("53958532")]
        [DataRow("34689306")]
        [DataRow("25672049")]
        public void ValidatePhoneTest(string phone)
        {
            Assert.IsTrue(MyValidator.ValidatePhone(phone));
        }
        [TestMethod()]
        [DataRow("4935")]
        [DataRow("+49866934583543")]
        [DataRow("r4ger434")]
        [DataRow("3067073625234")]
        public void ValidatePhoneTestBad(string phone)
        {
            Assert.IsFalse(MyValidator.ValidatePhone(phone));
        }

        [TestMethod()]
        [DataRow("61 fewgg")]
        [DataRow("263 fwegw")]
        [DataRow("57A")]
        [DataRow("589A")]
        [DataRow("2B")]
        public void ValidateNumberTest(string number)
        {
            Assert.IsTrue(MyValidator.ValidateNumber(number));
        }

        [TestMethod()]
        [DataRow("4935")]
        [DataRow("53958532")]
        [DataRow("gerk 356")]
        [DataRow("23463453")]
        [DataRow("0")]
        public void ValidateNumberTestBad(string number)
        {
            Assert.IsFalse(MyValidator.ValidateNumber(number));
        }


        [TestMethod()]
        [DataRow("victor@email.com")]
        [DataRow("roguevyper@tehsisri.email")]
        [DataRow("ti2106@btcmod.com")]
        [DataRow("prohoroffv@weinzed.com")]
        public void ValidateEmailTest(string email)
        {
            Assert.IsTrue(MyValidator.ValidateEmail(email));
        }
        [TestMethod()]
        [DataRow("hejrg")]
        [DataRow("efeg.com")]
        [DataRow("wada\"gijg@gmai.com")]
        public void ValidateEmailTestBad(string email)
        {
            Assert.IsFalse(MyValidator.ValidateEmail(email));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Duathlete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duathlete.Models.Tests
{
    [TestClass()]
    public class DuathleteTests
    {
        //BIP, Name, Age, Bike, Run
        Duathlete GoodAthlete = new Duathlete(1, "Søren", 26, 120, 50);
        Duathlete ShortNameAthlete = new Duathlete(2, "Bo", 26, 120, 50);
        Duathlete EmptyNameAthlete = new Duathlete(2, "", 26, 120, 50);
        Duathlete BadAgeGroupAthlete = new Duathlete(2, "Kjeld", 26, 120, 50);


        [TestMethod()]
        public void ToStringTest()
        {
            string expected = "Bip=1, Name=Søren, AgeGroup=2, Bike=120, Run=50, Total=170";
            string actual = GoodAthlete.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            GoodAthlete.ValidateName();
            Assert.ThrowsException<ArgumentNullException>(() => EmptyNameAthlete.ValidateName());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ShortNameAthlete.ValidateName());
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(4)]
        [DataRow(5)]
        public void ValidateAgeGroupTest(int ageGroup)
        {
            BadAgeGroupAthlete.AgeGroup = ageGroup;
            
            try
            {
                BadAgeGroupAthlete.ValidateAgeGroup();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual($"Der er sket en fejl, agegroup skal altid være mellem 1 og 4 - Denne gang var den: {ageGroup}", ex.ParamName);
            }
            GoodAthlete.ValidateAgeGroup();
        }

        [TestMethod()]
        public void ValidateTotalTest()
        {
            int expected = 170;
            int actual = GoodAthlete.Total;

            Assert.AreEqual(expected, actual);
            GoodAthlete.ValidateTotal();
        }

        [TestMethod()]
        public void ValidateTest()
        {
            GoodAthlete.Validate();
            Assert.ThrowsException<ArgumentNullException>(() => EmptyNameAthlete.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ShortNameAthlete.Validate());
            BadAgeGroupAthlete.AgeGroup = 0;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => BadAgeGroupAthlete.Validate());
        }
    }
}
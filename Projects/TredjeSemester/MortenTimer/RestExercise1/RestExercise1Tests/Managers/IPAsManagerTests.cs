using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestExercise1.Managers;
using RestExercise1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestExercise1.Managers.Tests
{
    [TestClass()]
    public class IPAsManagerTests
    {
        public IPAsManager Manager { get; set; } = new IPAsManager();
        //[TestMethod()]
        //public void GetAllTest()
        //{
        //    var ipaList = Manager.GetAll();
        //    //Tester hvorvidt listen er Null 
        //    Assert.IsNotNull(ipaList); 
        //    //Tester om listen er 2 objekter lang
        //    Assert.AreEqual(2, ipaList.Count);
        //    //Tester om listen er af typen List<IPA>
        //    Assert.IsInstanceOfType(ipaList, typeof(List<RestExercise1.Models.IPA>));
        //}

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.IsNotNull(Manager.GetById(1));
        }

        [TestMethod()]
        public void AddTest()
        {
            Manager.Add(new IPA { Brand = "Anarkist", Grain = "Malt", Id = 1, Name = "Vacation Forever", Proof = 6.3 });
            Assert.AreEqual(3, Manager.GetAll("").Count);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Manager.Delete(1);
            Assert.AreEqual(1, Manager.GetAll("").Count);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Manager.Update(2, new IPA { Brand = "Anarkist", Grain = "Malt", Id = 1, Name = "Vacation Forever", Proof = 6.3 });
            Assert.AreEqual(Manager.GetById(2), new IPA { Brand = "Anarkist", Grain = "Malt", Id = 1, Name = "Vacation Forever", Proof = 6.3 });
        }
    }
}
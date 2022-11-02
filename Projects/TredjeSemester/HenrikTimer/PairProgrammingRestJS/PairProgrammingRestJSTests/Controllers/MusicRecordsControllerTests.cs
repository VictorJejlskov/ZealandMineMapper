using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairProgrammingRestJS.Controllers;
using PairProgrammingRestJS.Managers;
using PairProgrammingRestJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingRestJS.Controllers.Tests
{
    [TestClass()]
    public class MusicRecordsControllerTests
    {
        [TestCleanup()]
        public void CleanUp()
        {
            MusicRecordsManager.Reset();
        }
        [TestMethod()]
        public void GetTest()
        {
            var manager = new MusicRecordsManager();
            List<MusicRecord> testList = manager.GetAll();
            Assert.IsNotNull(testList);
            Assert.AreEqual(5, testList.Count);
            
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            var manager = new MusicRecordsManager();
            var idToFind = 5;
            var expected = new MusicRecord(5, "Industry baby", "Lil Nas X");

            var actual = manager.GetById(idToFind);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PostTest()
        {
            var manager = new MusicRecordsManager();
            MusicRecord recordToAdd = new MusicRecord(6, "House Music", "Boris Brejcha");
            var expectedObject = recordToAdd;
            var expectedCount = 6;

            var actualObject = manager.Add(recordToAdd);
            var actualCount = manager.GetAll().Count();

            Assert.AreEqual(expectedObject, actualObject);
            Assert.AreEqual(expectedCount, actualCount);


        }

        [TestMethod()]
        public void PutTest()
        {
            var manager = new MusicRecordsManager();
            var recordToUpdate = new MusicRecord(100, "Space Diver", "Boris Brejcha");
            var notExpected = recordToUpdate;
            var idToChange = 4;
            var expected = new MusicRecord(idToChange, "Space Diver", "Boris Brejcha"); ;
            expected.Id = idToChange;

            var actual = manager.Update(recordToUpdate, idToChange);

            Assert.AreNotEqual(notExpected, actual);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void DeleteTest()
        {
            var manager = new MusicRecordsManager();
            List<MusicRecord> testList = manager.GetAll();
            var idToDelete = 5;
            var expectedCount = testList.Count() - 1;
            MusicRecord expectedObject = new MusicRecord(5, "Industry baby", "Lil Nas X");

            var actualObject = manager.Delete(idToDelete);

            Assert.AreEqual(expectedCount ,testList.Count());
            Assert.AreEqual(expectedObject, actualObject);

        }
    }
}
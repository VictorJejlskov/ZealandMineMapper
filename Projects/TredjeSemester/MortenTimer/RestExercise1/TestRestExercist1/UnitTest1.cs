using RestExercise1;
using RestExercise1.Managers;

namespace TestRestExercist1
{
    [TestClass]
    public class UnitTest1
    {
        public IPAsManager Manager;
        [TestInitialize]
        public void Setup()
        {
            Manager = new IPAsManager();
        }
        [TestMethod]
        public void TestGetAll()
        {
            Assert.AreEqual(Manager.GetAll().Count, 2);
        }
    }
}
using MyMath;

namespace MathTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicRooterTest()
        {
            //Arrange
            Rooter rooter = new Rooter();
            double expectedResult = 2;
            double input = expectedResult * expectedResult;

            //Act
            double actualResult = rooter.SquareRoot(input);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, expectedResult / 100);
        }
        [TestMethod]
        public void RooterTest_12()
        {
            //Arrange
            Rooter rooter = new Rooter();
            double expectedResult = 12;
            double input = expectedResult * expectedResult;

            //Act
            double actualResult = rooter.SquareRoot(input);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, expectedResult / 100);
        }
        [TestMethod]
        public void RooterTest_Exceptions()
        {
            //Arrange
            Rooter rooter = new Rooter();
            try
            {
                rooter.SquareRoot(-4);
            }
            catch (System.ArgumentException)
            {
                return;
            }
            Assert.Fail();
        }
    }
}
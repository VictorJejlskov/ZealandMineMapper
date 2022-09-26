namespace TestStringUtility
{
    [TestClass]
    public class TestStringUtility
    {
        [TestMethod]
        public void ShouldFindOneYInMysterious()
        {
            //Arrange
            string stringToCheck = "mysterious";
            string stringToFind = "y";
            int expectedResult = 1;

            //Act
            StringUtility.StringUtility utility = new StringUtility.StringUtility();
            int actualResult = utility.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ShouldFindTwoSInMysterious()
        {
            //Arrange
            string stringToCheck = "mysterious";
            string stringToFind = "s";
            int expectedResult = 2;

            //Act
            StringUtility.StringUtility utility = new StringUtility.StringUtility();
            int actualResult = utility.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SearchShouldntBeCaseSensitive()
        {
            //Arrange
            string stringToCheck = "mySterious";
            string stringToFind = "s";
            int expectedResult = 2;

            //Act
            StringUtility.StringUtility utility = new StringUtility.StringUtility();
            int actualResult = utility.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
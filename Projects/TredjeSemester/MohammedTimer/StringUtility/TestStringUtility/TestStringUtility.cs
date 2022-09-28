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
        [TestMethod]
        public void StringToCheckShouldNotBeNull()
        {
            //Arrenge
            string stringToCheck = null;
            string stringToFind = "s";
            int expectedResult = 0;

            //Act
            StringUtility.StringUtility utility = new StringUtility.StringUtility();
            int actualResult = utility.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void StringToFindShouldNotBeNull()
        {
            //Arrenge
            string stringToCheck = "Mysterious";
            string stringToFind = null;
            int expectedResult = 0;

            //Act
            StringUtility.StringUtility utility = new StringUtility.StringUtility();
            int actualResult = utility.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void StringToCheckShouldNotBeEmpty()
        {
            //Arrenge
            string stringToCheck = "";
            string stringToFind = "s";
            int expectedResult = 0;

            //Act
            StringUtility.StringUtility utility = new StringUtility.StringUtility();
            int actualResult = utility.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void StringToFindShouldNotBeEmpty()
        {
            //Arrenge
            string stringToCheck = "Mysterious";
            string stringToFind = "";
            int expectedResult = 0;

            //Act
            StringUtility.StringUtility utility = new StringUtility.StringUtility();
            int actualResult = utility.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void StringToCheckAndFindOneLetter()
        {
            //Arrenge
            string stringToCheck = "M";
            string stringToFind = "m";
            int expectedResult = 1;

            //Act
            StringUtility.StringUtility utility = new StringUtility.StringUtility();
            int actualResult = utility.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void StringToCheckAndFindTwelveLetter()
        {
            //Arrenge
            string stringToCheck = "Mysteriously";
            string stringToFind = "Mysteriously";
            int expectedResult = 1;

            //Act
            StringUtility.StringUtility utility = new StringUtility.StringUtility();
            int actualResult = utility.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
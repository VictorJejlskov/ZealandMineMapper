using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring_Exercise;

namespace UnitTestProject_Refactoring
{
    [TestClass]
    public class UnitTestRefactoring
    {
        [TestMethod]
        public void AddingTransactionToSilverAccount()
        {
            // Arrange
            var aType = Account.AccountType.Silver;
            var sut = Account.CreateAccount(aType);

            // Act
            sut.AddTransaction(200m);
            int result = sut.RewardPoints;

            //assert
            Assert.AreEqual(20, result);
            Assert.AreEqual(200, sut.Balance);
        }

        [TestMethod]
        public void AddingTransactionToGoldAccount()
        {
            // Arrange
            var aType = Account.AccountType.Gold;
            var sut = Account.CreateAccount(aType);

            // Assert
            sut.AddTransaction(20000m);
            int result = sut.RewardPoints;
            decimal balance = sut.Balance;

            //assert
            Assert.AreEqual(20000, sut.Balance);
            Assert.AreEqual(20000, balance);
            Assert.AreEqual(4010, result);
        }

        [TestMethod]
        public void AddingTransactionToPlatinumAccount()
        {
            // Arrange
            var aType = Account.AccountType.Platinum;
            var sut = Account.CreateAccount(aType);

            // Assert
            sut.AddTransaction(10000m);
            int result = sut.RewardPoints;
            decimal balance = sut.Balance;

            //assert
            Assert.AreEqual(10000, balance);
            Assert.AreEqual(5010, result);
        }
        [TestMethod]
        public void AddingTransactionToDefaultAccount()
        {
            // Arrange
            var sut = Account.CreateAccount(0);

            // Assert
            sut.AddTransaction(10000m);
            int result = sut.RewardPoints;
            decimal balance = sut.Balance;

            //assert
            Assert.AreEqual(10000, balance);
            Assert.AreEqual(0, result);
        }
    }
}

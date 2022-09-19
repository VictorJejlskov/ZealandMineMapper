using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring_Exercise
{
    public abstract class Account
    {

        private protected int _amountDivisor;
        private protected int _balanceDivisor;
        public decimal Balance
        {
            get;
            private set;
        }

        public int RewardPoints
        {
            get;
            private set;
        }
        public void AddTransaction(decimal amount)
        {
            Balance += amount;
            RewardPoints += CalculateRewardPoints(amount);
        }
        public abstract int CalculateRewardPoints(decimal amount);
        public enum AccountType
        {
            Silver = 1,
            Gold = 2,
            Platinum = 3
        }
        public AccountType accType;
        public static Account CreateAccount(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Silver:
                    return new AccountSilver();
                case AccountType.Gold:
                    return new AccountGold();
                case AccountType.Platinum:
                    return new AccountPlatinum();
                default:
                    return new AccountDefault();

            }
        }

        public static Account TestFactory(Account accountType)
        {
            switch (accountType)
            {
                case AccountSilver silver:
                    return new AccountSilver();
                case AccountGold gold:
                    return new AccountGold();
                case AccountPlatinum platinum:
                    return new AccountPlatinum();
                default:
                    return new AccountDefault();

            }
        }
    }
}


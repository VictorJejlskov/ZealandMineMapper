using System;

namespace Refactoring_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Account defaultAccount = Account.CreateAccount(0);
            Account silverAccount = Account.CreateAccount(Account.AccountType.Silver);
            Account goldAccount = Account.CreateAccount(Account.AccountType.Gold);
            Account platinumAccount = Account.CreateAccount(Account.AccountType.Platinum);
        }
    }
}

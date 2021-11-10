using System;

namespace BankV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount myAccount = new BankAccount();
            Console.WriteLine("Whose account do you want to access?");
            myAccount.AccountHolder = Console.ReadLine();

            Console.WriteLine($"Account belongs to : {myAccount.AccountHolder}");
            myAccount.Deposit(2000);
            Console.WriteLine($"Account balance is : {myAccount.Balance}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Account belongs to : {myAccount.AccountHolder}");
            myAccount.Withdraw(1500);
            Console.WriteLine($"Account balance is : {myAccount.Balance}");

            // The LAST line of code should be ABOVE this line
        }
    }
}
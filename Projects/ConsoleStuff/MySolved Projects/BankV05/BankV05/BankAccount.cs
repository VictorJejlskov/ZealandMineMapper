namespace BankV05
{
    /// <summary>
    /// This class represents a very simple bank account.
    /// Only the amount of money on the account is represented.
    /// </summary>
    public class BankAccount
    {
        private double _balance;
        private string _accountHolder;



        public BankAccount()
        {
            _accountHolder = "John Doe";
            _balance = 0.0;
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set { _accountHolder = value; }
        }

        public double Balance
        {
            get { return _balance;}
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            _balance = _balance - amount;
        }
    }
}
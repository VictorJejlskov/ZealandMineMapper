import IBankAccount from "./IBankAccount";

abstract class BankAccount implements IBankAccount {
  constructor(
    public accountNumber: number = BankAccount.nextAccountNumber++,
    public balance: number,
    public firstName: string,
    public lastName: string,
    public rateOfInterest: number,
    public ssn: number
  ) {}

  static nextAccountNumber: number = 100;
  abstract addInterest()
  abstract addInterest(fee: number)
  deposit(amount: number) {
    if(amount >= 0) this.balance += amount
  }
  getBalance(): number {
    return this.balance
  }
  withdraw(amount: number) {
    if (this.balance-amount > 0) this.balance -= amount
  }
  
}

export default BankAccount
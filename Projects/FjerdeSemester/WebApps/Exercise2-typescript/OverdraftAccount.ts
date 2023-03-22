import BankAccount from "./BankAccount"

class OverdraftAccount extends BankAccount {
  constructor(
    public accountNumber: number = BankAccount.nextAccountNumber++,
    public balance: number,
    public firstName: string,
    public lastName: string,
    public rateOfInterest: number,
    public ssn: number,
    public overdraftInterest: number,
    public overdraftLimit: number
  ) {
    super(accountNumber, balance, firstName, lastName, rateOfInterest, ssn)
  }
  addInterest = (fee?: number) => {
    if (this.balance > 0) this.balance *= this.rateOfInterest / 100 + 1
    else this.balance *= (this.rateOfInterest / 100 - 1) * -1
    if (fee && this.balance < 0) this.balance -= fee
  }
  checkLimit = (): boolean => {
    return this.balance >= this.overdraftLimit
  }
  withdraw(amount: number) {
    if (this.balance-amount < this.overdraftLimit) this.balance -= amount
  }
}
export default OverdraftAccount
import BankAccount from "./BankAccount";

class LoanAccount extends BankAccount{
    constructor(
        public accountNumber: number = BankAccount.nextAccountNumber++,
        public balance: number,
        public firstName: string,
        public lastName: string,
        public rateOfInterest: number,
        public ssn: number,
        public principal: number
    ){
        super(accountNumber, balance, firstName, lastName, rateOfInterest, ssn)
    }
    addInterest(fee?: number) {
        this.balance -= this.balance * this.rateOfInterest / 100;
        if (fee != null) {
            this.balance -= fee;
        }
    }
    
}
export default LoanAccount
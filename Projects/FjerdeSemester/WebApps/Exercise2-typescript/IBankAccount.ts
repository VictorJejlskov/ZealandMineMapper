interface IBankAccount{
    accountNumber: number,
    balance: number,
    firstName: string,
    lastName: string,
    rateOfInterest: number,
    ssn: number

    addInterest()
    addInterest(fee: number)
    deposit(amount: number)
    getBalance(): number
    withdraw(amount: number)
}
export default IBankAccount


import LoanAccount from "./LoanAccount"
import OverdraftAccount from "./OverdraftAccount"

const acc1 = new LoanAccount(0, 100, "Victor", "Jejlskov", 10, 1001, 1)
const acc2 = new OverdraftAccount(0, 100, "Victor", "Jejlskov", 10, 1001, 10, 10000)

console.log("Account 1:")
console.log(acc1.getBalance())

acc1.deposit(500)
console.log("Account 1:")
console.log(acc1.getBalance())

acc1.withdraw(450)
console.log("Account 1:")
console.log(acc1.getBalance())

acc1.withdraw(500)
console.log("Account 1:")
console.log(acc1.getBalance())


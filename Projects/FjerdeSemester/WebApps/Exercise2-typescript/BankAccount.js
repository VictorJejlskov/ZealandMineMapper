"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var BankAccount = /** @class */ (function () {
    function BankAccount(accountNumber, balance, firstName, lastName, rateOfInterest, ssn) {
        if (accountNumber === void 0) { accountNumber = BankAccount.nextAccountNumber++; }
        this.accountNumber = accountNumber;
        this.balance = balance;
        this.firstName = firstName;
        this.lastName = lastName;
        this.rateOfInterest = rateOfInterest;
        this.ssn = ssn;
    }
    BankAccount.prototype.deposit = function (amount) {
        if (amount >= 0)
            this.balance += amount;
    };
    BankAccount.prototype.getBalance = function () {
        return this.balance;
    };
    BankAccount.prototype.withdraw = function (amount) {
        if (this.balance - amount > 0)
            this.balance -= amount;
    };
    BankAccount.nextAccountNumber = 100;
    return BankAccount;
}());
exports.default = BankAccount;

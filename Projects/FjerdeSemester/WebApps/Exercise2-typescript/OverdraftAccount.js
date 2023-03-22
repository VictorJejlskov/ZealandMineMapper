"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
var BankAccount_1 = require("./BankAccount");
var OverdraftAccount = /** @class */ (function (_super) {
    __extends(OverdraftAccount, _super);
    function OverdraftAccount(accountNumber, balance, firstName, lastName, rateOfInterest, ssn, overdraftInterest, overdraftLimit) {
        if (accountNumber === void 0) { accountNumber = BankAccount_1.default.nextAccountNumber++; }
        var _this = _super.call(this, accountNumber, balance, firstName, lastName, rateOfInterest, ssn) || this;
        _this.accountNumber = accountNumber;
        _this.balance = balance;
        _this.firstName = firstName;
        _this.lastName = lastName;
        _this.rateOfInterest = rateOfInterest;
        _this.ssn = ssn;
        _this.overdraftInterest = overdraftInterest;
        _this.overdraftLimit = overdraftLimit;
        _this.addInterest = function (fee) {
            if (_this.balance > 0)
                _this.balance *= _this.rateOfInterest / 100 + 1;
            else
                _this.balance *= (_this.rateOfInterest / 100 - 1) * -1;
            if (fee && _this.balance < 0)
                _this.balance -= fee;
        };
        _this.checkLimit = function () {
            return _this.balance >= _this.overdraftLimit;
        };
        return _this;
    }
    OverdraftAccount.prototype.withdraw = function (amount) {
        if (this.balance - amount < this.overdraftLimit)
            this.balance -= amount;
    };
    return OverdraftAccount;
}(BankAccount_1.default));
exports.default = OverdraftAccount;

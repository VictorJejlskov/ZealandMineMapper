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
var LoanAccount = /** @class */ (function (_super) {
    __extends(LoanAccount, _super);
    function LoanAccount(accountNumber, balance, firstName, lastName, rateOfInterest, ssn, principal) {
        if (accountNumber === void 0) { accountNumber = BankAccount_1.default.nextAccountNumber++; }
        var _this = _super.call(this, accountNumber, balance, firstName, lastName, rateOfInterest, ssn) || this;
        _this.accountNumber = accountNumber;
        _this.balance = balance;
        _this.firstName = firstName;
        _this.lastName = lastName;
        _this.rateOfInterest = rateOfInterest;
        _this.ssn = ssn;
        _this.principal = principal;
        return _this;
    }
    LoanAccount.prototype.addInterest = function (fee) {
        this.balance -= this.balance * this.rateOfInterest / 100;
        if (fee != null) {
            this.balance -= fee;
        }
    };
    return LoanAccount;
}(BankAccount_1.default));
exports.default = LoanAccount;

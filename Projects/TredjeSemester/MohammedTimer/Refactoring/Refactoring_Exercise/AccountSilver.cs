using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring_Exercise
{
    public class AccountSilver : Account
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            _amountDivisor = 10;
            int points;
            points = (int)decimal.Floor(amount / _amountDivisor);
            return Math.Max(points, 0);
        }
    }
}

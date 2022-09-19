using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring_Exercise
{
    public class AccountGold : Account
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            _amountDivisor = 5;
            _balanceDivisor = 2000;
            int points;
            points = (int)decimal.Floor((Balance / _balanceDivisor) + (amount / _amountDivisor));
            return Math.Max(points, 0);
        }
    }
}

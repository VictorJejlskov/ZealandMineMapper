using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring_Exercise
{
    public class AccountPlatinum : Account
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            _amountDivisor = 2;
            _balanceDivisor = 1000;
            int points;
            points = (int)decimal.Ceiling((Balance / _balanceDivisor) + (amount / _amountDivisor));
            return Math.Max(points, 0);
        }
    }
}

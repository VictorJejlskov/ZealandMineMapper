using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring_Exercise
{
    public class AccountDefault : Account
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return 0;
        }
    }
}

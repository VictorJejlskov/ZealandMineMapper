using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringV10
{
    public class FilterIsDivisibleBy5 : IFilterCondition
    {
        public bool Condition(int value)
        {
            return value % 5 == 0;
        }

        public static string FilterType()
        {
            return "Filter: Is Divisible By 5";
        }
    }
}

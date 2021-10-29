using System.Collections.Generic;
using System.Linq.Expressions;

namespace FilteringV10
{
    /// <summary>
    /// Class capable on filtering a List of integers.
    /// Current filtering condition:
    /// Include values larger than 10.
    /// </summary>
    public static class Filter
    {
        public static List<int> FilterValues(List<int> values, IFilterCondition filterCondition)
        {
            List<int> filteredValues = new List<int>();

            foreach (var value in values)
            {
                if (filterCondition.Condition(value))
                {
                    filteredValues.Add(value);
                }
            }

            return filteredValues;
        }

        public static List<int> MultipleFilterValues(List<int> values, List<IFilterCondition> filterConditions)
        {
            List<int> filteredValues = values;

            foreach (IFilterCondition filterCondition in filterConditions)
            {
                filteredValues = FilterValues(filteredValues, filterCondition);
            }

            return filteredValues;
        }
    }
}
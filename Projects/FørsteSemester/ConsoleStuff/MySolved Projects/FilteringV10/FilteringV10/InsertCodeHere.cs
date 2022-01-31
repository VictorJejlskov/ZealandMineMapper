using System;
using System.Collections.Generic;

namespace FilteringV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> values = new List<int>() {12, 24, 9, 10, 6, 3, 45, 46, 60, 18, 39, 26, 39, 25, 15, 75, 20, 40, 80};
            List<int> filteredValues = Filter.FilterValues(values, new FilterIsEvenNumber());

            Console.WriteLine(FilterIsEvenNumber.FilterType());
            foreach (var value in filteredValues)
            {
                Console.Write($" {value} ");
            }
            Console.WriteLine($"\n");

            filteredValues = Filter.FilterValues(values, new FilterIsDivisibleBy6());
            Console.WriteLine(FilterIsDivisibleBy6.FilterType());
            foreach (var value in filteredValues)
            {
                Console.Write($" {value} ");
            }
            Console.WriteLine($"\n");

            filteredValues = Filter.FilterValues(values, new FilterIsDivisibleBy5());
            Console.WriteLine(FilterIsDivisibleBy5.FilterType());
            foreach (var value in filteredValues)
            {
                Console.Write($" {value} ");
            }
            Console.WriteLine($"\n");



            List<IFilterCondition> filterConditions = new List<IFilterCondition>();
            filterConditions.Add(new FilterIsEvenNumber());
            filterConditions.Add(new FilterIsDivisibleBy5());
            filteredValues = Filter.MultipleFilterValues(values, filterConditions);
            Console.WriteLine("Filters: Even & Divisible by 5");
            foreach (var value in filteredValues)
            {
                Console.Write($" {value} ");
            }

            Console.WriteLine($"\n");
            // The LAST line of code should be ABOVE this line
        }
    }
}
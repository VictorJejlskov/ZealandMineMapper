using System;
using System.Collections.Generic;

namespace StaticExamples
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            Car myCar1 = new Car("MinMor123", 267839);
            Car myCar2 = new Car("MinMor321", 267839);
            Car myCar3 = new Car("MinMor111", 267839);
            // The FIRST line of code should be BELOW this line

            #region ListMethods test
            List<int> aList = new List<int> { 23, 86, 51, 11, 39 };
            //ListMethods listMethodsObject = new ListMethods();
            int smallest = ListMethods.FindSmallestNumber(aList);
            Console.WriteLine($"The smallest number in the list is : {smallest}");

            int average = ListMethods.FindAverage(aList);
            Console.WriteLine($"The average of the list is : {average}"); 
            #endregion

            Console.WriteLine(Car.PrintUsageStatistics());
            // The LAST line of code should be ABOVE this line
        }
    }
}
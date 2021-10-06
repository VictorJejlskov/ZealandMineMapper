using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ArrayTest
{
    class ArrayHelper
    {
        public static int LowValue(int[] input)
        {
            int lowValue = input[0];
            foreach (int i in input)
            {
                //if (lowValue > i)
                //{
                //    lowValue = i;
                //}
                lowValue = input.Min();
            }
            return lowValue;
        }

        public static int MaxValue(int[] input)
        {
            int maxValue = input[0];
            foreach (int i in input)
            {
                //if (maxValue < i)
                //{
                //    maxValue = i;
                //}

                maxValue = input.Max();
            }
            
            return maxValue;
        }

        public static int AverageValue(int[] input)
        {
            int averageValue = 0;
            int totalValue = 0;
            //foreach (int i in input)
            //{
            //    totalValue += i;
            //}

            totalValue = input.Sum();
            averageValue = Convert.ToInt32(input.Average());
            //averageValue = totalValue / input.Length;
            return totalValue;

        }
    }
}

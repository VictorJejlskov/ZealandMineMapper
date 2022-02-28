using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCarExercise
{
    class CarYearComparator : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Year - y.Year;
        }
    }
}

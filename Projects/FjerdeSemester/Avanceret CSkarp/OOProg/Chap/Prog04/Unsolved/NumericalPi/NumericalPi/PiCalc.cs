using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NumericalPi
{
    public class PiCalc
    {
        /// <summary>
        /// Executes the calculation of an 
        /// approximate value of pi.
        /// </summary>
        /// <param name="iterations">Number of iterations to perform</param>
        /// <returns>Approximate value of pi</returns>
        public double Calculate(int iterations)
        {
            int insideUnitCircleA = 0;
            int insideUnitCircleB = 0;
            int insideUnitCircleC = 0;
            int insideUnitCircleD = 0;

            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Run(() => { insideUnitCircleA = Iterate(iterations/4); }));
            tasks.Add(Task.Run(() => { insideUnitCircleB = Iterate(iterations/4); }));
            tasks.Add(Task.Run(() => { insideUnitCircleC = Iterate(iterations/4); }));
            tasks.Add(Task.Run(() => { insideUnitCircleD = Iterate(iterations/4); }));

            Task.WaitAll(tasks.ToArray());
            int result = (insideUnitCircleA + insideUnitCircleB + insideUnitCircleC + insideUnitCircleD);
            return result * 4.0 / iterations;

        }

        /// <summary>
        /// Perform a number of "dart-throwing" simulations.
        /// </summary>
        /// <param name="iterations">Number of dart-throws to perform</param>
        /// <returns>Number of throws within the unit circle</returns>
        public int Iterate(int iterations)
        {
            Random _generator = new Random(Guid.NewGuid().GetHashCode());
            int insideUnitCircle = 0;

            for (int i = 0; i < iterations; i++)
            {
                double x = _generator.NextDouble();
                double y = _generator.NextDouble();

                if (x * x + y * y < 1.0)
                {
                    insideUnitCircle++;
                }
            }

            return insideUnitCircle;
        }
    }
}
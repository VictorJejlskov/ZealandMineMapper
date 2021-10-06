using System;

namespace CalculationSimulation
{
    /// <summary>
    /// This class simulates a calculation of a value depending on
    /// an x and y value. The calculation takes about 500 milliseconds.
    /// However, the simulator may optionally use a cache to speed
    /// up the caluclation.
    /// </summary>
    public class Simulator
    {
        #region Instance fields
        private Random _generator;
        private bool _useCache;
        private Cache _cache;
        public int MaxValue { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Only create the cache if specified
        /// </summary>
        public Simulator(int maxValue)
        {
            _generator = new Random();
            _useCache = true;
            MaxValue = maxValue;
            _cache = (_useCache ? new Cache() : null);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Simulate a calculation, possibly using a cached value.
        /// </summary>
        public int Calculate(int x, int y)
        {
            int result = Constants.CalculationNoValue;

            if (x < MaxValue && x >= 0 && y < MaxValue && y >= 0)
            {
                if (_useCache)
                {
                    result = _cache.Lookup(x, y);
                }

                if (result == Constants.CalculationNoValue)
                {
                    result = DoCalculation(x, y);

                    if (_useCache)
                    {
                        _cache.Insert(x, y, result);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Simulate an actual calculation
        /// </summary>
        private int DoCalculation(int x, int y)
        {
            Pause(Constants.SimulationTimeInMilliSecs);
            return _generator.Next(Constants.CalculationMinValue, Constants.CalculationMaxValue);
        }

        /// <summary>
        /// Pause for the specified number of milliseconds
        /// </summary>
        private void Pause(int mSecs)
        {
            System.Threading.Thread.Sleep(mSecs);
        } 
        #endregion
    }
}

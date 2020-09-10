using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats setStats;
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            if(numbers.Count() == 0)
            {
                setStats.max = float.NaN;
                setStats.max = float.NaN;
                setStats.max = float.NaN;
                return setStats;
            }
            else
            {
                ReturnAverage(numbers);
                ReturnMax(numbers);
                ReturnMin(numbers);
                return setStats;
            }
        }
        private void ReturnAverage(List<float> numbers)
        {
            float computedAverage = numbers.Sum() / numbers.Count();
            setStats.average = computedAverage;
        }
        private void ReturnMax(List<float> numbers)
        {
            float max = numbers.Max();
            setStats.max = max;
        }
        private void ReturnMin(List<float> numbers)
        {
            float min = numbers.Min();
            setStats.min = min;
        }
    }
}

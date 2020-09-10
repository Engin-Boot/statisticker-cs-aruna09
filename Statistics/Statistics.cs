using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {

        public Stats setStats;
        public Stats CalculateStatistics(List<double> numbers) {
            //Implement statistics here
            setStats = new Stats();
            if(numbers.Count() == 0)
            {
                setStats.max = double.NaN;
                setStats.max = double.NaN;
                setStats.max = double.NaN;
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
        private void ReturnAverage(List<double> numbers)
        {
            double computedAverage = numbers.Sum() / numbers.Count();
            setStats.average = computedAverage;
        }
        private void ReturnMax(List<double> numbers)
        {
            double max = numbers.Max();
            setStats.max = max;
        }
        private void ReturnMin(List<double> numbers)
        {
            double min = numbers.Min();
            setStats.min = min;
        }
    }
}

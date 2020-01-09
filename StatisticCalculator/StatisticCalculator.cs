using System;
using InterfaceCalculator;
using MeanLogic;

namespace StatisticCalculator
{
    public class StatisticCalculator : Calculator4, IAvgMean
    {
        private readonly MeanInt calcMean = new MeanInt();

        public dynamic Mean_Average(dynamic array)
        {
            return calcMean.Mean_Average(array);
        }
    }
}

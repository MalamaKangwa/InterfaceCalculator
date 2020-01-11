using System;
using InterfaceCalculator;
using MeanLogic;
using Variance;

namespace StatisticCalculator
{
    public class StatisticCalculator : Calculator4, IAvgMean, IVariance
    {
        private readonly MeanInt calcMean = new MeanInt();
        private readonly getVariance calcVariance = new getVariance();

        public dynamic Mean_Average(dynamic array)
        {
            return calcMean.Mean_Average(array);
        }

        public dynamic Variance(dynamic array)
        {
            return calcVariance.Variance(array);
        }

    }
}

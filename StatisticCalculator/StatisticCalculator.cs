using System;
using InterfaceCalculator;
using MeanLogic;
using VarianceLogic;
using StandardDev;

namespace StatisticCalculator
{
    public class StatisticCalculator : Calculator4, IAvgMean, IVariance, IStandardDev
    {
        private readonly MeanInt calcMean = new MeanInt();
        private readonly getVariance calcVariance = new getVariance();
        private readonly getStandardDev calcStandardDev = new getStandardDev();

        public dynamic Mean_Average(dynamic array)
        {
            return calcMean.Mean_Average(array);
        }

        public dynamic Variance(dynamic array)
        {
            return calcVariance.Variance(array);
        }

        public dynamic StandardDeviation(dynamic array)
        {
            return calcStandardDev.StandardDeviation(array);
        }


    }
}


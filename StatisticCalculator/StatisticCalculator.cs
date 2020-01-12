using System;
using InterfaceCalculator;
using MeanLogic;
using VarianceLogic;
using StandardDev;
using Z_Score;


namespace StatisticCalculator
{
    public class StatisticCalculator : Calculator4, IAvgMean, IVariance, IStandardDev
    {
        private readonly MeanInt calcMean = new MeanInt();
        private readonly getVariance calcVariance = new getVariance();
        private readonly getStandardDev calcStandardDev = new getStandardDev();
        private readonly getZ_Score calcZ_Score = new getZ_Score();

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

        public dynamic ZScore(dynamic a, dynamic array)
        {
            return calcZ_Score.ZScore(a, array);
        }


    }
}


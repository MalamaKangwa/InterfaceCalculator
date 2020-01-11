using System;
using VarianceLogic;

namespace StandardDev
{
    public class FindStandardDev
    {
        public static dynamic result;
        public static dynamic StandardDeviation(dynamic arrayA)
        {

            dynamic theVariance = FindVariance.Variance(arrayA);
            
            result = Helpers.Rounding.RoundTo2(Math.Sqrt(theVariance));
            return result;
        }
    }
}

using System;
using MeanLogic;
using Helpers;
using StandardDev;

namespace Z_Score
{
    public class FindZ_Score
    {
        public static dynamic result;

        public static dynamic ZScore(dynamic a, dynamic arrayA)
        {
            dynamic theMean = MeanAvg.Mean_Average(arrayA);
            dynamic theStandardDev = FindStandardDev.StandardDeviation(arrayA);

            dynamic ZScore_Step1 = a - theMean;
            dynamic Result1 = ZScore_Step1 / theStandardDev;

            result = Rounding.RoundTo2(Result1);

            return result;
        } 

    }
}

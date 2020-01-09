using System;
using MeanLogic;

namespace MeanLogic
{
    public class MeanInt: IAvgMean
    {
        public static dynamic result;

        public dynamic Mean_Average(dynamic a)
        {
            result = MeanAvg.Mean_Average(a);
            return result;
        }
        
    }
}

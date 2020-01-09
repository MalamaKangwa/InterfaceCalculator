using System;
using AvgMean;

namespace AvgMean
{
    public class MeanInt: IAvgMean
    {
        public static dynamic result;

        public dynamic Mean_Average(dynamic a)
        {
            result = MeanAvg.Mean(a);
            return result;
        }
        
    }
}

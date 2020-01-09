using System;
using InterfaceCalculator;

namespace AvgMean
{
    public class MeanAvg
    {
        public static dynamic result;
        public static dynamic Mean(dynamic arrayX)
        {
            var total = Addition.Sum(arrayX);
            var array_Count = Helpers.ArrayHelper.Length(arrayX);
            result = Division.Quotient(total, array_Count);
            return result;
        }
    }
}

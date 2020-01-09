using System;
using InterfaceCalculator;
using Helpers;

namespace MeanLogic
{
    public class MeanAvg
    {
        public static dynamic result;
        public static dynamic Mean_Average(dynamic arrayX)
        {
            var total = Addition.Sum(arrayX);
            var array_Count = Helpers.ArrayHelper.arrayLength(arrayX);
            dynamic Result1 = Division.Quotient(total, array_Count);
            result = Helpers.Rounding.RoundTo2(Result1);

            return result;
        }
    }
}
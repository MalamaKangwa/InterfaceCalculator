using System;
using MeanLogic;
using InterfaceCalculator;
using System.Diagnostics;

namespace VarianceLogic
{
    public class FindVariance
    {
        public static dynamic result;
        public static dynamic Variance(dynamic arrayA)
        {
            
            dynamic theMean = MeanAvg.Mean_Average(arrayA);
            dynamic arrayCount_1 = Helpers.ArrayHelper.arrayLength(arrayA) - 1;

            dynamic squares = new Array[0];
            dynamic squareSum = 0.0;
            dynamic differences = 0.0;


            foreach (dynamic a in arrayA) {
                differences = Subtraction.Difference(a, theMean);
                squares = Square.Squared(differences);
                squareSum = (squareSum + squares);

                Debug.WriteLine("This is the issue");

            }

            result = Division.Quotient(squareSum, arrayCount_1);
            return result;
        }
    }
}

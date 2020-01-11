using System;
using MeanLogic;
using InterfaceCalculator;
using System.Diagnostics;

namespace Variance
{
    public class FindVariance
    {
        public static dynamic result;
        public static dynamic Variance(dynamic arrayA)
        {
            
            dynamic theMean = MeanAvg.Mean_Average(arrayA);
            dynamic arrayCount_1 = Helpers.ArrayHelper.arrayLength(arrayA) - 1;

            dynamic d = new Array[0];
            dynamic f = 0.0;
            dynamic squareSum = 0.0;
            dynamic c = 0.0;


            foreach (dynamic a in arrayA) {
                c = Subtraction.Difference(a, theMean);
                d = Square.Squared(c);
                squareSum = (squareSum + d);

                //squareSum = f + a;
                //squareSum must be 34
                Debug.WriteLine("This is the issue");

            }

            result = Division.Quotient(squareSum, arrayCount_1);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class Subtraction
    {
        public static int Difference(int a, int b)
        {
            return a - b;
        }

        public static double Difference(double a, double b)
        {
            return a - b;
        }

        public static double Difference(double[] arrayA)
        {
            double c = arrayA[0];

            foreach (double a in arrayA)
            {
                c = Difference(c, a);
            }
            double d = c + arrayA[0];
            return d;
        }

        public static int Difference(int[] arrayB)
        {
            int d = arrayB[0];
            
            foreach (int a in arrayB)
            {
                d = Difference(d, a);
            }
            int e = d + arrayB[0];
            return e;
        }
    }
}

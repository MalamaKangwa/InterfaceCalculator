using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator
{
    public class Division
    {

        public static int Quotient(int a, int b)
        {
            return a / b;
        }

        public static double Quotient(double a, double b)
        {
            return a / b;
        }

        public static double Quotient(double[] arrayA)
        {
            double c = arrayA[0];

            foreach (double a in arrayA)
            {
                c = Quotient(c, a);
            }
            double d = c * arrayA[0];
            return d;
        }

        public static int Quotient(int[] arrayB)
        {
            int d = arrayB[0];

            for (int i = 1; i < arrayB.Length; i++)
            {
                d = Quotient(d, arrayB[i]);
            }
            return d;
        }

    }
}

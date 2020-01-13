using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator
{
    public class Multiply
    {
        public static dynamic Product(dynamic a, dynamic b)
        {
            return a * b;
        }

        public static double Product(double[] arrayA)
        {
            double c = arrayA[0];

            foreach (double a in arrayA)
            {
                c = Product(a, c);
            }

            double d = Helpers.Rounding.RoundTo2(c / arrayA[0]);
            return d;
        }

        public static int Product(int[] arrayB)
        {
            int d = 1;

            foreach (int a in arrayB)
            {
                d = Product(a, d);
            }
            return d;
        }

    }
}

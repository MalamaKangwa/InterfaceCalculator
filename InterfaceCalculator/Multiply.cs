using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class Multiply
    {
        public static int Product(int a, int b)
        {
            return a * b;
        }

        public static double Product(double a, double b)
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

            double d = c / arrayA[0];
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

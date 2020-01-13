using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator
{
    public class Square
    {
        public static dynamic Squared(dynamic a)
        {
            return a * a;
        }

        public static int[] Squared(int[] arrayA)
        {
            int l = Helpers.ArrayHelper.arrayLength(arrayA);
            int[] c = new int[l];
            int i = 0;

            foreach (int a in arrayA)
            {
                c[i] = Squared(a);
                i++;
            }
            return c;
        }

        public static double[] Squared(double[] arrayA)
        {
            int l = Helpers.ArrayHelper.arrayLength(arrayA);
            double[] c = new double[l];
            int i = 0;

            foreach (double a in arrayA)
            {
                c[i] = Squared(a);
                i++;
            }
            return c;
        }
    }
}

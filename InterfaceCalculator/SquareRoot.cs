using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator
{
    public class SquareRoot
    {
        public static double Root(int a)
        {
            double b = Math.Sqrt(a);
            return b;
        }

        public static double Root(double a)
        {
            double b = Math.Sqrt(a);
            return b;
        }

        
        public static double[] Root(double[] arrayA) {

            int l = Helpers.ArrayHelper.arrayLength(arrayA);
            double[] c = new double[l];
            int i = 0;
            
            foreach (double a in arrayA) 
            {
                c[i] = Root(a);
                i++;
            }
                return c;
        }

        public static double[] Root(int[] arrayA)
        {

            int l = Helpers.ArrayHelper.arrayLength(arrayA);
            double[] c = new double[l];
            int i = 0;

            foreach (int a in arrayA)
            {
                dynamic x = Root(a);
                dynamic e = Helpers.Rounding.RoundTo2(x);
                c[i] = e;
                i++;
            }
            return c;
        }
    }
}

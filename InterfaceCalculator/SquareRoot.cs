using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator
{
    public class SquareRoot
    {
        public static int Root(int a)
        {
            double b = Math.Sqrt(a);
            int c = Convert.ToInt32(b);
            return c;
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
    }
}

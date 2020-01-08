using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
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
    }
}

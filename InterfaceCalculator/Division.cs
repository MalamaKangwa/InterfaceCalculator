﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator
{
    public class Division
    {

        public static dynamic Quotient(dynamic a, dynamic b)
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
            double d2 = c * arrayA[0];
            double d = Helpers.Rounding.RoundTo2(d2);
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

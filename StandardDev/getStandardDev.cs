using System;
using System.Collections.Generic;
using System.Text;

namespace StandardDev
{
    public class getStandardDev: IStandardDev
    {
        public static dynamic result;

        public dynamic StandardDeviation(dynamic arrayA)
        {
            result = FindStandardDev.StandardDeviation(arrayA);
            return result;
        }
    
    }
}
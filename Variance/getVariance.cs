﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VarianceLogic
{
    
    public class getVariance: IVariance
    {
        public static dynamic result;

        public dynamic Variance(dynamic arrayA)
        {
            result = FindVariance.Variance(arrayA);
            return result;
        }

    }

}
﻿using System;


namespace InterfaceCalculator
{
    public interface ICubed
    {
        public dynamic CubedValue(dynamic a);
    }

    public class CubedInterface: ICubed
    {
        public dynamic result;

        public dynamic CubedValue(dynamic a, dynamic b)
        {
            result = (a);
            return result;
        }

    }
}
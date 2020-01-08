using System;


namespace InterfaceCalculator
{
    public interface ISub
    {
        public dynamic Sub(dynamic a, dynamic b);
    }

    public class SubtractionInterface: ISub
    {
        public dynamic result;

        public dynamic Sub(dynamic a, dynamic b)
        {
            result = Subtraction.Difference(a, b);
            return result;
        }

    }
}


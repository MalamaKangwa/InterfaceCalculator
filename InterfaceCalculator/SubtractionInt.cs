using System;


namespace InterfaceCalculator
{
    public interface ISub
    {
        public dynamic Sub(dynamic a, dynamic b);
        public dynamic Sub(dynamic a);
    }

    public class SubtractionInterface: ISub
    {
        public dynamic result;

        public dynamic Sub(dynamic a, dynamic b)
        {
            result = Subtraction.Difference(a, b);
            return result;
        }

        public dynamic Sub(dynamic a)
        {
            result = Subtraction.Difference(a);
            return result;
        }

    }
}


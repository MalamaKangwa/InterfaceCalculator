using System;

namespace InterfaceCalculator
{
    public interface IMultiply
    {
        public dynamic Multilplication(dynamic a, dynamic b);
    }

    public class MultiplyInterface: IMultiply
    {
        public dynamic result;

        public dynamic Multilplication(dynamic a, dynamic b)
        {
            result = Multiply.Product(a, b);
            return result;
        }

    }
}

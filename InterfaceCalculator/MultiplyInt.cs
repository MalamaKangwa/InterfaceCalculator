using System;

namespace InterfaceCalculator
{
    public interface IMultiply
    {
        public dynamic Multilplication(dynamic a, dynamic b);
        public dynamic Multilplication(dynamic a);
    }

    public class MultiplyInterface: IMultiply
    {
        public dynamic result;

        public dynamic Multilplication(dynamic a, dynamic b)
        {
            result = Multiply.Product(a, b);
            return result;
        }

        public dynamic Multilplication(dynamic a)
        {
            result = Multiply.Product(a);
            return result;
        }

    }
}

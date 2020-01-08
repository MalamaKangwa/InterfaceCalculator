using System;


namespace InterfaceCalculator
{
    public interface IDivide
    {
        public dynamic Divide(dynamic a, dynamic b);
    }

    public class DivClass: IDivide
    {
        public dynamic result;

        public dynamic Divide(dynamic a, dynamic b)
        {
            result = Division.Quotient(a, b);
            return result;
        }

    }
}

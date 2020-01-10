using System;


namespace InterfaceCalculator
{
    public interface IDivide
    {
        public dynamic Divide(dynamic a, dynamic b);
    }

    public class DivisionInterface: IDivide
    {
        public dynamic result;

        public dynamic Divide(dynamic a, dynamic b)
        {
            result = Division.Quotient(a, b);
            return result;
        }

        public dynamic Divide(dynamic a)
        {
            result = Division.Quotient(a);
            return result;
        }
    }
}

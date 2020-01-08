using System;

namespace InterfaceCalculator
{
    public interface ICalc4
    {
            public dynamic Add(dynamic a, dynamic b);
            public dynamic Divide(dynamic a, dynamic b);

    }

    public class Calculator4 : ISum, IDivide
    {
        readonly AddingInterface adding = new AddingInterface();
        readonly DivisionInterface dividing = new DivisionInterface();

        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = adding.Add(a, b);
            return result;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            result = dividing.Divide(a, b);
            return result;
        }


    }
}

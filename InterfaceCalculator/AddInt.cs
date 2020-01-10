using System;

namespace InterfaceCalculator
{

    public interface ISum
    {
        public dynamic Add(dynamic a, dynamic b);
    }


    public class AddingInterface : ISum
    {
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = Addition.Sum(a, b);
            return result;
        }

        public dynamic Add(dynamic a)
        {
            result = Addition.Sum(a);
            return result;
        }
    }
}


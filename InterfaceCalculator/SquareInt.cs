using System;


namespace InterfaceCalculator
{
    public interface ISquare
    {
        public dynamic Sqr(dynamic a);
    }

    public class SquareInterface: ISquare
    {
        public dynamic result;

        public dynamic Sqr(dynamic a)
        {
            result = Square.Squared(a);
            return result;
        }

    }
}

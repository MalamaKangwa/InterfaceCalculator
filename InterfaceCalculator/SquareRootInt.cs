using System;


namespace InterfaceCalculator
{
    public interface ISquareRoot
    {
        public dynamic SqrRoot(dynamic a);
    }

    public class SquareRootInterface: ISquareRoot
    {
        public dynamic result;

        public dynamic SqrRoot(dynamic a)
        {
            result = SquareRoot.Root(a);
            return result;
        }
    }
}

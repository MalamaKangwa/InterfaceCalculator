using System;

namespace InterfaceCalculator
{
    public interface ICalc4
    {
        public dynamic Add(dynamic a, dynamic b);
        public dynamic Add(dynamic a);
        public dynamic Sub(dynamic a, dynamic b);
        public dynamic Sub(dynamic a);
        public dynamic Divide(dynamic a, dynamic b);
        public dynamic Divide(dynamic a);
        public dynamic Multiplication(dynamic a, dynamic b);
        public dynamic Multiplication(dynamic a);

    }

    public class Calculator4 : ISum, ISub, IMultiply, IDivide, ISquare, ISquareRoot, ICubed 
    {
        readonly AddingInterface adding = new AddingInterface();
        readonly SubtractionInterface subbing = new SubtractionInterface();
        readonly DivisionInterface dividing = new DivisionInterface();
        readonly MultiplyInterface multiplying = new MultiplyInterface();
        readonly SquareInterface squaring = new SquareInterface();
        readonly SquareRootInterface SqrRooting = new SquareRootInterface();
        readonly CubedInterface cubing = new CubedInterface();

        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = adding.Add(a, b);
            return result;
        }

        public dynamic Add(dynamic a)
        {
            result = adding.Add(a);
            return result;
        }

        public dynamic Sub(dynamic a, dynamic b)
        {
            result = subbing.Sub(a, b);
            return result;
        }

        public dynamic Sub(dynamic a)
        {
            result = subbing.Sub(a);
            return result;
        }

        
        public dynamic Divide(dynamic a, dynamic b)
        {
            result = dividing.Divide(a, b);
            return result;
        }
        public dynamic Divide(dynamic a)
        {
            result = dividing.Divide(a);
            return result;
        }

        public dynamic Sqr(dynamic a)
        {
            result = squaring.Sqr(a);
            return result;
        }

        public dynamic SqrRoot(dynamic a)
        {
            result = SqrRooting.SqrRoot(a);
            return result;
        }

        public dynamic CubedValue(dynamic a)
        {
            result = cubing.CubedValue(a);
            return result;
        }

        public dynamic Multilplication(dynamic a, dynamic b)
        {
            result = multiplying.Multilplication(a, b);
            return result;
        }

        public dynamic Multilplication(dynamic a)
        {
            result = multiplying.Multilplication(a);
            return result;

        }

    }
}

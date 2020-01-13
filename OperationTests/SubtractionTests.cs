using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfaceCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 10;
        private readonly int b = 20;
        private readonly double c = 10.01;
        private readonly double d = 20.02;
        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07 };
        private readonly int[] arrayB = { 1, 2, 3, 4, 5 };

        [TestMethod()]
        public void SubIntTest()
        {
            int c = Subtraction.Difference(b, a);
            Assert.AreEqual(10, c);
        }

        [TestMethod()]
        public void SubDoubleTest()
        {
            double a = Subtraction.Difference(d, c);
            Assert.AreEqual(10.01, a);
        }

        [TestMethod()]
        public void SubIntArrayTest()
        {
            int c = Subtraction.Difference(arrayB);

            Assert.AreEqual(-13, c);
        }

        [TestMethod()]
        public void SubDoubleArrayTest()
        {
            double a = Subtraction.Difference(arrayA);

            Assert.AreEqual(-8.16, a);

        }
    }
}
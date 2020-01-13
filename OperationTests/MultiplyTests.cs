using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator.Tests
{
    [TestClass()]
    public class MultiplyTests
    {
        private readonly int a = 10;
        private readonly int b = 20;
        private readonly double c = 1.5;
        private readonly double d = 2.5;
        private readonly double[] arrayA = { 2.0, 2.5, 3.5, 4 };
        private readonly int[] arrayB = { 1, 2, 3, 4 };

        [TestMethod()]
        public void ProductTest()
        {
            int c = Multiply.Product(a, b);
            Assert.AreEqual(200, c);
        }

        [TestMethod()]
        public void ProductDoubleTest()
        {
            double a = Multiply.Product(c, d);
            Assert.AreEqual(3.75, a);
        }

        [TestMethod()]
        public void ProductArrayTest()
        {
            int c = Multiply.Product(arrayB);
            Assert.AreEqual(24, c);
        }

        [TestMethod()]
        public void ProductDoubleArrayTest()
        {
            double a = Multiply.Product(arrayA);
            Assert.AreEqual(70, a);
        }

    }
}
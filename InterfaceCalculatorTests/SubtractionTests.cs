using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 100;
        private readonly int b = 20;
        private readonly double c = 30.05;
        private readonly double d = 20.02;
        private readonly double[] arrayA = { 9.01, 2.04, 3.06, 1.07};
        private readonly int[] arrayB = {26, 7, 8, 5, 2 };

        [TestMethod()]
        public void SubIntTest()
        {
            Calculator4 calculator = new Calculator4();

            int c = calculator.Sub(a, b);

            Assert.AreEqual(80, c);
            Assert.AreEqual(80, calculator.result);

        }

        [TestMethod()]
        public void SubDoubleTest()
        {
            Calculator4 calculator = new Calculator4();

            double a = calculator.Sub(c, d);

            Assert.AreEqual(10.03, a);
            Assert.AreEqual(10.03, calculator.result);

        }

        [TestMethod()]
        public void SubIntArrayTest()
        {
            Calculator4 calculator = new Calculator4();

            int c = calculator.Sub(arrayB);

            Assert.AreEqual(4, c);
            Assert.AreEqual(4, calculator.result);

        }

        [TestMethod()]
        public void SubDoubleArrayTest()
        {
            Calculator4 calculator = new Calculator4();

            double a = calculator.Sub(arrayA);

            Assert.AreEqual(2.84, a);
            Assert.AreEqual(2.84, calculator.result);

        }

    }
}

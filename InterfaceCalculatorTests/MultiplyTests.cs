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
            Calculator4 calculator = new Calculator4();

            int c = calculator.Multilplication(a, b);

            Assert.AreEqual(200, c);
            Assert.AreEqual(200, calculator.result);

        }

        [TestMethod()]
        public void ProductDoubleTest()
        {
            Calculator4 calculator = new Calculator4();

            double a = calculator.Multilplication(c, d);

            Assert.AreEqual(3.75, a);
            Assert.AreEqual(3.75, calculator.result);

        }

        [TestMethod()]
        public void ProductArrayTest()
        {
            Calculator4 calculator = new Calculator4();

            int c = calculator.Multilplication(arrayB);

            Assert.AreEqual(24, c);
            Assert.AreEqual(24, calculator.result);

        }

        [TestMethod()]
        public void ProductDoubleArrayTest()
        {
            Calculator4 calculator = new Calculator4();

            double a = calculator.Multilplication(arrayA);

            Assert.AreEqual(70, a);
            Assert.AreEqual(70, calculator.result);

        }

    }
}
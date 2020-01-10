using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 100;
        private readonly int b = 20;
        private readonly double c = 10.5;
        private readonly double d = 2.5;
        private readonly double[] arrayA = { 20.0, 2.5, 4.1};
        private readonly int[] arrayB = { 16, 2, 2 };

        [TestMethod()]
        public void DivideTest()
        {
            Calculator4 calculator = new Calculator4();

            int c = calculator.Divide(a, b);

            Assert.AreEqual(5, c);
            Assert.AreEqual(5, calculator.result);

        }

        [TestMethod()]
        public void DivideDoubleTest()
        {
            Calculator4 calculator = new Calculator4();

            double a = calculator.Divide(c, d);

            Assert.AreEqual(4.2, a);
            Assert.AreEqual(4.2, calculator.result);

        }

        [TestMethod()]
        public void DivideArrayTest()
        {
            Calculator4 calculator = new Calculator4();

            int c = calculator.Divide(arrayB);

            Assert.AreEqual(4, c);
            Assert.AreEqual(4, calculator.result);

        }

        [TestMethod()]
        public void DivideDoubleArrayTest()
        {
            Calculator4 calculator = new Calculator4();

            double a = calculator.Divide(arrayA);

            Assert.AreEqual(1.95, a);
            Assert.AreEqual(1.95, calculator.result);

        }
        


    }
}


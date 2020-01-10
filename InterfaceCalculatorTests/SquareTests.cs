using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 12;
        private readonly double b = 1.5;

        [TestMethod()]
        public void SquareIntTest()
        {
            Calculator4 calculator = new Calculator4();

            int c = calculator.Sqr(a);

            Assert.AreEqual(144, c);
            Assert.AreEqual(144, calculator.result);

        }

        [TestMethod()]
        public void SquareDoubleTest()
        {
            Calculator4 calculator = new Calculator4();

            double c = calculator.Sqr(b);

            Assert.AreEqual(2.25, c);
            Assert.AreEqual(2.25, calculator.result);

        }

    }
}
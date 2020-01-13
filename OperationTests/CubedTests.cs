using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator.Tests
{
    [TestClass()]
    public class CubedTests
    {
        private readonly int a = 3;
        private readonly double b = 2.5;

        [TestMethod()]
        public void CubedTest()
        {
            Calculator4 calculator = new Calculator4();

            int c = calculator.CubedValue(a);

            Assert.AreEqual(27, c);
            Assert.AreEqual(27, calculator.result);

        }

        [TestMethod()]
        public void CubedDoubleTest()
        {
            Calculator4 calculator = new Calculator4();

            double c = calculator.CubedValue(b);

            Assert.AreEqual(15.625, c);
            Assert.AreEqual(15.625, calculator.result);

        }

    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly int a = 144;
        private readonly double b = 2.25;

        [TestMethod()]
        public void SqrRootIntTest()
        {
            Calculator4 calculator = new Calculator4();

            int c = calculator.SqrRoot(a);

            Assert.AreEqual(12, c);
            Assert.AreEqual(12, calculator.result);

        }

        [TestMethod()]
        public void SqrRootDoubleTest()
        {
            Calculator4 calculator = new Calculator4();

            double c = calculator.SqrRoot(b);

            Assert.AreEqual(1.5, c);
            Assert.AreEqual(1.5, calculator.result);

        }
    }
}
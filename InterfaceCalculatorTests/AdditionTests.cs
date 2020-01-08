using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 10;
        private readonly int b = 20;
        private readonly double c = 10.01;
        private readonly double d = 20.02;
        //private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07, 5, 6, 7, 8, 9, 10 };
        //private readonly int[] arrayB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [TestMethod()]
        public void AddTest()
        {
            Calculator4 calculator = new Calculator4();

            int c = calculator.Add(a, b);

            Assert.AreEqual(30, c);
            Assert.AreEqual(30, calculator.result);

        }

        [TestMethod()]
        public void AddDoubleTest()
        {
            Calculator4 calculator = new Calculator4();

            double a = calculator.Add(c, d);

            Assert.AreEqual(30.03, a);
            Assert.AreEqual(30.03, calculator.result);

        }

    }
}
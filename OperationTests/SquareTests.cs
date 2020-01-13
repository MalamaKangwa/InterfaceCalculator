using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int f = 12;
        private readonly double g = 1.5;
        private readonly int[] arrayF = {2,3,4};
        private readonly double[] arrayG = { 2.5, 3.5, 4.5 };


        [TestMethod()]
        public void SquareIntTest()
        {
            int c = Square.Squared(f);
            Assert.AreEqual(144, c);
        }

        [TestMethod()]
        public void SquareDoubleTest()
        {
            double c = Square.Squared(g);
            Assert.AreEqual(2.25, c);
        }

        [TestMethod()]
        public void SquareArrayTest()
        {
            int[] x = { 4, 9, 16 };
            int[] c = Square.Squared(arrayF);

            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }
        }

        [TestMethod()]
        public void SquareArrayDoubleTest()
        {
            double[] x = {6.25,12.25,20.25};
            double[] c = Square.Squared(arrayG);

            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }
        }
    }
}
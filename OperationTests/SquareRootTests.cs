using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly int h = 144;
        private readonly double i = 2.25;
        private readonly double[] arrayC = {1.44,6.25,38.44};

        [TestMethod()]
        public void SqrRootIntTest()
        {
            int c = SquareRoot.Root(h);
            Assert.AreEqual(12, c);
        }

        public void SqrRootDoubleTest()
        {
            double c = SquareRoot.Root(i);
            Assert.AreEqual(1.5, c);
        }


        [TestMethod()]
        public void SqrRootDoubleArrayTest()
        {
            double[] x = { 1.2, 2.5, 6.2 };
            double[] c = SquareRoot.Root(arrayC);
            for(int i = 0; i<c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }
            
        }


    }
}
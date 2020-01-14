using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfaceCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator.Tests
{
    [TestClass()]
    public class Calculator4Tests
    {

        private readonly int a = 10;
        private readonly int b = 20;
        private readonly int f = 12;
        private readonly int h = 144;
        private readonly double i = 2.25;
        private readonly double g = 1.5;
        private readonly double c = 10.01;
        private readonly double d = 20.02;
        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07 };
        private readonly int[] arrayB = { 1, 2, 3, 4, 5 };
        private readonly double[] arrayC = { 20.0, 2.5, 4.1 };
        private readonly int[] arrayD = { 16, 2, 2 };
        private readonly double[] arrayE = { 1.44, 6.25, 38.44 };
        private readonly int[] arrayF = { 2, 3, 4 };
        private readonly double[] arrayG = { 2.5, 3.5, 4.5 };


        Calculator4 calculator = new Calculator4();

        [TestMethod()]
        public void AddTest()
        {
            int c = calculator.Add(a, b);
            Assert.AreEqual(30, calculator.result);

        }

        [TestMethod()]
        public void AddDoubleTest()
        {
            double a = calculator.Add(c, d);
            Assert.AreEqual(30.03, calculator.result);
        }

        [TestMethod()]
        public void AddArrayTest()
        {
            int c = calculator.Add(arrayB);
            Assert.AreEqual(15, calculator.result);
        }

        [TestMethod()]
        public void AddDoubleArrayTest()
        {
            double a = calculator.Add(arrayA);
            Assert.AreEqual(10.18, calculator.result);
        }

        [TestMethod()]
        public void SubIntTest()
        {
            int c = calculator.Sub(b, a);
            Assert.AreEqual(10, calculator.result);
        }

        [TestMethod()]
        public void SubDoubleTest()
        {
            double a = calculator.Sub(d, c);
            Assert.AreEqual(10.01, calculator.result);
        }

        [TestMethod()]
        public void SubIntArrayTest()
        {
            int c = calculator.Sub(arrayB);
            Assert.AreEqual(-13, calculator.result);
        }

        [TestMethod()]
        public void SubDoubleArrayTest()
        {
            double a = calculator.Sub(arrayA);
            Assert.AreEqual(-8.16, calculator.result);

        }

        [TestMethod()]
        public void DivideTest()
        {
            int c = calculator.Divide(b, a);
            Assert.AreEqual(2, calculator.result);
        }

        [TestMethod()]
        public void DivideDoubleTest()
        {
            double a = calculator.Divide(d, c);
            Assert.AreEqual(2, calculator.result);

        }

        [TestMethod()]
        public void DivideArrayTest()
        {
            int c = calculator.Divide(arrayD);
            Assert.AreEqual(4, calculator.result);
        }

        [TestMethod()]
        public void DivideDoubleArrayTest()
        {
            double a = calculator.Divide(arrayC);
            Assert.AreEqual(1.95, calculator.result);
        }

        [TestMethod()]
        public void ProductTest()
        {
            int c = calculator.Multilplication(a, b);
            Assert.AreEqual(200, calculator.result);
        }

        [TestMethod()]
        public void ProductDoubleTest()
        {
            double a = calculator.Multilplication(i, g);
            Assert.AreEqual(3.375, calculator.result);
        }

        [TestMethod()]
        public void ProductArrayTest()
        {
            int c = calculator.Multilplication(arrayB);
            Assert.AreEqual(120, calculator.result);
        }

        [TestMethod()]
        public void ProductDoubleArrayTest()
        {
            double a = calculator.Multilplication(arrayA);
            Assert.AreEqual(25.66, calculator.result);
        }

        [TestMethod()]
        public void SquareIntTest()
        {
            int c = calculator.Sqr(f);
            Assert.AreEqual(144, calculator.result);

        }

        [TestMethod()]
        public void SquareDoubleTest()
        {
            double c = calculator.Sqr(g);
            Assert.AreEqual(2.25, calculator.result);

        }

        [TestMethod()]
        public void SqrRootIntTest()
        {
            dynamic c = calculator.SqrRoot(h);
            Assert.AreEqual(12, calculator.result);
        }

        [TestMethod()]
        public void SqrRootDoubleTest()
        {
            double c = calculator.SqrRoot(i);
            Assert.AreEqual(1.5, calculator.result);
        }

        [TestMethod()]
        public void SqrRootArrayTest()
        {
            double[] x = { 1.41, 1.73, 2 };
            double[] c = calculator.SqrRoot(arrayF);
            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }

        }

        [TestMethod()]
        public void SqrRootDoubleArrayTest()
        {
            double[] x = { 1.2, 2.5, 6.2 };
            double[] c = calculator.SqrRoot(arrayE);
            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }
        }

        [TestMethod()]
        public void SquareArrayTest()
        {
            int[] x = { 4, 9, 16 };
            int[] c = calculator.Sqr(arrayF);

            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }
        }

        [TestMethod()]
        public void SquareArrayDoubleTest()
        {
            double[] x = { 6.25, 12.25, 20.25 };
            double[] c = calculator.Sqr(arrayG);

            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }
        }
    }
}

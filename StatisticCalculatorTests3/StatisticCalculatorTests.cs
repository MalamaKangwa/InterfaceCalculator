using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticCalculator.Tests
{
    [TestClass()]
    public class StatisticCalculatorTests
    {

        private readonly double[] arrayX = { 4, 2, 6, 8, 4, 12, 10 };
        private readonly double[] arrayA = { 8, 10, 14, 9, 12, 7};

        [TestMethod()]
        public void Mean_AverageTest()
        {
            StatisticCalculator StatCalc = new StatisticCalculator();
            var finalMean = StatCalc.Mean_Average(arrayX);

            Assert.AreEqual(6.57, finalMean);
        }

        [TestMethod()]
        public void Variance_Test()
        {
            StatisticCalculator StatCalc = new StatisticCalculator();
            var finalVariance = StatCalc.Variance(arrayA);

            Assert.AreEqual(6.8, finalVariance);
        }


        [TestMethod()]
        public void StandardDev_Test()
        {
            StatisticCalculator StatCalc = new StatisticCalculator();
            var finalStandardDev = StatCalc.StandardDeviation(arrayA);

            Assert.AreEqual(2.61, finalStandardDev);
        }

    }
}


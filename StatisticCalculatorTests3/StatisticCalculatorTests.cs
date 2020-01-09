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

        [TestMethod()]
        public void Mean_AverageTest()
        {
            StatisticCalculator StatCalc = new StatisticCalculator();
            var finalMean = StatCalc.Mean_Average(arrayX);

            Assert.AreEqual(6.57, finalMean);
        }
    }
}


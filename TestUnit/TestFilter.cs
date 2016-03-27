using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assets.Backend.Filters;
using Assets.Backend.Auxiliary;

namespace TestUnit
{
    [TestClass]
    public class TestFilter
    {
        [TestMethod]
        public void FilterMovingAverage_GetOutput()
        {
            Filter filter = new FilterMovingAverage(4);

            filter.AddInput(10.0);
            filter.AddInput(15.0);
            filter.AddInput(25.0);
            filter.AddInput(36.0);

            double result = filter.GetOutput();

            Assert.IsTrue(ExtraMath.EqualValue(result, 21.5));
        }

        [TestMethod]
        public void FilterSinglePole_GetOutput()
        {
            Filter filter = new FilterSinglePole(3, 0.5);

            filter.AddInput(10.0);
            filter.AddInput(15.0);
            filter.AddInput(25.0);
            filter.AddInput(36.0);

            double result = filter.GetOutput();

            Assert.IsTrue(ExtraMath.EqualValue(result, 29.609));
        }

        [TestMethod]
        public void FilterGaussian_GetOutput()
        {
            Filter filter = new FilterGaussian(3, 0.5);

            filter.AddInput(10.0);
            filter.AddInput(15.0);
            filter.AddInput(25.0);
            filter.AddInput(36.0);

            double result = filter.GetOutput();

            Assert.IsTrue(ExtraMath.EqualValue(result, 25.274));
        }
    }
}

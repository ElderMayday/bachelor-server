using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assets.Backend.Estimators;
using System.Collections.Generic;
using Assets.Backend.Auxiliary;

namespace TestUnit
{
    [TestClass]
    public class TestEstimator
    {
        private List<double> pure, output;

        [TestInitialize]
        public void Initialize()
        {
            pure = new List<double>();
            pure.Add(10.0);
            pure.Add(23.0);
            pure.Add(29.0);
            pure.Add(30.0);
            pure.Add(43.0);

            output = new List<double>();
            output.Add(12.0);
            output.Add(19.0);
            output.Add(32.0);
            output.Add(31.0);
            output.Add(40.0);
        }

        [TestMethod]
        public void EstimatorCorrelation_Estimate()
        {
            Estimator estimator = new EstimatorCorrelation(pure, output);

            double result = estimator.Estimate();

            Assert.IsTrue(ExtraMath.EqualValue(result, 0.9662));
        }


        [TestMethod]
        public void EstimatorMinkowski_Estimate()
        {
            Estimator estimator = new EstimatorMinkowski(pure, output, 2.0);

            double result = estimator.Estimate();

            Assert.IsTrue(ExtraMath.EqualValue(result, 6.245));
        }
        

        [TestMethod]
        public void EstimatorDistance_Estimate()
        {
            Estimator estimator = new EstimatorDistance(pure, output);

            double result = estimator.Estimate();

            Assert.IsTrue(ExtraMath.EqualValue(result, 4.0));
        }

        [TestMethod]
        public void EstimatoCos_Estimate()
        {
            Estimator estimator = new EstimatorCos(pure, output);

            double result = estimator.Estimate();

            Assert.IsTrue(ExtraMath.EqualValue(result, 0.995));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assets.Backend.Auxiliary;

namespace TestUnit
{
    [TestClass]
    public class TestExtraMath
    {
        [TestMethod]
        public void ExtraMath_Factorial_1()
        {
            int result = ExtraMath.Factorial(0);

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void ExtraMath_Factorial_2()
        {
            int result = ExtraMath.Factorial(1);

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void ExtraMath_Factorial_3()
        {
            int result = ExtraMath.Factorial(4);

            Assert.AreEqual(result, 24);
        }

        [TestMethod]
        public void ExtraMath_Combination()
        {
            int result = ExtraMath.Combination(3, 2);

            Assert.AreEqual(result, 3);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assets.Backend.Auxiliary;

namespace TestUnit
{
    [TestClass]
    public class TestExtraMath
    {
        [TestMethod]
        public void TestFactorial1()
        {
            int result = ExtraMath.Factorial(0);

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestFactorial2()
        {
            int result = ExtraMath.Factorial(1);

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestFactorial3()
        {
            int result = ExtraMath.Factorial(4);

            Assert.AreEqual(result, 24);
        }

        [TestMethod]
        public void TestCombination1()
        {
            int result = ExtraMath.Combination(3, 2);

            Assert.AreEqual(result, 3);
        }
    }
}

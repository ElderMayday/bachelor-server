using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assets.Backend.Deserializers;
using Assets.Backend.Auxiliary;

namespace TestUnit
{
    [TestClass]
    public class TestDeserializer
    {
        [TestMethod]
        public void DeserializerCustom_Do()
        {
            Deserializer deserializer = new DeserializerCustom();

            Vector3 vector = deserializer.Do("<3.5;0.8;-30.5>");

            Assert.IsTrue(ExtraMath.EqualValue(vector.X, 3.5));
            Assert.IsTrue(ExtraMath.EqualValue(vector.Y, 0.8));
            Assert.IsTrue(ExtraMath.EqualValue(vector.Z, -30.5));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Vectors
{
    internal class UnitTests
    {
        [TestMethod]
        public void TestVectorAddition()
        {

            Vector vector1 = new Vector(2, 3);
            Vector vector2 = new Vector(1, 2);
            Vector expectedResult = new Vector(3, 5);
            Vector result = vector1.Add(vector2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestVectorMultiplication()
        {
            Vector vector = new Vector(2, 3);
            double scalar = 2;
            Vector expectedResult = new Vector(4, 6);
            Vector result = vector.Multiply(scalar);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestDotProduct()
        {

            Vector vector1 = new Vector(2, 3);
            Vector vector2 = new Vector(1, 2);
            double expectedResult = 8;
            double result = vector1.DotProduct(vector2);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestAngleBetween()
        {

            Vector vector1 = new Vector(2, 0);
            Vector vector2 = new Vector(0, 2);
            double expectedResult = (Math.PI) / 2;
            double result = vector1.anglebetween(vector2);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMagnitude()
        {
            Vector vector = new Vector(3, 4);
            double expectedResult = 5;
            double result = vector.Magnitude();
            Assert.AreEqual(expectedResult, result);
        }

    }
}

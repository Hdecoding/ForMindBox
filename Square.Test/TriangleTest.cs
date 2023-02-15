using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculateSquare;

namespace CalculateSquare.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestMethod()
        {
            {
                //Arrange
                var triangle = new Triangle("Triangle", 9, 6, 4);
                double expected = 9.56;

                //Act
                var result = triangle.CalcSquare();

                //Assert
                Assert.AreEqual(expected, result);
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
            {
                //Arrange
                var triangle = new Triangle("Triangle", 3, 4, 5);

                //Act
                var result = triangle.isRectangularTriangle();

                //Assert
                Assert.IsTrue(result);
            }
        }
    }
}

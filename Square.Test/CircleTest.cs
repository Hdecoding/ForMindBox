using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculateSquare;

namespace CalculateSquare.Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                //Arrange
                var circle = new Circle("Circle", 5);
                double expected = 78.54;

                //Act
                var result = circle.CalcSquare();

                //Assert
                Assert.AreEqual(expected, result);
            }

        }

    }
}

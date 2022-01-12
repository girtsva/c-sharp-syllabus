using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculateArea.Tests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void AreaOfCircle_Radius2_ShouldReturn12Point566371()
        {
            // Act
            var circleArea = Math.Round(Geometry.AreaOfCircle(2), 6);

            // Assert
            Assert.AreEqual(12.566371, circleArea);
        }

        [TestMethod]
        public void AreaOfRectangle_Length3Width6_ShouldReturn18()
        {
            // Act
            var rectangleArea = Geometry.AreaOfRectangle(3, 6);

            // Assert
            Assert.AreEqual(18, rectangleArea);
        }

        [TestMethod]
        public void AreaOfTriangle_Ground3h2_ShouldReturn3()
        {
            // Act
            var triangleArea = Geometry.AreaOfTriangle(3, 2);

            // Assert
            Assert.AreEqual(3, triangleArea);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GravityCalculator.Tests
{
    [TestClass]
    public class GravityCalculatorTests
    {
        private GravityCalculator _target;

        [TestInitialize]
        public void TestInitialize()
        {
            _target = new GravityCalculator();
        }

        [TestMethod]
        public void CalculateFinalPosition_Formula_ShouldReturnMinus490Point5()
        {
            // Act
            var result = _target.CalculateFinalPosition();

            // Assert
            Assert.AreEqual(-490.5, result);
        }
    }
}

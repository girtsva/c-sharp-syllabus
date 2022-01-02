using NUnit.Framework;
using System;

namespace Exercise08.Tests
{
    public class EmployeePayTests
    {
        private EmployeePay _target;
        
        [Test]
        public void IsLessThanMinimumWage_BasePay6PointZero_ShouldReturnTrue()
        {
            // Arrange
            _target = new EmployeePay("Test Employee", 6.00, 40);

            // Act
            var result = _target.IsLessThanMinimumWage();

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void WorkedMoreThanAllowedHours_HoursWorked90_ShouldReturnTrue()
        {
            // Arrange
            _target = new EmployeePay("Test Employee", 6.00, 90);

            // Act
            var result = _target.WorkedMoreThanAllowedHours();

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void CalculatePay_BasePay8Point20AndHoursWorked47_ShouldReturn414Point20()
        {
            // Arrange
            _target = new EmployeePay("Test Employee", 8.20, 47);

            // Act
            var result = _target.CalculatePay();

            // Assert
            Assert.AreEqual(414.10m, result);
        }
    }
}
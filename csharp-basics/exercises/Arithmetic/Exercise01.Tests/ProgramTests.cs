using NUnit.Framework;

namespace Exercise01.Tests
{
    public class ProgramTests
    {
        [Test]
        public void CheckFifteen_InputIsNot15_ReturnsFalse()
        {
            // Arrange
            int a = 1;
            int b = 1;

            // Act
            var result = Program.CheckFifteen(a, b);

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestCase(15, 2)]  // first integer is 15
        [TestCase(5, 15)]  // second integer is 15
        [TestCase(7, 8)]   // sum is 15
        [TestCase(16, 1)]  // difference is 15 when first integer larger
        [TestCase(10, 25)] // difference is 15 when second integer larger
        public void CheckFifteen_InputOrSumOrDifferenceIs15_ReturnsTrue(int a, int b)
        {
            // Act
            var result = Program.CheckFifteen(a, b);

            // Assert
            Assert.AreEqual(true, result);
        }
    }
}
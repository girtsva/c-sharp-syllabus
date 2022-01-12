using NUnit.Framework;

namespace Exercise02.Tests
{
    public class ProgramTests
    {
        [Test]
        public void CheckOddEven_InputNumberIsEven_ReturnsEven()
        {
            // Arrange
            int a = 8;

            // Act
            var result = Program.CheckOddEven(a);

            // Assert
            Assert.AreEqual("Even Number", result);
        }

        [Test]
        public void CheckOddEven_InputNumberIsOdd_ReturnsOdd()
        {
            // Arrange
            int a = 55;

            // Act
            var result = Program.CheckOddEven(a);

            // Assert
            Assert.AreEqual("Odd Number", result);
        }
    }
}
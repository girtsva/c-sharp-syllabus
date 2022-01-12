using NUnit.Framework;

namespace Exercise06.Tests
{
    public class CozaLozaWozaTests
    {
        private CozaLozaWoza _target;

        [SetUp]
        public void Setup()
        {
            _target = new CozaLozaWoza();
        }

        [TestCase(105, ExpectedResult = "CozaLozaWoza")]    // number is multiple of 3, 5 and 7
        [TestCase(70, ExpectedResult = "LozaWoza")]         // number is multiple of 5 and 7
        [TestCase(42, ExpectedResult = "CozaWoza")]         // number is multiple of 3 and 7
        [TestCase(45, ExpectedResult = "CozaLoza")]         // number is multiple of 3 and 5
        [TestCase(91, ExpectedResult = "Woza")]             // number is multiple of 7
        [TestCase(100, ExpectedResult = "Loza")]            // number is multiple of 5
        [TestCase(69, ExpectedResult = "Coza")]             // number is multiple of 3
        [TestCase(59, ExpectedResult = "59")]               // number is not a multiple of 3, 5 or 7
        public string TransformNumber_InputNumber_ShouldBeExpectedResult(int number)
        {
            return _target.TransformNumber(number);
        }
    }
}
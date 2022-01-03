using NUnit.Framework;

namespace Exercise05.Tests
{
    public class DateTests
    {
        private Date _target;
        
        [SetUp]
        public void Setup()
        {
            _target = new Date(03, 01, 2022);
        }

        [Test]
        public void Day_EnteredValueAtInitializationIsReturned_ShouldReturn3()
        {
            // Assert
            Assert.AreEqual(3, _target.Day);
        }

        [Test]
        public void Month_EnteredValueAtInitializationIsReturned_ShouldReturn1()
        {
            // Assert
            Assert.AreEqual(1, _target.Month);
        }

        [Test]
        public void Year_EnteredValueAtInitializationIsReturned_ShouldReturn2022()
        {
            // Assert
            Assert.AreEqual(2022, _target.Year);
        }

        [Test]
        public void DisplayDate_EnteredValuesAtInitializationAreReturned_ShouldReturnString()
        {
            // Assert
            Assert.AreEqual("3/1/2022", _target.DisplayDate());
        }
    }
}
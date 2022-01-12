using System;
using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class TigerTests
    {
        private Tiger _target;
        
        [SetUp]
        public void Setup()
        {
            _target = new Tiger("Jack", "Tiger", 80.54, "Zoo");
        }

        [Test]
        public void ToString_ValuesEnteredInConstructorAreRecorded_ShouldReturnValuesEnteredInConstructor()
        {
            // Assert
            Assert.AreEqual("Tiger[Jack, 80.54, Zoo, 0]", _target.ToString());
        }

        [Test]
        public void Eat_Meat3_ShouldContainFoodEaten3()
        {
            // Arrange
            var meat = new Meat(3);

            // Act
            _target.Eat(meat);

            // Assert
            Assert.AreEqual("Tiger[Jack, 80.54, Zoo, 3]", _target.ToString());
        }

        [Test]
        public void Eat_Vegetable4_ShouldThrowException()
        {
            // Arrange
            var vegetable = new Vegetable(4);

            // Assert
            Assert.Throws(Is.TypeOf<ArgumentException>().And.Message.EqualTo($"{_target.GetType().Name}s are not eating that type of food!"),() => _target.Eat(vegetable));
        }

        
    }
}
using System;
using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class MouseTests
    {
        private Mouse _target;
        
        [SetUp]
        public void Setup()
        {
            _target = new Mouse("Wee-wee", "Mouse", 0.25, "Hole");
        }

        [Test]
        public void ToString_ValuesEnteredInConstructorAreRecorded_ShouldReturnValuesEnteredInConstructor()
        {
            // Assert
            Assert.AreEqual("Mouse[Wee-wee, 0.25, Hole, 0]", _target.ToString());
        }

        [Test]
        public void Eat_Meat4_ShouldThrowException()
        {
            // Arrange
            var meat = new Meat(4);

            // Assert
            Assert.Throws(Is.TypeOf<ArgumentException>().And.Message.EqualTo($"{_target.GetType().Name}s are not eating that type of food!"),() => _target.Eat(meat));
        }

        [Test]
        public void Eat_Vegetable3_ShouldContainFoodEaten3()
        {
            // Arrange
            var vegetable = new Vegetable(3);

            // Act
            _target.Eat(vegetable);

            // Assert
            Assert.AreEqual("Mouse[Wee-wee, 0.25, Hole, 3]", _target.ToString());
        }
    }
}
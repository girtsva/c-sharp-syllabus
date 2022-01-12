using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class CatTests
    {
        private Cat _target;
        
        [SetUp]
        public void Setup()
        {
            _target = new Cat("Rex", "Cat", 3.50, "Basement", "Cornish Rex");
        }

        [Test]
        public void ToString_ValuesEnteredInConstructorAreRecorded_ShouldReturnValuesEnteredInConstructor()
        {
            // Assert
            Assert.AreEqual("Cat[Rex, Cornish Rex, 3.5, Basement, 0]", _target.ToString());
        }

        [Test]
        public void Eat_Meat4_ShouldContainFoodEaten4()
        {
            // Arrange
            var meat = new Meat(4);

            // Act
            _target.Eat(meat);

            // Assert
            Assert.AreEqual("Cat[Rex, Cornish Rex, 3.5, Basement, 4]", _target.ToString());
        }

        [Test]
        public void Eat_Vegetable3_ShouldContainFoodEaten3()
        {
            // Arrange
            var vegetable = new Vegetable(3);

            // Act
            _target.Eat(vegetable);

            // Assert
            Assert.AreEqual("Cat[Rex, Cornish Rex, 3.5, Basement, 3]", _target.ToString());
        }
    }
}
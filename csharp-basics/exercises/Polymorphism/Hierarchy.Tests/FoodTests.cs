using NUnit.Framework;

namespace Hierarchy.Tests
{
    class FoodTests
    {
        private Meat _targetMeat;
        private Vegetable _targetVegetable;

        [SetUp]
        public void Setup()
        {
            _targetMeat = new Meat(5);
            _targetVegetable = new Vegetable(7);
        }

        [Test]
        public void MeatQuantity_ValueEnteredInConstructorIsRecorded_ShouldReturn5()
        {
            // Assert
            Assert.AreEqual(5, _targetMeat.Quantity);
        }

        [Test]
        public void VegetableQuantity_ValueEnteredInConstructorIsRecorded_ShouldReturn7()
        {
            // Assert
            Assert.AreEqual(7, _targetVegetable.Quantity);
        }
    }
}

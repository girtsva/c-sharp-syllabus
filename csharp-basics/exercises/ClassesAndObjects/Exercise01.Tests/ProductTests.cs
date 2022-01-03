using NUnit.Framework;

namespace Exercise01.Tests
{
    public class ProductTests
    {
        private Product _target;
        
        [SetUp]
        public void Setup()
        {
            _target = new Product("Test Product", 10.00, 5);
        }

        [Test]
        public void Name_SetAtInitialization_ShouldEqualTestProduct()
        {
            // Assert
            Assert.AreEqual("Test Product", _target.Name);
        }

        [Test]
        public void Price_SetTo25_ShouldEqual25()
        {
            // Act
            _target.Price = 25;
            
            // Assert
            Assert.AreEqual(25, _target.Price);
        }

        [Test]
        public void Amount_SetTo15_ShouldEqual15()
        {
            // Act
            _target.Amount = 15;

            // Assert
            Assert.AreEqual(15, _target.Amount);
        }
    }
}
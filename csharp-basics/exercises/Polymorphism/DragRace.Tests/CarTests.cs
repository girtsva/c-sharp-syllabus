using NUnit.Framework;
using System.Collections.Generic;

namespace DragRace.Tests
{
    public class CarTests
    {
        private List<ICar> _target;

        [SetUp]
        public void Setup()
        {
            _target = new List<ICar>();
            _target.Add(new Audi());
            _target.Add(new Bmw());
            _target.Add(new Lexus());
            _target.Add(new Subaru());
            _target.Add(new Tesla());
            _target.Add(new Toyota());
        }

        [Test]
        public void SpeedUp_CarSpeedCanBeIncreased_SpeedAfterFunctionExecutionShouldBeLarger()
        {
            foreach (var car in _target)
            {
                // Act
                var initialSpeed = int.Parse(car.ShowCurrentSpeed());
                car.SpeedUp();
                var actualSpeed = int.Parse(car.ShowCurrentSpeed());

                // Assert
                Assert.AreEqual(0, initialSpeed);
                Assert.Greater(actualSpeed, initialSpeed);
            }
        }

        [Test]
        public void SlowDown_CarSpeedCanBeDecreased_SpeedAfterFunctionExecutionShouldBeLess()
        {
            foreach (var car in _target)
            {
                // Arrange
                car.SpeedUp();
                var initialSpeed = int.Parse(car.ShowCurrentSpeed());

                // Act
                car.SlowDown();
                var actualSpeed = int.Parse(car.ShowCurrentSpeed());

                // Assert
                Assert.Greater(initialSpeed, actualSpeed);
                Assert.NotZero(initialSpeed);
                Assert.AreEqual(0, actualSpeed);
            }
        }

        [Test]
        public void UseNitrousOxideEngine_CarSpeedIsIncreased_SpeedAfterFunctionExecutionShouldBeLarger()
        {
            foreach (var car in _target)
	        {
                if (car is IBoostable boostable)
                {
                    // Act
                    var initialSpeed = int.Parse(car.ShowCurrentSpeed());
                    boostable.UseNitrousOxideEngine();
                    var actualSpeed = int.Parse(car.ShowCurrentSpeed());

                    // Assert
                    Assert.AreEqual(0, initialSpeed);
                    Assert.Greater(actualSpeed, initialSpeed);
                }

	        }
        }
    }
}
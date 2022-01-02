using System;

namespace GravityCalculator
{
    public class GravityCalculator
    {
        private const double GRAVITY = -9.81;  // Earth's gravity in m/s^2
        private double _initialVelocity;
        private double _fallingTime;
        private double _initialPosition;

        public GravityCalculator()
        {
            _initialVelocity = 0.0;
            _fallingTime = 10.0;
            _initialPosition = 0.0;
        }

        public double CalculateFinalPosition()
        {
            return 0.5 * GRAVITY * Math.Pow(_fallingTime, 2) + _initialVelocity * _fallingTime + _initialPosition;
        }

        public string ShowNewObjectPosition()
        {
            return "The object's position after " + _fallingTime + " seconds is " + CalculateFinalPosition() + " m.";
        }
    }
}

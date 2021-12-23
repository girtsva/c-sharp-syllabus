using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _liters;
        
        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return Math.Round((_endKilometers - _startKilometers) / _liters, 2);
        }

        private double ConsumptionPer100Km()
        {
            return Math.Round(100 / CalculateConsumption(), 2);
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _endKilometers = mileage;
            _liters = liters;
        }

        public string CarEconomyClass()
        {
            string performance = $"{ConsumptionPer100Km()} l/100km for a total distance of {_endKilometers - _startKilometers}km";

            if (GasHog())
            {
                return performance + " and is a Gas Hog.";
            }
            else if (EconomyCar())
            {
                return performance + " and is an Economy Car.";
            }
            else
            {
                return performance + " and is not either a Gas Hog, nor Economy Car.";
            }
        }
    }
}

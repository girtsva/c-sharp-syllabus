using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Odometer
    {
        private int _maxMileage = 999999;
        private int _startingMileage;
        public int Mileage { get; private set; }
        private FuelGauge _fuelGauge;
        private int _fuelEconomy = 10;

        public Odometer(int startingMileage, FuelGauge fuelGauge)
        {
            _startingMileage = startingMileage;
            Mileage = startingMileage;
            _fuelGauge = fuelGauge;
        }

        public int AddMileage()
        {
            int newMileage = Mileage < _maxMileage ? ++Mileage : 0;
            DecreaseFuel();
            return newMileage;
        }

        public void DecreaseFuel()
        {
            int distance = Mileage - _startingMileage;
            if (distance % _fuelEconomy == 0)
            {
                _fuelGauge.BurnFuel();
            }
        }
    }
}

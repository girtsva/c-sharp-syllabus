using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class FuelGauge
    {
        private int _fuelTankCapacity = 70;
        public int AmountOfFuel { get; private set; }

        public void AddFuel()
        {
            if (AmountOfFuel < _fuelTankCapacity)
            {
                AmountOfFuel++;
            }
        }

        public void BurnFuel()
        {
            if (AmountOfFuel > 0 )
            {
                AmountOfFuel--;
            }
        }

        public int GetTankCapacity()
        {
            return _fuelTankCapacity;
        }
    }
}

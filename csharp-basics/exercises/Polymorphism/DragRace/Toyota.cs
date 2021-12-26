using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    public class Toyota : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 7;
        }

        public void SlowDown()
        {
            _currentSpeed -= 7;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 70;
        }

        public void StartEngine()
        {
            Console.WriteLine("Pssst...Brbrbrr...");
        }
    }
}

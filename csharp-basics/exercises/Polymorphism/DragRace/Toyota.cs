using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    public class Toyota : ICar, IBoostable
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 7;
        }

        public void SlowDown()
        {
            currentSpeed -= 7;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 70;
        }

        public void StartEngine()
        {
            Console.WriteLine("Pssst...Brbrbrr...");
        }
    }
}

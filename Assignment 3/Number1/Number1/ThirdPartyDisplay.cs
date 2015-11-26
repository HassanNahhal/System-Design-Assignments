using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class ThirdPartyDisplay : IObserver, IDisplay
    {
        private float _maxTemp = 0.0f;
        private float _minTemp = 200;
        private float _tempSum = 0.0f;
        private int _numReadings;
        private WaterData _waterData;

        public ThirdPartyDisplay(WaterData waterData)
        {
            this._waterData = waterData;
            waterData.RegisterObserver(this);
        }

        public void Update(float temperature, float quality)
        {
            _tempSum += temperature;
            _numReadings++;

            if (temperature > _maxTemp)
            {
                _maxTemp = temperature;
            }

            if (temperature < _minTemp)
            {
                _minTemp = temperature;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (_tempSum / _numReadings)
                + "/" + _maxTemp + "/" + _minTemp);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class WebDataDisplay : IObserver, IDisplay
    {
        private float _currentTemperature = 0f;
        private float _lastTemperature;
        private WaterData _waterData;

        public WebDataDisplay(WaterData weatherData)
        {
            this._waterData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float quality)
        {
            _lastTemperature = _currentTemperature;
            _currentTemperature = temperature;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Water Temperature: ");

            if (_currentTemperature > _lastTemperature)
            {
                Console.WriteLine("Water getting hotter!");
            }
            else if (_currentTemperature == _lastTemperature)
            {
                Console.WriteLine("Same temperature");
            }
            else if (_currentTemperature < _lastTemperature)
            {
                Console.WriteLine("Watch out for cooler, and freezing water");
            }
        }
    }
}

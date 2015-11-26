using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class MobileDataDisplay : IObserver, IDisplay
    {
        private float _temperature;
        private float _quality;
        private ISubject _weatherData;

        public MobileDataDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float quality)
        {
            this._temperature = temperature;
            this._quality = quality;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current Water Data: " + _temperature
                + "F degrees and " + _quality + "% dirt");
        }
    }
}

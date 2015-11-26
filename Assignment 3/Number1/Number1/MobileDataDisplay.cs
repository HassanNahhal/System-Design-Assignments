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
        private float _humidity;
        private ISubject _weatherData;

        public MobileDataDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature
                + "F degrees and " + _humidity + "% humidity");
        }
    }
}

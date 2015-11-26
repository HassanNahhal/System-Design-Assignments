using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class WaterData : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private float _temperature;
        private float _quality;

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temperature, _quality);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float quality)
        {
            this._temperature = temperature;
            this._quality = quality;
            MeasurementsChanged();
        }
    }
}

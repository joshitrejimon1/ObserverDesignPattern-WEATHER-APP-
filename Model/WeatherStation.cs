using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Model
{
    internal class WeatherStation : IWeatherStation
    {
        private List<IObserver> observers = new List<IObserver>();
        string temperature;
        string humidity;
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetMeasurements(string temperature, string humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            NotifyObservers();
        }
    }
}

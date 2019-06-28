using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    class WeatherData : ISubject
    {

        private List<IObserver> observers;
        private double temperature;
        private double humidity;
        private double pressure;

        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }

        public void registerObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void notifyObserver()
        {
            try {
                for (int i = 0; i < observers.Count; i++)
                {
                    IObserver observer = this.observers[i];
                    observer.update(temperature, humidity, pressure);
                }
            }
           catch
            {

            }
        }

        public void measurementsChange()
        {
            this.notifyObserver();
        }

        public void setMeasurements(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.measurementsChange();
        }

    }
}

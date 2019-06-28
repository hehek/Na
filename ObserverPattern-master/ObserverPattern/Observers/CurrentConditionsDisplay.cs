using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    class currentConditionsDisplay : IObserver, IDisplay
    {
        public delegate void ConditionsState(WeatherData weatherData);
        public event ConditionsState ConditionsUpdate;

        private double temperature;
        private double humidity;
        private ISubject weatherData;

        public currentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.registerObserver(this);
        }


      public  void update(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        display();
    }

        public void display()
        {
            Console.WriteLine($"Current conditions: {temperature}C degrees and {humidity} % humidity");
        }
              
    }
}

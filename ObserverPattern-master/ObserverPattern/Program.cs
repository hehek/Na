using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observers;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {           
          
            WeatherData weatherData = new WeatherData();


            currentConditionsDisplay currentDisplay = new currentConditionsDisplay(weatherData);

            Console.WriteLine("New data:");
            
            weatherData.setMeasurements(80, 65, 30.4);
            weatherData.setMeasurements(82, 70, 29.2);
            weatherData.setMeasurements(78, 90, 29.2);

            Console.WriteLine("Changes:");

            weatherData.setMeasurements(65, 65, 31.4);
            weatherData.setMeasurements(80, 50, 25.2);
            weatherData.setMeasurements(76, 70, 25.9);

            Console.WriteLine("Changes:");

            weatherData.setMeasurements(6, 65, 31.4);
            weatherData.setMeasurements(80, 50, 25.2);
            weatherData.setMeasurements(76, 70, 25.9);

            Console.ReadKey();
        }
    }
}

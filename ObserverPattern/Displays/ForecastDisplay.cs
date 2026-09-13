using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            if (humidity > 80)
            {
                Console.WriteLine("Forecast: Its going to get rainy");
            }
            else if (temperature > 25)
            {
                Console.WriteLine("Forecast: Beautiful weather above 25 degrees is coming!");
            }
            else
            {
                Console.WriteLine("Forecast: No changes suscpected");
            }
        }
    }
}

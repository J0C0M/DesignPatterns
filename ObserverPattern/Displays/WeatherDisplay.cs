using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal abstract class WeatherDisplay : Observer, DisplayElement
    {
        protected float temperature;
        protected float humidity;
        protected float pressure;
        private Subject weatherData;
        public WeatherDisplay(Subject weatherData)
        {
            weatherData.RegisterObserver(this);
        }
        public virtual void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public abstract void Display();
    }
}
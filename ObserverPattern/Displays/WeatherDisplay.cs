using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal abstract class WeatherDisplay : Observer, DisplayElement
    {
        protected float temperature;
        protected float humidity;
        protected float pressure;
        protected Subject weatherData;
        protected WeatherDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
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
using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : WeatherDisplay
    {
        public ForecastDisplay(Subject weatherData) : base(weatherData)
        {
        }

        public override void Display()
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

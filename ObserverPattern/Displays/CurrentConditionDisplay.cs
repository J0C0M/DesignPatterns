using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : WeatherDisplay
    {
        public CurrentConditionDisplay(Subject weatherData) : base(weatherData)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Current weather conditions: {temperature}C degrees & {humidity}% humidity");
        }
    }
}

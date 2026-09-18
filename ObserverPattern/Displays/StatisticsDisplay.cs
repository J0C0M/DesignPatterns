using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : WeatherDisplay
    {
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;

        public StatisticsDisplay(Subject weatherData) : base(weatherData)
        {
        }

        public override void Update(float temp, float humidity, float pressure)
        {
            sumTemperature += temp;
            countUpdated++;

            if (countUpdated == 1 || temp > maxTemp)
            {
                maxTemp = temp;
            }
            if (countUpdated == 1 || temp < minTemp)
            {
                minTemp = temp;
            }

            base.Update(temp, humidity, pressure);
        }

        public override void Display()
        {
            float average = sumTemperature / countUpdated;
            Console.WriteLine($"Avg temp = {average}, max temp = {maxTemp}, min temp ={minTemp}");
        }
    }
}

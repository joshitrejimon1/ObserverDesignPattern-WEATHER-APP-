using ObserverDesignPattern.Model;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a weather station
            WeatherStation weatherStation = new WeatherStation();

            // Create weather display widgets
            TemperatureDisplay temperatureDisplay = new TemperatureDisplay();
            HumidityDisplay humidityDisplay = new HumidityDisplay();

            // Register displays as observers
            weatherStation.RegisterObserver(temperatureDisplay);
            weatherStation.RegisterObserver(humidityDisplay);

            // Simulate weather changes
            weatherStation.SetMeasurements("25", "50");
            weatherStation.SetMeasurements("30", "55");

            // Unregister a display
            weatherStation.RemoveObserver(temperatureDisplay);

            // Simulate more weather changes
            weatherStation.SetMeasurements("28", "48");
        }
    }

}
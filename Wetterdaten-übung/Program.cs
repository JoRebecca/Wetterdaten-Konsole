using System.Text.Json;

namespace Wetterdaten_übung
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            WeatherService service = new WeatherService();

            Console.WriteLine("Wetter-App startet...");

            Console.WriteLine("Bitte geben Sie eine Stadt ein:  ");
            string city= Console.ReadLine() ?? "Leipzig"; // Fallback auf leipzig wenn user nix gibt

            WeatherData? weather = await service.GetWeatherAsync(city);

            if (weather != null)// falls api fehlschläft 
            {
                Console.WriteLine($"\n Stadt:       {weather.CityName}");
                Console.WriteLine($" Temperatur:  {weather.Temperature}°C");
                Console.WriteLine($" Wetter:      {weather.Description}");
                Console.WriteLine($" Luftfeuchte: {weather.Humidity}%");
            }
        }
    }
}

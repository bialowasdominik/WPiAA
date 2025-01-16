using System.Text.Json;

namespace Facade
{
    public class WeatherInfo
    {
        public double Temperature { get; set; }
    }

    public class WeatherServiceFacade
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "2d1e5773fe3d1dc316f624436f334f1a";
        private const string WeatherBaseUrl = "https://api.openweathermap.org/data/2.5/weather";
        private const string GeoBaseUrl = "http://api.openweathermap.org/geo/1.0/direct";

        public WeatherServiceFacade()
        {
            _httpClient = new HttpClient();
        }

        public async Task<WeatherInfo> GetWeatherAsync(string cityName)
        {
            try
            {
                var geoUrl = $"{GeoBaseUrl}?q={cityName}&appid={ApiKey}";
                var geoResponse = await _httpClient.GetAsync(geoUrl);

                if (!geoResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine("Nie udało się pobrać danych pogodowych.");
                    return null;
                }
                var geoResponseContent = await geoResponse.Content.ReadAsStringAsync();
                var geoData = JsonSerializer.Deserialize<JsonElement[]>(geoResponseContent);

                var lat = geoData[0].GetProperty("lat").GetDouble();
                var lon = geoData[0].GetProperty("lon").GetDouble();

                var url = $"{WeatherBaseUrl}?lat={lat}&lon={lon}&appid={ApiKey}&units=metric";
                var response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Nie udało się pobrać danych pogodowych.");
                    return null;
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                var weatherData = JsonSerializer.Deserialize<JsonElement>(responseContent);

                var temperature = weatherData.GetProperty("main").GetProperty("temp").GetDouble();

                return new WeatherInfo
                {
                    Temperature = temperature
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
                return null;
            }
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            var weatherService = new WeatherServiceFacade();

            while (true)
            {
                Console.WriteLine("Podaj nazwę miasta (lub wpisz 'exit', aby zakończyć):");
                var cityName = Console.ReadLine();

                if (string.Equals(cityName, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var weatherInfo = await weatherService.GetWeatherAsync(cityName);

                if (weatherInfo != null)
                {
                    Console.WriteLine($"Aktualna temperatura w mieście {cityName}: {weatherInfo.Temperature}°C");
                }
                else
                {
                    Console.WriteLine("Nie udało się pobrać danych pogodowych.");
                }
            }
        }
    }
}

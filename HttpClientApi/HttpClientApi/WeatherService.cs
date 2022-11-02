using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientApi
{
    public interface IWeatherService
    {
        Task<string> Get(string cityName);
    }
    public class WeatherService
    {
        private HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Get(string cityName)
        {
            var apiKey = "<GET YOUR API KEY HERE https://www.weatherapi.com/>";

            string APIURL = $"?key={apiKey}&q={cityName}";
            var response = await _httpClient.GetAsync(APIURL);
            return await response.Content.ReadAsStringAsync();
        }
    }
}

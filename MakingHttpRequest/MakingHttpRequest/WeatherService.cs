using System.Net.Http;
using System.Threading.Tasks;

namespace MakingHttpRequest
{
    public interface IWeatherService
    {
        Task<string> Get(string cityName);
    }

    public class WeatherService : IWeatherService
    {
        private HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Get(string cityName)
        {
            var apiKey = "bca4ef7badc0404895464710220211";

            string APIURL = $"?key={apiKey}&q={cityName}";
            var response = await _httpClient.GetAsync(APIURL);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace WeatherWebApplication.Class
{
    public class GetWeatherDetailsByCityName : IWeatherChecker
    {
        public async Task<WeatherResponse> GetWeatherDetails(string city)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://api.openweathermap.org");
                    var response = await client.GetAsync($"data/2.5/weather?q={city}&appid=7086c9136403fe063f1d52bf6816f715");
                    response.EnsureSuccessStatusCode();
                    string content = await response.Content.ReadAsStringAsync();
                    var weatherResponseDetails = JsonConvert.DeserializeObject<WeatherResponse>(content);
                    return weatherResponseDetails;

                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

       

    }
}

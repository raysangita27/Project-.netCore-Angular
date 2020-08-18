using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherWebApplication.Class;
using System.Net.Http;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherWebApplication.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {  
        // GET api/<controller>/5
        [HttpGet("[action]/city={cityList}")]
        public ActionResult<IEnumerable<WeatherResponseForCitiesDTO>> Get(string cityList)
        {
            try
            {
                List<WeatherResponseForCitiesDTO> weatherResponsesList = new List<WeatherResponseForCitiesDTO>();
                string[] cityListArr = cityList.Split(",");
                foreach (string city in cityListArr)
                {
                    GetWeatherDetailsByCityName getWeatherDetails = new GetWeatherDetailsByCityName();
                    var weatherResponse = getWeatherDetails.GetWeatherDetails(city).Result;
                    weatherResponsesList.Add(WeatherResponseToDTO(weatherResponse));
                }
                weatherResponsesList.Sort((x, y) =>
                {
                    return x.temp.CompareTo(y.temp) ;
                });
                return Ok(weatherResponsesList
                    );
            }
            catch(HttpRequestException httpRequestException)
            {
                return BadRequest($"Error getting weather from OpenWeather: {httpRequestException.Message}");
            }
        }

        public static WeatherResponseForCitiesDTO WeatherResponseToDTO(WeatherResponse weatherResponse) =>
           new WeatherResponseForCitiesDTO
           {
               city = weatherResponse.name,
               temp = weatherResponse.main.temp,
               summary = String.Join(",", weatherResponse.weather.Select(x => x.main)),
           };

    }
}

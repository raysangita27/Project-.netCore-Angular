using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebApplication.Class;

namespace WeatherWebApplication
{
    interface IWeatherChecker
    {
        Task<WeatherResponse> GetWeatherDetails(string paramVal);
    }
}

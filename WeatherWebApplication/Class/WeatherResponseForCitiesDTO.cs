using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebApplication.Class
{
    public class WeatherResponseForCitiesDTO
    {
        public string city { get; set; }
        public double temp { get; set; }
        public string summary { get; set; }
    }
}

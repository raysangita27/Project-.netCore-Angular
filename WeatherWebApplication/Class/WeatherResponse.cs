using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebApplication.Class
{
    public class WeatherResponse
    {
        public string @base { get; set; }
        public Clouds clouds { get; set; }
        public int cod { get; set; }
        public Coord coord { get; set; }
        public int dt { get; set; }
        public int id { get; set; }
        public Main main { get; set; }
        public string name { get; set; }
        public Sys sys { get; set; }
        public int visibility { get; set; }
        public List<Weather> weather { get; set; }
        public Wind wind { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebApplication.Class
{
    public class Sys
    {
        public string country { get; set; }
        public int id { get; set; }
        public string message { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
        public int type { get; set; }
    }
}

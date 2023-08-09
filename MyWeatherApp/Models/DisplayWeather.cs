using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeatherApp.Models
{
    public class DisplayWeather
    {
        public string country { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public double temp { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public  double temp_max { get; set; }
        public double speed { get; set; }
        public string description { get; set; }
    
        public double pressure { get; set; }
        public string name { get; set; }
    }
}
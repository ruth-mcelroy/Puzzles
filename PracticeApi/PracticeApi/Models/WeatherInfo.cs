using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeApi.Models
{
    public class WeatherInfo
    {
        public string City { get; set; }
        public bool WeatherWarning { get; set; }
        public double Temperature { get; set; }
        public string Information { get; set; }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PracticeApi.Models;

namespace PracticeApi.Controllers
{
    [RoutePrefix("api/weather")]
    public class WeatherController : ApiController
    {
       
        public List<WeatherInfo> WeatherInfoList= new List<WeatherInfo>()
        {
            new WeatherInfo(){City = "Dublin", Temperature = 18.08, WeatherWarning = false, Information = "Nice and Sunny Day"},
            new WeatherInfo(){City = "Cork", Temperature = 23, WeatherWarning = false, Information = "Don't go here if you can avoid it."},
            new WeatherInfo(){City = "Galway", Temperature = 28, WeatherWarning = true, Information = "Too hot"},
            new WeatherInfo(){City = "Belfast", Temperature = 13, WeatherWarning = false, Information = "Colder than everywhere else."},
            new WeatherInfo(){City = "Waterford", Temperature = 16, WeatherWarning = false, Information = "Why would you go to Waterford anyway?"}
        };

        
        


        //[Route("all")]
        //public IEnumerable<Models.WeatherInfo> GetAllWeather()
        //{
        //    return  WeatherInfoList;
        //}


         [Route("")]
        public IHttpActionResult GetAllWeather()
        {
            return Ok(WeatherInfoList);
        }

        [Route("{cityInput:alpha}")]

        public IHttpActionResult GetWeatherCity(string cityInput)
        {
            var c1 = WeatherInfoList.FirstOrDefault((c) => c.City.ToUpper() == cityInput.ToUpper());

            if (c1 == null)
            {
                return NotFound();
            }

            else return Ok(c1);
        }

        [Route("warning")]

        public IHttpActionResult GetWarnings()
        {
            var cities = WeatherInfoList.Where(w => w.WeatherWarning)
                                         .Select(w => w.City);

            return Ok(cities);
                                        
                                    
        }

        
    }
}

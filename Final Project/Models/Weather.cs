using Nancy.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Weather
    {
        public Weather()
        {

        }
        public WeatherPrint getWeatherForcast()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Alexandria&appid=f5bbc84839fecaad065f7feae5f76b3a";

            var client = new WebClient();
            var content = client.DownloadString(url);
            JToken jcontent = JToken.Parse(content);
            var main = jcontent.SelectToken("weather.main");

            var newWeather = new WeatherPrint();
            newWeather.Main = "clear";
            return newWeather;
        }
    }
}

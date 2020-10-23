using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;




namespace Final_Project.Controllers
{
    public class WeatherController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WeatherOrNot()
        {
            return View();
        }
        public IActionResult GetWeather()
        {
            Weather weather = new Weather();
            var weatherPrint = weather.getWeatherForcast();

            // return Json(weather.getWeatherForcast());
            
            return View(weatherPrint);
        }
    }
}

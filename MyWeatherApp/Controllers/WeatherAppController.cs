using System;
using System.Net;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWeatherApp.Models;
using System.Web.UI;

namespace MyWeatherApp.Controllers
{
    public class WeatherAppController : Controller
    {
        // GET: WeatherApp
        Weathers weather = new Weathers();
        Weathers.Root root = new Weathers.Root();   
        DisplayWeather ds  = new DisplayWeather();
        string Json;


        public ActionResult Index()
        {
           
            return View();
        }

       
        public ActionResult WeatherDetails(String city)
        {
            string apiKey = "229670b77520462593b078486233c410";

            string url = String.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&apiKey={1}", city, apiKey);

            
                using (var webClient = new WebClient())
               {
                try
                {
                    Json = webClient.DownloadString(url);
                }catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                    
               

                    
                    
                        var serializer = new JavaScriptSerializer();
                    Weathers.Root sr = serializer.Deserialize<Weathers.Root>(Json);
                     
                    ds.country = sr.sys.country;
                    ds.pressure = sr.main.pressure; 
                    ds.temp = sr.main.temp;
                    ds.temp_max = sr.main.temp_max;
                    ds.temp_min = sr.main.temp_min;
                    ds.humidity = sr.main.humidity;
                    ds.description = sr.weather[0].description;
                    ds.speed = sr.wind.speed;
                    ds.lon = sr.coord.lon;
                    ds.lat = sr.coord.lat;
                    ds.name = sr.name;
                    

                   

                return Json(ds, JsonRequestBehavior.AllowGet);
            }

           

        }
    }
}
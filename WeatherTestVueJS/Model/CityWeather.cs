using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherTestVueJS.Model
{
    /// <summary>
    /// Main class that will store the result of the forecast
    /// </summary>
    public class CityWeather
    {
        public string Id { get; set; }
        public CityWeather()
        {
            WeatherStats = new List<CityWeatherPerDay>();
        }

        public string Location { get; set; }
        public string ZipCode { get; set; }
        public string Units { get; set; }

        public List<CityWeatherPerDay> WeatherStats { get; set; }
    }
}

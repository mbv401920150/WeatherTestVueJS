using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherTestVueJS.Model
{
    /// <summary>
    /// Class to store the forecast per each day
    /// </summary>
    public class CityWeatherPerDay
    {
        public string Date { get; set; }
        public string AverageTemp { get; set; }
        public bool ChanceOfPrecipitation { get; set; }
    }
}

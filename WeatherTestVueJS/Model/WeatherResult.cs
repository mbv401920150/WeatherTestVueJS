using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherTestVueJS.Model
{
    /// <summary> 
    /// Main class that will work as model to Parse the JSON String to an object
    /// It's fully recommended to allow manipulation through LINQ
    /// </summary>
    public class WeatherResult
    {
        public string cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
        public List<WheaterEntry> list { get; set; }
        public City city { get; set; }
    }
}

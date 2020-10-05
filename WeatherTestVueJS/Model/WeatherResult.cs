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
        public string Cod { get; set; }
        public int Message { get; set; }
        public int Cnt { get; set; }
        public List<WheaterEntry> List { get; set; }
        public City City { get; set; }
    }
}

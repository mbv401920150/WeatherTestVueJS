using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherTestVueJS.Model
{
    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public double population { get; set; }
        public int timezone { get; set; }
        public double sunrise { get; set; }
        public double sunset { get; set; }
    }
}

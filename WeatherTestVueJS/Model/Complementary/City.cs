using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherTestVueJS.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public string Country { get; set; }
        public double Population { get; set; }
        public int Timezone { get; set; }
        public double Sunrise { get; set; }
        public double Sunset { get; set; }
    }
}

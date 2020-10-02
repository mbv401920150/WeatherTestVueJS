using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherTestVueJS.Model
{
    /// <summary>
    /// Class with the temperature measures of each entry 
    /// </summary>
    public class MainMeasures
    {
        /// <summary> 
        /// Get the average of temp per each measure
        /// Necessary to calculate the average per day (Max and Min)
        /// </summary>
        public double temp_average
        {
            get
            {
                return Math.Round((temp_min + temp_max) / 2, 2);
            }
        }
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public float pressure { get; set; }
        public float sea_level { get; set; }
        public float grnd_level { get; set; }
        public float humidity { get; set; }
        public float temp_kf { get; set; }
    }
}

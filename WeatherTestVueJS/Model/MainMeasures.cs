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
        public double TempAverage
        {
            get
            {
                return Math.Round((Temp_min + Temp_max) / 2, 2);
            }
        }
        public float Temp { get; set; }
        public float Feels_like { get; set; }
        public float Temp_min { get; set; }
        public float Temp_max { get; set; }
        public float Pressure { get; set; }
        public float Sea_level { get; set; }
        public float Grnd_level { get; set; }
        public float Humidity { get; set; }
        public float Temp_kf { get; set; }
    }
}

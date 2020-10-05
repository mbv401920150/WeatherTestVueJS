using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherTestVueJS.Model
{
    /// <summary> 
    /// Weather information
    /// </summary>
    public class WheaterEntry
    {
        /// <summary>
        /// UnixEpoch date format
        /// </summary>
        public double Dt { get; set; }
        public MainMeasures Main { get; set; }
        public List<Wheater> Weather { get; set; }
        public Clouds Clouds { get; set; }
        public Wind Wind { get; set; }
        public double Visibility { get; set; }
        public float Pop { get; set; }
        public SysWheater Sys { get; set; }
        public string Dt_txt { get; set; }

        /// <summary>
        /// Take the TimeStamp from the API result and return a DateTime format
        /// </summary>
        public DateTime Date
        {
            get
            {
                return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddSeconds(Dt);
            }
        }
    }
}

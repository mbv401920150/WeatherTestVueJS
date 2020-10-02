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
        public double dt { get; set; }
        public MainMeasures main { get; set; }
        public List<Wheater> weather { get; set; }
        public Clouds clouds { get; set; }
        public Wind wind { get; set; }
        public double visibility { get; set; }
        public float pop { get; set; }
        public SysWheater sys { get; set; }
        public string dt_txt { get; set; }

        /// <summary>
        /// Take the TimeStamp from the API result and return a DateTime format
        /// </summary>
        public DateTime date
        {
            get
            {
                return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddSeconds(dt);
            }
        }
    }
}

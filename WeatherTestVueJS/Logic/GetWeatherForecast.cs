using MediatR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using WeatherTestVueJS.Model;

namespace WeatherTestVueJS.Logic
{
    public class GetWeatherForecast
    {
        public class Request : IRequest<CityWeather>
        {
            public string location { get; set; }
        }

        public class Handler : IRequestHandler<Request, CityWeather>
        {
            private readonly IConfiguration _iConfig;
            public Handler(IConfiguration iConfig)
            {
                _iConfig = iConfig;
            }

            /// <summary> Return the URL combined with the current city and the API key</summary>
            /// <param name="location">Location based on ({city name},{city code},{country code})</param>
            /// <returns>The complete URL to make call to the API</returns>
            private string getUrl(string location)
            {
                string url = _iConfig.GetSection("WeatherConfig:BaseUrl").Value;
                string apiKey = _iConfig.GetSection("WeatherConfig:API_KEY").Value;

                return url
                    .Replace("{LOCATION}", location)
                    .Replace("{APIKEY}", apiKey);
            }

            /// <summary> Get the Forecast of the Weather of the next 5 days of the selected location </summary>
            /// <param name="location">Use the format CITY,CITY_CODE,COUNTRY</param>
            /// <returns>An instance of the class CityWeather </returns>
            public async Task<CityWeather> Handle(Request request, CancellationToken cancellationToken)
            {
                try
                {
                    // Create the URL to make the request
                    string url = getUrl(request.location);

                    // Create the new request using the location and the API Key
                    HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                    // Store the API result as JSON String
                    string resultJsonString = "";

                    // Execute the request
                    using (HttpWebResponse response =  (HttpWebResponse) await httpRequest.GetResponseAsync())
                    // Read the result as an Stream
                    using (Stream stream = response.GetResponseStream())
                    // Reader to get the result as String
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        // String as JSON
                        resultJsonString = await reader.ReadToEndAsync();
                    }

                    // Parse the JSON String to a WeatherResult class
                    var weatherResult = JsonConvert.DeserializeObject<WeatherResult>(resultJsonString);

                    // Create a new instace of CityWeather to return the result
                    CityWeather result = new CityWeather();

                    // Use LINQ to extract and calculate the forecast per days
                    // The API return entries for 5 days, in a range of 3 hours
                    // First the list is sorted by date ASC
                    // The WHERE clause remove the current day
                    // The LINQ group the data per date (without taking consideration the time)
                    // The SELECT return the date, the average temp, and if exists or not chance of precipitation
                    // TAKE will only return the first 5 days
                    var stats = weatherResult
                        .list
                        .OrderBy(measure => measure.date)
                        .Where(measure => measure.date >= DateTime.Today.AddDays(1))
                        .GroupBy(measure => measure.date.ToString("MM/dd/yyyy"))
                        .Select(daily => new CityWeatherPerDay()
                        {
                            Date = daily.Key,
                            AverageTemp = Math.Round(daily.Average(m => m.main.temp_average), 2),
                            ChanceOfPrecipitation = daily.Average(m => m.pop) > 0
                        })
                        .Take(5);

                    result.Id = weatherResult.city.id; // Add the City ID
                    result.Location = request.location.Replace(",", ", "); // Beautify the string for final display
                    result.WeatherStats.AddRange(stats); // Add 5 days

                    // Return the result
                    return result;
                }
                catch { throw; }
            }
        }
    }
}

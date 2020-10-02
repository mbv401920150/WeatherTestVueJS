using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherTestVueJS.Logic;
using WeatherTestVueJS.Model;

namespace WeatherTestVueJS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;
        public WeatherForecastController(IMediator mediator) {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<CityWeather>> getForecast([FromQuery] GetWeatherForecast.Request request)
        {
            return await _mediator.Send(request);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightForecastController : ControllerBase
    {

        private readonly ILogger<FlightForecastController> _logger;

        public FlightForecastController(ILogger<FlightForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
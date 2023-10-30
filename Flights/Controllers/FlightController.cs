using Flights.ReadModel;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {

        private readonly ILogger<FlightController> _logger;

        public FlightController(ILogger<FlightController> logger)
        {
            _logger = logger;
        }

        Random random = new Random();

        [HttpGet]
        public IEnumerable<FlightRm> Search() => new FlightRm[]
        {
            new ( Guid.NewGuid(),
            "American Airlines",
            random.Next(90, 5000).ToString(),
            new TimePlaceRm("Los Angeles",DateTime.Now.AddHours(random.Next(1, 3))),
            new TimePlaceRm("Istanbul",DateTime.Now.AddHours(random.Next(4, 10))),
            random.Next(1, 853)
         ),
        new (
            Guid.NewGuid(),
            "Delta Airlines",
            random.Next(90, 5000).ToString(),
            new TimePlaceRm("New York", DateTime.Now.AddHours(random.Next(1, 3))),
            new TimePlaceRm("Paris", DateTime.Now.AddHours(random.Next(4, 10))),
            random.Next(1, 853)
        ),
        new (
            Guid.NewGuid(),
            "United Airlines",
            random.Next(90, 5000).ToString(),
            new TimePlaceRm("Chicago", DateTime.Now.AddHours(random.Next(1, 3))),
            new TimePlaceRm("London", DateTime.Now.AddHours(random.Next(4, 10))),
            random.Next(1, 853)
        ),
        new (
            Guid.NewGuid(),
            "Lufthansa",
            random.Next(90, 5000).ToString(),
            new TimePlaceRm("Berlin", DateTime.Now.AddHours(random.Next(1, 3))),
            new TimePlaceRm("Rome", DateTime.Now.AddHours(random.Next(4, 13))),
            random.Next(1, 853)
        ),
        new (
            Guid.NewGuid(),
            "Emirates",
            random.Next(90, 5000).ToString(),
            new TimePlaceRm("Dubai", DateTime.Now.AddHours(random.Next(1, 3))),
            new TimePlaceRm("Tokyo", DateTime.Now.AddHours(random.Next(4, 10))),
            random.Next(1, 853)
        ),
        new (
            Guid.NewGuid(),
            "Singapore Airlines",
            random.Next(90, 5000).ToString(),
            new TimePlaceRm("Singapore", DateTime.Now.AddHours(random.Next(1, 3))),
            new TimePlaceRm("Sydney", DateTime.Now.AddHours(random.Next(4, 15))),
            random.Next(1, 853)
        )
        };
    }
}
using Microsoft.AspNetCore.Mvc;

namespace my_2nd_AspDotNetCore_with_angular_app.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
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

[ApiController]
[Route("[controller]")]
public class QWeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<QWeatherForecastController> _logger;

    public QWeatherForecastController(ILogger<QWeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{value1}")]
    public IEnumerable<QWeatherForecast> Get(int Value1)
    {
        return Enumerable.Range(1, 5).Select(index => new QWeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
//            TemperatureC = -13,
            TemperatureC = Value1,
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

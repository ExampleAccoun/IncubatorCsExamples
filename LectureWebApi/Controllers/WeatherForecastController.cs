using LectureWebApi.Business;
using Microsoft.AspNetCore.Mvc;

namespace LectureWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(IWeatherForecastService weatherForecastService)
    {
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        var weatherForecasts = await _weatherForecastService.GetWeatherForecasts();

        return weatherForecasts;
    }
}
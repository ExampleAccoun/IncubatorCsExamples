namespace LectureWebApi.Business;

public interface IWeatherForecastService
{
    public Task<IEnumerable<WeatherForecast>> GetWeatherForecasts();
}
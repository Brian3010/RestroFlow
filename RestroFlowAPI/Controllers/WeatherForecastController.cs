using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestroFlowAPI.Repositories.Interfaces;

namespace RestroFlowAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private static readonly string[] Summaries = new[]
    {
          "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
      };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IRedisTokenRepository _redisTokenRepository;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IRedisTokenRepository redisTokenRepository) {
      _logger = logger;
      _redisTokenRepository = redisTokenRepository;
    }

    [Authorize(Roles = "Staff")]
    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> GetAsync() {
      // testing purpose
      string userId = "73b87a5d-2f3d-436c-8a58-2103a1eb7959";
      var tokens = await _redisTokenRepository.GetRFTokensByUserId(userId);
      var deviceIds = _redisTokenRepository.GetDeviceIdsByUserId(userId);
      _logger.LogInformation("RefreshTokens of userId-{0}: {1}", userId, tokens);
      _logger.LogInformation("DevicedIds of userId-{0}: {1}", userId, deviceIds);

      return Enumerable.Range(1, 5).Select(index => new WeatherForecast {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
      })
      .ToArray();
    }
  }
}

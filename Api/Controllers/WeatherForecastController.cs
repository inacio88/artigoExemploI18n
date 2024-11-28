using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Common.Resources;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IStringLocalizer<Resource> _localizer;

    public WeatherForecastController(IStringLocalizer<Resource> localizer)
    {
        _localizer = localizer;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IActionResult Get()
    {
        return Ok($"Sucesso na traducao: {_localizer["msg_sucesso"]}");
    }
}

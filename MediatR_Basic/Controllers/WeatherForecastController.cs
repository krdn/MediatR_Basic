using MediatR_Basic.Services;
using Microsoft.AspNetCore.Mvc;

namespace MediatR_Basic.Controllers;
[ApiController]
[Route("[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IEnumerable<INotifier> _notifiers;
    private readonly INotifierMediatorService _notifierMediatorService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
        IEnumerable<INotifier> notifiers,
        INotifierMediatorService notifierMediatorService)
    {
        _logger = logger;
        _notifiers = notifiers;
        _notifierMediatorService = notifierMediatorService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet(Name = "TestMediator")]
    public IActionResult TestMediator()
    {
        var myService = new MyService(new Handler1(), new Handler2(), new Handler3());
        myService.DoSomething();

        var myServiceMediator = new MyServiceMediator(new HandlerMediator(new Handler1(), new Handler2(), new Handler3()));
        myServiceMediator.DoSomething();

        return Ok();
    }


    [HttpGet("")]
    public ActionResult<string> NotifyAll()
    {
        _notifiers.ToList().ForEach(x => x.Notify());
        return "Completed IEnumerable";
    }

    [HttpGet("")]
    public ActionResult<string> NotifyAllMediatorService()
    {
        _notifierMediatorService.Notify();
        return "Completed MediatorService";
    }


    [HttpGet("")]
    public ActionResult<string> NotifyAllMediatorServiceCanRun()
    {
        _notifiers.Where(x => x.CanRun()).ToList().ForEach(x => x.Notify());
        return "Completed MediatorServiceCanRun";
    }
}

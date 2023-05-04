using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class todolistController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<todolistController> _logger;

    public todolistController(ILogger<todolistController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Gettodolist")]
    public IEnumerable<todolist> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new todolist
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

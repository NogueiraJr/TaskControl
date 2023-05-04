using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class todolistController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Ativa", "Completa", "Pausada", "Cancelada", "Encaminhada", "Arquivada"
    };

    private readonly ILogger<todolistController> _logger;

    public todolistController(ILogger<todolistController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Gettodolist")]
    public IEnumerable<todolist> Get()
    {
        return Enumerable.Range(1, 15).Select(index => new todolist
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            valMin = Random.Shared.Next(-1, 9),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

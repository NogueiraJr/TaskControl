using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoListController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Ativa", "Completa", "Pausada", "Cancelada", "Encaminhada", "Arquivada"
    };

    private readonly TodoListContext _context;
    private readonly ILogger<TodoListController> _logger;

    public TodoListController(TodoListContext context, ILogger<TodoListController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet(Name = "Gettodolist")]
    public async Task<IEnumerable<TodoList>> Get()
    {
        var ret = await _context.TodoLists.ToListAsync();
        return ret;
    }
}

public class TodoList
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public string Situation { get; set; }
}

public class TodoListContext : DbContext
{
    public TodoListContext(DbContextOptions<TodoListContext> options)
        : base(options)
    {
    }

    public DbSet<TodoList> TodoLists { get; set; }
}

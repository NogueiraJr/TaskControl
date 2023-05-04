namespace webapi;

public class todolist
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 9 + (int)(TemperatureC / 2);

    public string? Summary { get; set; }
}

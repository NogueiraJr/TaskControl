namespace webapi;

public class todolist
{
    public DateOnly Date { get; set; }

    public int valMin { get; set; }

    public int valMax => 9 + (int)(valMin / 2);

    public string? Summary { get; set; }
}

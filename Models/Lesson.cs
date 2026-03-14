namespace CodeKurs.Web.Models;

public class Lesson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Order { get; set; }
    public string Language { get; set; } = "csharp";

    public List<ProgrammingTask> Tasks { get; set; } = new();
}

namespace CodeKurs.Web.Models;

public class UserProgress
{
    public int Id { get; set; }
    public string UserId { get; set; } = "guest"; // Für den Anfang nutzen wir einen Standard-User
    public int TaskId { get; set; }
    public bool IsCompleted { get; set; }
    public string LastSubmittedCode { get; set; } = string.Empty;
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

    public ProgrammingTask? Task { get; set; }
}

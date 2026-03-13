namespace CodeKurs.Web.Models;

public enum TaskType
{
    Programming,
    MultipleChoice
}

public class ProgrammingTask
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskType Type { get; set; } = TaskType.Programming;
    public string Language { get; set; } = "csharp"; // "csharp" oder "java"
    
    // Für Programmieraufgaben
    public string InitialCode { get; set; } = string.Empty;
    public string ExpectedOutput { get; set; } = string.Empty;
    
    // Für Multiple Choice (JSON-String der Optionen)
    public string? ChoicesJson { get; set; } 
    public string? CorrectAnswer { get; set; }

    // Validierungsregeln
    public string? RequiredKeywords { get; set; } // Kommagetrennte Liste von Schlüsselwörtern
}

public class TaskNavItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public TaskType Type { get; set; }
}

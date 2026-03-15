namespace CodeKurs.Web.Models;

public enum TaskType
{
    Theory,         // Reine Theorie ohne Code-Eingabe
    Programming,    // Klassische Programmieraufgabe
    MultipleChoice, // Quiz
    Edu,            // Aufgabe mit Tests (Placeholder)
    Output          // Validierung durch Output-Vergleich
}

public class ProgrammingTask
{
    public int Id { get; set; }
    public int? LessonId { get; set; }
    public Lesson? Lesson { get; set; }
    public int Order { get; set; } // Reihenfolge innerhalb der Lektion

    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskType Type { get; set; } = TaskType.Programming;
    public string Language { get; set; } = "csharp";
    
    // Für Programmieraufgaben
    public string InitialCode { get; set; } = string.Empty;
    public string ExpectedOutput { get; set; } = string.Empty;
    public string? Solution { get; set; }
    
    // Platzhalter-Logik (z.B. LessonName#TaskName#File#PlaceholderIndex)
    public string? PlaceholderDependency { get; set; }

    // Für Multiple Choice (JSON-String der Optionen)
    public string? ChoicesJson { get; set; } 
    public string? CorrectAnswer { get; set; }

    // Validierungsregeln
    public string? RequiredKeywords { get; set; } 
    public string? TestCode { get; set; } // Versteckter Code für Unit-Tests (Edu-Tasks)
}

public class TaskNavItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public TaskType Type { get; set; }
}

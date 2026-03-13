using Microsoft.EntityFrameworkCore;
using CodeKurs.Web.Models;

namespace CodeKurs.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ProgrammingTask> Tasks { get; set; }
    public DbSet<UserProgress> Progress { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Beispiel-Daten initialisieren (Seeding)
        modelBuilder.Entity<ProgrammingTask>().HasData(
            new ProgrammingTask
            {
                Id = 1,
                Title = "Erste Schritte: Hallo Welt (C#)",
                Description = "Schreibe ein Programm, das 'Hallo Welt!' auf der Konsole ausgibt.",
                Type = TaskType.Programming,
                Language = "csharp",
                InitialCode = "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\t// Dein Code hier\n\t}\n}",
                ExpectedOutput = "Hallo Welt!",
                RequiredKeywords = "Console.WriteLine"
            },
            new ProgrammingTask
            {
                Id = 2,
                Title = "Quiz: Was ist C#?",
                Description = "Wähle die richtige Beschreibung für C# aus.",
                Type = TaskType.MultipleChoice,
                Language = "csharp",
                ChoicesJson = "[\"Eine Skriptsprache für Webbrowser\", \"Eine objektorientierte Programmiersprache von Microsoft\", \"Ein Betriebssystem\"]",
                CorrectAnswer = "Eine objektorientierte Programmiersprache von Microsoft"
            },
            new ProgrammingTask
            {
                Id = 3,
                Title = "Variablen: Ganzzahlen (C#)",
                Description = "Erstelle eine Variable vom Typ int mit dem Namen 'alter' und weise ihr den Wert 25 zu. Gib sie dann aus.",
                Type = TaskType.Programming,
                Language = "csharp",
                InitialCode = "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\t// Dein Code hier\n\t}\n}",
                ExpectedOutput = "25",
                RequiredKeywords = "int,alter"
            },
            new ProgrammingTask
            {
                Id = 4,
                Title = "Java: Hallo Welt",
                Description = "Schreibe ein Java-Programm, das 'Hallo Java!' ausgibt. Die Klasse muss 'Program' heißen.",
                Type = TaskType.Programming,
                Language = "java",
                InitialCode = "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}",
                ExpectedOutput = "Hallo Java!",
                RequiredKeywords = "System.out.println"
            },
            new ProgrammingTask
            {
                Id = 5,
                Title = "JavaScript: Einfache Addition",
                Description = "Addiere 5 und 10 und gib das Ergebnis aus.",
                Type = TaskType.Programming,
                Language = "javascript",
                InitialCode = "// Dein Code hier\nconsole.log();",
                ExpectedOutput = "15",
                RequiredKeywords = "console.log"
            }
        );
    }
}

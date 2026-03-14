using Microsoft.EntityFrameworkCore;
using CodeKurs.Web.Models;

namespace CodeKurs.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<ProgrammingTask> Tasks { get; set; }
    public DbSet<UserProgress> Progress { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // --- Lektionen Seeding ---
        modelBuilder.Entity<Lesson>().HasData(
            new Lesson { Id = 1, Title = "C# Einführung", Description = "Lerne die Grundlagen von C#.", Order = 1, Language = "csharp" },
            new Lesson { Id = 2, Title = "Kontrollstrukturen", Description = "If-Else und Logik.", Order = 2, Language = "csharp" },
            new Lesson { Id = 3, Title = "Schleifen", Description = "Wiederholungen in C#.", Order = 3, Language = "csharp" },
            new Lesson { Id = 4, Title = "Klassen & Methoden", Description = "Logik in Klassen kapseln.", Order = 4, Language = "csharp" },
            new Lesson { Id = 5, Title = "Java Einstieg", Description = "Lerne Java kennen.", Order = 5, Language = "java" },
            new Lesson { Id = 6, Title = "JavaScript Einführung", Description = "Programmieren für das Web.", Order = 6, Language = "javascript" }
        );

        // --- Aufgaben Seeding ---
        modelBuilder.Entity<ProgrammingTask>().HasData(
            // ... (Ids 1-5 wie gehabt)
            new ProgrammingTask
            {
                Id = 1, LessonId = 1, Order = 1, Title = "Theorie: Was ist C#?", Description = "C# ist eine moderne Programmiersprache von Microsoft.", Type = TaskType.Theory, Language = "csharp"
            },
            new ProgrammingTask
            {
                Id = 2, LessonId = 1, Order = 2, Title = "Hallo Welt (C#)", Description = "Schreibe 'Hallo Welt!' auf die Konsole.", Type = TaskType.Programming, Language = "csharp",
                InitialCode = "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\t// Dein Code hier\n\t}\n}",
                ExpectedOutput = "Hallo Welt!", RequiredKeywords = "Console.WriteLine"
            },
            new ProgrammingTask
            {
                Id = 3, LessonId = 1, Order = 3, Title = "Variablen: int", Description = "Erstelle 'alter' mit Wert 25.", Type = TaskType.Programming, Language = "csharp",
                InitialCode = "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\t// Dein Code hier\n\t}\n}",
                ExpectedOutput = "25", RequiredKeywords = "int,alter"
            },
            new ProgrammingTask
            {
                Id = 10, LessonId = 1, Order = 4, Title = "Variablen: string", Description = "Erstelle eine Variable 'name' vom Typ string mit dem Wert 'C# Profi' und gib sie aus.", Type = TaskType.Programming, Language = "csharp",
                InitialCode = "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\t// Dein Code hier\n\t}\n}",
                ExpectedOutput = "C# Profi", RequiredKeywords = "string,name"
            },
            new ProgrammingTask
            {
                Id = 11, LessonId = 1, Order = 5, Title = "Variablen: double", Description = "Erstelle eine Variable 'preis' vom Typ double mit dem Wert 9.99 und gib sie aus.", Type = TaskType.Programming, Language = "csharp",
                InitialCode = "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\t// Dein Code hier\n\t}\n}",
                ExpectedOutput = "9.99", RequiredKeywords = "double,preis"
            },

            new ProgrammingTask
            {
                Id = 4, LessonId = 2, Order = 1, Title = "Logik: Positiv/Negativ", Description = "Prüfe, ob 'zahl' (-5) positiv ist.", Type = TaskType.Programming, Language = "csharp",
                InitialCode = "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\tint zahl = -5;\n\t\t// Dein Code hier\n\t}\n}",
                ExpectedOutput = "Negativ", RequiredKeywords = "if,else"
            },

            new ProgrammingTask
            {
                Id = 5, LessonId = 3, Order = 1, Title = "For-Schleife: Summe", Description = "Berechne Summe 1-5.", Type = TaskType.Programming, Language = "csharp",
                InitialCode = "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\tint summe = 0;\n\t\t// Nutze eine for-Schleife\n\t\tConsole.WriteLine(summe);\n\t}\n}",
                ExpectedOutput = "15", RequiredKeywords = "for"
            },

            // NEUE EDU AUFGABE (Lesson 4)
            new ProgrammingTask
            {
                Id = 8, LessonId = 4, Order = 1, Title = "Edu: Die Rechner-Klasse", 
                Description = "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)', die die Summe zurückgibt.", 
                Type = TaskType.Edu, Language = "csharp",
                InitialCode = "public class Calculator \n{\n    // Hier deine Methode\n}",
                TestCode = "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}",
                RequiredKeywords = "class,Calculator,static,int"
            },

            new ProgrammingTask
            {
                Id = 9, LessonId = 4, Order = 2, Title = "Edu: Objekte erstellen",
                Description = "Erstelle eine Instanz der Klasse 'Person', setze den Namen auf 'Max' und gib das Objekt zurück.",
                Type = TaskType.Edu, Language = "csharp",
                InitialCode = "public class Person {\n    public string Name { get; set; }\n}\n\npublic class Program {\n    public static Person CreatePerson() {\n        // Erstelle hier eine neue Person und setze den Namen\n        return null;\n    }\n}",
                TestCode = "public class TestRunner {\n    public static void Main() {\n        var p = Program.CreatePerson();\n        if(p != null && p.Name == \"Max\")\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Der Name ist nicht 'Max' oder das Objekt wurde nicht erstellt.\");\n    }\n}",
                RequiredKeywords = "new,Person,Max"
            },

            // Java (Lesson 5)
            new ProgrammingTask
            {
                Id = 6, LessonId = 5, Order = 1, Title = "Java: Hallo Welt", Description = "Schreibe 'Hallo Welt!' in Java.", Type = TaskType.Programming, Language = "java",
                InitialCode = "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}",
                ExpectedOutput = "Hallo Welt!", RequiredKeywords = "System.out.println"
            },

            // JavaScript (Lesson 6)
            new ProgrammingTask
            {
                Id = 7, LessonId = 6, Order = 1, Title = "JS: Hallo Welt", Description = "Schreibe 'Hallo Welt!' in JavaScript.", Type = TaskType.Programming, Language = "javascript",
                InitialCode = "console.log();", ExpectedOutput = "Hallo Welt!", RequiredKeywords = "console.log"
            }
        );
    }
}

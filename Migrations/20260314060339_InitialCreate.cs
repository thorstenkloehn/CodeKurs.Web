using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Order = table.Column<int>(type: "INTEGER", nullable: false),
                    Language = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LessonId = table.Column<int>(type: "INTEGER", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Language = table.Column<string>(type: "TEXT", nullable: false),
                    InitialCode = table.Column<string>(type: "TEXT", nullable: false),
                    ExpectedOutput = table.Column<string>(type: "TEXT", nullable: false),
                    PlaceholderDependency = table.Column<string>(type: "TEXT", nullable: true),
                    ChoicesJson = table.Column<string>(type: "TEXT", nullable: true),
                    CorrectAnswer = table.Column<string>(type: "TEXT", nullable: true),
                    RequiredKeywords = table.Column<string>(type: "TEXT", nullable: true),
                    TestCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Progress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    TaskId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSubmittedCode = table.Column<string>(type: "TEXT", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Progress_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[,]
                {
                    { 1, "Lerne die Grundlagen von C#.", "csharp", 1, "C# Einführung" },
                    { 2, "If-Else und Logik.", "csharp", 2, "Kontrollstrukturen" },
                    { 3, "Wiederholungen in C#.", "csharp", 3, "Schleifen" },
                    { 4, "Logik in Klassen kapseln.", "csharp", 4, "Klassen & Methoden" },
                    { 5, "Lerne Java kennen.", "java", 5, "Java Einstieg" },
                    { 6, "Programmieren für das Web.", "javascript", 6, "JavaScript Einführung" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1, null, null, "C# ist eine moderne Programmiersprache von Microsoft.", "", "", "csharp", 1, 1, null, null, null, "Theorie: Was ist C#?", 0 },
                    { 2, null, null, "Schreibe 'Hallo Welt!' auf die Konsole.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code hier\n	}\n}", "csharp", 1, 2, null, "Console.WriteLine", null, "Hallo Welt (C#)", 1 },
                    { 3, null, null, "Erstelle 'alter' mit Wert 25.", "25", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code hier\n	}\n}", "csharp", 1, 3, null, "int,alter", null, "Variablen: int", 1 },
                    { 4, null, null, "Prüfe, ob 'zahl' (-5) positiv ist.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", "csharp", 2, 1, null, "if,else", null, "Logik: Positiv/Negativ", 1 },
                    { 5, null, null, "Berechne Summe 1-5.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", "csharp", 3, 1, null, "for", null, "For-Schleife: Summe", 1 },
                    { 6, null, null, "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", 5, 1, null, "System.out.println", null, "Java: Hallo Welt", 1 },
                    { 7, null, null, "Schreibe 'Hallo Welt!' in JavaScript.", "Hallo Welt!", "console.log();", "javascript", 6, 1, null, "console.log", null, "JS: Hallo Welt", 1 },
                    { 8, null, null, "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)', die die Summe zurückgibt.", "", "public class Calculator \n{\n    // Hier deine Methode\n}", "csharp", 4, 1, null, "class,Calculator,static,int", "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 },
                    { 9, null, null, "Erstelle eine Instanz der Klasse 'Person', setze den Namen auf 'Max' und gib das Objekt zurück.", "", "public class Person {\n    public string Name { get; set; }\n}\n\npublic class Program {\n    public static Person CreatePerson() {\n        // Erstelle hier eine neue Person und setze den Namen\n        return null;\n    }\n}", "csharp", 4, 2, null, "new,Person,Max", "public class TestRunner {\n    public static void Main() {\n        var p = Program.CreatePerson();\n        if(p != null && p.Name == \"Max\")\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Der Name ist nicht 'Max' oder das Objekt wurde nicht erstellt.\");\n    }\n}", "Edu: Objekte erstellen", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Progress_TaskId",
                table: "Progress",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_LessonId",
                table: "Tasks",
                column: "LessonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Progress");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Lessons");
        }
    }
}

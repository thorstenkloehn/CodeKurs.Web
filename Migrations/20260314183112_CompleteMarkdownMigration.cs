using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class CompleteMarkdownMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", "Java Einstieg" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[,]
                {
                    { 101, "<p>Lerne Entscheidungen im Code zu treffen.</p><p>In dieser Lektion lernst du <code>if</code> und <code>else</code> kennen.</p>\n", "csharp", 2, "Kontrollstrukturen" },
                    { 102, "<p>Objektorientierte Programmierung.</p><p>Alles in C# findet in Klassen statt.</p>\n", "csharp", 4, "Klassen & Methoden" },
                    { 103, "<p>Wiederhole Aufgaben effizient.</p><p>Schleifen helfen dir, Aufgaben mehrfach auszuführen.</p>\n", "csharp", 3, "Schleifen" },
                    { 104, "<p>Ein Einstieg in die Welt von C#.</p><p>In dieser Lektion lernst du die ersten Schritte in C#.</p>\n", "csharp", 1, "C# Grundlagen" },
                    { 105, "<p>Programmieren für das Web.</p><p>JavaScript erweckt Webseiten zum Leben.</p>\n", "javascript", 1, "JavaScript Einführung" }
                });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", "System.out.println", "Java: Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Title" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", "if", "Java: If-Else" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1002, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", "csharp", 101, 1, null, "if,else", null, "Logik: Positiv/Negativ", 1 },
                    { 1003, null, null, "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'.", "", "public class Calculator \n{\n    // Hier deine Methode\n}", "csharp", 102, 1, null, "class,Calculator,static,int", "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 },
                    { 1004, null, null, "Berechne die Summe der Zahlen 1 bis 5.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", "csharp", 103, 1, null, "for", null, "For-Schleife: Summe", 1 },
                    { 1005, null, null, "C# ist eine objektorientierte Sprache von Microsoft.", "", "", "csharp", 104, 1, null, null, null, "Was ist C#?", 0 },
                    { 1006, null, null, "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 104, 2, null, "Console.WriteLine", null, "Hallo Welt", 1 },
                    { 1007, null, null, "Schreibe 'Hallo Welt!' in JavaScript.", "Hallo Welt!", "console.log();", "javascript", 105, 1, null, "console.log", null, "JS: Hallo Welt", 1 },
                    { 1008, null, null, "Erstelle eine Funktion 'begruessung', die 'Hallo' zurückgibt.", "Hallo", "function begruessung() {\n    // Dein Code hier\n}\nconsole.log(begruessung());", "javascript", 105, 2, null, "function,return", null, "JS: Funktionen", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "Ein Einstieg in die Welt von C#.", "csharp", "C# Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "C# ist eine objektorientierte Sprache von Microsoft.", "", "", "csharp", null, "Was ist C#?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", "Console.WriteLine", "Hallo Welt" });
        }
    }
}

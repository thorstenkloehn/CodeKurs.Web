using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class MarkdownSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[] { 100, "Ein Einstieg in die Welt von C#.", "csharp", 1, "C# Grundlagen" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1000, null, null, "C# ist eine objektorientierte Sprache von Microsoft.", "", "", "csharp", 100, 1, null, null, null, "Was ist C#?", 0 },
                    { 1001, null, null, "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 100, 2, null, "Console.WriteLine", null, "Hallo Welt", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 100);

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
                    { 9, null, null, "Erstelle eine Instanz der Klasse 'Person', setze den Namen auf 'Max' und gib das Objekt zurück.", "", "public class Person {\n    public string Name { get; set; }\n}\n\npublic class Program {\n    public static Person CreatePerson() {\n        // Erstelle hier eine neue Person und setze den Namen\n        return null;\n    }\n}", "csharp", 4, 2, null, "new,Person,Max", "public class TestRunner {\n    public static void Main() {\n        var p = Program.CreatePerson();\n        if(p != null && p.Name == \"Max\")\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Der Name ist nicht 'Max' oder das Objekt wurde nicht erstellt.\");\n    }\n}", "Edu: Objekte erstellen", 3 },
                    { 10, null, null, "Erstelle eine Variable 'name' vom Typ string mit dem Wert 'C# Profi' und gib sie aus.", "C# Profi", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code hier\n	}\n}", "csharp", 1, 4, null, "string,name", null, "Variablen: string", 1 },
                    { 11, null, null, "Erstelle eine Variable 'preis' vom Typ double mit dem Wert 9.99 und gib sie aus.", "9.99", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code hier\n	}\n}", "csharp", 1, 5, null, "double,preis", null, "Variablen: double", 1 },
                    { 12, null, null, "Erstelle ein int-Array 'zahlen' mit den Werten 1, 2, 3 und gib das erste Element aus.", "1", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code hier\n	}\n}", "csharp", 1, 6, null, "int[],zahlen", null, "Arrays: Einführung", 1 },
                    { 13, null, null, "Prüfe, ob die Variable 'x' (10) größer als 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 5, 2, null, "if", null, "Java: If-Else", 1 },
                    { 14, null, null, "Erstelle eine Funktion 'begruessung', die 'Hallo' zurückgibt und rufe sie in console.log auf.", "Hallo", "function begruessung() {\n    // Dein Code hier\n}\nconsole.log(begruessung());", "javascript", 6, 2, null, "function,return", null, "JS: Funktionen", 1 }
                });
        }
    }
}

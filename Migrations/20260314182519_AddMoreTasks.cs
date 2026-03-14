using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 12, null, null, "Erstelle ein int-Array 'zahlen' mit den Werten 1, 2, 3 und gib das erste Element aus.", "1", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code hier\n	}\n}", "csharp", 1, 6, null, "int[],zahlen", null, "Arrays: Einführung", 1 },
                    { 13, null, null, "Prüfe, ob die Variable 'x' (10) größer als 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 5, 2, null, "if", null, "Java: If-Else", 1 },
                    { 14, null, null, "Erstelle eine Funktion 'begruessung', die 'Hallo' zurückgibt und rufe sie in console.log auf.", "Hallo", "function begruessung() {\n    // Dein Code hier\n}\nconsole.log(begruessung());", "javascript", 6, 2, null, "function,return", null, "JS: Funktionen", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreCSharpDataTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 10, null, null, "Erstelle eine Variable 'name' vom Typ string mit dem Wert 'C# Profi' und gib sie aus.", "C# Profi", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code hier\n	}\n}", "csharp", 1, 4, null, "string,name", null, "Variablen: string", 1 },
                    { 11, null, null, "Erstelle eine Variable 'preis' vom Typ double mit dem Wert 9.99 und gib sie aus.", "9.99", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code hier\n	}\n}", "csharp", 1, 5, null, "double,preis", null, "Variablen: double", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}

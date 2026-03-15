using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class FixQuizSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "ChoicesJson", "CorrectAnswer" },
                values: new object[] { "[\"Damit sie schneller geladen wird\", \"Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen\", \"Um anzuzeigen, dass es ein String ist\", \"Das mut ist optional\"]", "Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "ChoicesJson", "CorrectAnswer" },
                values: new object[] { null, null });
        }
    }
}

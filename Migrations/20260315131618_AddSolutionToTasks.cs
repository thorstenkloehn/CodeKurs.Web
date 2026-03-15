using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddSolutionToTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Solution",
                table: "Tasks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1000,
                column: "Solution",
                value: "console.log(\"Hallo Welt!\");");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Solution",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Solution",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1003,
                column: "Solution",
                value: "package main\n\nimport \"fmt\"\n\nfunc main() {\n    fmt.Println(\"Hallo Welt!\")\n}\n");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1004,
                column: "Solution",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1005,
                column: "Solution",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1006,
                column: "Solution",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1007,
                column: "Solution",
                value: "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		Console.WriteLine(\"Hallo Welt!\");\n	}\n}");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1008,
                column: "Solution",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1009,
                column: "Solution",
                value: "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Solution",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Solution",
                table: "Tasks");
        }
    }
}

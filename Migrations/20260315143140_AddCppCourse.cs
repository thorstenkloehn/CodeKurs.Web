using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddCppCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", "cpp", "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die serverseitige Programmierung mit PHP.</p><p>In dieser Lektion lernst du die Grundlagen von PHP kennen. PHP-Code wird auf dem Server ausgeführt und das Ergebnis wird als HTML an den Browser gesendet.</p>\n", "php", "PHP Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", "c", "C Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", "Python Grundlagen" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[] { 111, "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", 1, "Java Einstieg" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "cpp", "Was ist C++?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "InitialCode", "Language", "RequiredKeywords", "Solution" },
                values: new object[] { "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "cpp", "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "php", "Was ist PHP?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "InitialCode", "Language", "RequiredKeywords", "Solution" },
                values: new object[] { "<?php\n// Dein Code hier\n", "php", "echo", "<?php\necho \"Hallo Welt!\";\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "c", "Was ist C?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "InitialCode", "Language", "RequiredKeywords", "Solution" },
                values: new object[] { "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", "print", "print(\"Hallo Welt!\")\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", 111, 1, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", null, "Java: Hallo Welt", 1 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1020, null, null, "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 111, 2, null, "if", null, null, "Java: If-Else", 1 },
                    { 1021, null, null, "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 111, 3, null, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die serverseitige Programmierung mit PHP.</p><p>In dieser Lektion lernst du die Grundlagen von PHP kennen. PHP-Code wird auf dem Server ausgeführt und das Ergebnis wird als HTML an den Browser gesendet.</p>\n", "php", "PHP Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", "c", "C Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", "Python Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", "Java Einstieg" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "php", "Was ist PHP?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "InitialCode", "Language", "RequiredKeywords", "Solution" },
                values: new object[] { "<?php\n// Dein Code hier\n", "php", "echo", "<?php\necho \"Hallo Welt!\";\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "c", "Was ist C?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "InitialCode", "Language", "RequiredKeywords", "Solution" },
                values: new object[] { "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "python", "Was ist Python?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "InitialCode", "Language", "RequiredKeywords", "Solution" },
                values: new object[] { "# Dein Code hier\n", "python", "print", "print(\"Hallo Welt!\")\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", "Java: Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", "if", null, "Java: If-Else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", 110, 3, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 });
        }
    }
}

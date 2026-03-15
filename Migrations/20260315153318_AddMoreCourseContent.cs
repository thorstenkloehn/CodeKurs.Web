using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreCourseContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "JavaScript: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Programmieren für das Web.</p><p>JavaScript erweckt Webseiten zum Leben.</p>\n", "javascript", "JavaScript Einführung" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "go", "Go: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Go (Golang).</p><p>In dieser Lektion lernst du die ersten Schritte in Go. Go ist bekannt für seine starke Unterstützung von Nebenläufigkeit und seine schnelle Kompilierung.</p>\n", "go", 1, "Go Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne Entscheidungen im Code zu treffen.</p><p>In dieser Lektion lernst du <code>if</code> und <code>else</code> kennen.</p>\n", 2, "Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben effizient.</p><p>Schleifen helfen dir, Aufgaben mehrfach auszuführen.</p>\n", 3, "Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von C#.</p><p>In dieser Lektion lernst du die ersten Schritte in C#.</p>\n", "csharp", 1, "C# Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Objektorientierte Programmierung.</p><p>Alles in C# findet in Klassen statt.</p>\n", "csharp", 4, "Klassen & Methoden" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen und Code wiederholen.</p><p>Kontrollstrukturen sind das Herzstück jeder Programmiersprache. In Rust gibt es neben <code>if</code> und <code>else</code> auch mächtige Schleifen-Konstrukte wie <code>loop</code>, <code>while</code> und <code>for</code>.</p>\n", "rust", 3, "Rust: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Wie liest man Daten von der Tastatur in Rust ein?</p><p>Rust legt großen Wert auf Sicherheit. Daher ist die Standardeingabe etwas ausführlicher als in anderen Sprachen. Das Modul <code>std::io</code> bietet Zugriff auf die Funktionen, um von der Tastatur zu lesen.</p>\n", "rust", 2, "Rust: Ein- und Ausgabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Rust - Sicher, schnell und modern.</p><p>In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.</p>\n", "rust", "Rust Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "cpp", 2, "C++: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", "cpp", "C++ Grundlagen" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[,]
                {
                    { 113, "<p>Entscheidungen treffen mit if und else.</p>", "php", 2, "PHP: Kontrollstrukturen" },
                    { 114, "<p>Ein Einstieg in die serverseitige Programmierung mit PHP.</p><p>In dieser Lektion lernst du die Grundlagen von PHP kennen. PHP-Code wird auf dem Server ausgeführt und das Ergebnis wird als HTML an den Browser gesendet.</p>\n", "php", 1, "PHP Grundlagen" },
                    { 115, "<p>Entscheidungen treffen mit if und else.</p>", "c", 2, "C: Kontrollstrukturen" },
                    { 116, "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", "c", 1, "C Grundlagen" },
                    { 117, "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", "python", 2, "Python: Kontrollstrukturen" },
                    { 118, "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", 1, "Python Grundlagen" },
                    { 119, "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", 1, "Java Einstieg" },
                    { 120, "<p>Entscheidungen treffen mit if und else.</p>", "java", 2, "Java: Kontrollstrukturen" }
                });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "let zahl = -5;\n// Dein Code hier\n", "if,else", "let zahl = -5;\nif (zahl > 0) {\n    console.log(\"Positiv\");\n} else {\n    console.log(\"Negativ\");\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in JavaScript.", "Hallo Welt!", "console.log();", 101, 1, "console.log", "console.log(\"Hallo Welt!\");", "JS: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Erstelle eine Funktion 'begruessung', die 'Hallo' zurückgibt.", "Hallo", "function begruessung() {\n    // Dein Code hier\n}\nconsole.log(begruessung());", "javascript", 2, "function,return", "JS: Funktionen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    // Dein Code hier\n}\n", 102, 1, "if,else", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    if zahl > 0 {\n        fmt.Print(\"Positiv\")\n    } else {\n        fmt.Print(\"Negativ\")\n    }\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Go ist eine bei Google entwickelte Open-Source-Programmiersprache, die sich durch Effizienz und Einfachheit auszeichnet.", "", "", "go", 103, null, "Was ist Go?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}\n", "go", 2, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    fmt.Println(\"Hallo Welt!\")\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", "if,else", "Logik: Positiv/Negativ", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Berechne die Summe der Zahlen 1 bis 5.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", 105, 1, "for", null, "For-Schleife: Summe" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "Description", "InitialCode", "LessonId", "RequiredKeywords", "TestCode", "Title", "Type" },
                values: new object[] { "C# ist eine objektorientierte Sprache von Microsoft.", "", 106, null, null, "Was ist C#?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { null, null, "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 2, "Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		Console.WriteLine(\"Hallo Welt!\");\n	}\n}", "Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'.", "", "public class Calculator \n{\n    // Hier deine Methode\n}", "csharp", 107, 1, "class,Calculator,static,int", null, "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Zahl `x` größer als 10 ist. Gib 'Groß' aus, ansonsten 'Klein'.", "Groß", "fn main() {\n    let x = 15;\n    // Dein Code hier\n}\n", 108, 1, "if,else", "fn main() {\n    let x = 15;\n    if x > 10 {\n        println!(\"Groß\");\n    } else {\n        println!(\"Klein\");\n    }\n}\n", "Einfaches if/else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Rust hat eine endlose Schleife namens `loop`. Nutze `break`, um sie zu verlassen, wenn `i` den Wert 5 erreicht hat. Gib `i` in jedem Durchgang aus.", "0\n1\n2\n3\n4\n5", "fn main() {\n    let mut i = 0;\n    loop {\n        // Dein Code hier\n        i += 1;\n    }\n}\n", 108, 2, "loop,break", "fn main() {\n    let mut i = 0;\n    loop {\n        println!(\"{}\", i);\n        if i == 5 {\n            break;\n        }\n        i += 1;\n    }\n}\n", "Die `loop` Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine `while` Schleife, um die Zahlen von 3 bis 1 (herunterzählend) auszugeben.", "3\n2\n1", "fn main() {\n    let mut n = 3;\n    // Dein Code hier\n}\n", 108, 3, "while", "fn main() {\n    let mut n = 3;\n    while n > 0 {\n        println!(\"{}\", n);\n        n -= 1;\n    }\n}\n", "While Schleife", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "[\"Damit sie schneller geladen wird\", \"Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen\", \"Um anzuzeigen, dass es ein String ist\", \"Das mut ist optional\"]", "Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen", "Warum muss die Variable für die Eingabe mit `mut` deklariert werden (z.B. `let mut input`)?", "", "", 109, 1, null, null, "Anatomie der Eingabe", 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "In Rust nutzt man `std::io::stdin()`, um Eingaben einzulesen. <br>Lies einen Namen von der Tastatur ein und gib 'Hallo [Name]!' aus. <br>Hinweis: Tippe in das Eingabefeld rechts das Wort 'Rust' ein, bevor du auf Ausführen klickst.", "Hallo Rust!", "use std::io;\n\nfn main() {\n    let mut input = String::new(); // Erstellt einen Puffer\n    \n    // Deine Aufgabe: Nutze io::stdin().read_line(&mut input).unwrap();\n    \n    println!(\"Hallo {}!\", input.trim());\n}\n", "rust", 109, 2, "read_line", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    println!(\"Hallo {}!\", input.trim());\n}\n", "Einen String einlesen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies eine Zahl von der Tastatur ein, verdopple sie und gib das Ergebnis aus. <br>Hinweis: Nutze `.trim().parse::<i32>().unwrap()`, um den String in eine Zahl zu wandeln. <br>Tippe die Zahl '21' in das Eingabefeld.", "Ergebnis: 42", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    // Deine Aufgabe: Wandle 'input' in eine Zahl 'n' um\n    // let n: i32 = ...\n    \n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "rust", 109, "parse", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let n: i32 = input.trim().parse().unwrap();\n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "Zahl einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lies zwei Zahlen nacheinander ein und gib deren Summe aus. <br>Wichtig: Das Eingabefeld unterstützt aktuell nur eine Zeile. Trenne deine beiden Zahlen im Eingabefeld mit einem Leerzeichen (z.B. '10 5').", "Summe: 15", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    \n    println!(\"Summe: {}\", a + b);\n}\n", "rust", 3, "split_whitespace", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    println!(\"Summe: {}\", a + b);\n}\n", "Zwei Zahlen addieren", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", "rust", 110, 1, null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", "rust", 2, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 111, 1, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "cpp", 112, "Was ist C++?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution" },
                values: new object[] { "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 112, "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable '$zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "<?php\n$zahl = -5;\n// Dein Code hier\n?>\n", "php", 113, "if,else", "<?php\n$zahl = -5;\nif ($zahl > 0) {\n    echo \"Positiv\";\n} else {\n    echo \"Negativ\";\n}\n?>\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "", "", "php", 114, 1, null, "Was ist PHP?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "<?php\n// Dein Code hier\n", "php", 114, 2, "echo", "<?php\necho \"Hallo Welt!\";\n", null, "Hallo Welt", 1 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1026, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", 115, 1, null, "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", null, "Logik: Positiv/Negativ", 1 },
                    { 1027, null, null, "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", "c", 116, 1, null, null, null, null, "Was ist C?", 0 },
                    { 1028, null, null, "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 116, 2, null, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", null, "Hallo Welt", 1 },
                    { 1029, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", 117, 1, null, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", null, "Logik: Positiv/Negativ", 1 },
                    { 1030, null, null, "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", 117, 2, null, "for,in,range", "for i in range(1, 4):\n    print(i)\n", null, "Zahlen von 1 bis 3 ausgeben", 1 },
                    { 1031, null, null, "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", 118, 1, null, null, null, null, "Was ist Python?", 0 },
                    { 1032, null, null, "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", 118, 2, null, "print", "print(\"Hallo Welt!\")\n", null, "Hallo Welt", 1 },
                    { 1033, null, null, "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", 119, 1, null, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", null, "Java: Hallo Welt", 1 },
                    { 1034, null, null, "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 119, 2, null, "if", null, null, "Java: If-Else", 1 },
                    { 1035, null, null, "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 119, 3, null, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 },
                    { 1036, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 120, 1, null, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", null, "Logik: Positiv/Negativ", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Programmieren für das Web.</p><p>JavaScript erweckt Webseiten zum Leben.</p>\n", 1, "JavaScript Einführung" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Go (Golang).</p><p>In dieser Lektion lernst du die ersten Schritte in Go. Go ist bekannt für seine starke Unterstützung von Nebenläufigkeit und seine schnelle Kompilierung.</p>\n", "go", "Go Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne Entscheidungen im Code zu treffen.</p><p>In dieser Lektion lernst du <code>if</code> und <code>else</code> kennen.</p>\n", "csharp", "Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben effizient.</p><p>Schleifen helfen dir, Aufgaben mehrfach auszuführen.</p>\n", "csharp", 3, "Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von C#.</p><p>In dieser Lektion lernst du die ersten Schritte in C#.</p>\n", 1, "C# Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Objektorientierte Programmierung.</p><p>Alles in C# findet in Klassen statt.</p>\n", 4, "Klassen & Methoden" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Wie liest man Daten von der Tastatur in Rust ein?</p><p>Rust legt großen Wert auf Sicherheit. Daher ist die Standardeingabe etwas ausführlicher als in anderen Sprachen. Das Modul <code>std::io</code> bietet Zugriff auf die Funktionen, um von der Tastatur zu lesen.</p>\n", "rust", 2, "Rust: Ein- und Ausgabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Rust - Sicher, schnell und modern.</p><p>In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.</p>\n", "rust", 1, "Rust Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", "cpp", 1, "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die serverseitige Programmierung mit PHP.</p><p>In dieser Lektion lernst du die Grundlagen von PHP kennen. PHP-Code wird auf dem Server ausgeführt und das Ergebnis wird als HTML an den Browser gesendet.</p>\n", "php", 1, "PHP Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", "c", "C Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", 1, "Python Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", "Java Einstieg" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in JavaScript.", "Hallo Welt!", "console.log();", "console.log", "console.log(\"Hallo Welt!\");", "JS: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine Funktion 'begruessung', die 'Hallo' zurückgibt.", "Hallo", "function begruessung() {\n    // Dein Code hier\n}\nconsole.log(begruessung());", 100, 2, "function,return", null, "JS: Funktionen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Go ist eine bei Google entwickelte Open-Source-Programmiersprache, die sich durch Effizienz und Einfachheit auszeichnet.", "", "", "go", 1, null, "Was ist Go?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}\n", 101, 2, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    fmt.Println(\"Hallo Welt!\")\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", "csharp", 102, "if,else", "Logik: Positiv/Negativ", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Berechne die Summe der Zahlen 1 bis 5.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", "csharp", 1, "for", null, "For-Schleife: Summe" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "C# ist eine objektorientierte Sprache von Microsoft.", "", "", null, "Was ist C#?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", 104, 2, "Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		Console.WriteLine(\"Hallo Welt!\");\n	}\n}", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "Description", "InitialCode", "LessonId", "RequiredKeywords", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'.", "public class Calculator \n{\n    // Hier deine Methode\n}", 105, "class,Calculator,static,int", "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "[\"Damit sie schneller geladen wird\", \"Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen\", \"Um anzuzeigen, dass es ein String ist\", \"Das mut ist optional\"]", "Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen", "Warum muss die Variable für die Eingabe mit `mut` deklariert werden (z.B. `let mut input`)?", "", "", "rust", 1, null, null, "Anatomie der Eingabe", 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "In Rust nutzt man `std::io::stdin()`, um Eingaben einzulesen. <br>Lies einen Namen von der Tastatur ein und gib 'Hallo [Name]!' aus. <br>Hinweis: Tippe in das Eingabefeld rechts das Wort 'Rust' ein, bevor du auf Ausführen klickst.", "Hallo Rust!", "use std::io;\n\nfn main() {\n    let mut input = String::new(); // Erstellt einen Puffer\n    \n    // Deine Aufgabe: Nutze io::stdin().read_line(&mut input).unwrap();\n    \n    println!(\"Hallo {}!\", input.trim());\n}\n", "rust", 106, 2, "read_line", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    println!(\"Hallo {}!\", input.trim());\n}\n", null, "Einen String einlesen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies eine Zahl von der Tastatur ein, verdopple sie und gib das Ergebnis aus. <br>Hinweis: Nutze `.trim().parse::<i32>().unwrap()`, um den String in eine Zahl zu wandeln. <br>Tippe die Zahl '21' in das Eingabefeld.", "Ergebnis: 42", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    // Deine Aufgabe: Wandle 'input' in eine Zahl 'n' um\n    // let n: i32 = ...\n    \n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", 106, 2, "parse", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let n: i32 = input.trim().parse().unwrap();\n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "Zahl einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies zwei Zahlen nacheinander ein und gib deren Summe aus. <br>Wichtig: Das Eingabefeld unterstützt aktuell nur eine Zeile. Trenne deine beiden Zahlen im Eingabefeld mit einem Leerzeichen (z.B. '10 5').", "Summe: 15", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    \n    println!(\"Summe: {}\", a + b);\n}\n", 106, 3, "split_whitespace", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    println!(\"Summe: {}\", a + b);\n}\n", "Zwei Zahlen addieren" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", 107, 1, null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { null, null, "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", 107, 2, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "", "", "cpp", 108, 1, null, null, "Was ist C++?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 108, "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "", "", "php", 1, null, null, "Was ist PHP?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "<?php\n// Dein Code hier\n", "php", 109, 2, "echo", "<?php\necho \"Hallo Welt!\";\n", "Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", "c", 1, null, null, "Was ist C?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 110, 2, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "python", 111, "Was ist Python?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution" },
                values: new object[] { "# Dein Code hier\n", "python", 111, "print", "print(\"Hallo Welt!\")\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", 112, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", "Java: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 112, 2, "if", "Java: If-Else", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 112, 3, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 });
        }
    }
}

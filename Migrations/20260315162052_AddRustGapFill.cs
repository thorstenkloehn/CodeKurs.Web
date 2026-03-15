using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddRustGapFill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Übe die Syntax für Benutzereingaben in Rust, indem du die Lücken füllst.</p><p>In Rust ist das Einlesen von der Konsole explizit. Du brauchst:</p>\n<ol>\n<li>Einen <strong>veränderbaren String</strong> (<code>let mut input = String::new()</code>).</li>\n<li>Den Aufruf von <strong><code>io::stdin().read_line()</code></strong>.</li>\n<li>Eine <strong>veränderbare Referenz</strong> auf deinen String (<code>&amp;mut input</code>).</li>\n<li>Eine Fehlerbehandlung wie <strong><code>.unwrap()</code></strong> oder <code>.expect()</code>.</li>\n</ol>\n", 5, "Rust: Lückentext Eingabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Rust - Sicher, schnell und modern.</p><p>In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.</p>\n", "rust", 1, "Rust Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C++ arbeitest.</p><p>C++ ist eine objektorientierte Erweiterung von C und bietet komfortable Typen wie <code>std::string</code>.</p>\n", 3, "Variablen in C++" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "C++: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", "cpp", 1, "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in PHP arbeitest.</p><p>PHP ist eine schwach typisierte Sprache. Variablen werden mit einem Dollarzeichen ($) eingeleitet.</p>\n", 3, "Variablen in PHP" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "PHP: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die serverseitige Programmierung mit PHP.</p><p>In dieser Lektion lernst du die Grundlagen von PHP kennen. PHP-Code wird auf dem Server ausgeführt und das Ergebnis wird als HTML an den Browser gesendet.</p>\n", "php", 1, "PHP Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C arbeitest.</p><p>In C musst du Datentypen explizit angeben. Für Booleans musst du <code>&lt;stdbool.h&gt;</code> einbinden.</p>\n", 3, "Variablen in C" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "C: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", "c", 1, "C Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Python arbeitest.</p><p>In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.</p>\n", 4, "Variablen in Python" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", 2, "Python: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Code-Blöcke wiederholst.</p><p>Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet <code>for</code> für bekannte Iterationen und <code>while</code> für bedingte Wiederholungen.</p>\n", 3, "Python: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", 1, "Python Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", 4, "Variablen in Java" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", 1, "Java Einstieg" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "Java: Kontrollstrukturen" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[] { 133, "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", "java", 3, "Java: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Vervollständige die Zeile, um einen neuen, leeren String-Puffer zu erstellen. <br>Nutze `String::new()`.", "Puffer bereit.", "fn main() {\n    // Vervollständige: let mut input = ...\n    let mut input = ___________;\n    \n    println!(\"Puffer bereit.\");\n}\n", "String::new", "fn main() {\n    let mut input = String::new();\n    println!(\"Puffer bereit.\");\n}\n", "Lücke: Den Puffer erstellen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`.", "Bitte etwas tippen:\nGelesen!", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    \n    // Lücke: io::stdin().read_line(____ buffer).unwrap();\n    io::stdin().read_line(____ buffer).unwrap();\n    \n    println!(\"Gelesen!\");\n}\n", "&mut", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    io::stdin().read_line(&mut buffer).unwrap();\n    println!(\"Gelesen!\");\n}\n", "Lücke: Die Referenz" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`.", "", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    \n    // Lücke: ____::stdin().read_line(&mut input).unwrap();\n    ____::stdin().read_line(&mut input).unwrap();\n}\n", "rust", 115, 3, "io::stdin", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n}\n", "Lücke: Das Modul aufrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe die komplette Zeile, um eine Eingabe in die Variable `text` einzulesen. <br>Vergiss das `.unwrap()` am Ende nicht!", "Eingabe erfolgt.", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    \n    // Schreibe hier die komplette read_line Zeile:\n    \n    println!(\"Eingabe erfolgt.\");\n}\n", "rust", 115, 4, "read_line,&mut,unwrap", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    io::stdin().read_line(&mut text).unwrap();\n    println!(\"Eingabe erfolgt.\");\n}\n", "Lücke: Alles zusammen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", "rust", 1, null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", "rust", 2, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus.", "15", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "int,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 117, 2, "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'string', um zwei Texte zu verknüpfen.", "Hallo Welt", "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 117, 3, "string,cout", "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "#include <iostream>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "cpp", 117, 4, "bool,if,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        cout << \"Wahr\";\n    } else {\n        cout << \"Falsch\";\n    }\n    return 0;\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 118, 1, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "", "", "cpp", 1, null, null, "Was ist C++?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 2, "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In PHP beginnen Variablen mit einem $. Addiere zwei Zahlen und gib das Ergebnis mit echo aus.", "15", "<?php\n// Dein Code", "echo,$", "<?php\n$a = 10;\n$b = 5;\necho $a + $b;", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Multipliziere zwei Gleitkommazahlen und gib das Ergebnis aus.", "12.5", "<?php\n// Dein Code", 120, 2, "echo", "<?php\n$a = 2.5;\n$b = 5.0;\necho $a * $b;", "Gleitkommazahlen (Float)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings werden in PHP mit dem Punkt (.) verknüpft.", "Hallo Welt", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\n// Dein Code", 120, 3, "echo,.", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\necho $s1 . $s2;", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "<?php\n$isActive = true;\n// Dein Code", "php", 120, 4, "if,echo", "<?php\n$isActive = true;\nif ($isActive) {\n    echo \"Wahr\";\n} else {\n    echo \"Falsch\";\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable '$zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "<?php\n$zahl = -5;\n// Dein Code hier\n?>\n", "php", 121, 1, "if,else", "<?php\n$zahl = -5;\nif ($zahl > 0) {\n    echo \"Positiv\";\n} else {\n    echo \"Negativ\";\n}\n?>\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "", "", "php", 1, null, null, "Was ist PHP?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "<?php\n// Dein Code hier\n", "php", 2, "echo", "<?php\necho \"Hallo Welt!\";\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "15", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 123, 2, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "Hallo Welt", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 123, 3, "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "Wahr", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "c", 123, 4, "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", 124, 1, "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", "c", 1, null, null, "Was ist C?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 2, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "# Dein Code hier", "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "Hallo Welt", "# Dein Code hier", 126, 3, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "Wahr", "is_active = True\n# Dein Code", 126, 4, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", 127, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", "Logik: Positiv/Negativ", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", 127, "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", "python", 128, "for,in,range", "for i in range(1, 6):\n    print(i)\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", "python", 128, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", 1, null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", 2, "print", "print(\"Hallo Welt!\")\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", null, "Zeichenketten (String)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", 130, 4, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", "Booleans (boolean)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", 131, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", "Java: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", 131, "if", null, "Java: If-Else" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1079, null, null, "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 131, 3, null, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 },
                    { 1080, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 132, 1, null, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", null, "Logik: Positiv/Negativ", 1 },
                    { 1081, null, null, "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", "java", 133, 1, null, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", null, "Zahlen 1 bis 5", 1 },
                    { 1082, null, null, "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", "java", 133, 2, null, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", null, "Summe bis 10", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Rust - Sicher, schnell und modern.</p><p>In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.</p>\n", 1, "Rust Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C++ arbeitest.</p><p>C++ ist eine objektorientierte Erweiterung von C und bietet komfortable Typen wie <code>std::string</code>.</p>\n", "cpp", 3, "Variablen in C++" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "C++: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", 1, "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in PHP arbeitest.</p><p>PHP ist eine schwach typisierte Sprache. Variablen werden mit einem Dollarzeichen ($) eingeleitet.</p>\n", "php", 3, "Variablen in PHP" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "PHP: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die serverseitige Programmierung mit PHP.</p><p>In dieser Lektion lernst du die Grundlagen von PHP kennen. PHP-Code wird auf dem Server ausgeführt und das Ergebnis wird als HTML an den Browser gesendet.</p>\n", 1, "PHP Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C arbeitest.</p><p>In C musst du Datentypen explizit angeben. Für Booleans musst du <code>&lt;stdbool.h&gt;</code> einbinden.</p>\n", "c", 3, "Variablen in C" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "C: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", 1, "C Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Python arbeitest.</p><p>In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.</p>\n", "python", 4, "Variablen in Python" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", 2, "Python: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Code-Blöcke wiederholst.</p><p>Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet <code>for</code> für bekannte Iterationen und <code>while</code> für bedingte Wiederholungen.</p>\n", 3, "Python: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", 1, "Python Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", "java", 4, "Variablen in Java" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", 1, "Java Einstieg" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "Java: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", 3, "Java: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus.", "15", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 116, 1, "int,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 116, 2, "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verwende den Typ 'string', um zwei Texte zu verknüpfen.", "Hallo Welt", "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 3, "string,cout", "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}", "Zeichenketten (string)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "#include <iostream>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "cpp", 4, "bool,if,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        cout << \"Wahr\";\n    } else {\n        cout << \"Falsch\";\n    }\n    return 0;\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "", "", 118, 1, null, null, "Was ist C++?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", 118, 2, "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In PHP beginnen Variablen mit einem $. Addiere zwei Zahlen und gib das Ergebnis mit echo aus.", "15", "<?php\n// Dein Code", "php", 119, 1, "echo,$", "<?php\n$a = 10;\n$b = 5;\necho $a + $b;", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Multipliziere zwei Gleitkommazahlen und gib das Ergebnis aus.", "12.5", "<?php\n// Dein Code", "php", 119, 2, "echo", "<?php\n$a = 2.5;\n$b = 5.0;\necho $a * $b;", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Strings werden in PHP mit dem Punkt (.) verknüpft.", "Hallo Welt", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\n// Dein Code", "php", 3, "echo,.", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\necho $s1 . $s2;", "Zeichenketten (String)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "<?php\n$isActive = true;\n// Dein Code", "php", 4, "if,echo", "<?php\n$isActive = true;\nif ($isActive) {\n    echo \"Wahr\";\n} else {\n    echo \"Falsch\";\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable '$zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "<?php\n$zahl = -5;\n// Dein Code hier\n?>\n", "if,else", "<?php\n$zahl = -5;\nif ($zahl > 0) {\n    echo \"Positiv\";\n} else {\n    echo \"Negativ\";\n}\n?>\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "", "", 121, 1, null, null, "Was ist PHP?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "<?php\n// Dein Code hier\n", 121, 2, "echo", "<?php\necho \"Hallo Welt!\";\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "15", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 122, 1, "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 122, 2, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "Hallo Welt", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 3, "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "Wahr", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "c", 4, "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", 124, 1, null, null, "Was ist C?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", 124, 2, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "# Dein Code hier", "python", 125, 1, "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "python", 125, 2, "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "Hallo Welt", "# Dein Code hier", "python", 3, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", "Zeichenketten (String)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "Wahr", "is_active = True\n# Dein Code", "python", 4, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", 127, 1, "for,in,range", "for i in range(1, 6):\n    print(i)\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", 127, 2, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", 128, null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", 128, "print", "print(\"Hallo Welt!\")\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 129, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 129, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 3, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", "Zeichenketten (String)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", "java", 4, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", "Booleans (boolean)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", "Java: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "if", null, "Java: If-Else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", 131, 1, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", 132, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", 132, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", "Summe bis 10" });
        }
    }
}

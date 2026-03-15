using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddCallByValueReferencePointerLessons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie JavaScript mit Werten und Objekten umgeht.</p><p>JavaScript nutzt ein Modell, das oft als <strong>Call-by-Sharing</strong> bezeichnet wird.</p>\n<ol>\n<li><strong>Primitive Typen (<code>number</code>, <code>string</code>, <code>boolean</code>)</strong>: Diese werden per Wert (<strong>Call by Value</strong>) übergeben. Die Funktion erhält eine echte Kopie.</li>\n<li><strong>Objekte und Arrays</strong>: Hier wird eine Referenz auf das Objekt übergeben. Du kannst den Inhalt des Objekts ändern, aber du kannst die Variable selbst nicht in der Funktion auf ein neues Objekt umbiegen.</li>\n</ol>\n", 5, "JavaScript: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "JavaScript: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben mit for und while.</p><p>In JavaScript sind Schleifen ein wichtiges Werkzeug, um Arrays zu durchlaufen oder wiederkehrende Aufgaben zu automatisieren.</p>\n", 3, "JavaScript: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Programmieren für das Web.</p><p>JavaScript erweckt Webseiten zum Leben.</p>\n", "javascript", 1, "JavaScript Einführung" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Go arbeitest.</p><p>In Go kannst du Variablen mit <code>var</code> oder der Kurzschreibweise <code>:=</code> deklarieren.</p>\n", 3, "Variablen in Go" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "Go: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Go (Golang).</p><p>In dieser Lektion lernst du die ersten Schritte in Go. Go ist bekannt für seine starke Unterstützung von Nebenläufigkeit und seine schnelle Kompilierung.</p>\n", "go", 1, "Go Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Verstehe den Unterschied zwischen Werten und Pointern in Go.</p><p>Go ist eine &quot;Call by Value&quot; Sprache. Das bedeutet, es wird immer eine Kopie übergeben.</p>\n<ol>\n<li><strong>Werte übergeben</strong>: Die Funktion erhält eine Kopie des Wertes.</li>\n<li><strong>Pointer übergeben</strong>: Die Funktion erhält eine Kopie der Speicheradresse. Da sie die Adresse kennt, kann sie den Wert an dieser Stelle im Speicher verändern. Dies wird oft als &quot;Call by Reference&quot;-Verhalten bezeichnet, technisch gesehen ist es aber die Übergabe eines Pointer-Wertes.</li>\n</ol>\n", "go", 4, "Go: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C# arbeitest.</p><p>Variablen sind Container zum Speichern von Datenwerten. In C# musst du den Datentyp einer Variable angeben.</p>\n", 5, "Variablen in C#" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne Entscheidungen im Code zu treffen.</p><p>In dieser Lektion lernst du <code>if</code> und <code>else</code> kennen.</p>\n", 2, "Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben effizient.</p><p>Schleifen helfen dir, Aufgaben mehrfach auszuführen.</p>\n", 3, "Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von C#.</p><p>In dieser Lektion lernst du die ersten Schritte in C#.</p>\n", "csharp", 1, "C# Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Einsatz von ref und out für Call by Reference in C#.</p><p>In C# werden Werttypen (wie <code>int</code>, <code>bool</code>) standardmäßig per <strong>Call by Value</strong> übergeben.</p>\n<ol>\n<li><strong>ref</strong>: Übergibt eine Referenz auf eine Variable. Die Variable muss vor der Übergabe initialisiert sein.</li>\n<li><strong>out</strong>: Übergibt eine Referenz, aber die Variable muss nicht initialisiert sein. Die Methode <strong>muss</strong> der <code>out</code>-Variable jedoch einen Wert zuweisen.</li>\n<li><strong>Pointer</strong>: C# unterstützt Pointer nur in <code>unsafe</code> Codeblöcken, was für allgemeine Anwendungen selten genutzt wird.</li>\n</ol>\n", "csharp", 6, "C#: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Objektorientierte Programmierung.</p><p>Alles in C# findet in Klassen statt.</p>\n", "csharp", 4, "Klassen & Methoden" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen und Code wiederholen.</p><p>Kontrollstrukturen sind das Herzstück jeder Programmiersprache. In Rust gibt es neben <code>if</code> und <code>else</code> auch mächtige Schleifen-Konstrukte wie <code>loop</code>, <code>while</code> und <code>for</code>.</p>\n", 3, "Rust: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Rust arbeitest.</p><p>In Rust sind Variablen standardmäßig unveränderlich (immutable). Mit <code>let mut</code> kannst du sie veränderbar machen.</p>\n", 4, "Variablen in Rust" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Wie liest man Daten von der Tastatur in Rust ein?</p><p>Rust legt großen Wert auf Sicherheit. Daher ist die Standardeingabe etwas ausführlicher als in anderen Sprachen. Das Modul <code>std::io</code> bietet Zugriff auf die Funktionen, um von der Tastatur zu lesen.</p>\n", "rust", 2, "Rust: Ein- und Ausgabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Übe die Syntax für Benutzereingaben in Rust, indem du die Lücken füllst.</p><p>In Rust ist das Einlesen von der Konsole explizit. Du brauchst:</p>\n<ol>\n<li>Einen <strong>veränderbaren String</strong> (<code>let mut input = String::new()</code>).</li>\n<li>Den Aufruf von <strong><code>io::stdin().read_line()</code></strong>.</li>\n<li>Eine <strong>veränderbare Referenz</strong> auf deinen String (<code>&amp;mut input</code>).</li>\n<li>Eine Fehlerbehandlung wie <strong><code>.unwrap()</code></strong> oder <code>.expect()</code>.</li>\n</ol>\n", "rust", 5, "Rust: Lückentext Eingabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Rust - Sicher, schnell und modern.</p><p>In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.</p>\n", "rust", "Rust Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Rust Daten sicher per Referenz übergibt.</p><p>In Rust gibt es kein klassisches &quot;Call by Reference&quot; wie in C++, sondern <strong>Borrowing</strong> (Ausleihen).</p>\n<ol>\n<li><strong>Unveränderbares Borrowing (<code>&amp;T</code>)</strong>: Man darf den Wert lesen, aber nicht ändern. Man kann beliebig viele dieser Referenzen gleichzeitig haben.</li>\n<li><strong>Veränderbares Borrowing (<code>&amp;mut T</code>)</strong>: Man darf den Wert ändern. Es darf jedoch immer nur <strong>eine</strong> veränderbare Referenz zur gleichen Zeit existieren (Sicherheit gegen Data Races).</li>\n<li><strong>Ownership</strong>: Wird kein <code>&amp;</code> verwendet, wird der Wert <strong>verschoben</strong> (Move) und die ursprüngliche Variable ist nicht mehr nutzbar.</li>\n</ol>\n", "rust", 6, "Rust: Referenzen und Borrowing" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C++ arbeitest.</p><p>C++ ist eine objektorientierte Erweiterung von C und bietet komfortable Typen wie <code>std::string</code>.</p>\n", "cpp", 3, "Variablen in C++" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "cpp", 2, "C++: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", "cpp", 1, "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value, Call by Reference und Call by Pointer.</p><p>In C++ gibt es drei Hauptarten, wie Daten an Funktionen übergeben werden können:</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie erstellt. Änderungen in der Funktion haben keine Auswirkung auf das Original.</li>\n<li><strong>Call by Reference</strong>: Die Funktion erhält direkten Zugriff auf das Original (Alias). Änderungen wirken sich sofort aus. Syntax: <code>Type&amp; name</code>.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse der Variable wird übergeben. Die Funktion greift über Dereferenzierung (<code>*</code>) auf das Original zu. Syntax: <code>Type* name</code> und beim Aufruf <code>&amp;variable</code>.</li>\n</ol>\n", "cpp", 4, "C++: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in PHP arbeitest.</p><p>PHP ist eine schwach typisierte Sprache. Variablen werden mit einem Dollarzeichen ($) eingeleitet.</p>\n", "php", 3, "Variablen in PHP" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "php", 2, "PHP: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die serverseitige Programmierung mit PHP.</p><p>In dieser Lektion lernst du die Grundlagen von PHP kennen. PHP-Code wird auf dem Server ausgeführt und das Ergebnis wird als HTML an den Browser gesendet.</p>\n", "php", 1, "PHP Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Reference in PHP.</p><p>In PHP werden Variablen standardmäßig als <strong>Call by Value</strong> übergeben.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie der Variable erstellt.</li>\n<li><strong>Call by Reference</strong>: Nutzt man ein <code>&amp;</code> vor dem Parameternamen in der Funktionsdefinition, wird eine Referenz auf die Originalvariable übergeben. Änderungen wirken sich direkt aus.</li>\n</ol>\n", "php", 4, "PHP: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C arbeitest.</p><p>In C musst du Datentypen explizit angeben. Für Booleans musst du <code>&lt;stdbool.h&gt;</code> einbinden.</p>\n", "c", 3, "Variablen in C" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "c", 2, "C: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", "c", "C Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Pointer in C.</p><p>In C gibt es (im Gegensatz zu C++) kein echtes &quot;Call by Reference&quot;. Stattdessen nutzt man Pointer, um ähnliche Effekte zu erzielen.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie des Wertes an die Funktion übergeben. Änderungen betreffen nur die Kopie.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse einer Variable wird übergeben. Die Funktion kann über diese Adresse direkt auf den Speicher des Aufrufers zugreifen und den Wert ändern.</li>\n</ol>\n", "c", 4, "C: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Python arbeitest.</p><p>In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.</p>\n", "python", 4, "Variablen in Python" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[,]
                {
                    { 134, "<p>Lerne, wie Python mit Referenzen und veränderlichen Objekten umgeht.</p><p>Python nutzt ein Modell namens <strong>Pass-by-Object-Reference</strong>.</p>\n<ol>\n<li><strong>Unveränderliche Typen (<code>int</code>, <code>str</code>, <code>tuple</code>)</strong>: Da diese nicht geändert werden können, verhält es sich wie <strong>Call by Value</strong>. Jede &quot;Änderung&quot; erzeugt ein neues Objekt lokal in der Funktion.</li>\n<li><strong>Veränderliche Typen (<code>list</code>, <code>dict</code>, <code>set</code>)</strong>: Die Referenz wird übergeben. Änderungen am Objekt (z.B. <code>.append()</code>) wirken sich direkt auf das Original aus.</li>\n</ol>\n", "python", 5, "Python: Parameterübergabe" },
                    { 135, "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", "python", 2, "Python: Kontrollstrukturen" },
                    { 136, "<p>Lerne, wie du Code-Blöcke wiederholst.</p><p>Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet <code>for</code> für bekannte Iterationen und <code>while</code> für bedingte Wiederholungen.</p>\n", "python", 3, "Python: Schleifen" },
                    { 137, "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", 1, "Python Grundlagen" },
                    { 138, "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", "java", 4, "Variablen in Java" },
                    { 139, "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", 1, "Java Einstieg" },
                    { 140, "<p>Verstehe den Unterschied zwischen Primitiven und Objekten in Java.</p><p>In Java gibt es oft Diskussionen über &quot;Call by Reference&quot;. Die Wahrheit ist: <strong>Java ist immer Call by Value.</strong></p>\n<ol>\n<li><strong>Primitive Typen (<code>int</code>, <code>double</code>, etc.)</strong>: Es wird eine Kopie des eigentlichen Wertes übergeben.</li>\n<li><strong>Objekt-Referenzen</strong>: Es wird eine Kopie der <strong>Adresse</strong> des Objekts übergeben. Deshalb kannst du Attribute des Objekts in einer Methode ändern, aber du kannst nicht die ursprüngliche Variable auf ein komplett neues Objekt zeigen lassen.</li>\n</ol>\n", "java", 5, "Java: Parameterübergabe" },
                    { 141, "<p>Entscheidungen treffen mit if und else.</p>", "java", 2, "Java: Kontrollstrukturen" },
                    { 142, "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", "java", 3, "Java: Schleifen" }
                });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `zahl` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "function verdopple(x) {\n    x = x * 2;\n}\n\nlet zahl = 5;\nverdopple(zahl);\nconsole.log(zahl);\n", "x = x * 2", "function verdopple(x) {\n    x = x * 2;\n}\n\nlet zahl = 5;\nverdopple(zahl);\nconsole.log(zahl);\n", "Primitive: Pass by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In JS werden Objekte über eine Referenz übergeben. Ändere die Eigenschaft `name` des Objekts in der Funktion.", "Geändert", "function updateName(obj) {\n    // Ändere obj.name zu \"Geändert\"\n    obj.name = \"Geändert\";\n}\n\nlet person = { name: \"Original\" };\nupdateName(person);\nconsole.log(person.name);\n", 101, 2, "obj.name", "function updateName(obj) {\n    obj.name = \"Geändert\";\n}\n\nlet person = { name: \"Original\" };\nupdateName(person);\nconsole.log(person.name);\n", "Objekte: Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "let zahl = -5;\n// Dein Code hier\n", 1, "if,else", "let zahl = -5;\nif (zahl > 0) {\n    console.log(\"Positiv\");\n} else {\n    console.log(\"Negativ\");\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "// Dein Code hier\n", "for", "for (let i = 1; i <= 5; i++) {\n    console.log(i);\n}\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "let summe = 0;\nlet i = 1;\n// Dein Code hier\n", "while", "let summe = 0;\nlet i = 1;\nwhile (i < 5) {\n    summe += i;\n    i++;\n}\nconsole.log(summe);\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in JavaScript.", "Hallo Welt!", "console.log();", "javascript", "console.log", "console.log(\"Hallo Welt!\");", "JS: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine Funktion 'begruessung', die 'Hallo' zurückgibt.", "Hallo", "function begruessung() {\n    // Dein Code hier\n}\nconsole.log(begruessung());", "javascript", "function,return", null, "JS: Funktionen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Description", "ExpectedOutput", "LessonId", "Order", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", 105, 1, "package main\n\nimport \"fmt\"\n\nfunc main() {\n    var a int = 10\n    b := 5\n    fmt.Println(a + b)\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", 105, 2, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    a := 2.5\n    b := 5.0\n    fmt.Println(a * b)\n}", "Gleitkommazahlen (float64)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei Strings in Go.", "Hallo Welt", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", 3, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    s1 := \"Hallo \"\n    s2 := \"Welt\"\n    fmt.Println(s1 + s2)\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    // Dein Code\n}", 105, 4, "if,fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    if isActive {\n        fmt.Println(\"Wahr\")\n    } else {\n        fmt.Println(\"Falsch\")\n    }\n}", "Booleans (bool)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    // Dein Code hier\n}\n", 1, "if,else", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    if zahl > 0 {\n        fmt.Print(\"Positiv\")\n    } else {\n        fmt.Print(\"Negativ\")\n    }\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Go ist eine bei Google entwickelte Open-Source-Programmiersprache, die sich durch Effizienz und Einfachheit auszeichnet.", "", "", "go", null, null, "Was ist Go?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}\n", "go", "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    fmt.Println(\"Hallo Welt!\")\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `updateName`, sodass sie den Namen lokal ändert, aber das Original in `main` unverändert bleibt.", "Original", "package main\nimport \"fmt\"\n\nfunc updateName(n string) {\n    // Name ändern\n    n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateName(name)\n    fmt.Print(name)\n}\n", "go", 108, 1, "n = \"Geändert\"", "package main\nimport \"fmt\"\n\nfunc updateName(n string) {\n    n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateName(name)\n    fmt.Print(name)\n}\n", "Call by Value in Go" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*string`), um den Wert des Originals zu verändern.", "Geändert", "package main\nimport \"fmt\"\n\nfunc updateNamePtr(n *string) {\n    // Ändere den Wert, auf den der Pointer zeigt\n    *n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    // Übergebe die Adresse mit &\n    updateNamePtr(&name)\n    fmt.Print(name)\n}\n", "go", 108, 2, "*string,*n,&name", "package main\nimport \"fmt\"\n\nfunc updateNamePtr(n *string) {\n    *n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateNamePtr(&name)\n    fmt.Print(name)\n}\n", "Call by Pointer in Go" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um eine Zahl per Pointer zu verdoppeln.", "20", "package main\nimport \"fmt\"\n\nfunc double(n ___int) { // Pointer-Typ\n    ___n = ___n * 2     // Dereferenzierung\n}\n\nfunc main() {\n    x := 10\n    double(___x)        // Adresse übergeben\n    fmt.Print(x)\n}\n", "go", 3, "*int,*n,&x", "package main\nimport \"fmt\"\n\nfunc double(n *int) {\n    *n = *n * 2\n}\n\nfunc main() {\n    x := 10\n    double(&x)\n    fmt.Print(x)\n}\n", "Lückentext: Pointer-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "Description", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "int,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int a = 10;\n		int b = 5;\n		Console.WriteLine(a + b);\n	}\n}", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie mit einer anderen Zahl und gib das Ergebnis aus.", "12.5", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", 109, 2, "double,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		double a = 2.5;\n		double b = 5.0;\n		Console.WriteLine(a * b);\n	}\n}", "Gleitkommazahlen (Double)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "Description", "ExpectedOutput", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei Strings und gib sie aus.", "Hallo Welt", 109, 3, "string,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		string s1 = \"Hallo \";\n		string s2 = \"Welt\";\n		Console.WriteLine(s1 + s2);\n	}\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Verwende eine bool-Variable in einer if-Anweisung, um 'Wahr' auszugeben, wenn sie true ist, sonst 'Falsch'.", "Wahr", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		// Dein Code\n	}\n}", 109, 4, "bool,if,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		if (isActive)\n		{\n			Console.WriteLine(\"Wahr\");\n		}\n		else\n		{\n			Console.WriteLine(\"Falsch\");\n		}\n	}\n}", null, "Booleans (Wahrheitswerte)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", "csharp", 110, null, "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Berechne die Summe der Zahlen 1 bis 5.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", "csharp", 111, 1, "for", null, "For-Schleife: Summe" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C# ist eine objektorientierte Sprache von Microsoft.", "", "", "csharp", 1, null, null, "Was ist C#?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 112, 2, "Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		Console.WriteLine(\"Hallo Welt!\");\n	}\n}", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `ref`-Keyword, um den Wert der Variable `zahl` in der Methode `Verdopple` zu ändern.", "10", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        // Nutze ref auch beim Aufruf\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", "csharp", 1, "ref int,ref zahl", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das ref Keyword" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `out`-Keyword, um einen Wert von einer Methode zurückzugeben, ohne den Rückgabewert zu nutzen.", "42", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        // out Variablen MÜSSEN in der Methode zugewiesen werden\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", "csharp", 2, "out int,out zahl", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das out Keyword" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `ref` oder `out`.", "x=2,y=1", "using System;\n\npublic class Program\n{\n    static void Swap(____ int a, ____ int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(____ x, ____ y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", "csharp", 3, "ref int,ref x", "using System;\n\npublic class Program\n{\n    static void Swap(ref int a, ref int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(ref x, ref y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", "Lückentext: C# Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "InitialCode", "Language", "RequiredKeywords", "TestCode", "Title", "Type" },
                values: new object[] { null, null, "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'.", "public class Calculator \n{\n    // Hier deine Methode\n}", "csharp", "class,Calculator,static,int", "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Zahl `x` größer als 10 ist. Gib 'Groß' aus, ansonsten 'Klein'.", "Groß", "fn main() {\n    let x = 15;\n    // Dein Code hier\n}\n", 115, 1, "if,else", "fn main() {\n    let x = 15;\n    if x > 10 {\n        println!(\"Groß\");\n    } else {\n        println!(\"Klein\");\n    }\n}\n", "Einfaches if/else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Rust hat eine endlose Schleife namens `loop`. Nutze `break`, um sie zu verlassen, wenn `i` den Wert 5 erreicht hat. Gib `i` in jedem Durchgang aus.", "0\n1\n2\n3\n4\n5", "fn main() {\n    let mut i = 0;\n    loop {\n        // Dein Code hier\n        i += 1;\n    }\n}\n", 115, "loop,break", "fn main() {\n    let mut i = 0;\n    loop {\n        println!(\"{}\", i);\n        if i == 5 {\n            break;\n        }\n        i += 1;\n    }\n}\n", "Die `loop` Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while` Schleife, um die Zahlen von 3 bis 1 (herunterzählend) auszugeben.", "3\n2\n1", "fn main() {\n    let mut n = 3;\n    // Dein Code hier\n}\n", 115, "while", "fn main() {\n    let mut n = 3;\n    while n > 0 {\n        println!(\"{}\", n);\n        n -= 1;\n    }\n}\n", "While Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine i32-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "fn main() {\n    // Dein Code\n}", 116, "let,println!", "fn main() {\n    let a: i32 = 10;\n    let b: i32 = 5;\n    println!(\"{}\", a + b);\n}", "Ganzzahlen (i32)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine f64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "fn main() {\n    // Dein Code\n}", 116, "f64,println!", "fn main() {\n    let a: f64 = 2.5;\n    let b: f64 = 5.0;\n    println!(\"{}\", a * b);\n}", "Gleitkommazahlen (f64)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "fn main() {\n    // Dein Code\n}", 116, "String,println!", "fn main() {\n    let s1 = String::from(\"Hallo \");\n    let s2 = \"Welt\";\n    println!(\"{}{}\", s1, s2);\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "fn main() {\n    let is_active = true;\n    // Dein Code\n}", 116, "bool,if,println!", "fn main() {\n    let is_active = true;\n    if is_active {\n        println!(\"Wahr\");\n    } else {\n        println!(\"Falsch\");\n    }\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "LessonId", "Title", "Type" },
                values: new object[] { "[\"Damit sie schneller geladen wird\", \"Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen\", \"Um anzuzeigen, dass es ein String ist\", \"Das mut ist optional\"]", "Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen", "Warum muss die Variable für die Eingabe mit `mut` deklariert werden (z.B. `let mut input`)?", 117, "Anatomie der Eingabe", 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust nutzt man `std::io::stdin()`, um Eingaben einzulesen. <br>Lies einen Namen von der Tastatur ein und gib 'Hallo [Name]!' aus. <br>Hinweis: Tippe in das Eingabefeld rechts das Wort 'Rust' ein, bevor du auf Ausführen klickst.", "Hallo Rust!", "use std::io;\n\nfn main() {\n    let mut input = String::new(); // Erstellt einen Puffer\n    \n    // Deine Aufgabe: Nutze io::stdin().read_line(&mut input).unwrap();\n    \n    println!(\"Hallo {}!\", input.trim());\n}\n", 117, "read_line", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    println!(\"Hallo {}!\", input.trim());\n}\n", "Einen String einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies eine Zahl von der Tastatur ein, verdopple sie und gib das Ergebnis aus. <br>Hinweis: Nutze `.trim().parse::<i32>().unwrap()`, um den String in eine Zahl zu wandeln. <br>Tippe die Zahl '21' in das Eingabefeld.", "Ergebnis: 42", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    // Deine Aufgabe: Wandle 'input' in eine Zahl 'n' um\n    // let n: i32 = ...\n    \n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "rust", 2, "parse", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let n: i32 = input.trim().parse().unwrap();\n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "Zahl einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies zwei Zahlen nacheinander ein und gib deren Summe aus. <br>Wichtig: Das Eingabefeld unterstützt aktuell nur eine Zeile. Trenne deine beiden Zahlen im Eingabefeld mit einem Leerzeichen (z.B. '10 5').", "Summe: 15", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    \n    println!(\"Summe: {}\", a + b);\n}\n", "rust", 3, "split_whitespace", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    println!(\"Summe: {}\", a + b);\n}\n", "Zwei Zahlen addieren" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Zeile, um einen neuen, leeren String-Puffer zu erstellen. <br>Nutze `String::new()`.", "Puffer bereit.", "fn main() {\n    // Vervollständige: let mut input = ...\n    let mut input = ___________;\n    \n    println!(\"Puffer bereit.\");\n}\n", "rust", 118, 1, "String::new", "fn main() {\n    let mut input = String::new();\n    println!(\"Puffer bereit.\");\n}\n", "Lücke: Den Puffer erstellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`.", "Bitte etwas tippen:\nGelesen!", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    \n    // Lücke: io::stdin().read_line(____ buffer).unwrap();\n    io::stdin().read_line(____ buffer).unwrap();\n    \n    println!(\"Gelesen!\");\n}\n", "rust", 118, 2, "&mut", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    io::stdin().read_line(&mut buffer).unwrap();\n    println!(\"Gelesen!\");\n}\n", "Lücke: Die Referenz" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`.", "", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    \n    // Lücke: ____::stdin().read_line(&mut input).unwrap();\n    ____::stdin().read_line(&mut input).unwrap();\n}\n", "rust", 3, "io::stdin", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n}\n", "Lücke: Das Modul aufrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Schreibe die komplette Zeile, um eine Eingabe in die Variable `text` einzulesen. <br>Vergiss das `.unwrap()` am Ende nicht!", "Eingabe erfolgt.", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    \n    // Schreibe hier die komplette read_line Zeile:\n    \n    println!(\"Eingabe erfolgt.\");\n}\n", "rust", 118, 4, "read_line,&mut,unwrap", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    io::stdin().read_line(&mut text).unwrap();\n    println!(\"Eingabe erfolgt.\");\n}\n", "Lücke: Alles zusammen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", "rust", 1, null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", "rust", 119, 2, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `laenge`, sodass sie die Länge eines Strings berechnet, ohne den Besitz (Ownership) zu übernehmen.", "Die Länge von 'Hallo' ist 5.", "fn laenge(s: &String) -> usize {\n    // Berechne die Länge\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    // Übergebe eine Referenz mit &\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "rust", 1, "&String,&s1", "fn laenge(s: &String) -> usize {\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "Unveränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `&mut`, um den Inhalt eines Strings in einer Funktion zu verändern.", "Hallo, Welt", "fn aendern(s: &mut String) {\n    // Füge Text an\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    // Übergebe eine veränderbare Referenz mit &mut\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "rust", 2, "&mut String,&mut s", "fn aendern(s: &mut String) {\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "Veränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `&` oder `&mut`.", "Lesen: Daten\nDaten...geändert", "fn main() {\n    let ___ s = String::from(\"Daten\");\n    \n    process_read(___s);  // Nur Lesen\n    process_write(___s); // Schreiben\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: ___String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: ___String) {\n    s.push_str(\"...geändert\");\n}\n", "rust", 3, "&s,&mut s,&String,&mut String", "fn main() {\n    let mut s = String::from(\"Daten\");\n    \n    process_read(&s);\n    process_write(&mut s);\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: &String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: &mut String) {\n    s.push_str(\"...geändert\");\n}\n", "Lückentext: Rust Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus.", "15", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", "int,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 121, 2, "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'string', um zwei Texte zu verknüpfen.", "Hallo Welt", "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 121, 3, "string,cout", "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "#include <iostream>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "cpp", 121, 4, "bool,if,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        cout << \"Wahr\";\n    } else {\n        cout << \"Falsch\";\n    }\n    return 0;\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 122, 1, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "", "", "cpp", 1, null, null, "Was ist C++?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 2, "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt (Call by Value).", "Wert nach Funktion: 5", "#include <iostream>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", "x = x * 2", "#include <iostream>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine Referenz (`&`), um den Wert der Originalvariable in der Funktion `verdoppleRef` dauerhaft zu ändern.", "Geänderter Wert: 10", "#include <iostream>\n\n// Nutze & für Call by Reference\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 124, 2, "int&", "#include <iostream>\n\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Reference", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Wert über Pointer: 10", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 124, 3, "int*,&zahl", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Pointer" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit der richtigen Syntax für Pointer und Referenzen.", "x=2, y=1", "#include <iostream>\n\nvoid swap(int__ a, int__ b) { // Nutze & für Referenzen\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=\" << x << \", y=\" << y;\n    return 0;\n}\n", "cpp", 124, 4, "int&", "#include <iostream>\n\nvoid swap(int& a, int& b) {\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=2, y=1\";\n    return 0;\n}\n", "Lückentext: Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In PHP beginnen Variablen mit einem $. Addiere zwei Zahlen und gib das Ergebnis mit echo aus.", "15", "<?php\n// Dein Code", "php", 125, 1, "echo,$", "<?php\n$a = 10;\n$b = 5;\necho $a + $b;", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Multipliziere zwei Gleitkommazahlen und gib das Ergebnis aus.", "12.5", "<?php\n// Dein Code", "php", 125, 2, "echo", "<?php\n$a = 2.5;\n$b = 5.0;\necho $a * $b;", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings werden in PHP mit dem Punkt (.) verknüpft.", "Hallo Welt", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\n// Dein Code", "php", 125, 3, "echo,.", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\necho $s1 . $s2;", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "<?php\n$isActive = true;\n// Dein Code", "php", 125, 4, "if,echo", "<?php\n$isActive = true;\nif ($isActive) {\n    echo \"Wahr\";\n} else {\n    echo \"Falsch\";\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable '$zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "<?php\n$zahl = -5;\n// Dein Code hier\n?>\n", "php", 126, 1, "if,else", "<?php\n$zahl = -5;\nif ($zahl > 0) {\n    echo \"Positiv\";\n} else {\n    echo \"Negativ\";\n}\n?>\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "", "", "php", 127, null, null, "Was ist PHP?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "<?php\n// Dein Code hier\n", "php", 127, "echo", "<?php\necho \"Hallo Welt!\";\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Originalwert: 5", "<?php\n\nfunction verdopple($zahl) {\n    // Ändere den Wert lokal\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", "php", 128, "$zahl = $zahl * 2", "<?php\n\nfunction verdopple($zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", "Call by Value in PHP", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das Ampersand-Zeichen (`&`) in der Parameterliste, um den Wert des Originals zu verändern.", "Geänderter Wert: 10", "<?php\n\n// Nutze & vor der Variable\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", "php", 128, "&$zahl", "<?php\n\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", "Call by Reference in PHP" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um eine Referenz an die Funktion zu übergeben.", "11", "<?php\n\nfunction addOne(____$n) { // Ampersand hier einfügen\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", "php", 128, 3, "&$n", "<?php\n\nfunction addOne(&$n) {\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", "Lückentext: Referenz-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "15", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 129, 1, "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 129, 2, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "Hallo Welt", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 129, 3, "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "Wahr", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "c", 129, 4, "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", 130, 1, "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", "c", 1, null, null, null, "Was ist C?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 131, 2, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Wert nach Funktion: 5", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "c", 132, "x = x * 2", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "Call by Value in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Geänderter Wert: 10", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl mit &\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "c", 132, "int *,*x,&zahl", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "Call by Pointer in C" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1083, null, null, "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen.", "x=2, y=1", "#include <stdio.h>\n\nvoid swap(int ____ a, int ____ b) {\n    int temp = ____ a;\n    ____ a = ____ b;\n    ____ b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=%d, y=%d\", x, y);\n    return 0;\n}\n", "c", 132, 3, null, "int *,* a,* b", "#include <stdio.h>\n\nvoid swap(int * a, int * b) {\n    int temp = * a;\n    * a = * b;\n    * b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=2, y=1\");\n    return 0;\n}\n", null, "Lückentext: Pointer-Syntax", 1 },
                    { 1084, null, null, "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "# Dein Code hier", "python", 133, 1, null, "print", "a = 10\nb = 5\nprint(a + b)", null, "Ganzzahlen (Integer)", 1 },
                    { 1085, null, null, "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "python", 133, 2, null, "print", "a = 2.5\nb = 5\nprint(a * b)", null, "Gleitkommazahlen (Float)", 1 },
                    { 1086, null, null, "Strings können in Python mit dem + Operator verknüpft werden.", "Hallo Welt", "# Dein Code hier", "python", 133, 3, null, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", null, "Zeichenketten (String)", 1 },
                    { 1087, null, null, "Verwende einen Boolean (True/False) in einer if-Anweisung.", "Wahr", "is_active = True\n# Dein Code", "python", 133, 4, null, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", null, "Booleans (Wahrheitswerte)", 1 },
                    { 1088, null, null, "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "def verdopple(x):\n    # x lokal verdoppeln\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "python", 134, 1, null, "x = x * 2", "def verdopple(x):\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", null, "Unveränderliche Typen (Integers)", 1 },
                    { 1089, null, null, "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden.", "Python", "def add_element(liste):\n    # Füge \"Python\" zur Liste hinzu\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "python", 134, 2, null, "append", "def add_element(liste):\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", null, "Veränderliche Typen (Listen)", 1 },
                    { 1090, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", 135, 1, null, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", null, "Logik: Positiv/Negativ", 1 },
                    { 1091, null, null, "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", 135, 2, null, "for,in,range", "for i in range(1, 4):\n    print(i)\n", null, "Zahlen von 1 bis 3 ausgeben", 1 },
                    { 1092, null, null, "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", "python", 136, 1, null, "for,in,range", "for i in range(1, 6):\n    print(i)\n", null, "Zahlen 1 bis 5", 1 },
                    { 1093, null, null, "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", "python", 136, 2, null, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", null, "Summe bis 10", 1 },
                    { 1094, null, null, "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", 137, 1, null, null, null, null, "Was ist Python?", 0 },
                    { 1095, null, null, "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", 137, 2, null, "print", "print(\"Hallo Welt!\")\n", null, "Hallo Welt", 1 },
                    { 1096, null, null, "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 138, 1, null, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", null, "Ganzzahlen (int)", 1 },
                    { 1097, null, null, "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 138, 2, null, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", null, "Gleitkommazahlen (double)", 1 },
                    { 1098, null, null, "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 138, 3, null, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", null, "Zeichenketten (String)", 1 },
                    { 1099, null, null, "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", "java", 138, 4, null, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", null, "Booleans (boolean)", 1 },
                    { 1100, null, null, "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", 139, 1, null, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", null, "Java: Hallo Welt", 1 },
                    { 1101, null, null, "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 139, 2, null, "if", null, null, "Java: If-Else", 1 },
                    { 1102, null, null, "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 139, 3, null, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 },
                    { 1103, null, null, "Versuche den Wert von `x` in der Methode `verdopple` zu ändern. Bleibt das Original in `main` gleich?", "5", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "java", 140, 1, null, "x = x * 2", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", null, "Primitive: Pass by Value", 1 },
                    { 1104, null, null, "In Java werden Objektreferenzen per Wert übergeben. Du kannst das Objekt verändern, aber nicht die Referenz selbst.", "Java", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        // Füge ein Element hinzu\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "java", 140, 2, null, "list.add", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", null, "Objekte: Referenz ändern", 1 },
                    { 1105, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 141, 1, null, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", null, "Logik: Positiv/Negativ", 1 },
                    { 1106, null, null, "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", "java", 142, 1, null, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", null, "Zahlen 1 bis 5", 1 },
                    { 1107, null, null, "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", "java", 142, 2, null, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", null, "Summe bis 10", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "JavaScript: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben mit for und while.</p><p>In JavaScript sind Schleifen ein wichtiges Werkzeug, um Arrays zu durchlaufen oder wiederkehrende Aufgaben zu automatisieren.</p>\n", 3, "JavaScript: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Programmieren für das Web.</p><p>JavaScript erweckt Webseiten zum Leben.</p>\n", 1, "JavaScript Einführung" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Go arbeitest.</p><p>In Go kannst du Variablen mit <code>var</code> oder der Kurzschreibweise <code>:=</code> deklarieren.</p>\n", "go", 3, "Variablen in Go" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "Go: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Go (Golang).</p><p>In dieser Lektion lernst du die ersten Schritte in Go. Go ist bekannt für seine starke Unterstützung von Nebenläufigkeit und seine schnelle Kompilierung.</p>\n", 1, "Go Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C# arbeitest.</p><p>Variablen sind Container zum Speichern von Datenwerten. In C# musst du den Datentyp einer Variable angeben.</p>\n", "csharp", 5, "Variablen in C#" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne Entscheidungen im Code zu treffen.</p><p>In dieser Lektion lernst du <code>if</code> und <code>else</code> kennen.</p>\n", "csharp", 2, "Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben effizient.</p><p>Schleifen helfen dir, Aufgaben mehrfach auszuführen.</p>\n", 3, "Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von C#.</p><p>In dieser Lektion lernst du die ersten Schritte in C#.</p>\n", 1, "C# Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Objektorientierte Programmierung.</p><p>Alles in C# findet in Klassen statt.</p>\n", 4, "Klassen & Methoden" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen und Code wiederholen.</p><p>Kontrollstrukturen sind das Herzstück jeder Programmiersprache. In Rust gibt es neben <code>if</code> und <code>else</code> auch mächtige Schleifen-Konstrukte wie <code>loop</code>, <code>while</code> und <code>for</code>.</p>\n", "rust", 3, "Rust: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Rust arbeitest.</p><p>In Rust sind Variablen standardmäßig unveränderlich (immutable). Mit <code>let mut</code> kannst du sie veränderbar machen.</p>\n", "rust", 4, "Variablen in Rust" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Wie liest man Daten von der Tastatur in Rust ein?</p><p>Rust legt großen Wert auf Sicherheit. Daher ist die Standardeingabe etwas ausführlicher als in anderen Sprachen. Das Modul <code>std::io</code> bietet Zugriff auf die Funktionen, um von der Tastatur zu lesen.</p>\n", "rust", 2, "Rust: Ein- und Ausgabe" });

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
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Rust - Sicher, schnell und modern.</p><p>In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.</p>\n", 1, "Rust Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C++ arbeitest.</p><p>C++ ist eine objektorientierte Erweiterung von C und bietet komfortable Typen wie <code>std::string</code>.</p>\n", "cpp", 3, "Variablen in C++" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "cpp", 2, "C++: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", "cpp", "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in PHP arbeitest.</p><p>PHP ist eine schwach typisierte Sprache. Variablen werden mit einem Dollarzeichen ($) eingeleitet.</p>\n", "php", 3, "Variablen in PHP" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "php", 2, "PHP: Kontrollstrukturen" });

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
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C arbeitest.</p><p>In C musst du Datentypen explizit angeben. Für Booleans musst du <code>&lt;stdbool.h&gt;</code> einbinden.</p>\n", "c", 3, "Variablen in C" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "c", 2, "C: Kontrollstrukturen" });

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
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Python arbeitest.</p><p>In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.</p>\n", "python", 4, "Variablen in Python" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", "python", 2, "Python: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Code-Blöcke wiederholst.</p><p>Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet <code>for</code> für bekannte Iterationen und <code>while</code> für bedingte Wiederholungen.</p>\n", "python", 3, "Python: Schleifen" });

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
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", "java", 4, "Variablen in Java" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", "Java Einstieg" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "java", 2, "Java: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", "java", 3, "Java: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "let zahl = -5;\n// Dein Code hier\n", "if,else", "let zahl = -5;\nif (zahl > 0) {\n    console.log(\"Positiv\");\n} else {\n    console.log(\"Negativ\");\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "// Dein Code hier\n", 102, 1, "for", "for (let i = 1; i <= 5; i++) {\n    console.log(i);\n}\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "let summe = 0;\nlet i = 1;\n// Dein Code hier\n", 2, "while", "let summe = 0;\nlet i = 1;\nwhile (i < 5) {\n    summe += i;\n    i++;\n}\nconsole.log(summe);\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in JavaScript.", "Hallo Welt!", "console.log();", "console.log", "console.log(\"Hallo Welt!\");", "JS: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine Funktion 'begruessung', die 'Hallo' zurückgibt.", "Hallo", "function begruessung() {\n    // Dein Code hier\n}\nconsole.log(begruessung());", "function,return", null, "JS: Funktionen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", "go", "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    var a int = 10\n    b := 5\n    fmt.Println(a + b)\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", "go", "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    a := 2.5\n    b := 5.0\n    fmt.Println(a * b)\n}", "Gleitkommazahlen (float64)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Description", "ExpectedOutput", "LessonId", "Order", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei Strings in Go.", "Hallo Welt", 104, 3, "package main\n\nimport \"fmt\"\n\nfunc main() {\n    s1 := \"Hallo \"\n    s2 := \"Welt\"\n    fmt.Println(s1 + s2)\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    // Dein Code\n}", 104, 4, "if,fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    if isActive {\n        fmt.Println(\"Wahr\")\n    } else {\n        fmt.Println(\"Falsch\")\n    }\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    // Dein Code hier\n}\n", 1, "if,else", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    if zahl > 0 {\n        fmt.Print(\"Positiv\")\n    } else {\n        fmt.Print(\"Negativ\")\n    }\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Go ist eine bei Google entwickelte Open-Source-Programmiersprache, die sich durch Effizienz und Einfachheit auszeichnet.", "", "", 106, 1, null, null, "Was ist Go?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}\n", 2, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    fmt.Println(\"Hallo Welt!\")\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", "int,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int a = 10;\n		int b = 5;\n		Console.WriteLine(a + b);\n	}\n}", "Ganzzahlen (Integer)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie mit einer anderen Zahl und gib das Ergebnis aus.", "12.5", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", "double,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		double a = 2.5;\n		double b = 5.0;\n		Console.WriteLine(a * b);\n	}\n}", "Gleitkommazahlen (Double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei Strings und gib sie aus.", "Hallo Welt", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 107, 3, "string,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		string s1 = \"Hallo \";\n		string s2 = \"Welt\";\n		Console.WriteLine(s1 + s2);\n	}\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende eine bool-Variable in einer if-Anweisung, um 'Wahr' auszugeben, wenn sie true ist, sonst 'Falsch'.", "Wahr", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		// Dein Code\n	}\n}", "csharp", 107, 4, "bool,if,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		if (isActive)\n		{\n			Console.WriteLine(\"Wahr\");\n		}\n		else\n		{\n			Console.WriteLine(\"Falsch\");\n		}\n	}\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", "csharp", 1, "if,else", null, "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "Description", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Berechne die Summe der Zahlen 1 bis 5.", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", "for", null, "For-Schleife: Summe" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C# ist eine objektorientierte Sprache von Microsoft.", "", "", 110, 1, null, null, "Was ist C#?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "Description", "ExpectedOutput", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", 110, 2, "Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		Console.WriteLine(\"Hallo Welt!\");\n	}\n}", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'.", "", "public class Calculator \n{\n    // Hier deine Methode\n}", 111, 1, "class,Calculator,static,int", null, "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Zahl `x` größer als 10 ist. Gib 'Groß' aus, ansonsten 'Klein'.", "Groß", "fn main() {\n    let x = 15;\n    // Dein Code hier\n}\n", "rust", 112, "fn main() {\n    let x = 15;\n    if x > 10 {\n        println!(\"Groß\");\n    } else {\n        println!(\"Klein\");\n    }\n}\n", "Einfaches if/else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Rust hat eine endlose Schleife namens `loop`. Nutze `break`, um sie zu verlassen, wenn `i` den Wert 5 erreicht hat. Gib `i` in jedem Durchgang aus.", "0\n1\n2\n3\n4\n5", "fn main() {\n    let mut i = 0;\n    loop {\n        // Dein Code hier\n        i += 1;\n    }\n}\n", "rust", 112, 2, "loop,break", "fn main() {\n    let mut i = 0;\n    loop {\n        println!(\"{}\", i);\n        if i == 5 {\n            break;\n        }\n        i += 1;\n    }\n}\n", "Die `loop` Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine `while` Schleife, um die Zahlen von 3 bis 1 (herunterzählend) auszugeben.", "3\n2\n1", "fn main() {\n    let mut n = 3;\n    // Dein Code hier\n}\n", "rust", 3, "while", "fn main() {\n    let mut n = 3;\n    while n > 0 {\n        println!(\"{}\", n);\n        n -= 1;\n    }\n}\n", "While Schleife", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine i32-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "fn main() {\n    // Dein Code\n}", "rust", 113, 1, "let,println!", "fn main() {\n    let a: i32 = 10;\n    let b: i32 = 5;\n    println!(\"{}\", a + b);\n}", "Ganzzahlen (i32)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine f64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "fn main() {\n    // Dein Code\n}", "rust", 2, "f64,println!", "fn main() {\n    let a: f64 = 2.5;\n    let b: f64 = 5.0;\n    println!(\"{}\", a * b);\n}", "Gleitkommazahlen (f64)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "fn main() {\n    // Dein Code\n}", "rust", 3, "String,println!", "fn main() {\n    let s1 = String::from(\"Hallo \");\n    let s2 = \"Welt\";\n    println!(\"{}{}\", s1, s2);\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "fn main() {\n    let is_active = true;\n    // Dein Code\n}", "rust", 4, "bool,if,println!", "fn main() {\n    let is_active = true;\n    if is_active {\n        println!(\"Wahr\");\n    } else {\n        println!(\"Falsch\");\n    }\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "InitialCode", "Language", "RequiredKeywords", "TestCode", "Title", "Type" },
                values: new object[] { "[\"Damit sie schneller geladen wird\", \"Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen\", \"Um anzuzeigen, dass es ein String ist\", \"Das mut ist optional\"]", "Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen", "Warum muss die Variable für die Eingabe mit `mut` deklariert werden (z.B. `let mut input`)?", "", "rust", null, null, "Anatomie der Eingabe", 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust nutzt man `std::io::stdin()`, um Eingaben einzulesen. <br>Lies einen Namen von der Tastatur ein und gib 'Hallo [Name]!' aus. <br>Hinweis: Tippe in das Eingabefeld rechts das Wort 'Rust' ein, bevor du auf Ausführen klickst.", "Hallo Rust!", "use std::io;\n\nfn main() {\n    let mut input = String::new(); // Erstellt einen Puffer\n    \n    // Deine Aufgabe: Nutze io::stdin().read_line(&mut input).unwrap();\n    \n    println!(\"Hallo {}!\", input.trim());\n}\n", 114, 2, "read_line", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    println!(\"Hallo {}!\", input.trim());\n}\n", "Einen String einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies eine Zahl von der Tastatur ein, verdopple sie und gib das Ergebnis aus. <br>Hinweis: Nutze `.trim().parse::<i32>().unwrap()`, um den String in eine Zahl zu wandeln. <br>Tippe die Zahl '21' in das Eingabefeld.", "Ergebnis: 42", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    // Deine Aufgabe: Wandle 'input' in eine Zahl 'n' um\n    // let n: i32 = ...\n    \n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", 114, "parse", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let n: i32 = input.trim().parse().unwrap();\n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "Zahl einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies zwei Zahlen nacheinander ein und gib deren Summe aus. <br>Wichtig: Das Eingabefeld unterstützt aktuell nur eine Zeile. Trenne deine beiden Zahlen im Eingabefeld mit einem Leerzeichen (z.B. '10 5').", "Summe: 15", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    \n    println!(\"Summe: {}\", a + b);\n}\n", 114, "split_whitespace", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    println!(\"Summe: {}\", a + b);\n}\n", "Zwei Zahlen addieren" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Zeile, um einen neuen, leeren String-Puffer zu erstellen. <br>Nutze `String::new()`.", "Puffer bereit.", "fn main() {\n    // Vervollständige: let mut input = ...\n    let mut input = ___________;\n    \n    println!(\"Puffer bereit.\");\n}\n", 115, "String::new", "fn main() {\n    let mut input = String::new();\n    println!(\"Puffer bereit.\");\n}\n", "Lücke: Den Puffer erstellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`.", "Bitte etwas tippen:\nGelesen!", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    \n    // Lücke: io::stdin().read_line(____ buffer).unwrap();\n    io::stdin().read_line(____ buffer).unwrap();\n    \n    println!(\"Gelesen!\");\n}\n", 115, "&mut", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    io::stdin().read_line(&mut buffer).unwrap();\n    println!(\"Gelesen!\");\n}\n", "Lücke: Die Referenz" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`.", "", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    \n    // Lücke: ____::stdin().read_line(&mut input).unwrap();\n    ____::stdin().read_line(&mut input).unwrap();\n}\n", 115, "io::stdin", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n}\n", "Lücke: Das Modul aufrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe die komplette Zeile, um eine Eingabe in die Variable `text` einzulesen. <br>Vergiss das `.unwrap()` am Ende nicht!", "Eingabe erfolgt.", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    \n    // Schreibe hier die komplette read_line Zeile:\n    \n    println!(\"Eingabe erfolgt.\");\n}\n", 115, "read_line,&mut,unwrap", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    io::stdin().read_line(&mut text).unwrap();\n    println!(\"Eingabe erfolgt.\");\n}\n", "Lücke: Alles zusammen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "LessonId", "Title", "Type" },
                values: new object[] { null, null, "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", 116, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", 116, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus.", "15", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 1, "int,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 2, "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'string', um zwei Texte zu verknüpfen.", "Hallo Welt", "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 117, 3, "string,cout", "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}", "Zeichenketten (string)" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 1, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "", "", "cpp", 119, 1, null, null, "Was ist C++?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 2, "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n", "Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In PHP beginnen Variablen mit einem $. Addiere zwei Zahlen und gib das Ergebnis mit echo aus.", "15", "<?php\n// Dein Code", "php", 120, 1, "echo,$", "<?php\n$a = 10;\n$b = 5;\necho $a + $b;", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Multipliziere zwei Gleitkommazahlen und gib das Ergebnis aus.", "12.5", "<?php\n// Dein Code", "php", 2, "echo", "<?php\n$a = 2.5;\n$b = 5.0;\necho $a * $b;", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings werden in PHP mit dem Punkt (.) verknüpft.", "Hallo Welt", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\n// Dein Code", "php", 3, "echo,.", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\necho $s1 . $s2;", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "<?php\n$isActive = true;\n// Dein Code", "php", 4, "if,echo", "<?php\n$isActive = true;\nif ($isActive) {\n    echo \"Wahr\";\n} else {\n    echo \"Falsch\";\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable '$zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "<?php\n$zahl = -5;\n// Dein Code hier\n?>\n", "php", "if,else", "<?php\n$zahl = -5;\nif ($zahl > 0) {\n    echo \"Positiv\";\n} else {\n    echo \"Negativ\";\n}\n?>\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "", "", "php", 122, 1, null, null, "Was ist PHP?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "<?php\n// Dein Code hier\n", "php", 122, 2, "echo", "<?php\necho \"Hallo Welt!\";\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "15", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 123, 1, "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 123, 2, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "Hallo Welt", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 3, "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "Wahr", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "c", 4, "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", "c", 125, 1, null, null, "Was ist C?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 125, 2, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "# Dein Code hier", "python", 126, 1, "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "python", 126, 2, "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "Hallo Welt", "# Dein Code hier", "python", 126, 3, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "Wahr", "is_active = True\n# Dein Code", "python", 126, 4, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", 127, 1, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", 127, 2, "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", "python", 128, "for,in,range", "for i in range(1, 6):\n    print(i)\n", "Zahlen 1 bis 5", 1 });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", 129, null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", 129, "print", "print(\"Hallo Welt!\")\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 130, 1, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 130, 2, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 130, 3, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", "java", 130, 4, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", "Booleans (boolean)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", 131, 1, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", "Java: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 131, 2, "if", null, "Java: If-Else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 3, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 132, 1, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", "java", 133, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", "java", 133, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", "Summe bis 10" });
        }
    }
}

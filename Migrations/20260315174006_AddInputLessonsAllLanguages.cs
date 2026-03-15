using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddInputLessonsAllLanguages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Daten in Node.js von der Konsole einliest.</p><p>In Node.js ist das Einlesen von der Konsole etwas technischer als im Browser.</p>\n<ol>\n<li><strong>fs Modul</strong>: Über <code>fs.readFileSync(0)</code> kann synchron von der Standard-Eingabe gelesen werden.</li>\n<li><strong>Buffer zu String</strong>: Das Ergebnis muss meist mit <code>.toString()</code> umgewandelt und mit <code>.trim()</code> von Zeilenumbrüchen befreit werden.</li>\n</ol>\n", 6, "JavaScript: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "JavaScript: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben mit for und while.</p><p>In JavaScript sind Schleifen ein wichtiges Werkzeug, um Arrays zu durchlaufen oder wiederkehrende Aufgaben zu automatisieren.</p>\n", 3, "JavaScript: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Programmieren für das Web.</p><p>JavaScript erweckt Webseiten zum Leben.</p>\n", "javascript", 1, "JavaScript Einführung" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Go arbeitest.</p><p>In Go kannst du Variablen mit <code>var</code> oder der Kurzschreibweise <code>:=</code> deklarieren.</p>\n", 3, "Variablen in Go" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "Go: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Go (Golang).</p><p>In dieser Lektion lernst du die ersten Schritte in Go. Go ist bekannt für seine starke Unterstützung von Nebenläufigkeit und seine schnelle Kompilierung.</p>\n", 1, "Go Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du Daten in Go mit fmt.Scanln einliest.</p><p>In Go bietet das Package <strong><code>fmt</code></strong> einfache Möglichkeiten für Konsoleneingaben.</p>\n<ol>\n<li><strong><code>fmt.Scanln()</code></strong>: Liest bis zum Ende der Zeile. Benötigt einen Pointer (Adresse) auf die Variable.</li>\n<li><strong><code>fmt.Scanf()</code></strong>: Ermöglicht formatiertes Einlesen, ähnlich wie in C.</li>\n<li><strong>bufio</strong>: Für komplexere Eingaben nutzt man oft <code>bufio.NewReader(os.Stdin)</code>, um ganze Sätze mit Leerzeichen zu lesen.</li>\n</ol>\n", "go", "Go: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Verstehe den Unterschied zwischen Werten und Pointern in Go.</p><p>Go ist eine &quot;Call by Value&quot; Sprache. Das bedeutet, es wird immer eine Kopie übergeben.</p>\n<ol>\n<li><strong>Werte übergeben</strong>: Die Funktion erhält eine Kopie des Wertes.</li>\n<li><strong>Pointer übergeben</strong>: Die Funktion erhält eine Kopie der Speicheradresse. Da sie die Adresse kennt, kann sie den Wert an dieser Stelle im Speicher verändern. Dies wird oft als &quot;Call by Reference&quot;-Verhalten bezeichnet, technisch gesehen ist es aber die Übergabe eines Pointer-Wertes.</li>\n</ol>\n", "go", 4, "Go: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C# arbeitest.</p><p>Variablen sind Container zum Speichern von Datenwerten. In C# musst du den Datentyp einer Variable angeben.</p>\n", 5, "Variablen in C#" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne Entscheidungen im Code zu treffen.</p><p>In dieser Lektion lernst du <code>if</code> und <code>else</code> kennen.</p>\n", 2, "Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben effizient.</p><p>Schleifen helfen dir, Aufgaben mehrfach auszuführen.</p>\n", 3, "Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Console.ReadLine() für Eingaben in C# nutzt.</p><p>In C# nutzt du die Klasse <strong><code>Console</code></strong>, um Eingaben zu erhalten.</p>\n<ol>\n<li><strong><code>Console.ReadLine()</code></strong>: Liest eine komplette Zeile als String ein.</li>\n<li><strong><code>Console.Read()</code></strong>: Liest nur ein einzelnes Zeichen als Ganzzahl-Code (ASCII/Unicode).</li>\n<li><strong>Parsing</strong>: Nutze Methoden wie <code>int.Parse()</code> oder <code>Convert.ToInt32()</code>, um Texte in Zahlen zu wandeln.</li>\n</ol>\n", 7, "C#: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von C#.</p><p>In dieser Lektion lernst du die ersten Schritte in C#.</p>\n", "csharp", 1, "C# Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Einsatz von ref und out für Call by Reference in C#.</p><p>In C# werden Werttypen (wie <code>int</code>, <code>bool</code>) standardmäßig per <strong>Call by Value</strong> übergeben.</p>\n<ol>\n<li><strong>ref</strong>: Übergibt eine Referenz auf eine Variable. Die Variable muss vor der Übergabe initialisiert sein.</li>\n<li><strong>out</strong>: Übergibt eine Referenz, aber die Variable muss nicht initialisiert sein. Die Methode <strong>muss</strong> der <code>out</code>-Variable jedoch einen Wert zuweisen.</li>\n<li><strong>Pointer</strong>: C# unterstützt Pointer nur in <code>unsafe</code> Codeblöcken, was für allgemeine Anwendungen selten genutzt wird.</li>\n</ol>\n", "csharp", 6, "C#: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Objektorientierte Programmierung.</p><p>Alles in C# findet in Klassen statt.</p>\n", "csharp", 4, "Klassen & Methoden" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen und Code wiederholen.</p><p>Kontrollstrukturen sind das Herzstück jeder Programmiersprache. In Rust gibt es neben <code>if</code> und <code>else</code> auch mächtige Schleifen-Konstrukte wie <code>loop</code>, <code>while</code> und <code>for</code>.</p>\n", 3, "Rust: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Rust arbeitest.</p><p>In Rust sind Variablen standardmäßig unveränderlich (immutable). Mit <code>let mut</code> kannst du sie veränderbar machen.</p>\n", 4, "Variablen in Rust" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wie liest man Daten von der Tastatur in Rust ein?</p><p>Rust legt großen Wert auf Sicherheit. Daher ist die Standardeingabe etwas ausführlicher als in anderen Sprachen. Das Modul <code>std::io</code> bietet Zugriff auf die Funktionen, um von der Tastatur zu lesen.</p>\n", 2, "Rust: Ein- und Ausgabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Vertiefe dein Wissen über Borrowing und lerne Smart Pointer wie Box kennen.</p><p>Rust erzwingt strikte Regeln für Referenzen zur Kompilierzeit (<strong>Borrow Checker</strong>).</p>\n<ol>\n<li><strong>Immutable Borrowing (<code>&amp;T</code>)</strong>: Beliebig viele Referenzen zum Lesen erlaubt.</li>\n<li><strong>Mutable Borrowing (<code>&amp;mut T</code>)</strong>: Nur eine Referenz zum Schreiben erlaubt.</li>\n<li><strong>Smart Pointer (<code>Box&lt;T&gt;</code>)</strong>: Ermöglicht es, Daten auf dem Heap statt auf dem Stack zu speichern. <code>Box</code> besitzt die Daten und gibt sie automatisch frei.</li>\n</ol>\n", 7, "Rust: Fortgeschrittene Referenzen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Übe die Syntax für Benutzereingaben in Rust, indem du die Lücken füllst.</p><p>In Rust ist das Einlesen von der Konsole explizit. Du brauchst:</p>\n<ol>\n<li>Einen <strong>veränderbaren String</strong> (<code>let mut input = String::new()</code>).</li>\n<li>Den Aufruf von <strong><code>io::stdin().read_line()</code></strong>.</li>\n<li>Eine <strong>veränderbare Referenz</strong> auf deinen String (<code>&amp;mut input</code>).</li>\n<li>Eine Fehlerbehandlung wie <strong><code>.unwrap()</code></strong> oder <code>.expect()</code>.</li>\n</ol>\n", "rust", "Rust: Lückentext Eingabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Rust - Sicher, schnell und modern.</p><p>In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.</p>\n", "rust", 1, "Rust Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Rust Daten sicher per Referenz übergibt.</p><p>In Rust gibt es kein klassisches &quot;Call by Reference&quot; wie in C++, sondern <strong>Borrowing</strong> (Ausleihen).</p>\n<ol>\n<li><strong>Unveränderbares Borrowing (<code>&amp;T</code>)</strong>: Man darf den Wert lesen, aber nicht ändern. Man kann beliebig viele dieser Referenzen gleichzeitig haben.</li>\n<li><strong>Veränderbares Borrowing (<code>&amp;mut T</code>)</strong>: Man darf den Wert ändern. Es darf jedoch immer nur <strong>eine</strong> veränderbare Referenz zur gleichen Zeit existieren (Sicherheit gegen Data Races).</li>\n<li><strong>Ownership</strong>: Wird kein <code>&amp;</code> verwendet, wird der Wert <strong>verschoben</strong> (Move) und die ursprüngliche Variable ist nicht mehr nutzbar.</li>\n</ol>\n", "rust", 6, "Rust: Referenzen und Borrowing" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne den sicheren Umgang mit Raw Pointern und modernen Smart Pointern in C++.</p><p>In modernem C++ (ab C++11) solltest du <strong>Smart Pointer</strong> gegenüber Raw Pointern bevorzugen, um Speicherlecks zu vermeiden.</p>\n<ol>\n<li><strong>Raw Pointer (<code>T*</code>)</strong>: Speichert eine nackte Speicheradresse. Du musst dich selbst um <code>delete</code> kümmern.</li>\n<li><strong><code>std::unique_ptr&lt;T&gt;</code></strong>: Exklusives Eigentum. Der Speicher wird automatisch freigegeben, wenn der Pointer out-of-scope geht.</li>\n<li><strong><code>std::shared_ptr&lt;T&gt;</code></strong>: Gemeinsames Eigentum. Nutzt Reference Counting.</li>\n</ol>\n", 5, "C++: Pointer und Smart Pointer" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C++ arbeitest.</p><p>C++ ist eine objektorientierte Erweiterung von C und bietet komfortable Typen wie <code>std::string</code>.</p>\n", 3, "Variablen in C++" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du std::cin für Eingaben in C++ nutzt.</p><p>In C++ nutzt du den Input-Stream <strong><code>std::cin</code></strong>.</p>\n<ol>\n<li><strong>Extraktionsoperator (<code>&gt;&gt;</code>)</strong>: Die Daten werden aus dem Stream extrahiert und in die Variable geschrieben.</li>\n<li><strong>Mehrere Eingaben</strong>: Du kannst <code>std::cin &gt;&gt; a &gt;&gt; b;</code> nutzen, um zwei Werte nacheinander zu lesen.</li>\n</ol>\n", "cpp", 6, "C++: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Language", "Title" },
                values: new object[] { "cpp", "C++: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", "cpp", "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value, Call by Reference und Call by Pointer.</p><p>In C++ gibt es drei Hauptarten, wie Daten an Funktionen übergeben werden können:</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie erstellt. Änderungen in der Funktion haben keine Auswirkung auf das Original.</li>\n<li><strong>Call by Reference</strong>: Die Funktion erhält direkten Zugriff auf das Original (Alias). Änderungen wirken sich sofort aus. Syntax: <code>Type&amp; name</code>.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse der Variable wird übergeben. Die Funktion greift über Dereferenzierung (<code>*</code>) auf das Original zu. Syntax: <code>Type* name</code> und beim Aufruf <code>&amp;variable</code>.</li>\n</ol>\n", "cpp", "C++: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in PHP arbeitest.</p><p>PHP ist eine schwach typisierte Sprache. Variablen werden mit einem Dollarzeichen ($) eingeleitet.</p>\n", "php", "Variablen in PHP" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Language", "Title" },
                values: new object[] { "php", "PHP: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die serverseitige Programmierung mit PHP.</p><p>In dieser Lektion lernst du die Grundlagen von PHP kennen. PHP-Code wird auf dem Server ausgeführt und das Ergebnis wird als HTML an den Browser gesendet.</p>\n", "php", "PHP Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Daten in PHP von STDIN einliest.</p><p>In PHP nutzt du oft die vordefinierte Konstante <strong><code>STDIN</code></strong> für Eingaben.</p>\n<ol>\n<li><strong><code>fgets(STDIN)</code></strong>: Liest eine Zeile von der Standard-Eingabe.</li>\n<li><strong><code>trim()</code></strong>: Wichtig, da die Eingabe meist das Zeichen für das Zeilenende (<code>\\n</code>) enthält.</li>\n</ol>\n", "php", 5, "PHP: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Reference in PHP.</p><p>In PHP werden Variablen standardmäßig als <strong>Call by Value</strong> übergeben.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie der Variable erstellt.</li>\n<li><strong>Call by Reference</strong>: Nutzt man ein <code>&amp;</code> vor dem Parameternamen in der Funktionsdefinition, wird eine Referenz auf die Originalvariable übergeben. Änderungen wirken sich direkt aus.</li>\n</ol>\n", "php", "PHP: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C arbeitest.</p><p>In C musst du Datentypen explizit angeben. Für Booleans musst du <code>&lt;stdbool.h&gt;</code> einbinden.</p>\n", "c", 3, "Variablen in C" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "c", "C: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", "c", 1, "C Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du scanf für Eingaben in C nutzt.</p><p>In C ist <strong><code>scanf</code></strong> die Standardfunktion zum Einlesen von formatierten Daten.</p>\n<ol>\n<li><strong>Format-String</strong>: <code>%d</code> für Integer, <code>%f</code> für Float, etc.</li>\n<li><strong>Adressoperator (<code>&amp;</code>)</strong>: <code>scanf</code> benötigt die Speicheradresse der Variable, in die der Wert geschrieben werden soll.</li>\n</ol>\n", "c", 5, "C: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Pointer in C.</p><p>In C gibt es (im Gegensatz zu C++) kein echtes &quot;Call by Reference&quot;. Stattdessen nutzt man Pointer, um ähnliche Effekte zu erzielen.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie des Wertes an die Funktion übergeben. Änderungen betreffen nur die Kopie.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse einer Variable wird übergeben. Die Funktion kann über diese Adresse direkt auf den Speicher des Aufrufers zugreifen und den Wert ändern.</li>\n</ol>\n", "c", "C: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Python arbeitest.</p><p>In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.</p>\n", "python", 4, "Variablen in Python" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie Python mit Referenzen und veränderlichen Objekten umgeht.</p><p>Python nutzt ein Modell namens <strong>Pass-by-Object-Reference</strong>.</p>\n<ol>\n<li><strong>Unveränderliche Typen (<code>int</code>, <code>str</code>, <code>tuple</code>)</strong>: Da diese nicht geändert werden können, verhält es sich wie <strong>Call by Value</strong>. Jede &quot;Änderung&quot; erzeugt ein neues Objekt lokal in der Funktion.</li>\n<li><strong>Veränderliche Typen (<code>list</code>, <code>dict</code>, <code>set</code>)</strong>: Die Referenz wird übergeben. Änderungen am Objekt (z.B. <code>.append()</code>) wirken sich direkt auf das Original aus.</li>\n</ol>\n", "python", "Python: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", "python", "Python: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du Code-Blöcke wiederholst.</p><p>Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet <code>for</code> für bekannte Iterationen und <code>while</code> für bedingte Wiederholungen.</p>\n", "python", "Python: Schleifen" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[,]
                {
                    { 145, "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", 1, "Python Grundlagen" },
                    { 146, "<p>Lerne, wie du Daten von der Konsole einliest.</p><p>In Python nutzt du die Funktion <strong><code>input()</code></strong>, um Daten vom Benutzer zu erhalten.</p>\n<ol>\n<li><strong>Standard</strong>: <code>input()</code> gibt immer einen String zurück.</li>\n<li><strong>Konvertierung</strong>: Wenn du mit Zahlen rechnen möchtest, musst du das Ergebnis explizit umwandeln (z.B. <code>int(input())</code> oder <code>float(input())</code>).</li>\n</ol>\n", "python", 5, "Python: Benutzereingaben" },
                    { 147, "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", "java", 4, "Variablen in Java" },
                    { 148, "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", 1, "Java Einstieg" },
                    { 149, "<p>Verstehe den Unterschied zwischen Primitiven und Objekten in Java.</p><p>In Java gibt es oft Diskussionen über &quot;Call by Reference&quot;. Die Wahrheit ist: <strong>Java ist immer Call by Value.</strong></p>\n<ol>\n<li><strong>Primitive Typen (<code>int</code>, <code>double</code>, etc.)</strong>: Es wird eine Kopie des eigentlichen Wertes übergeben.</li>\n<li><strong>Objekt-Referenzen</strong>: Es wird eine Kopie der <strong>Adresse</strong> des Objekts übergeben. Deshalb kannst du Attribute des Objekts in einer Methode ändern, aber du kannst nicht die ursprüngliche Variable auf ein komplett neues Objekt zeigen lassen.</li>\n</ol>\n", "java", 5, "Java: Parameterübergabe" },
                    { 150, "<p>Lerne, wie du die Scanner-Klasse für Eingaben in Java nutzt.</p><p>In Java ist die Klasse <strong><code>java.util.Scanner</code></strong> der einfachste Weg für Konsoleneingaben.</p>\n<ol>\n<li><strong>Instanziierung</strong>: <code>Scanner sc = new Scanner(System.in);</code>.</li>\n<li><strong>Methoden</strong>: <code>next()</code> für Strings, <code>nextInt()</code> für Ganzzahlen, <code>nextDouble()</code> für Kommazahlen.</li>\n<li><strong>Puffer</strong>: Beachte, dass <code>nextInt()</code> oft einen Zeilenumbruch im Puffer lässt.</li>\n</ol>\n", "java", 6, "Java: Benutzereingaben" },
                    { 151, "<p>Entscheidungen treffen mit if und else.</p>", "java", 2, "Java: Kontrollstrukturen" },
                    { 152, "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", "java", 3, "Java: Schleifen" }
                });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `fs.readFileSync(0)` für synchrones Einlesen von der Konsole.", "Eingabe war: JS", "const fs = require('fs');\n// Lese von stdin\nlet input = fs.readFileSync(0).toString().trim();\nconsole.log(\"Eingabe war: \" + input);\n", "readFileSync", "const fs = require('fs');\nlet input = fs.readFileSync(0).toString().trim();\nconsole.log(\"Eingabe war: \" + input);\n", "readline: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Welches Modul wird für den Zugriff auf das Dateisystem und stdin benötigt?", "Gelesen!", "const fs = ____('fs');\n\nlet data = fs.readFileSync(0);\nconsole.log(\"Gelesen!\");\n", 102, 2, "require", "const fs = require('fs');\nlet data = fs.readFileSync(0);\nconsole.log(\"Gelesen!\");\n", "Lückentext: fs Modul" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "let zahl = -5;\n// Dein Code hier\n", 1, "if,else", "let zahl = -5;\nif (zahl > 0) {\n    console.log(\"Positiv\");\n} else {\n    console.log(\"Negativ\");\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "// Dein Code hier\n", "for", "for (let i = 1; i <= 5; i++) {\n    console.log(i);\n}\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "let summe = 0;\nlet i = 1;\n// Dein Code hier\n", "while", "let summe = 0;\nlet i = 1;\nwhile (i < 5) {\n    summe += i;\n    i++;\n}\nconsole.log(summe);\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in JavaScript.", "Hallo Welt!", "console.log();", "javascript", "console.log", "console.log(\"Hallo Welt!\");", "JS: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine Funktion 'begruessung', die 'Hallo' zurückgibt.", "Hallo", "function begruessung() {\n    // Dein Code hier\n}\nconsole.log(begruessung());", "javascript", "function,return", null, "JS: Funktionen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Description", "ExpectedOutput", "LessonId", "Order", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", 106, 1, "package main\n\nimport \"fmt\"\n\nfunc main() {\n    var a int = 10\n    b := 5\n    fmt.Println(a + b)\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", 106, 2, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    a := 2.5\n    b := 5.0\n    fmt.Println(a * b)\n}", "Gleitkommazahlen (float64)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei Strings in Go.", "Hallo Welt", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", 3, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    s1 := \"Hallo \"\n    s2 := \"Welt\"\n    fmt.Println(s1 + s2)\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    // Dein Code\n}", 106, 4, "if,fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    if isActive {\n        fmt.Println(\"Wahr\")\n    } else {\n        fmt.Println(\"Falsch\")\n    }\n}", "Booleans (bool)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    // Dein Code hier\n}\n", 1, "if,else", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    if zahl > 0 {\n        fmt.Print(\"Positiv\")\n    } else {\n        fmt.Print(\"Negativ\")\n    }\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Go ist eine bei Google entwickelte Open-Source-Programmiersprache, die sich durch Effizienz und Einfachheit auszeichnet.", "", "", null, null, "Was ist Go?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}\n", "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    fmt.Println(\"Hallo Welt!\")\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `fmt.Scanln`, um einen String einzulesen. Übergib die Adresse der Variable mit `&`.", "Gelesen: Go", "package main\nimport \"fmt\"\n\nfunc main() {\n    var input string\n    // Nutze fmt.Scanln\n    fmt.Scanln(&input)\n    fmt.Print(\"Gelesen: \" + input)\n}\n", 109, 1, "Scanln,&input", "package main\nimport \"fmt\"\n\nfunc main() {\n    var input string\n    fmt.Scanln(&input)\n    fmt.Print(\"Gelesen: \" + input)\n}\n", "Scanln: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Welches Zeichen wird benötigt, um die Adresse einer Variable an Scanln zu übergeben?", "OK", "package main\nimport \"fmt\"\n\nfunc main() {\n    var x int\n    fmt.Scanln(__x) // Lücke füllen\n    fmt.Print(\"OK\")\n}\n", "go", 2, "&x", "package main\nimport \"fmt\"\n\nfunc main() {\n    var x int\n    fmt.Scanln(&x)\n    fmt.Print(\"OK\")\n}\n", "Lückentext: Adressoperator in Go" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `updateName`, sodass sie den Namen lokal ändert, aber das Original in `main` unverändert bleibt.", "Original", "package main\nimport \"fmt\"\n\nfunc updateName(n string) {\n    // Name ändern\n    n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateName(name)\n    fmt.Print(name)\n}\n", "go", 110, 1, "n = \"Geändert\"", "package main\nimport \"fmt\"\n\nfunc updateName(n string) {\n    n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateName(name)\n    fmt.Print(name)\n}\n", "Call by Value in Go" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*string`), um den Wert des Originals zu verändern.", "Geändert", "package main\nimport \"fmt\"\n\nfunc updateNamePtr(n *string) {\n    // Ändere den Wert, auf den der Pointer zeigt\n    *n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    // Übergebe die Adresse mit &\n    updateNamePtr(&name)\n    fmt.Print(name)\n}\n", "go", 110, 2, "*string,*n,&name", "package main\nimport \"fmt\"\n\nfunc updateNamePtr(n *string) {\n    *n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateNamePtr(&name)\n    fmt.Print(name)\n}\n", "Call by Pointer in Go" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um eine Zahl per Pointer zu verdoppeln.", "20", "package main\nimport \"fmt\"\n\nfunc double(n ___int) { // Pointer-Typ\n    ___n = ___n * 2     // Dereferenzierung\n}\n\nfunc main() {\n    x := 10\n    double(___x)        // Adresse übergeben\n    fmt.Print(x)\n}\n", "go", 110, 3, "*int,*n,&x", "package main\nimport \"fmt\"\n\nfunc double(n *int) {\n    *n = *n * 2\n}\n\nfunc main() {\n    x := 10\n    double(&x)\n    fmt.Print(x)\n}\n", "Lückentext: Pointer-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", 111, "int,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int a = 10;\n		int b = 5;\n		Console.WriteLine(a + b);\n	}\n}", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie mit einer anderen Zahl und gib das Ergebnis aus.", "12.5", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", 2, "double,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		double a = 2.5;\n		double b = 5.0;\n		Console.WriteLine(a * b);\n	}\n}", "Gleitkommazahlen (Double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verknüpfe zwei Strings und gib sie aus.", "Hallo Welt", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", 111, 3, "string,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		string s1 = \"Hallo \";\n		string s2 = \"Welt\";\n		Console.WriteLine(s1 + s2);\n	}\n}", "Zeichenketten (String)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende eine bool-Variable in einer if-Anweisung, um 'Wahr' auszugeben, wenn sie true ist, sonst 'Falsch'.", "Wahr", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		// Dein Code\n	}\n}", 111, 4, "bool,if,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		if (isActive)\n		{\n			Console.WriteLine(\"Wahr\");\n		}\n		else\n		{\n			Console.WriteLine(\"Falsch\");\n		}\n	}\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", 112, "if,else", null, "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Berechne die Summe der Zahlen 1 bis 5.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", 1, "for", null, "For-Schleife: Summe" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies einen Namen mit `Console.ReadLine()` ein.", "Hallo CSharp", "using System;\n\npublic class Program {\n    public static void Main() {\n        // Lese von der Konsole\n        string name = Console.ReadLine();\n        Console.Write(\"Hallo \" + name);\n    }\n}\n", 114, 1, "Console.ReadLine", "using System;\n\npublic class Program {\n    public static void Main() {\n        string name = Console.ReadLine();\n        Console.Write(\"Hallo \" + name);\n    }\n}\n", "ReadLine: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Wandle die Eingabe mit `int.Parse()` in eine Zahl um.", "20", "using System;\n\npublic class Program {\n    public static void Main() {\n        string s = Console.ReadLine();\n        // Lücke: int x = ___.Parse(s);\n        int x = ___.Parse(s);\n        Console.Write(x * 2);\n    }\n}\n", 2, "int.Parse", "using System;\n\npublic class Program {\n    public static void Main() {\n        string s = Console.ReadLine();\n        int x = int.Parse(s);\n        Console.Write(x * 2);\n    }\n}\n", null, "Lückentext: String zu Zahl", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C# ist eine objektorientierte Sprache von Microsoft.", "", "", "csharp", null, null, "Was ist C#?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", "Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		Console.WriteLine(\"Hallo Welt!\");\n	}\n}", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `ref`-Keyword, um den Wert der Variable `zahl` in der Methode `Verdopple` zu ändern.", "10", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        // Nutze ref auch beim Aufruf\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", "csharp", 116, 1, "ref int,ref zahl", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das ref Keyword" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `out`-Keyword, um einen Wert von einer Methode zurückzugeben, ohne den Rückgabewert zu nutzen.", "42", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        // out Variablen MÜSSEN in der Methode zugewiesen werden\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", "csharp", 2, "out int,out zahl", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das out Keyword" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `ref` oder `out`.", "x=2,y=1", "using System;\n\npublic class Program\n{\n    static void Swap(____ int a, ____ int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(____ x, ____ y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", "csharp", 3, "ref int,ref x", "using System;\n\npublic class Program\n{\n    static void Swap(ref int a, ref int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(ref x, ref y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", "Lückentext: C# Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'.", "", "public class Calculator \n{\n    // Hier deine Methode\n}", "csharp", 117, 1, "class,Calculator,static,int", null, "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Zahl `x` größer als 10 ist. Gib 'Groß' aus, ansonsten 'Klein'.", "Groß", "fn main() {\n    let x = 15;\n    // Dein Code hier\n}\n", 118, 1, "if,else", "fn main() {\n    let x = 15;\n    if x > 10 {\n        println!(\"Groß\");\n    } else {\n        println!(\"Klein\");\n    }\n}\n", "Einfaches if/else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { null, null, "Rust hat eine endlose Schleife namens `loop`. Nutze `break`, um sie zu verlassen, wenn `i` den Wert 5 erreicht hat. Gib `i` in jedem Durchgang aus.", "0\n1\n2\n3\n4\n5", "fn main() {\n    let mut i = 0;\n    loop {\n        // Dein Code hier\n        i += 1;\n    }\n}\n", 118, 2, "loop,break", "fn main() {\n    let mut i = 0;\n    loop {\n        println!(\"{}\", i);\n        if i == 5 {\n            break;\n        }\n        i += 1;\n    }\n}\n", "Die `loop` Schleife", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while` Schleife, um die Zahlen von 3 bis 1 (herunterzählend) auszugeben.", "3\n2\n1", "fn main() {\n    let mut n = 3;\n    // Dein Code hier\n}\n", 118, 3, "while", "fn main() {\n    let mut n = 3;\n    while n > 0 {\n        println!(\"{}\", n);\n        n -= 1;\n    }\n}\n", "While Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine i32-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "fn main() {\n    // Dein Code\n}", 119, 1, "let,println!", "fn main() {\n    let a: i32 = 10;\n    let b: i32 = 5;\n    println!(\"{}\", a + b);\n}", "Ganzzahlen (i32)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine f64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "fn main() {\n    // Dein Code\n}", 119, 2, "f64,println!", "fn main() {\n    let a: f64 = 2.5;\n    let b: f64 = 5.0;\n    println!(\"{}\", a * b);\n}", "Gleitkommazahlen (f64)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "fn main() {\n    // Dein Code\n}", 119, 3, "String,println!", "fn main() {\n    let s1 = String::from(\"Hallo \");\n    let s2 = \"Welt\";\n    println!(\"{}{}\", s1, s2);\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "fn main() {\n    let is_active = true;\n    // Dein Code\n}", 119, 4, "bool,if,println!", "fn main() {\n    let is_active = true;\n    if is_active {\n        println!(\"Wahr\");\n    } else {\n        println!(\"Falsch\");\n    }\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "[\"Damit sie schneller geladen wird\", \"Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen\", \"Um anzuzeigen, dass es ein String ist\", \"Das mut ist optional\"]", "Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen", "Warum muss die Variable für die Eingabe mit `mut` deklariert werden (z.B. `let mut input`)?", "", "", 120, 1, null, null, "Anatomie der Eingabe", 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust nutzt man `std::io::stdin()`, um Eingaben einzulesen. <br>Lies einen Namen von der Tastatur ein und gib 'Hallo [Name]!' aus. <br>Hinweis: Tippe in das Eingabefeld rechts das Wort 'Rust' ein, bevor du auf Ausführen klickst.", "Hallo Rust!", "use std::io;\n\nfn main() {\n    let mut input = String::new(); // Erstellt einen Puffer\n    \n    // Deine Aufgabe: Nutze io::stdin().read_line(&mut input).unwrap();\n    \n    println!(\"Hallo {}!\", input.trim());\n}\n", 120, 2, "read_line", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    println!(\"Hallo {}!\", input.trim());\n}\n", "Einen String einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies eine Zahl von der Tastatur ein, verdopple sie und gib das Ergebnis aus. <br>Hinweis: Nutze `.trim().parse::<i32>().unwrap()`, um den String in eine Zahl zu wandeln. <br>Tippe die Zahl '21' in das Eingabefeld.", "Ergebnis: 42", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    // Deine Aufgabe: Wandle 'input' in eine Zahl 'n' um\n    // let n: i32 = ...\n    \n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", 120, "parse", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let n: i32 = input.trim().parse().unwrap();\n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "Zahl einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies zwei Zahlen nacheinander ein und gib deren Summe aus. <br>Wichtig: Das Eingabefeld unterstützt aktuell nur eine Zeile. Trenne deine beiden Zahlen im Eingabefeld mit einem Leerzeichen (z.B. '10 5').", "Summe: 15", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    \n    println!(\"Summe: {}\", a + b);\n}\n", 120, "split_whitespace", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    println!(\"Summe: {}\", a + b);\n}\n", "Zwei Zahlen addieren" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust kannst du viele unveränderbare Referenzen haben, aber nur eine veränderbare. Fülle die Lücken, um den Wert zu lesen und zu schreiben.", "Lesen: 10\nNeu: 20", "fn main() {\n    let mut data = 10;\n    \n    let r1 = &data; // Immutable\n    println!(\"Lesen: {}\", r1);\n    \n    // Lücke: Erstelle eine veränderbare Referenz\n    let r2 = ________;\n    *r2 += 10;\n    \n    println!(\"Neu: {}\", data);\n}\n", 121, 1, "&mut data,*r2", "fn main() {\n    let mut data = 10;\n    let r1 = &data;\n    println!(\"Lesen: {}\", r1);\n    \n    let r2 = &mut data;\n    *r2 += 10;\n    println!(\"Neu: {}\", data);\n}\n", "Immutable vs Mutable" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze `Box<T>`, um einen Wert auf dem Heap zu speichern. Vervollständige die Zeile mit `Box::new()`.", "Heap Wert: 50", "fn main() {\n    // Speichere die Zahl 50 auf dem Heap\n    let heap_val = Box::new(50);\n    \n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", 121, 2, "Box::new,*heap_val", "fn main() {\n    let heap_val = Box::new(50);\n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", "Box: Smart Pointer auf dem Heap", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Referenzen können automatisch dereferenziert werden. Übergebe eine Referenz an eine Funktion, die einen primitiven Typ erwartet.", "Zahl: 42", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    // Übergebe den Wert hinter der Referenz\n    print_int(*r);\n}\n", 121, 3, "*r", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    print_int(*r);\n}\n", "Deref Coercion" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Zeile, um einen neuen, leeren String-Puffer zu erstellen. <br>Nutze `String::new()`.", "Puffer bereit.", "fn main() {\n    // Vervollständige: let mut input = ...\n    let mut input = ___________;\n    \n    println!(\"Puffer bereit.\");\n}\n", 122, "String::new", "fn main() {\n    let mut input = String::new();\n    println!(\"Puffer bereit.\");\n}\n", "Lücke: Den Puffer erstellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`.", "Bitte etwas tippen:\nGelesen!", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    \n    // Lücke: io::stdin().read_line(____ buffer).unwrap();\n    io::stdin().read_line(____ buffer).unwrap();\n    \n    println!(\"Gelesen!\");\n}\n", 122, "&mut", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    io::stdin().read_line(&mut buffer).unwrap();\n    println!(\"Gelesen!\");\n}\n", "Lücke: Die Referenz" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`.", "", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    \n    // Lücke: ____::stdin().read_line(&mut input).unwrap();\n    ____::stdin().read_line(&mut input).unwrap();\n}\n", 122, "io::stdin", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n}\n", "Lücke: Das Modul aufrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe die komplette Zeile, um eine Eingabe in die Variable `text` einzulesen. <br>Vergiss das `.unwrap()` am Ende nicht!", "Eingabe erfolgt.", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    \n    // Schreibe hier die komplette read_line Zeile:\n    \n    println!(\"Eingabe erfolgt.\");\n}\n", "rust", 4, "read_line,&mut,unwrap", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    io::stdin().read_line(&mut text).unwrap();\n    println!(\"Eingabe erfolgt.\");\n}\n", "Lücke: Alles zusammen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", "rust", 123, 1, null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", "rust", 123, 2, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `laenge`, sodass sie die Länge eines Strings berechnet, ohne den Besitz (Ownership) zu übernehmen.", "Die Länge von 'Hallo' ist 5.", "fn laenge(s: &String) -> usize {\n    // Berechne die Länge\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    // Übergebe eine Referenz mit &\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "rust", 124, "&String,&s1", "fn laenge(s: &String) -> usize {\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "Unveränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `&mut`, um den Inhalt eines Strings in einer Funktion zu verändern.", "Hallo, Welt", "fn aendern(s: &mut String) {\n    // Füge Text an\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    // Übergebe eine veränderbare Referenz mit &mut\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "rust", 124, "&mut String,&mut s", "fn aendern(s: &mut String) {\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "Veränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `&` oder `&mut`.", "Lesen: Daten\nDaten...geändert", "fn main() {\n    let ___ s = String::from(\"Daten\");\n    \n    process_read(___s);  // Nur Lesen\n    process_write(___s); // Schreiben\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: ___String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: ___String) {\n    s.push_str(\"...geändert\");\n}\n", "rust", 124, "&s,&mut s,&String,&mut String", "fn main() {\n    let mut s = String::from(\"Daten\");\n    \n    process_read(&s);\n    process_write(&mut s);\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: &String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: &mut String) {\n    s.push_str(\"...geändert\");\n}\n", "Lückentext: Rust Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um die Adresse von `zahl` in einem Raw Pointer zu speichern und den Wert darüber auszugeben.", "Wert: 100", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    // Lücke: int* ptr = ...\n    int* ptr = ________;\n    \n    // Lücke: Wert über Pointer ausgeben (Dereferenzierung)\n    std::cout << \"Wert: \" << ________;\n    return 0;\n}\n", 125, 1, "&zahl,*ptr", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    int* ptr = &zahl;\n    std::cout << \"Wert: \" << *ptr;\n    return 0;\n}\n", "Raw Pointer: Adresse abrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `std::unique_ptr`, um Speicher auf dem Heap sicher zu verwalten. Erstelle einen `unique_ptr<int>` mit `std::make_unique`.", "Smart Wert: 42", "#include <iostream>\n#include <memory>\n\nint main() {\n    // Erstelle einen unique_ptr für den Wert 42\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    \n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", 125, 2, "unique_ptr,make_unique", "#include <iostream>\n#include <memory>\n\nint main() {\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", "Smart Pointer: unique_ptr" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Ein `shared_ptr` erlaubt es mehreren Pointern, denselben Speicher zu besitzen. Erstelle einen `shared_ptr` und gib den `use_count()` aus.", "Count: 2", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        // Erstelle eine Kopie von p1\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", 3, "make_shared,use_count", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "Smart Pointer: shared_ptr", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus.", "15", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 126, 1, "int,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 2, "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'string', um zwei Texte zu verknüpfen.", "Hallo Welt", "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 3, "string,cout", "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "#include <iostream>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", 4, "bool,if,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        cout << \"Wahr\";\n    } else {\n        cout << \"Falsch\";\n    }\n    return 0;\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `std::cin` mit dem `>>` Operator, um eine Zahl einzulesen.", "Gelesen: 42", "#include <iostream>\n\nint main() {\n    int zahl;\n    // Nutze cin zum Einlesen\n    std::cin >> zahl;\n    std::cout << \"Gelesen: \" << zahl;\n    return 0;\n}\n", 127, 1, "cin >>", "#include <iostream>\n\nint main() {\n    int zahl;\n    std::cin >> zahl;\n    std::cout << \"Gelesen: \" << zahl;\n    return 0;\n}\n", "std::cin: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Welcher Operator wird für Eingaben mit `cin` verwendet?", "OK", "#include <iostream>\n\nint main() {\n    int x;\n    std::cin __ x; // Lücke füllen\n    std::cout << \"OK\";\n    return 0;\n}\n", "cpp", 2, ">>", "#include <iostream>\n\nint main() {\n    int x;\n    std::cin >> x;\n    std::cout << \"OK\";\n    return 0;\n}\n", "Lückentext: cin Operator" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 128, 1, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "", "", "cpp", 129, 1, null, null, "Was ist C++?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 129, 2, "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt (Call by Value).", "Wert nach Funktion: 5", "#include <iostream>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 130, "x = x * 2", "#include <iostream>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine Referenz (`&`), um den Wert der Originalvariable in der Funktion `verdoppleRef` dauerhaft zu ändern.", "Geänderter Wert: 10", "#include <iostream>\n\n// Nutze & für Call by Reference\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 130, 2, "int&", "#include <iostream>\n\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Reference", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Wert über Pointer: 10", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 130, 3, "int*,&zahl", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Pointer" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit der richtigen Syntax für Pointer und Referenzen.", "x=2, y=1", "#include <iostream>\n\nvoid swap(int__ a, int__ b) { // Nutze & für Referenzen\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=\" << x << \", y=\" << y;\n    return 0;\n}\n", "cpp", 4, "int&", "#include <iostream>\n\nvoid swap(int& a, int& b) {\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=2, y=1\";\n    return 0;\n}\n", "Lückentext: Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In PHP beginnen Variablen mit einem $. Addiere zwei Zahlen und gib das Ergebnis mit echo aus.", "15", "<?php\n// Dein Code", 131, 1, "echo,$", "<?php\n$a = 10;\n$b = 5;\necho $a + $b;", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Multipliziere zwei Gleitkommazahlen und gib das Ergebnis aus.", "12.5", "<?php\n// Dein Code", 131, 2, "echo", "<?php\n$a = 2.5;\n$b = 5.0;\necho $a * $b;", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings werden in PHP mit dem Punkt (.) verknüpft.", "Hallo Welt", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\n// Dein Code", "php", 3, "echo,.", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\necho $s1 . $s2;", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "<?php\n$isActive = true;\n// Dein Code", "php", 4, "if,echo", "<?php\n$isActive = true;\nif ($isActive) {\n    echo \"Wahr\";\n} else {\n    echo \"Falsch\";\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable '$zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "<?php\n$zahl = -5;\n// Dein Code hier\n?>\n", "php", 132, 1, "if,else", "<?php\n$zahl = -5;\nif ($zahl > 0) {\n    echo \"Positiv\";\n} else {\n    echo \"Negativ\";\n}\n?>\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "", "", "php", 133, 1, null, null, "Was ist PHP?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "<?php\n// Dein Code hier\n", "php", 133, 2, "echo", "<?php\necho \"Hallo Welt!\";\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze `fgets(STDIN)`, um eine Eingabe zu erhalten.", "Du hast gesagt: PHP", "<?php\n// Lese von der Standard-Eingabe\n$input = fgets(STDIN);\necho \"Du hast gesagt: \" . trim($input);\n", "php", 134, "fgets,STDIN", "<?php\n$input = fgets(STDIN);\necho \"Du hast gesagt: \" . trim($input);\n", "STDIN: Einlesen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Eingaben enthalten oft einen Zeilenumbruch. Welche Funktion entfernt diesen?", "Text", "<?php\n$s = \"Text\\n\";\n// Lücke: $s = ____($s);\n$s = ____($s);\necho $s;\n", "php", 134, "trim", "<?php\n$s = \"Text\\n\";\n$s = trim($s);\necho $s;\n", "Lückentext: trim Funktion" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Originalwert: 5", "<?php\n\nfunction verdopple($zahl) {\n    // Ändere den Wert lokal\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", "php", 135, "$zahl = $zahl * 2", "<?php\n\nfunction verdopple($zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", "Call by Value in PHP" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das Ampersand-Zeichen (`&`) in der Parameterliste, um den Wert des Originals zu verändern.", "<?php\n\n// Nutze & vor der Variable\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", "php", 135, "&$zahl", "<?php\n\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", "Call by Reference in PHP" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um eine Referenz an die Funktion zu übergeben.", "11", "<?php\n\nfunction addOne(____$n) { // Ampersand hier einfügen\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", "php", 135, "&$n", "<?php\n\nfunction addOne(&$n) {\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", "Lückentext: Referenz-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 136, "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 136, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 136, "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "c", 136, "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", 137, "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", "c", 138, 1, null, null, "Was ist C?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 138, 2, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies eine Ganzzahl mit `scanf` ein und gib sie aus.", "Zahl: 100", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    // scanf nutzt %d und den Adressoperator &\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", "c", 139, 1, "scanf,&zahl", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", "scanf: Ganzzahlen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Bei `scanf` musst du immer die Adresse der Variable angeben. Welches Zeichen wird dafür benötigt?", "OK", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", __x); // Lücke füllen\n    printf(\"OK\");\n    return 0;\n}\n", "c", 139, 2, "&x", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", &x);\n    printf(\"OK\");\n    return 0;\n}\n", "Lückentext: Adressoperator" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Wert nach Funktion: 5", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "c", 140, 1, "x = x * 2", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "Call by Value in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Geänderter Wert: 10", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl mit &\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "c", 140, 2, "int *,*x,&zahl", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "Call by Pointer in C", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen.", "x=2, y=1", "#include <stdio.h>\n\nvoid swap(int ____ a, int ____ b) {\n    int temp = ____ a;\n    ____ a = ____ b;\n    ____ b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=%d, y=%d\", x, y);\n    return 0;\n}\n", "c", 140, 3, "int *,* a,* b", "#include <stdio.h>\n\nvoid swap(int * a, int * b) {\n    int temp = * a;\n    * a = * b;\n    * b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=2, y=1\");\n    return 0;\n}\n", "Lückentext: Pointer-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "# Dein Code hier", "python", 141, "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "# Dein Code hier", "python", 141, "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "# Dein Code hier", "python", 141, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "is_active = True\n# Dein Code", "python", 141, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "def verdopple(x):\n    # x lokal verdoppeln\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "python", 142, "x = x * 2", "def verdopple(x):\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "Unveränderliche Typen (Integers)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden.", "Python", "def add_element(liste):\n    # Füge \"Python\" zur Liste hinzu\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "python", 142, "append", "def add_element(liste):\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "Veränderliche Typen (Listen)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", 143, 1, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", null, "Logik: Positiv/Negativ", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", 143, 2, "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", "python", 144, 1, "for,in,range", "for i in range(1, 6):\n    print(i)\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", "python", 144, 2, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", 145, null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", 145, "print", "print(\"Hallo Welt!\")\n", "Hallo Welt" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1114, null, null, "Nutze `input()`, um einen Namen einzulesen und gib 'Hallo [Name]' aus. <br>Hinweis: Tippe deinen Namen in das Eingabefeld rechts unten.", "Hallo Python", "# Lese den Namen ein\nname = input()\nprint(\"Hallo \" + name)\n", "python", 146, 1, null, "input", "name = input()\nprint(\"Hallo \" + name)\n", null, "input() Grundlagen", 1 },
                    { 1115, null, null, "Eingaben von `input()` sind immer Strings. Wandle die Eingabe in ein `int` um, um damit zu rechnen.", "20", "# Lücke: zahl = ___(input())\nzahl = ___(input())\nprint(zahl * 2)\n", "python", 146, 2, null, "int", "zahl = int(input())\nprint(zahl * 2)\n", null, "Lückentext: Typumwandlung", 1 },
                    { 1116, null, null, "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 147, 1, null, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", null, "Ganzzahlen (int)", 1 },
                    { 1117, null, null, "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 147, 2, null, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", null, "Gleitkommazahlen (double)", 1 },
                    { 1118, null, null, "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 147, 3, null, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", null, "Zeichenketten (String)", 1 },
                    { 1119, null, null, "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", "java", 147, 4, null, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", null, "Booleans (boolean)", 1 },
                    { 1120, null, null, "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", 148, 1, null, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", null, "Java: Hallo Welt", 1 },
                    { 1121, null, null, "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 148, 2, null, "if", null, null, "Java: If-Else", 1 },
                    { 1122, null, null, "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 148, 3, null, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 },
                    { 1123, null, null, "Versuche den Wert von `x` in der Methode `verdopple` zu ändern. Bleibt das Original in `main` gleich?", "5", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "java", 149, 1, null, "x = x * 2", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", null, "Primitive: Pass by Value", 1 },
                    { 1124, null, null, "In Java werden Objektreferenzen per Wert übergeben. Du kannst das Objekt verändern, aber nicht die Referenz selbst.", "Java", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        // Füge ein Element hinzu\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "java", 149, 2, null, "list.add", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", null, "Objekte: Referenz ändern", 1 },
                    { 1125, null, null, "Nutze die `Scanner`-Klasse, um einen Namen einzulesen.", "Hallo Java", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        // Erstelle einen Scanner\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", "java", 150, 1, null, "Scanner,System.in", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", null, "Scanner: Einlesen", 1 },
                    { 1126, null, null, "Welche Methode des Scanners liest die nächste Ganzzahl ein?", "42", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        // Lücke: int x = sc.____();\n        int x = sc.____();\n        System.out.print(x);\n    }\n}\n", "java", 150, 2, null, "nextInt", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        int x = sc.nextInt();\n        System.out.print(x);\n    }\n}\n", null, "Lückentext: Nächste Zahl", 1 },
                    { 1127, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 151, 1, null, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", null, "Logik: Positiv/Negativ", 1 },
                    { 1128, null, null, "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", "java", 152, 1, null, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", null, "Zahlen 1 bis 5", 1 },
                    { 1129, null, null, "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", "java", 152, 2, null, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", null, "Summe bis 10", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 152);

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
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Programmieren für das Web.</p><p>JavaScript erweckt Webseiten zum Leben.</p>\n", 1, "JavaScript Einführung" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Go arbeitest.</p><p>In Go kannst du Variablen mit <code>var</code> oder der Kurzschreibweise <code>:=</code> deklarieren.</p>\n", "go", 3, "Variablen in Go" });

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
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Go (Golang).</p><p>In dieser Lektion lernst du die ersten Schritte in Go. Go ist bekannt für seine starke Unterstützung von Nebenläufigkeit und seine schnelle Kompilierung.</p>\n", 1, "Go Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Verstehe den Unterschied zwischen Werten und Pointern in Go.</p><p>Go ist eine &quot;Call by Value&quot; Sprache. Das bedeutet, es wird immer eine Kopie übergeben.</p>\n<ol>\n<li><strong>Werte übergeben</strong>: Die Funktion erhält eine Kopie des Wertes.</li>\n<li><strong>Pointer übergeben</strong>: Die Funktion erhält eine Kopie der Speicheradresse. Da sie die Adresse kennt, kann sie den Wert an dieser Stelle im Speicher verändern. Dies wird oft als &quot;Call by Reference&quot;-Verhalten bezeichnet, technisch gesehen ist es aber die Übergabe eines Pointer-Wertes.</li>\n</ol>\n", 4, "Go: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C# arbeitest.</p><p>Variablen sind Container zum Speichern von Datenwerten. In C# musst du den Datentyp einer Variable angeben.</p>\n", "csharp", "Variablen in C#" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne Entscheidungen im Code zu treffen.</p><p>In dieser Lektion lernst du <code>if</code> und <code>else</code> kennen.</p>\n", "csharp", 2, "Kontrollstrukturen" });

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
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von C#.</p><p>In dieser Lektion lernst du die ersten Schritte in C#.</p>\n", 1, "C# Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne den Einsatz von ref und out für Call by Reference in C#.</p><p>In C# werden Werttypen (wie <code>int</code>, <code>bool</code>) standardmäßig per <strong>Call by Value</strong> übergeben.</p>\n<ol>\n<li><strong>ref</strong>: Übergibt eine Referenz auf eine Variable. Die Variable muss vor der Übergabe initialisiert sein.</li>\n<li><strong>out</strong>: Übergibt eine Referenz, aber die Variable muss nicht initialisiert sein. Die Methode <strong>muss</strong> der <code>out</code>-Variable jedoch einen Wert zuweisen.</li>\n<li><strong>Pointer</strong>: C# unterstützt Pointer nur in <code>unsafe</code> Codeblöcken, was für allgemeine Anwendungen selten genutzt wird.</li>\n</ol>\n", 6, "C#: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Objektorientierte Programmierung.</p><p>Alles in C# findet in Klassen statt.</p>\n", 4, "Klassen & Methoden" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen und Code wiederholen.</p><p>Kontrollstrukturen sind das Herzstück jeder Programmiersprache. In Rust gibt es neben <code>if</code> und <code>else</code> auch mächtige Schleifen-Konstrukte wie <code>loop</code>, <code>while</code> und <code>for</code>.</p>\n", "rust", 3, "Rust: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Rust arbeitest.</p><p>In Rust sind Variablen standardmäßig unveränderlich (immutable). Mit <code>let mut</code> kannst du sie veränderbar machen.</p>\n", "rust", 4, "Variablen in Rust" });

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
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Vertiefe dein Wissen über Borrowing und lerne Smart Pointer wie Box kennen.</p><p>Rust erzwingt strikte Regeln für Referenzen zur Kompilierzeit (<strong>Borrow Checker</strong>).</p>\n<ol>\n<li><strong>Immutable Borrowing (<code>&amp;T</code>)</strong>: Beliebig viele Referenzen zum Lesen erlaubt.</li>\n<li><strong>Mutable Borrowing (<code>&amp;mut T</code>)</strong>: Nur eine Referenz zum Schreiben erlaubt.</li>\n<li><strong>Smart Pointer (<code>Box&lt;T&gt;</code>)</strong>: Ermöglicht es, Daten auf dem Heap statt auf dem Stack zu speichern. <code>Box</code> besitzt die Daten und gibt sie automatisch frei.</li>\n</ol>\n", 7, "Rust: Fortgeschrittene Referenzen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Übe die Syntax für Benutzereingaben in Rust, indem du die Lücken füllst.</p><p>In Rust ist das Einlesen von der Konsole explizit. Du brauchst:</p>\n<ol>\n<li>Einen <strong>veränderbaren String</strong> (<code>let mut input = String::new()</code>).</li>\n<li>Den Aufruf von <strong><code>io::stdin().read_line()</code></strong>.</li>\n<li>Eine <strong>veränderbare Referenz</strong> auf deinen String (<code>&amp;mut input</code>).</li>\n<li>Eine Fehlerbehandlung wie <strong><code>.unwrap()</code></strong> oder <code>.expect()</code>.</li>\n</ol>\n", 5, "Rust: Lückentext Eingabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Rust - Sicher, schnell und modern.</p><p>In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.</p>\n", 1, "Rust Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Rust Daten sicher per Referenz übergibt.</p><p>In Rust gibt es kein klassisches &quot;Call by Reference&quot; wie in C++, sondern <strong>Borrowing</strong> (Ausleihen).</p>\n<ol>\n<li><strong>Unveränderbares Borrowing (<code>&amp;T</code>)</strong>: Man darf den Wert lesen, aber nicht ändern. Man kann beliebig viele dieser Referenzen gleichzeitig haben.</li>\n<li><strong>Veränderbares Borrowing (<code>&amp;mut T</code>)</strong>: Man darf den Wert ändern. Es darf jedoch immer nur <strong>eine</strong> veränderbare Referenz zur gleichen Zeit existieren (Sicherheit gegen Data Races).</li>\n<li><strong>Ownership</strong>: Wird kein <code>&amp;</code> verwendet, wird der Wert <strong>verschoben</strong> (Move) und die ursprüngliche Variable ist nicht mehr nutzbar.</li>\n</ol>\n", 6, "Rust: Referenzen und Borrowing" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne den sicheren Umgang mit Raw Pointern und modernen Smart Pointern in C++.</p><p>In modernem C++ (ab C++11) solltest du <strong>Smart Pointer</strong> gegenüber Raw Pointern bevorzugen, um Speicherlecks zu vermeiden.</p>\n<ol>\n<li><strong>Raw Pointer (<code>T*</code>)</strong>: Speichert eine nackte Speicheradresse. Du musst dich selbst um <code>delete</code> kümmern.</li>\n<li><strong><code>std::unique_ptr&lt;T&gt;</code></strong>: Exklusives Eigentum. Der Speicher wird automatisch freigegeben, wenn der Pointer out-of-scope geht.</li>\n<li><strong><code>std::shared_ptr&lt;T&gt;</code></strong>: Gemeinsames Eigentum. Nutzt Reference Counting.</li>\n</ol>\n", "cpp", "C++: Pointer und Smart Pointer" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C++ arbeitest.</p><p>C++ ist eine objektorientierte Erweiterung von C und bietet komfortable Typen wie <code>std::string</code>.</p>\n", "cpp", 3, "Variablen in C++" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "cpp", 2, "C++: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", 1, "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value, Call by Reference und Call by Pointer.</p><p>In C++ gibt es drei Hauptarten, wie Daten an Funktionen übergeben werden können:</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie erstellt. Änderungen in der Funktion haben keine Auswirkung auf das Original.</li>\n<li><strong>Call by Reference</strong>: Die Funktion erhält direkten Zugriff auf das Original (Alias). Änderungen wirken sich sofort aus. Syntax: <code>Type&amp; name</code>.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse der Variable wird übergeben. Die Funktion greift über Dereferenzierung (<code>*</code>) auf das Original zu. Syntax: <code>Type* name</code> und beim Aufruf <code>&amp;variable</code>.</li>\n</ol>\n", 4, "C++: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in PHP arbeitest.</p><p>PHP ist eine schwach typisierte Sprache. Variablen werden mit einem Dollarzeichen ($) eingeleitet.</p>\n", "php", 3, "Variablen in PHP" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Language", "Title" },
                values: new object[] { "php", "PHP: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die serverseitige Programmierung mit PHP.</p><p>In dieser Lektion lernst du die Grundlagen von PHP kennen. PHP-Code wird auf dem Server ausgeführt und das Ergebnis wird als HTML an den Browser gesendet.</p>\n", "php", "PHP Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Reference in PHP.</p><p>In PHP werden Variablen standardmäßig als <strong>Call by Value</strong> übergeben.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie der Variable erstellt.</li>\n<li><strong>Call by Reference</strong>: Nutzt man ein <code>&amp;</code> vor dem Parameternamen in der Funktionsdefinition, wird eine Referenz auf die Originalvariable übergeben. Änderungen wirken sich direkt aus.</li>\n</ol>\n", "php", "PHP: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C arbeitest.</p><p>In C musst du Datentypen explizit angeben. Für Booleans musst du <code>&lt;stdbool.h&gt;</code> einbinden.</p>\n", "c", "Variablen in C" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Language", "Title" },
                values: new object[] { "c", "C: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", "c", "C Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Pointer in C.</p><p>In C gibt es (im Gegensatz zu C++) kein echtes &quot;Call by Reference&quot;. Stattdessen nutzt man Pointer, um ähnliche Effekte zu erzielen.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie des Wertes an die Funktion übergeben. Änderungen betreffen nur die Kopie.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse einer Variable wird übergeben. Die Funktion kann über diese Adresse direkt auf den Speicher des Aufrufers zugreifen und den Wert ändern.</li>\n</ol>\n", "c", 4, "C: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Python arbeitest.</p><p>In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.</p>\n", "python", "Variablen in Python" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Python mit Referenzen und veränderlichen Objekten umgeht.</p><p>Python nutzt ein Modell namens <strong>Pass-by-Object-Reference</strong>.</p>\n<ol>\n<li><strong>Unveränderliche Typen (<code>int</code>, <code>str</code>, <code>tuple</code>)</strong>: Da diese nicht geändert werden können, verhält es sich wie <strong>Call by Value</strong>. Jede &quot;Änderung&quot; erzeugt ein neues Objekt lokal in der Funktion.</li>\n<li><strong>Veränderliche Typen (<code>list</code>, <code>dict</code>, <code>set</code>)</strong>: Die Referenz wird übergeben. Änderungen am Objekt (z.B. <code>.append()</code>) wirken sich direkt auf das Original aus.</li>\n</ol>\n", "python", 5, "Python: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", "python", "Python: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Code-Blöcke wiederholst.</p><p>Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet <code>for</code> für bekannte Iterationen und <code>while</code> für bedingte Wiederholungen.</p>\n", "python", 3, "Python: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", 1, "Python Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", "java", "Variablen in Java" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", 1, "Java Einstieg" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Verstehe den Unterschied zwischen Primitiven und Objekten in Java.</p><p>In Java gibt es oft Diskussionen über &quot;Call by Reference&quot;. Die Wahrheit ist: <strong>Java ist immer Call by Value.</strong></p>\n<ol>\n<li><strong>Primitive Typen (<code>int</code>, <code>double</code>, etc.)</strong>: Es wird eine Kopie des eigentlichen Wertes übergeben.</li>\n<li><strong>Objekt-Referenzen</strong>: Es wird eine Kopie der <strong>Adresse</strong> des Objekts übergeben. Deshalb kannst du Attribute des Objekts in einer Methode ändern, aber du kannst nicht die ursprüngliche Variable auf ein komplett neues Objekt zeigen lassen.</li>\n</ol>\n", "java", "Java: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "java", "Java: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", "java", "Java: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "let zahl = -5;\n// Dein Code hier\n", "if,else", "let zahl = -5;\nif (zahl > 0) {\n    console.log(\"Positiv\");\n} else {\n    console.log(\"Negativ\");\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "// Dein Code hier\n", 103, 1, "for", "for (let i = 1; i <= 5; i++) {\n    console.log(i);\n}\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "let summe = 0;\nlet i = 1;\n// Dein Code hier\n", 2, "while", "let summe = 0;\nlet i = 1;\nwhile (i < 5) {\n    summe += i;\n    i++;\n}\nconsole.log(summe);\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in JavaScript.", "Hallo Welt!", "console.log();", "console.log", "console.log(\"Hallo Welt!\");", "JS: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine Funktion 'begruessung', die 'Hallo' zurückgibt.", "Hallo", "function begruessung() {\n    // Dein Code hier\n}\nconsole.log(begruessung());", "function,return", null, "JS: Funktionen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", "go", "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    var a int = 10\n    b := 5\n    fmt.Println(a + b)\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", "go", "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    a := 2.5\n    b := 5.0\n    fmt.Println(a * b)\n}", "Gleitkommazahlen (float64)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Description", "ExpectedOutput", "LessonId", "Order", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei Strings in Go.", "Hallo Welt", 105, 3, "package main\n\nimport \"fmt\"\n\nfunc main() {\n    s1 := \"Hallo \"\n    s2 := \"Welt\"\n    fmt.Println(s1 + s2)\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    // Dein Code\n}", 105, 4, "if,fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    if isActive {\n        fmt.Println(\"Wahr\")\n    } else {\n        fmt.Println(\"Falsch\")\n    }\n}", "Booleans (bool)" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Go ist eine bei Google entwickelte Open-Source-Programmiersprache, die sich durch Effizienz und Einfachheit auszeichnet.", "", "", 107, 1, null, null, "Was ist Go?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}\n", 2, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    fmt.Println(\"Hallo Welt!\")\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Vervollständige die Funktion `updateName`, sodass sie den Namen lokal ändert, aber das Original in `main` unverändert bleibt.", "Original", "package main\nimport \"fmt\"\n\nfunc updateName(n string) {\n    // Name ändern\n    n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateName(name)\n    fmt.Print(name)\n}\n", "n = \"Geändert\"", "package main\nimport \"fmt\"\n\nfunc updateName(n string) {\n    n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateName(name)\n    fmt.Print(name)\n}\n", "Call by Value in Go", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*string`), um den Wert des Originals zu verändern.", "Geändert", "package main\nimport \"fmt\"\n\nfunc updateNamePtr(n *string) {\n    // Ändere den Wert, auf den der Pointer zeigt\n    *n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    // Übergebe die Adresse mit &\n    updateNamePtr(&name)\n    fmt.Print(name)\n}\n", "*string,*n,&name", "package main\nimport \"fmt\"\n\nfunc updateNamePtr(n *string) {\n    *n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateNamePtr(&name)\n    fmt.Print(name)\n}\n", "Call by Pointer in Go" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um eine Zahl per Pointer zu verdoppeln.", "20", "package main\nimport \"fmt\"\n\nfunc double(n ___int) { // Pointer-Typ\n    ___n = ___n * 2     // Dereferenzierung\n}\n\nfunc main() {\n    x := 10\n    double(___x)        // Adresse übergeben\n    fmt.Print(x)\n}\n", 108, 3, "*int,*n,&x", "package main\nimport \"fmt\"\n\nfunc double(n *int) {\n    *n = *n * 2\n}\n\nfunc main() {\n    x := 10\n    double(&x)\n    fmt.Print(x)\n}\n", "Lückentext: Pointer-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 1, "int,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int a = 10;\n		int b = 5;\n		Console.WriteLine(a + b);\n	}\n}", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie mit einer anderen Zahl und gib das Ergebnis aus.", "12.5", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 109, 2, "double,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		double a = 2.5;\n		double b = 5.0;\n		Console.WriteLine(a * b);\n	}\n}", "Gleitkommazahlen (Double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei Strings und gib sie aus.", "Hallo Welt", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 109, 3, "string,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		string s1 = \"Hallo \";\n		string s2 = \"Welt\";\n		Console.WriteLine(s1 + s2);\n	}\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende eine bool-Variable in einer if-Anweisung, um 'Wahr' auszugeben, wenn sie true ist, sonst 'Falsch'.", "Wahr", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		// Dein Code\n	}\n}", "csharp", 109, 4, "bool,if,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		if (isActive)\n		{\n			Console.WriteLine(\"Wahr\");\n		}\n		else\n		{\n			Console.WriteLine(\"Falsch\");\n		}\n	}\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", 110, "if,else", null, "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Berechne die Summe der Zahlen 1 bis 5.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", 1, "for", null, "For-Schleife: Summe" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C# ist eine objektorientierte Sprache von Microsoft.", "", "", 112, 1, null, null, "Was ist C#?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", 112, 2, "Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		Console.WriteLine(\"Hallo Welt!\");\n	}\n}", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `ref`-Keyword, um den Wert der Variable `zahl` in der Methode `Verdopple` zu ändern.", "10", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        // Nutze ref auch beim Aufruf\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", 113, "ref int,ref zahl", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das ref Keyword" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `out`-Keyword, um einen Wert von einer Methode zurückzugeben, ohne den Rückgabewert zu nutzen.", "42", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        // out Variablen MÜSSEN in der Methode zugewiesen werden\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", 2, "out int,out zahl", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das out Keyword" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `ref` oder `out`.", "x=2,y=1", "using System;\n\npublic class Program\n{\n    static void Swap(____ int a, ____ int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(____ x, ____ y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", 113, 3, "ref int,ref x", "using System;\n\npublic class Program\n{\n    static void Swap(ref int a, ref int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(ref x, ref y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", "Lückentext: C# Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'.", "", "public class Calculator \n{\n    // Hier deine Methode\n}", 1, "class,Calculator,static,int", null, "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Zahl `x` größer als 10 ist. Gib 'Groß' aus, ansonsten 'Klein'.", "Groß", "fn main() {\n    let x = 15;\n    // Dein Code hier\n}\n", "rust", "if,else", "fn main() {\n    let x = 15;\n    if x > 10 {\n        println!(\"Groß\");\n    } else {\n        println!(\"Klein\");\n    }\n}\n", "Einfaches if/else", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Rust hat eine endlose Schleife namens `loop`. Nutze `break`, um sie zu verlassen, wenn `i` den Wert 5 erreicht hat. Gib `i` in jedem Durchgang aus.", "0\n1\n2\n3\n4\n5", "fn main() {\n    let mut i = 0;\n    loop {\n        // Dein Code hier\n        i += 1;\n    }\n}\n", "rust", "loop,break", "fn main() {\n    let mut i = 0;\n    loop {\n        println!(\"{}\", i);\n        if i == 5 {\n            break;\n        }\n        i += 1;\n    }\n}\n", "Die `loop` Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while` Schleife, um die Zahlen von 3 bis 1 (herunterzählend) auszugeben.", "3\n2\n1", "fn main() {\n    let mut n = 3;\n    // Dein Code hier\n}\n", "rust", 115, 3, "while", "fn main() {\n    let mut n = 3;\n    while n > 0 {\n        println!(\"{}\", n);\n        n -= 1;\n    }\n}\n", "While Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine i32-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "fn main() {\n    // Dein Code\n}", "rust", 1, "let,println!", "fn main() {\n    let a: i32 = 10;\n    let b: i32 = 5;\n    println!(\"{}\", a + b);\n}", "Ganzzahlen (i32)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine f64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "fn main() {\n    // Dein Code\n}", "rust", 2, "f64,println!", "fn main() {\n    let a: f64 = 2.5;\n    let b: f64 = 5.0;\n    println!(\"{}\", a * b);\n}", "Gleitkommazahlen (f64)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "fn main() {\n    // Dein Code\n}", "rust", 116, 3, "String,println!", "fn main() {\n    let s1 = String::from(\"Hallo \");\n    let s2 = \"Welt\";\n    println!(\"{}{}\", s1, s2);\n}", null, "Zeichenketten (String)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "fn main() {\n    let is_active = true;\n    // Dein Code\n}", 116, 4, "bool,if,println!", "fn main() {\n    let is_active = true;\n    if is_active {\n        println!(\"Wahr\");\n    } else {\n        println!(\"Falsch\");\n    }\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "[\"Damit sie schneller geladen wird\", \"Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen\", \"Um anzuzeigen, dass es ein String ist\", \"Das mut ist optional\"]", "Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen", "Warum muss die Variable für die Eingabe mit `mut` deklariert werden (z.B. `let mut input`)?", "", "", 117, 1, null, null, "Anatomie der Eingabe", 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust nutzt man `std::io::stdin()`, um Eingaben einzulesen. <br>Lies einen Namen von der Tastatur ein und gib 'Hallo [Name]!' aus. <br>Hinweis: Tippe in das Eingabefeld rechts das Wort 'Rust' ein, bevor du auf Ausführen klickst.", "Hallo Rust!", "use std::io;\n\nfn main() {\n    let mut input = String::new(); // Erstellt einen Puffer\n    \n    // Deine Aufgabe: Nutze io::stdin().read_line(&mut input).unwrap();\n    \n    println!(\"Hallo {}!\", input.trim());\n}\n", 117, 2, "read_line", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    println!(\"Hallo {}!\", input.trim());\n}\n", "Einen String einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies eine Zahl von der Tastatur ein, verdopple sie und gib das Ergebnis aus. <br>Hinweis: Nutze `.trim().parse::<i32>().unwrap()`, um den String in eine Zahl zu wandeln. <br>Tippe die Zahl '21' in das Eingabefeld.", "Ergebnis: 42", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    // Deine Aufgabe: Wandle 'input' in eine Zahl 'n' um\n    // let n: i32 = ...\n    \n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", 117, 2, "parse", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let n: i32 = input.trim().parse().unwrap();\n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "Zahl einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies zwei Zahlen nacheinander ein und gib deren Summe aus. <br>Wichtig: Das Eingabefeld unterstützt aktuell nur eine Zeile. Trenne deine beiden Zahlen im Eingabefeld mit einem Leerzeichen (z.B. '10 5').", "Summe: 15", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    \n    println!(\"Summe: {}\", a + b);\n}\n", 117, 3, "split_whitespace", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    println!(\"Summe: {}\", a + b);\n}\n", "Zwei Zahlen addieren" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust kannst du viele unveränderbare Referenzen haben, aber nur eine veränderbare. Fülle die Lücken, um den Wert zu lesen und zu schreiben.", "Lesen: 10\nNeu: 20", "fn main() {\n    let mut data = 10;\n    \n    let r1 = &data; // Immutable\n    println!(\"Lesen: {}\", r1);\n    \n    // Lücke: Erstelle eine veränderbare Referenz\n    let r2 = ________;\n    *r2 += 10;\n    \n    println!(\"Neu: {}\", data);\n}\n", 118, 1, "&mut data,*r2", "fn main() {\n    let mut data = 10;\n    let r1 = &data;\n    println!(\"Lesen: {}\", r1);\n    \n    let r2 = &mut data;\n    *r2 += 10;\n    println!(\"Neu: {}\", data);\n}\n", "Immutable vs Mutable" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `Box<T>`, um einen Wert auf dem Heap zu speichern. Vervollständige die Zeile mit `Box::new()`.", "Heap Wert: 50", "fn main() {\n    // Speichere die Zahl 50 auf dem Heap\n    let heap_val = Box::new(50);\n    \n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", 118, 2, "Box::new,*heap_val", "fn main() {\n    let heap_val = Box::new(50);\n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", "Box: Smart Pointer auf dem Heap" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { null, null, "Referenzen können automatisch dereferenziert werden. Übergebe eine Referenz an eine Funktion, die einen primitiven Typ erwartet.", "Zahl: 42", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    // Übergebe den Wert hinter der Referenz\n    print_int(*r);\n}\n", 118, 3, "*r", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    print_int(*r);\n}\n", "Deref Coercion", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Zeile, um einen neuen, leeren String-Puffer zu erstellen. <br>Nutze `String::new()`.", "Puffer bereit.", "fn main() {\n    // Vervollständige: let mut input = ...\n    let mut input = ___________;\n    \n    println!(\"Puffer bereit.\");\n}\n", 119, 1, "String::new", "fn main() {\n    let mut input = String::new();\n    println!(\"Puffer bereit.\");\n}\n", "Lücke: Den Puffer erstellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`.", "Bitte etwas tippen:\nGelesen!", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    \n    // Lücke: io::stdin().read_line(____ buffer).unwrap();\n    io::stdin().read_line(____ buffer).unwrap();\n    \n    println!(\"Gelesen!\");\n}\n", 119, "&mut", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    io::stdin().read_line(&mut buffer).unwrap();\n    println!(\"Gelesen!\");\n}\n", "Lücke: Die Referenz" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`.", "", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    \n    // Lücke: ____::stdin().read_line(&mut input).unwrap();\n    ____::stdin().read_line(&mut input).unwrap();\n}\n", 119, "io::stdin", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n}\n", "Lücke: Das Modul aufrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe die komplette Zeile, um eine Eingabe in die Variable `text` einzulesen. <br>Vergiss das `.unwrap()` am Ende nicht!", "Eingabe erfolgt.", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    \n    // Schreibe hier die komplette read_line Zeile:\n    \n    println!(\"Eingabe erfolgt.\");\n}\n", 119, 4, "read_line,&mut,unwrap", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    io::stdin().read_line(&mut text).unwrap();\n    println!(\"Eingabe erfolgt.\");\n}\n", "Lücke: Alles zusammen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", 120, 1, null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", 120, 2, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `laenge`, sodass sie die Länge eines Strings berechnet, ohne den Besitz (Ownership) zu übernehmen.", "Die Länge von 'Hallo' ist 5.", "fn laenge(s: &String) -> usize {\n    // Berechne die Länge\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    // Übergebe eine Referenz mit &\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", 121, "&String,&s1", "fn laenge(s: &String) -> usize {\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "Unveränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `&mut`, um den Inhalt eines Strings in einer Funktion zu verändern.", "Hallo, Welt", "fn aendern(s: &mut String) {\n    // Füge Text an\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    // Übergebe eine veränderbare Referenz mit &mut\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", 121, "&mut String,&mut s", "fn aendern(s: &mut String) {\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "Veränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `&` oder `&mut`.", "Lesen: Daten\nDaten...geändert", "fn main() {\n    let ___ s = String::from(\"Daten\");\n    \n    process_read(___s);  // Nur Lesen\n    process_write(___s); // Schreiben\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: ___String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: ___String) {\n    s.push_str(\"...geändert\");\n}\n", 121, "&s,&mut s,&String,&mut String", "fn main() {\n    let mut s = String::from(\"Daten\");\n    \n    process_read(&s);\n    process_write(&mut s);\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: &String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: &mut String) {\n    s.push_str(\"...geändert\");\n}\n", "Lückentext: Rust Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um die Adresse von `zahl` in einem Raw Pointer zu speichern und den Wert darüber auszugeben.", "Wert: 100", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    // Lücke: int* ptr = ...\n    int* ptr = ________;\n    \n    // Lücke: Wert über Pointer ausgeben (Dereferenzierung)\n    std::cout << \"Wert: \" << ________;\n    return 0;\n}\n", "cpp", 1, "&zahl,*ptr", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    int* ptr = &zahl;\n    std::cout << \"Wert: \" << *ptr;\n    return 0;\n}\n", "Raw Pointer: Adresse abrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze `std::unique_ptr`, um Speicher auf dem Heap sicher zu verwalten. Erstelle einen `unique_ptr<int>` mit `std::make_unique`.", "Smart Wert: 42", "#include <iostream>\n#include <memory>\n\nint main() {\n    // Erstelle einen unique_ptr für den Wert 42\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    \n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", "cpp", 122, 2, "unique_ptr,make_unique", "#include <iostream>\n#include <memory>\n\nint main() {\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", "Smart Pointer: unique_ptr", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Ein `shared_ptr` erlaubt es mehreren Pointern, denselben Speicher zu besitzen. Erstelle einen `shared_ptr` und gib den `use_count()` aus.", "Count: 2", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        // Erstelle eine Kopie von p1\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "cpp", 122, 3, "make_shared,use_count", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "Smart Pointer: shared_ptr" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus.", "15", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 123, "int,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 123, "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'string', um zwei Texte zu verknüpfen.", "Hallo Welt", "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 123, "string,cout", "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "#include <iostream>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", 123, 4, "bool,if,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        cout << \"Wahr\";\n    } else {\n        cout << \"Falsch\";\n    }\n    return 0;\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", 124, 1, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "", "", 1, null, null, "Was ist C++?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", 125, 2, "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt (Call by Value).", "Wert nach Funktion: 5", "#include <iostream>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", 1, "x = x * 2", "#include <iostream>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine Referenz (`&`), um den Wert der Originalvariable in der Funktion `verdoppleRef` dauerhaft zu ändern.", "Geänderter Wert: 10", "#include <iostream>\n\n// Nutze & für Call by Reference\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", 2, "int&", "#include <iostream>\n\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Reference" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Wert über Pointer: 10", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", 3, "int*,&zahl", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Pointer" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit der richtigen Syntax für Pointer und Referenzen.", "x=2, y=1", "#include <iostream>\n\nvoid swap(int__ a, int__ b) { // Nutze & für Referenzen\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=\" << x << \", y=\" << y;\n    return 0;\n}\n", 126, 4, "int&", "#include <iostream>\n\nvoid swap(int& a, int& b) {\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=2, y=1\";\n    return 0;\n}\n", "Lückentext: Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In PHP beginnen Variablen mit einem $. Addiere zwei Zahlen und gib das Ergebnis mit echo aus.", "15", "<?php\n// Dein Code", "php", 1, "echo,$", "<?php\n$a = 10;\n$b = 5;\necho $a + $b;", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Multipliziere zwei Gleitkommazahlen und gib das Ergebnis aus.", "12.5", "<?php\n// Dein Code", "php", 127, 2, "echo", "<?php\n$a = 2.5;\n$b = 5.0;\necho $a * $b;", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Strings werden in PHP mit dem Punkt (.) verknüpft.", "Hallo Welt", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\n// Dein Code", "php", 127, 3, "echo,.", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\necho $s1 . $s2;", "Zeichenketten (String)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "<?php\n$isActive = true;\n// Dein Code", "php", 127, 4, "if,echo", "<?php\n$isActive = true;\nif ($isActive) {\n    echo \"Wahr\";\n} else {\n    echo \"Falsch\";\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable '$zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "<?php\n$zahl = -5;\n// Dein Code hier\n?>\n", "php", 128, "if,else", "<?php\n$zahl = -5;\nif ($zahl > 0) {\n    echo \"Positiv\";\n} else {\n    echo \"Negativ\";\n}\n?>\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "", "", "php", 129, 1, null, null, "Was ist PHP?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "<?php\n// Dein Code hier\n", "php", 129, 2, "echo", "<?php\necho \"Hallo Welt!\";\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Originalwert: 5", "<?php\n\nfunction verdopple($zahl) {\n    // Ändere den Wert lokal\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", "php", 1, "$zahl = $zahl * 2", "<?php\n\nfunction verdopple($zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", "Call by Value in PHP" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das Ampersand-Zeichen (`&`) in der Parameterliste, um den Wert des Originals zu verändern.", "Geänderter Wert: 10", "<?php\n\n// Nutze & vor der Variable\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", 130, 2, "&$zahl", "<?php\n\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", "Call by Reference in PHP" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um eine Referenz an die Funktion zu übergeben.", "11", "<?php\n\nfunction addOne(____$n) { // Ampersand hier einfügen\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", 130, 3, "&$n", "<?php\n\nfunction addOne(&$n) {\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", "Lückentext: Referenz-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "15", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 1, "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 2, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "Hallo Welt", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 131, 3, "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "Wahr", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "c", 131, 4, "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", 132, 1, "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", "c", 133, null, null, "Was ist C?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 133, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Wert nach Funktion: 5", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "c", 134, "x = x * 2", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "Call by Value in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl mit &\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "c", 134, "int *,*x,&zahl", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "Call by Pointer in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen.", "x=2, y=1", "#include <stdio.h>\n\nvoid swap(int ____ a, int ____ b) {\n    int temp = ____ a;\n    ____ a = ____ b;\n    ____ b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=%d, y=%d\", x, y);\n    return 0;\n}\n", "c", 134, "int *,* a,* b", "#include <stdio.h>\n\nvoid swap(int * a, int * b) {\n    int temp = * a;\n    * a = * b;\n    * b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=2, y=1\");\n    return 0;\n}\n", "Lückentext: Pointer-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "# Dein Code hier", "python", 135, "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "python", 135, "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "# Dein Code hier", "python", 135, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "is_active = True\n# Dein Code", "python", 135, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "def verdopple(x):\n    # x lokal verdoppeln\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "python", 136, "x = x * 2", "def verdopple(x):\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "Unveränderliche Typen (Integers)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden.", "Python", "def add_element(liste):\n    # Füge \"Python\" zur Liste hinzu\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "python", 136, 2, "append", "def add_element(liste):\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "Veränderliche Typen (Listen)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", 137, 1, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", 137, 2, "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", "python", 138, 1, "for,in,range", "for i in range(1, 6):\n    print(i)\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", "python", 138, 2, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", 139, 1, null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", 139, 2, "print", "print(\"Hallo Welt!\")\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 140, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 140, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 140, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", "java", 140, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", "Booleans (boolean)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", 141, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", "Java: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 141, "if", null, "Java: If-Else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 141, 3, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Versuche den Wert von `x` in der Methode `verdopple` zu ändern. Bleibt das Original in `main` gleich?", "5", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "java", 142, 1, "x = x * 2", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "Primitive: Pass by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Java werden Objektreferenzen per Wert übergeben. Du kannst das Objekt verändern, aber nicht die Referenz selbst.", "Java", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        // Füge ein Element hinzu\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "java", 142, 2, "list.add", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "Objekte: Referenz ändern" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 143, 1, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", "java", 144, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", "Zahlen 1 bis 5", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", "java", 144, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", "Summe bis 10" });
        }
    }
}

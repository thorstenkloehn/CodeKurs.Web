using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddSmartPointersAndAdvancedReferences : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Rust Daten sicher per Referenz übergibt.</p><p>In Rust gibt es kein klassisches &quot;Call by Reference&quot; wie in C++, sondern <strong>Borrowing</strong> (Ausleihen).</p>\n<ol>\n<li><strong>Unveränderbares Borrowing (<code>&amp;T</code>)</strong>: Man darf den Wert lesen, aber nicht ändern. Man kann beliebig viele dieser Referenzen gleichzeitig haben.</li>\n<li><strong>Veränderbares Borrowing (<code>&amp;mut T</code>)</strong>: Man darf den Wert ändern. Es darf jedoch immer nur <strong>eine</strong> veränderbare Referenz zur gleichen Zeit existieren (Sicherheit gegen Data Races).</li>\n<li><strong>Ownership</strong>: Wird kein <code>&amp;</code> verwendet, wird der Wert <strong>verschoben</strong> (Move) und die ursprüngliche Variable ist nicht mehr nutzbar.</li>\n</ol>\n", "rust", 6, "Rust: Referenzen und Borrowing" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne den sicheren Umgang mit Raw Pointern und modernen Smart Pointern in C++.</p><p>In modernem C++ (ab C++11) solltest du <strong>Smart Pointer</strong> gegenüber Raw Pointern bevorzugen, um Speicherlecks zu vermeiden.</p>\n<ol>\n<li><strong>Raw Pointer (<code>T*</code>)</strong>: Speichert eine nackte Speicheradresse. Du musst dich selbst um <code>delete</code> kümmern.</li>\n<li><strong><code>std::unique_ptr&lt;T&gt;</code></strong>: Exklusives Eigentum. Der Speicher wird automatisch freigegeben, wenn der Pointer out-of-scope geht.</li>\n<li><strong><code>std::shared_ptr&lt;T&gt;</code></strong>: Gemeinsames Eigentum. Nutzt Reference Counting.</li>\n</ol>\n", 5, "C++: Pointer und Smart Pointer" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C++ arbeitest.</p><p>C++ ist eine objektorientierte Erweiterung von C und bietet komfortable Typen wie <code>std::string</code>.</p>\n", 3, "Variablen in C++" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "C++: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", "cpp", 1, "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value, Call by Reference und Call by Pointer.</p><p>In C++ gibt es drei Hauptarten, wie Daten an Funktionen übergeben werden können:</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie erstellt. Änderungen in der Funktion haben keine Auswirkung auf das Original.</li>\n<li><strong>Call by Reference</strong>: Die Funktion erhält direkten Zugriff auf das Original (Alias). Änderungen wirken sich sofort aus. Syntax: <code>Type&amp; name</code>.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse der Variable wird übergeben. Die Funktion greift über Dereferenzierung (<code>*</code>) auf das Original zu. Syntax: <code>Type* name</code> und beim Aufruf <code>&amp;variable</code>.</li>\n</ol>\n", "cpp", 4, "C++: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in PHP arbeitest.</p><p>PHP ist eine schwach typisierte Sprache. Variablen werden mit einem Dollarzeichen ($) eingeleitet.</p>\n", 3, "Variablen in PHP" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "PHP: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die serverseitige Programmierung mit PHP.</p><p>In dieser Lektion lernst du die Grundlagen von PHP kennen. PHP-Code wird auf dem Server ausgeführt und das Ergebnis wird als HTML an den Browser gesendet.</p>\n", "php", 1, "PHP Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Reference in PHP.</p><p>In PHP werden Variablen standardmäßig als <strong>Call by Value</strong> übergeben.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie der Variable erstellt.</li>\n<li><strong>Call by Reference</strong>: Nutzt man ein <code>&amp;</code> vor dem Parameternamen in der Funktionsdefinition, wird eine Referenz auf die Originalvariable übergeben. Änderungen wirken sich direkt aus.</li>\n</ol>\n", "php", 4, "PHP: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C arbeitest.</p><p>In C musst du Datentypen explizit angeben. Für Booleans musst du <code>&lt;stdbool.h&gt;</code> einbinden.</p>\n", 3, "Variablen in C" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "C: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", "c", 1, "C Grundlagen" });

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
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Python arbeitest.</p><p>In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.</p>\n", 4, "Variablen in Python" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Python mit Referenzen und veränderlichen Objekten umgeht.</p><p>Python nutzt ein Modell namens <strong>Pass-by-Object-Reference</strong>.</p>\n<ol>\n<li><strong>Unveränderliche Typen (<code>int</code>, <code>str</code>, <code>tuple</code>)</strong>: Da diese nicht geändert werden können, verhält es sich wie <strong>Call by Value</strong>. Jede &quot;Änderung&quot; erzeugt ein neues Objekt lokal in der Funktion.</li>\n<li><strong>Veränderliche Typen (<code>list</code>, <code>dict</code>, <code>set</code>)</strong>: Die Referenz wird übergeben. Änderungen am Objekt (z.B. <code>.append()</code>) wirken sich direkt auf das Original aus.</li>\n</ol>\n", 5, "Python: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", 2, "Python: Kontrollstrukturen" });

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
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", "Python Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", 4, "Variablen in Java" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", 1, "Java Einstieg" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Verstehe den Unterschied zwischen Primitiven und Objekten in Java.</p><p>In Java gibt es oft Diskussionen über &quot;Call by Reference&quot;. Die Wahrheit ist: <strong>Java ist immer Call by Value.</strong></p>\n<ol>\n<li><strong>Primitive Typen (<code>int</code>, <code>double</code>, etc.)</strong>: Es wird eine Kopie des eigentlichen Wertes übergeben.</li>\n<li><strong>Objekt-Referenzen</strong>: Es wird eine Kopie der <strong>Adresse</strong> des Objekts übergeben. Deshalb kannst du Attribute des Objekts in einer Methode ändern, aber du kannst nicht die ursprüngliche Variable auf ein komplett neues Objekt zeigen lassen.</li>\n</ol>\n", 5, "Java: Parameterübergabe" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[,]
                {
                    { 143, "<p>Entscheidungen treffen mit if und else.</p>", "java", 2, "Java: Kontrollstrukturen" },
                    { 144, "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", "java", 3, "Java: Schleifen" }
                });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust kannst du viele unveränderbare Referenzen haben, aber nur eine veränderbare. Fülle die Lücken, um den Wert zu lesen und zu schreiben.", "Lesen: 10\nNeu: 20", "fn main() {\n    let mut data = 10;\n    \n    let r1 = &data; // Immutable\n    println!(\"Lesen: {}\", r1);\n    \n    // Lücke: Erstelle eine veränderbare Referenz\n    let r2 = ________;\n    *r2 += 10;\n    \n    println!(\"Neu: {}\", data);\n}\n", "&mut data,*r2", "fn main() {\n    let mut data = 10;\n    let r1 = &data;\n    println!(\"Lesen: {}\", r1);\n    \n    let r2 = &mut data;\n    *r2 += 10;\n    println!(\"Neu: {}\", data);\n}\n", "Immutable vs Mutable" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `Box<T>`, um einen Wert auf dem Heap zu speichern. Vervollständige die Zeile mit `Box::new()`.", "Heap Wert: 50", "fn main() {\n    // Speichere die Zahl 50 auf dem Heap\n    let heap_val = Box::new(50);\n    \n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", "Box::new,*heap_val", "fn main() {\n    let heap_val = Box::new(50);\n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", "Box: Smart Pointer auf dem Heap" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Referenzen können automatisch dereferenziert werden. Übergebe eine Referenz an eine Funktion, die einen primitiven Typ erwartet.", "Zahl: 42", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    // Übergebe den Wert hinter der Referenz\n    print_int(*r);\n}\n", "*r", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    print_int(*r);\n}\n", "Deref Coercion" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`.", "Bitte etwas tippen:\nGelesen!", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    \n    // Lücke: io::stdin().read_line(____ buffer).unwrap();\n    io::stdin().read_line(____ buffer).unwrap();\n    \n    println!(\"Gelesen!\");\n}\n", 2, "&mut", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    io::stdin().read_line(&mut buffer).unwrap();\n    println!(\"Gelesen!\");\n}\n", "Lücke: Die Referenz", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`.", "", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    \n    // Lücke: ____::stdin().read_line(&mut input).unwrap();\n    ____::stdin().read_line(&mut input).unwrap();\n}\n", 3, "io::stdin", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n}\n", "Lücke: Das Modul aufrufen" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", 1, null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", 2, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `laenge`, sodass sie die Länge eines Strings berechnet, ohne den Besitz (Ownership) zu übernehmen.", "Die Länge von 'Hallo' ist 5.", "fn laenge(s: &String) -> usize {\n    // Berechne die Länge\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    // Übergebe eine Referenz mit &\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "rust", "&String,&s1", "fn laenge(s: &String) -> usize {\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "Unveränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `&mut`, um den Inhalt eines Strings in einer Funktion zu verändern.", "Hallo, Welt", "fn aendern(s: &mut String) {\n    // Füge Text an\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    // Übergebe eine veränderbare Referenz mit &mut\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "rust", "&mut String,&mut s", "fn aendern(s: &mut String) {\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "Veränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `&` oder `&mut`.", "Lesen: Daten\nDaten...geändert", "fn main() {\n    let ___ s = String::from(\"Daten\");\n    \n    process_read(___s);  // Nur Lesen\n    process_write(___s); // Schreiben\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: ___String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: ___String) {\n    s.push_str(\"...geändert\");\n}\n", "rust", "&s,&mut s,&String,&mut String", "fn main() {\n    let mut s = String::from(\"Daten\");\n    \n    process_read(&s);\n    process_write(&mut s);\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: &String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: &mut String) {\n    s.push_str(\"...geändert\");\n}\n", "Lückentext: Rust Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um die Adresse von `zahl` in einem Raw Pointer zu speichern und den Wert darüber auszugeben.", "Wert: 100", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    // Lücke: int* ptr = ...\n    int* ptr = ________;\n    \n    // Lücke: Wert über Pointer ausgeben (Dereferenzierung)\n    std::cout << \"Wert: \" << ________;\n    return 0;\n}\n", 122, 1, "&zahl,*ptr", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    int* ptr = &zahl;\n    std::cout << \"Wert: \" << *ptr;\n    return 0;\n}\n", "Raw Pointer: Adresse abrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `std::unique_ptr`, um Speicher auf dem Heap sicher zu verwalten. Erstelle einen `unique_ptr<int>` mit `std::make_unique`.", "Smart Wert: 42", "#include <iostream>\n#include <memory>\n\nint main() {\n    // Erstelle einen unique_ptr für den Wert 42\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    \n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", 2, "unique_ptr,make_unique", "#include <iostream>\n#include <memory>\n\nint main() {\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", "Smart Pointer: unique_ptr" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Ein `shared_ptr` erlaubt es mehreren Pointern, denselben Speicher zu besitzen. Erstelle einen `shared_ptr` und gib den `use_count()` aus.", "Count: 2", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        // Erstelle eine Kopie von p1\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", 122, 3, "make_shared,use_count", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "Smart Pointer: shared_ptr", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus.", "15", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 1, "int,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 123, 2, "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'string', um zwei Texte zu verknüpfen.", "Hallo Welt", "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 123, 3, "string,cout", "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}", "Zeichenketten (string)" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", 1, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "", "", "cpp", null, null, "Was ist C++?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "cpp", "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt (Call by Value).", "Wert nach Funktion: 5", "#include <iostream>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 126, 1, "x = x * 2", "#include <iostream>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine Referenz (`&`), um den Wert der Originalvariable in der Funktion `verdoppleRef` dauerhaft zu ändern.", "Geänderter Wert: 10", "#include <iostream>\n\n// Nutze & für Call by Reference\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 126, 2, "int&", "#include <iostream>\n\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Reference" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Wert über Pointer: 10", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 3, "int*,&zahl", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Pointer" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Fülle die Lücken mit der richtigen Syntax für Pointer und Referenzen.", "x=2, y=1", "#include <iostream>\n\nvoid swap(int__ a, int__ b) { // Nutze & für Referenzen\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=\" << x << \", y=\" << y;\n    return 0;\n}\n", "cpp", 126, 4, "int&", "#include <iostream>\n\nvoid swap(int& a, int& b) {\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=2, y=1\";\n    return 0;\n}\n", "Lückentext: Syntax", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In PHP beginnen Variablen mit einem $. Addiere zwei Zahlen und gib das Ergebnis mit echo aus.", "15", "<?php\n// Dein Code", 1, "echo,$", "<?php\n$a = 10;\n$b = 5;\necho $a + $b;", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Multipliziere zwei Gleitkommazahlen und gib das Ergebnis aus.", "12.5", "<?php\n// Dein Code", 127, 2, "echo", "<?php\n$a = 2.5;\n$b = 5.0;\necho $a * $b;", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings werden in PHP mit dem Punkt (.) verknüpft.", "Hallo Welt", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\n// Dein Code", 127, 3, "echo,.", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\necho $s1 . $s2;", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "<?php\n$isActive = true;\n// Dein Code", 127, 4, "if,echo", "<?php\n$isActive = true;\nif ($isActive) {\n    echo \"Wahr\";\n} else {\n    echo \"Falsch\";\n}", "Booleans (Wahrheitswerte)" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "", "", "php", 1, null, null, "Was ist PHP?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "<?php\n// Dein Code hier\n", "php", 2, "echo", "<?php\necho \"Hallo Welt!\";\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Originalwert: 5", "<?php\n\nfunction verdopple($zahl) {\n    // Ändere den Wert lokal\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", "php", 130, 1, "$zahl = $zahl * 2", "<?php\n\nfunction verdopple($zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", "Call by Value in PHP" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das Ampersand-Zeichen (`&`) in der Parameterliste, um den Wert des Originals zu verändern.", "Geänderter Wert: 10", "<?php\n\n// Nutze & vor der Variable\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", "php", 2, "&$zahl", "<?php\n\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", "Call by Reference in PHP" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Fülle die Lücken, um eine Referenz an die Funktion zu übergeben.", "11", "<?php\n\nfunction addOne(____$n) { // Ampersand hier einfügen\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", "php", 130, 3, "&$n", "<?php\n\nfunction addOne(&$n) {\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", "Lückentext: Referenz-Syntax", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "15", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 1, "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 131, 2, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "Hallo Welt", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", 131, 3, "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "Wahr", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", 131, 4, "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", 132, "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", "c", 1, null, null, "Was ist C?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 2, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Wert nach Funktion: 5", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "c", 134, 1, "x = x * 2", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "Call by Value in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Geänderter Wert: 10", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl mit &\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "c", 2, "int *,*x,&zahl", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "Call by Pointer in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen.", "x=2, y=1", "#include <stdio.h>\n\nvoid swap(int ____ a, int ____ b) {\n    int temp = ____ a;\n    ____ a = ____ b;\n    ____ b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=%d, y=%d\", x, y);\n    return 0;\n}\n", "c", 3, "int *,* a,* b", "#include <stdio.h>\n\nvoid swap(int * a, int * b) {\n    int temp = * a;\n    * a = * b;\n    * b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=2, y=1\");\n    return 0;\n}\n", "Lückentext: Pointer-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "# Dein Code hier", "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "Hallo Welt", "# Dein Code hier", 135, 3, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "Wahr", "is_active = True\n# Dein Code", 135, 4, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "def verdopple(x):\n    # x lokal verdoppeln\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", 136, "x = x * 2", "def verdopple(x):\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "Unveränderliche Typen (Integers)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden.", "Python", "def add_element(liste):\n    # Füge \"Python\" zur Liste hinzu\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", 136, "append", "def add_element(liste):\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "Veränderliche Typen (Listen)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", 137, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", 137, "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", "python", 1, "for,in,range", "for i in range(1, 6):\n    print(i)\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", "python", 2, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", "print", "print(\"Hallo Welt!\")\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", 140, 1, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", null, "Ganzzahlen (int)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", 2, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", 3, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", 140, 4, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", "Booleans (boolean)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", 141, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", "Java: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", 141, "if", null, "Java: If-Else" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1108, null, null, "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 141, 3, null, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 },
                    { 1109, null, null, "Versuche den Wert von `x` in der Methode `verdopple` zu ändern. Bleibt das Original in `main` gleich?", "5", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "java", 142, 1, null, "x = x * 2", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", null, "Primitive: Pass by Value", 1 },
                    { 1110, null, null, "In Java werden Objektreferenzen per Wert übergeben. Du kannst das Objekt verändern, aber nicht die Referenz selbst.", "Java", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        // Füge ein Element hinzu\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "java", 142, 2, null, "list.add", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", null, "Objekte: Referenz ändern", 1 },
                    { 1111, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 143, 1, null, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", null, "Logik: Positiv/Negativ", 1 },
                    { 1112, null, null, "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", "java", 144, 1, null, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", null, "Zahlen 1 bis 5", 1 },
                    { 1113, null, null, "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", "java", 144, 2, null, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", null, "Summe bis 10", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Übe die Syntax für Benutzereingaben in Rust, indem du die Lücken füllst.</p><p>In Rust ist das Einlesen von der Konsole explizit. Du brauchst:</p>\n<ol>\n<li>Einen <strong>veränderbaren String</strong> (<code>let mut input = String::new()</code>).</li>\n<li>Den Aufruf von <strong><code>io::stdin().read_line()</code></strong>.</li>\n<li>Eine <strong>veränderbare Referenz</strong> auf deinen String (<code>&amp;mut input</code>).</li>\n<li>Eine Fehlerbehandlung wie <strong><code>.unwrap()</code></strong> oder <code>.expect()</code>.</li>\n</ol>\n", 5, "Rust: Lückentext Eingabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Rust - Sicher, schnell und modern.</p><p>In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.</p>\n", 1, "Rust Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Rust Daten sicher per Referenz übergibt.</p><p>In Rust gibt es kein klassisches &quot;Call by Reference&quot; wie in C++, sondern <strong>Borrowing</strong> (Ausleihen).</p>\n<ol>\n<li><strong>Unveränderbares Borrowing (<code>&amp;T</code>)</strong>: Man darf den Wert lesen, aber nicht ändern. Man kann beliebig viele dieser Referenzen gleichzeitig haben.</li>\n<li><strong>Veränderbares Borrowing (<code>&amp;mut T</code>)</strong>: Man darf den Wert ändern. Es darf jedoch immer nur <strong>eine</strong> veränderbare Referenz zur gleichen Zeit existieren (Sicherheit gegen Data Races).</li>\n<li><strong>Ownership</strong>: Wird kein <code>&amp;</code> verwendet, wird der Wert <strong>verschoben</strong> (Move) und die ursprüngliche Variable ist nicht mehr nutzbar.</li>\n</ol>\n", 6, "Rust: Referenzen und Borrowing" });

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
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "C++: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", 1, "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value, Call by Reference und Call by Pointer.</p><p>In C++ gibt es drei Hauptarten, wie Daten an Funktionen übergeben werden können:</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie erstellt. Änderungen in der Funktion haben keine Auswirkung auf das Original.</li>\n<li><strong>Call by Reference</strong>: Die Funktion erhält direkten Zugriff auf das Original (Alias). Änderungen wirken sich sofort aus. Syntax: <code>Type&amp; name</code>.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse der Variable wird übergeben. Die Funktion greift über Dereferenzierung (<code>*</code>) auf das Original zu. Syntax: <code>Type* name</code> und beim Aufruf <code>&amp;variable</code>.</li>\n</ol>\n", 4, "C++: Parameterübergabe" });

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
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die serverseitige Programmierung mit PHP.</p><p>In dieser Lektion lernst du die Grundlagen von PHP kennen. PHP-Code wird auf dem Server ausgeführt und das Ergebnis wird als HTML an den Browser gesendet.</p>\n", 1, "PHP Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Reference in PHP.</p><p>In PHP werden Variablen standardmäßig als <strong>Call by Value</strong> übergeben.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie der Variable erstellt.</li>\n<li><strong>Call by Reference</strong>: Nutzt man ein <code>&amp;</code> vor dem Parameternamen in der Funktionsdefinition, wird eine Referenz auf die Originalvariable übergeben. Änderungen wirken sich direkt aus.</li>\n</ol>\n", 4, "PHP: Parameterübergabe" });

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
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", 1, "C Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Pointer in C.</p><p>In C gibt es (im Gegensatz zu C++) kein echtes &quot;Call by Reference&quot;. Stattdessen nutzt man Pointer, um ähnliche Effekte zu erzielen.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie des Wertes an die Funktion übergeben. Änderungen betreffen nur die Kopie.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse einer Variable wird übergeben. Die Funktion kann über diese Adresse direkt auf den Speicher des Aufrufers zugreifen und den Wert ändern.</li>\n</ol>\n", 4, "C: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Python arbeitest.</p><p>In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.</p>\n", "python", 4, "Variablen in Python" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Python mit Referenzen und veränderlichen Objekten umgeht.</p><p>Python nutzt ein Modell namens <strong>Pass-by-Object-Reference</strong>.</p>\n<ol>\n<li><strong>Unveränderliche Typen (<code>int</code>, <code>str</code>, <code>tuple</code>)</strong>: Da diese nicht geändert werden können, verhält es sich wie <strong>Call by Value</strong>. Jede &quot;Änderung&quot; erzeugt ein neues Objekt lokal in der Funktion.</li>\n<li><strong>Veränderliche Typen (<code>list</code>, <code>dict</code>, <code>set</code>)</strong>: Die Referenz wird übergeben. Änderungen am Objekt (z.B. <code>.append()</code>) wirken sich direkt auf das Original aus.</li>\n</ol>\n", "python", 5, "Python: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", 2, "Python: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Code-Blöcke wiederholst.</p><p>Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet <code>for</code> für bekannte Iterationen und <code>while</code> für bedingte Wiederholungen.</p>\n", 3, "Python: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", 1, "Python Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", "java", 4, "Variablen in Java" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", "Java Einstieg" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Verstehe den Unterschied zwischen Primitiven und Objekten in Java.</p><p>In Java gibt es oft Diskussionen über &quot;Call by Reference&quot;. Die Wahrheit ist: <strong>Java ist immer Call by Value.</strong></p>\n<ol>\n<li><strong>Primitive Typen (<code>int</code>, <code>double</code>, etc.)</strong>: Es wird eine Kopie des eigentlichen Wertes übergeben.</li>\n<li><strong>Objekt-Referenzen</strong>: Es wird eine Kopie der <strong>Adresse</strong> des Objekts übergeben. Deshalb kannst du Attribute des Objekts in einer Methode ändern, aber du kannst nicht die ursprüngliche Variable auf ein komplett neues Objekt zeigen lassen.</li>\n</ol>\n", 5, "Java: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", 2, "Java: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", 3, "Java: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Zeile, um einen neuen, leeren String-Puffer zu erstellen. <br>Nutze `String::new()`.", "Puffer bereit.", "fn main() {\n    // Vervollständige: let mut input = ...\n    let mut input = ___________;\n    \n    println!(\"Puffer bereit.\");\n}\n", "String::new", "fn main() {\n    let mut input = String::new();\n    println!(\"Puffer bereit.\");\n}\n", "Lücke: Den Puffer erstellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`.", "Bitte etwas tippen:\nGelesen!", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    \n    // Lücke: io::stdin().read_line(____ buffer).unwrap();\n    io::stdin().read_line(____ buffer).unwrap();\n    \n    println!(\"Gelesen!\");\n}\n", "&mut", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    io::stdin().read_line(&mut buffer).unwrap();\n    println!(\"Gelesen!\");\n}\n", "Lücke: Die Referenz" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`.", "", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    \n    // Lücke: ____::stdin().read_line(&mut input).unwrap();\n    ____::stdin().read_line(&mut input).unwrap();\n}\n", "io::stdin", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n}\n", "Lücke: Das Modul aufrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe die komplette Zeile, um eine Eingabe in die Variable `text` einzulesen. <br>Vergiss das `.unwrap()` am Ende nicht!", "Eingabe erfolgt.", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    \n    // Schreibe hier die komplette read_line Zeile:\n    \n    println!(\"Eingabe erfolgt.\");\n}\n", 118, 4, "read_line,&mut,unwrap", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    io::stdin().read_line(&mut text).unwrap();\n    println!(\"Eingabe erfolgt.\");\n}\n", "Lücke: Alles zusammen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", 1, null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", 2, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `laenge`, sodass sie die Länge eines Strings berechnet, ohne den Besitz (Ownership) zu übernehmen.", "Die Länge von 'Hallo' ist 5.", "fn laenge(s: &String) -> usize {\n    // Berechne die Länge\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    // Übergebe eine Referenz mit &\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", 120, 1, "&String,&s1", "fn laenge(s: &String) -> usize {\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "Unveränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze `&mut`, um den Inhalt eines Strings in einer Funktion zu verändern.", "Hallo, Welt", "fn aendern(s: &mut String) {\n    // Füge Text an\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    // Übergebe eine veränderbare Referenz mit &mut\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", 2, "&mut String,&mut s", "fn aendern(s: &mut String) {\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "Veränderbare Referenzen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `&` oder `&mut`.", "Lesen: Daten\nDaten...geändert", "fn main() {\n    let ___ s = String::from(\"Daten\");\n    \n    process_read(___s);  // Nur Lesen\n    process_write(___s); // Schreiben\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: ___String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: ___String) {\n    s.push_str(\"...geändert\");\n}\n", 3, "&s,&mut s,&String,&mut String", "fn main() {\n    let mut s = String::from(\"Daten\");\n    \n    process_read(&s);\n    process_write(&mut s);\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: &String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: &mut String) {\n    s.push_str(\"...geändert\");\n}\n", "Lückentext: Rust Referenzen" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'string', um zwei Texte zu verknüpfen.", "Hallo Welt", "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", "string,cout", "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "#include <iostream>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", 121, 4, "bool,if,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        cout << \"Wahr\";\n    } else {\n        cout << \"Falsch\";\n    }\n    return 0;\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", 1, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "", "", 123, 1, null, null, "Was ist C++?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", 2, "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt (Call by Value).", "Wert nach Funktion: 5", "#include <iostream>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", 124, 1, "x = x * 2", "#include <iostream>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine Referenz (`&`), um den Wert der Originalvariable in der Funktion `verdoppleRef` dauerhaft zu ändern.", "Geänderter Wert: 10", "#include <iostream>\n\n// Nutze & für Call by Reference\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", 124, 2, "int&", "#include <iostream>\n\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Reference" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Wert über Pointer: 10", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", 124, 3, "int*,&zahl", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Pointer" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit der richtigen Syntax für Pointer und Referenzen.", "x=2, y=1", "#include <iostream>\n\nvoid swap(int__ a, int__ b) { // Nutze & für Referenzen\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=\" << x << \", y=\" << y;\n    return 0;\n}\n", 4, "int&", "#include <iostream>\n\nvoid swap(int& a, int& b) {\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=2, y=1\";\n    return 0;\n}\n", "Lückentext: Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "In PHP beginnen Variablen mit einem $. Addiere zwei Zahlen und gib das Ergebnis mit echo aus.", "15", "<?php\n// Dein Code", "php", "echo,$", "<?php\n$a = 10;\n$b = 5;\necho $a + $b;", "Ganzzahlen (Integer)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Multipliziere zwei Gleitkommazahlen und gib das Ergebnis aus.", "12.5", "<?php\n// Dein Code", "php", "echo", "<?php\n$a = 2.5;\n$b = 5.0;\necho $a * $b;", "Gleitkommazahlen (Float)" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable '$zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "<?php\n$zahl = -5;\n// Dein Code hier\n?>\n", "php", 1, "if,else", "<?php\n$zahl = -5;\nif ($zahl > 0) {\n    echo \"Positiv\";\n} else {\n    echo \"Negativ\";\n}\n?>\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "", "", "php", 127, 1, null, null, "Was ist PHP?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "<?php\n// Dein Code hier\n", 2, "echo", "<?php\necho \"Hallo Welt!\";\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Originalwert: 5", "<?php\n\nfunction verdopple($zahl) {\n    // Ändere den Wert lokal\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", 128, 1, "$zahl = $zahl * 2", "<?php\n\nfunction verdopple($zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", "Call by Value in PHP" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das Ampersand-Zeichen (`&`) in der Parameterliste, um den Wert des Originals zu verändern.", "Geänderter Wert: 10", "<?php\n\n// Nutze & vor der Variable\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", 128, 2, "&$zahl", "<?php\n\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", "Call by Reference in PHP" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um eine Referenz an die Funktion zu übergeben.", "11", "<?php\n\nfunction addOne(____$n) { // Ampersand hier einfügen\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", 128, 3, "&$n", "<?php\n\nfunction addOne(&$n) {\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", "Lückentext: Referenz-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "15", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 129, "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 2, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "Hallo Welt", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 3, "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", 1, "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", "c", 131, 1, null, null, "Was ist C?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", 2, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Wert nach Funktion: 5", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", 132, 1, "x = x * 2", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "Call by Value in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Geänderter Wert: 10", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl mit &\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", 132, 2, "int *,*x,&zahl", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "Call by Pointer in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen.", "x=2, y=1", "#include <stdio.h>\n\nvoid swap(int ____ a, int ____ b) {\n    int temp = ____ a;\n    ____ a = ____ b;\n    ____ b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=%d, y=%d\", x, y);\n    return 0;\n}\n", 132, 3, "int *,* a,* b", "#include <stdio.h>\n\nvoid swap(int * a, int * b) {\n    int temp = * a;\n    * a = * b;\n    * b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=2, y=1\");\n    return 0;\n}\n", "Lückentext: Pointer-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "# Dein Code hier", "python", 133, "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "python", 2, "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "Hallo Welt", "# Dein Code hier", "python", 3, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "Wahr", "is_active = True\n# Dein Code", "python", 133, 4, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "def verdopple(x):\n    # x lokal verdoppeln\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "python", 1, "x = x * 2", "def verdopple(x):\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "Unveränderliche Typen (Integers)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden.", "Python", "def add_element(liste):\n    # Füge \"Python\" zur Liste hinzu\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "python", 2, "append", "def add_element(liste):\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "Veränderliche Typen (Listen)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", 136, 1, "for,in,range", "for i in range(1, 6):\n    print(i)\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", 136, 2, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", 137, null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", 137, "print", "print(\"Hallo Welt!\")\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 138, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 138, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 3, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", "java", 4, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", "Booleans (boolean)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", "Java: Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", "if", null, "Java: If-Else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", 139, 3, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Versuche den Wert von `x` in der Methode `verdopple` zu ändern. Bleibt das Original in `main` gleich?", "5", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", 1, "x = x * 2", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "Primitive: Pass by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Java werden Objektreferenzen per Wert übergeben. Du kannst das Objekt verändern, aber nicht die Referenz selbst.", "Java", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        // Füge ein Element hinzu\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", 2, "list.add", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "Objekte: Referenz ändern" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", 141, 1, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", 142, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", 142, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", "Summe bis 10" });
        }
    }
}

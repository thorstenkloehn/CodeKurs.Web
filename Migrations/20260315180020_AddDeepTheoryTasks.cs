using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddDeepTheoryTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Description", "ExpectedOutput", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In JavaScript gibt es den Typ 'number' für alle Zahlen. Erstelle eine Variable mit let, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "let,console.log", "let a = 10;\nlet b = 5;\nconsole.log(a + b);", "Ganzzahlen (Number)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Auch Gleitkommazahlen sind in JavaScript vom Typ 'number'. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "// Dein Code hier", "console.log", "let a = 2.5;\nlet b = 5;\nconsole.log(a * b);", "Gleitkommazahlen (Number)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende String Interpolation (Backticks ``), um zwei Variablen in einem String auszugeben.", "Hallo Welt", "const s1 = \"Hallo\";\nconst s2 = \"Welt\";\n// Dein Code hier", "console.log,$,{", "const s1 = \"Hallo\";\nconst s2 = \"Welt\";\nconsole.log(`${s1} ${s2}`);", "Zeichenketten (String Interpotalion)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "let isActive = true;\n// Dein Code hier", 100, 5, "if,console.log", "let isActive = true;\nif (isActive) {\n    console.log(\"Wahr\");\n} else {\n    console.log(\"Falsch\");\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `zahl` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "function verdopple(x) {\n    x = x * 2;\n}\n\nlet zahl = 5;\nverdopple(zahl);\nconsole.log(zahl);\n", 101, 2, "x = x * 2", "function verdopple(x) {\n    x = x * 2;\n}\n\nlet zahl = 5;\nverdopple(zahl);\nconsole.log(zahl);\n", "Primitive: Pass by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In JS werden Objekte über eine Referenz übergeben. Ändere die Eigenschaft `name` des Objekts in der Funktion.", "Geändert", "function updateName(obj) {\n    // Ändere obj.name zu \"Geändert\"\n    obj.name = \"Geändert\";\n}\n\nlet person = { name: \"Original\" };\nupdateName(person);\nconsole.log(person.name);\n", 101, 3, "obj.name", "function updateName(obj) {\n    obj.name = \"Geändert\";\n}\n\nlet person = { name: \"Original\" };\nupdateName(person);\nconsole.log(person.name);\n", "Objekte: Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", 102, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `fs.readFileSync(0)` für synchrones Einlesen von der Konsole.", "Eingabe war: JS", "const fs = require('fs');\n// Lese von stdin\nlet input = fs.readFileSync(0).toString().trim();\nconsole.log(\"Eingabe war: \" + input);\n", 102, 2, "readFileSync", "const fs = require('fs');\nlet input = fs.readFileSync(0).toString().trim();\nconsole.log(\"Eingabe war: \" + input);\n", "readline: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Welches Modul wird für den Zugriff auf das Dateisystem und stdin benötigt?", "Gelesen!", "const fs = ____('fs');\n\nlet data = fs.readFileSync(0);\nconsole.log(\"Gelesen!\");\n", 102, 3, "require", "const fs = require('fs');\nlet data = fs.readFileSync(0);\nconsole.log(\"Gelesen!\");\n", "Lückentext: fs Modul" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", 103, null, null, "Branch Prediction und Sprungtabellen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "let zahl = -5;\n// Dein Code hier\n", 103, "if,else", "let zahl = -5;\nif (zahl > 0) {\n    console.log(\"Positiv\");\n} else {\n    console.log(\"Negativ\");\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden.", "", "", "javascript", 104, null, null, "Effizienz von Schleifen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "// Dein Code hier\n", "javascript", 104, "for", "for (let i = 1; i <= 5; i++) {\n    console.log(i);\n}\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "let summe = 0;\nlet i = 1;\n// Dein Code hier\n", "javascript", 104, "while", "let summe = 0;\nlet i = 1;\nwhile (i < 5) {\n    summe += i;\n    i++;\n}\nconsole.log(summe);\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "javascript", 105, 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in JavaScript.", "Hallo Welt!", "console.log();", "javascript", 105, 2, "console.log", "console.log(\"Hallo Welt!\");", "JS: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Erstelle eine Funktion 'begruessung', die 'Hallo' zurückgibt.", "Hallo", "function begruessung() {\n    // Dein Code hier\n}\nconsole.log(begruessung());", "javascript", 105, 3, "function,return", "JS: Funktionen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", 106, 1, null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", 106, 2, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    var a int = 10\n    b := 5\n    fmt.Println(a + b)\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", 106, 3, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    a := 2.5\n    b := 5.0\n    fmt.Println(a * b)\n}", "Gleitkommazahlen (float64)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei Strings in Go.", "Hallo Welt", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", 106, 4, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    s1 := \"Hallo \"\n    s2 := \"Welt\"\n    fmt.Println(s1 + s2)\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    // Dein Code\n}", 106, 5, "if,fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    if isActive {\n        fmt.Println(\"Wahr\")\n    } else {\n        fmt.Println(\"Falsch\")\n    }\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", 107, 1, null, null, "Branch Prediction und Sprungtabellen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    // Dein Code hier\n}\n", "go", 107, 2, "if,else", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    if zahl > 0 {\n        fmt.Print(\"Positiv\")\n    } else {\n        fmt.Print(\"Negativ\")\n    }\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "go", 108, 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Go ist eine bei Google entwickelte Open-Source-Programmiersprache, die sich durch Effizienz und Einfachheit auszeichnet.", "", "", "go", 108, 2, null, null, "Was ist Go?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}\n", "go", 108, 3, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    fmt.Println(\"Hallo Welt!\")\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "go", 109, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `fmt.Scanln`, um einen String einzulesen. Übergib die Adresse der Variable mit `&`.", "Gelesen: Go", "package main\nimport \"fmt\"\n\nfunc main() {\n    var input string\n    // Nutze fmt.Scanln\n    fmt.Scanln(&input)\n    fmt.Print(\"Gelesen: \" + input)\n}\n", "go", 109, 2, "Scanln,&input", "package main\nimport \"fmt\"\n\nfunc main() {\n    var input string\n    fmt.Scanln(&input)\n    fmt.Print(\"Gelesen: \" + input)\n}\n", "Scanln: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Welches Zeichen wird benötigt, um die Adresse einer Variable an Scanln zu übergeben?", "OK", "package main\nimport \"fmt\"\n\nfunc main() {\n    var x int\n    fmt.Scanln(__x) // Lücke füllen\n    fmt.Print(\"OK\")\n}\n", "go", 109, 3, "&x", "package main\nimport \"fmt\"\n\nfunc main() {\n    var x int\n    fmt.Scanln(&x)\n    fmt.Print(\"OK\")\n}\n", "Lückentext: Adressoperator in Go" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "go", 110, 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Vervollständige die Funktion `updateName`, sodass sie den Namen lokal ändert, aber das Original in `main` unverändert bleibt.", "Original", "package main\nimport \"fmt\"\n\nfunc updateName(n string) {\n    // Name ändern\n    n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateName(name)\n    fmt.Print(name)\n}\n", "go", 110, 2, "n = \"Geändert\"", "package main\nimport \"fmt\"\n\nfunc updateName(n string) {\n    n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateName(name)\n    fmt.Print(name)\n}\n", "Call by Value in Go", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*string`), um den Wert des Originals zu verändern.", "Geändert", "package main\nimport \"fmt\"\n\nfunc updateNamePtr(n *string) {\n    // Ändere den Wert, auf den der Pointer zeigt\n    *n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    // Übergebe die Adresse mit &\n    updateNamePtr(&name)\n    fmt.Print(name)\n}\n", "go", 110, 3, "*string,*n,&name", "package main\nimport \"fmt\"\n\nfunc updateNamePtr(n *string) {\n    *n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateNamePtr(&name)\n    fmt.Print(name)\n}\n", "Call by Pointer in Go" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um eine Zahl per Pointer zu verdoppeln.", "20", "package main\nimport \"fmt\"\n\nfunc double(n ___int) { // Pointer-Typ\n    ___n = ___n * 2     // Dereferenzierung\n}\n\nfunc main() {\n    x := 10\n    double(___x)        // Adresse übergeben\n    fmt.Print(x)\n}\n", "go", 110, 4, "*int,*n,&x", "package main\nimport \"fmt\"\n\nfunc double(n *int) {\n    *n = *n * 2\n}\n\nfunc main() {\n    x := 10\n    double(&x)\n    fmt.Print(x)\n}\n", "Lückentext: Pointer-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", 111, 1, null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", 111, 2, "int,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int a = 10;\n		int b = 5;\n		Console.WriteLine(a + b);\n	}\n}", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie mit einer anderen Zahl und gib das Ergebnis aus.", "12.5", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", 111, 3, "double,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		double a = 2.5;\n		double b = 5.0;\n		Console.WriteLine(a * b);\n	}\n}", null, "Gleitkommazahlen (Double)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei Strings und gib sie aus.", "Hallo Welt", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 111, 4, "string,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		string s1 = \"Hallo \";\n		string s2 = \"Welt\";\n		Console.WriteLine(s1 + s2);\n	}\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende eine bool-Variable in einer if-Anweisung, um 'Wahr' auszugeben, wenn sie true ist, sonst 'Falsch'.", "Wahr", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		// Dein Code\n	}\n}", "csharp", 111, 5, "bool,if,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		if (isActive)\n		{\n			Console.WriteLine(\"Wahr\");\n		}\n		else\n		{\n			Console.WriteLine(\"Falsch\");\n		}\n	}\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", "csharp", 112, 1, null, null, "Branch Prediction und Sprungtabellen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", "csharp", 112, 2, "if,else", null, "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden.", "", "", "csharp", 113, 1, null, null, "Effizienz von Schleifen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Berechne die Summe der Zahlen 1 bis 5.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", "csharp", 113, 2, "for", null, "For-Schleife: Summe" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "csharp", 114, 1, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { null, null, "Lies einen Namen mit `Console.ReadLine()` ein.", "Hallo CSharp", "using System;\n\npublic class Program {\n    public static void Main() {\n        // Lese von der Konsole\n        string name = Console.ReadLine();\n        Console.Write(\"Hallo \" + name);\n    }\n}\n", "csharp", 114, 2, "Console.ReadLine", "using System;\n\npublic class Program {\n    public static void Main() {\n        string name = Console.ReadLine();\n        Console.Write(\"Hallo \" + name);\n    }\n}\n", "ReadLine: Einlesen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Wandle die Eingabe mit `int.Parse()` in eine Zahl um.", "20", "using System;\n\npublic class Program {\n    public static void Main() {\n        string s = Console.ReadLine();\n        // Lücke: int x = ___.Parse(s);\n        int x = ___.Parse(s);\n        Console.Write(x * 2);\n    }\n}\n", "csharp", 114, 3, "int.Parse", "using System;\n\npublic class Program {\n    public static void Main() {\n        string s = Console.ReadLine();\n        int x = int.Parse(s);\n        Console.Write(x * 2);\n    }\n}\n", "Lückentext: String zu Zahl" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "csharp", 115, 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C# ist eine objektorientierte Sprache von Microsoft.", "", "", "csharp", 115, 2, null, null, "Was ist C#?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 115, 3, "Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		Console.WriteLine(\"Hallo Welt!\");\n	}\n}", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "csharp", 116, 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `ref`-Keyword, um den Wert der Variable `zahl` in der Methode `Verdopple` zu ändern.", "10", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        // Nutze ref auch beim Aufruf\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", "csharp", 116, 2, "ref int,ref zahl", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das ref Keyword" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `out`-Keyword, um einen Wert von einer Methode zurückzugeben, ohne den Rückgabewert zu nutzen.", "42", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        // out Variablen MÜSSEN in der Methode zugewiesen werden\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", "csharp", 116, 3, "out int,out zahl", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das out Keyword" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `ref` oder `out`.", "x=2,y=1", "using System;\n\npublic class Program\n{\n    static void Swap(____ int a, ____ int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(____ x, ____ y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", "csharp", 116, 4, "ref int,ref x", "using System;\n\npublic class Program\n{\n    static void Swap(ref int a, ref int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(ref x, ref y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", "Lückentext: C# Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Objekte einer Klasse werden im Heap gespeichert. Ein Objekt enthält nicht nur seine Datenfelder, sondern oft auch einen Zeiger auf eine Virtual Method Table (VTable), die es ermöglicht, zur Laufzeit die richtigen Methodenaufrufe (Polymorphismus) zuzuordnen.", "", "csharp", 117, 1, null, null, "Objektlayout im Speicher", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'.", "", "public class Calculator \n{\n    // Hier deine Methode\n}", "csharp", 117, 2, "class,Calculator,static,int", null, "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "LessonId", "Title" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", 118, "Branch Prediction und Sprungtabellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Zahl `x` größer als 10 ist. Gib 'Groß' aus, ansonsten 'Klein'.", "Groß", "fn main() {\n    let x = 15;\n    // Dein Code hier\n}\n", 118, "if,else", "fn main() {\n    let x = 15;\n    if x > 10 {\n        println!(\"Groß\");\n    } else {\n        println!(\"Klein\");\n    }\n}\n", "Einfaches if/else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Rust hat eine endlose Schleife namens `loop`. Nutze `break`, um sie zu verlassen, wenn `i` den Wert 5 erreicht hat. Gib `i` in jedem Durchgang aus.", "0\n1\n2\n3\n4\n5", "fn main() {\n    let mut i = 0;\n    loop {\n        // Dein Code hier\n        i += 1;\n    }\n}\n", 118, 3, "loop,break", "fn main() {\n    let mut i = 0;\n    loop {\n        println!(\"{}\", i);\n        if i == 5 {\n            break;\n        }\n        i += 1;\n    }\n}\n", "Die `loop` Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while` Schleife, um die Zahlen von 3 bis 1 (herunterzählend) auszugeben.", "3\n2\n1", "fn main() {\n    let mut n = 3;\n    // Dein Code hier\n}\n", 118, 4, "while", "fn main() {\n    let mut n = 3;\n    while n > 0 {\n        println!(\"{}\", n);\n        n -= 1;\n    }\n}\n", "While Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", 119, 1, null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine i32-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "fn main() {\n    // Dein Code\n}", "rust", 119, 2, "let,println!", "fn main() {\n    let a: i32 = 10;\n    let b: i32 = 5;\n    println!(\"{}\", a + b);\n}", "Ganzzahlen (i32)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine f64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "fn main() {\n    // Dein Code\n}", "rust", 119, 3, "f64,println!", "fn main() {\n    let a: f64 = 2.5;\n    let b: f64 = 5.0;\n    println!(\"{}\", a * b);\n}", "Gleitkommazahlen (f64)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "fn main() {\n    // Dein Code\n}", "rust", 119, 4, "String,println!", "fn main() {\n    let s1 = String::from(\"Hallo \");\n    let s2 = \"Welt\";\n    println!(\"{}{}\", s1, s2);\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "fn main() {\n    let is_active = true;\n    // Dein Code\n}", "rust", 119, 5, "bool,if,println!", "fn main() {\n    let is_active = true;\n    if is_active {\n        println!(\"Wahr\");\n    } else {\n        println!(\"Falsch\");\n    }\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "rust", 120, 1, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "[\"Damit sie schneller geladen wird\", \"Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen\", \"Um anzuzeigen, dass es ein String ist\", \"Das mut ist optional\"]", "Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen", "Warum muss die Variable für die Eingabe mit `mut` deklariert werden (z.B. `let mut input`)?", "", "", "rust", 120, 2, null, null, "Anatomie der Eingabe", 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust nutzt man `std::io::stdin()`, um Eingaben einzulesen. <br>Lies einen Namen von der Tastatur ein und gib 'Hallo [Name]!' aus. <br>Hinweis: Tippe in das Eingabefeld rechts das Wort 'Rust' ein, bevor du auf Ausführen klickst.", "Hallo Rust!", "use std::io;\n\nfn main() {\n    let mut input = String::new(); // Erstellt einen Puffer\n    \n    // Deine Aufgabe: Nutze io::stdin().read_line(&mut input).unwrap();\n    \n    println!(\"Hallo {}!\", input.trim());\n}\n", "rust", 120, 3, "read_line", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    println!(\"Hallo {}!\", input.trim());\n}\n", "Einen String einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies eine Zahl von der Tastatur ein, verdopple sie und gib das Ergebnis aus. <br>Hinweis: Nutze `.trim().parse::<i32>().unwrap()`, um den String in eine Zahl zu wandeln. <br>Tippe die Zahl '21' in das Eingabefeld.", "Ergebnis: 42", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    // Deine Aufgabe: Wandle 'input' in eine Zahl 'n' um\n    // let n: i32 = ...\n    \n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "rust", 120, 3, "parse", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let n: i32 = input.trim().parse().unwrap();\n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "Zahl einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies zwei Zahlen nacheinander ein und gib deren Summe aus. <br>Wichtig: Das Eingabefeld unterstützt aktuell nur eine Zeile. Trenne deine beiden Zahlen im Eingabefeld mit einem Leerzeichen (z.B. '10 5').", "Summe: 15", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    \n    println!(\"Summe: {}\", a + b);\n}\n", "rust", 120, 4, "split_whitespace", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    println!(\"Summe: {}\", a + b);\n}\n", "Zwei Zahlen addieren" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "rust", 121, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "In Rust kannst du viele unveränderbare Referenzen haben, aber nur eine veränderbare. Fülle die Lücken, um den Wert zu lesen und zu schreiben.", "Lesen: 10\nNeu: 20", "fn main() {\n    let mut data = 10;\n    \n    let r1 = &data; // Immutable\n    println!(\"Lesen: {}\", r1);\n    \n    // Lücke: Erstelle eine veränderbare Referenz\n    let r2 = ________;\n    *r2 += 10;\n    \n    println!(\"Neu: {}\", data);\n}\n", "rust", 121, 2, "&mut data,*r2", "fn main() {\n    let mut data = 10;\n    let r1 = &data;\n    println!(\"Lesen: {}\", r1);\n    \n    let r2 = &mut data;\n    *r2 += 10;\n    println!(\"Neu: {}\", data);\n}\n", "Immutable vs Mutable", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `Box<T>`, um einen Wert auf dem Heap zu speichern. Vervollständige die Zeile mit `Box::new()`.", "Heap Wert: 50", "fn main() {\n    // Speichere die Zahl 50 auf dem Heap\n    let heap_val = Box::new(50);\n    \n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", "rust", 121, 3, "Box::new,*heap_val", "fn main() {\n    let heap_val = Box::new(50);\n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", "Box: Smart Pointer auf dem Heap" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Referenzen können automatisch dereferenziert werden. Übergebe eine Referenz an eine Funktion, die einen primitiven Typ erwartet.", "Zahl: 42", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    // Übergebe den Wert hinter der Referenz\n    print_int(*r);\n}\n", "rust", 121, 4, "*r", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    print_int(*r);\n}\n", "Deref Coercion" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "rust", 122, 1, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Zeile, um einen neuen, leeren String-Puffer zu erstellen. <br>Nutze `String::new()`.", "Puffer bereit.", "fn main() {\n    // Vervollständige: let mut input = ...\n    let mut input = ___________;\n    \n    println!(\"Puffer bereit.\");\n}\n", "rust", 122, 2, "String::new", "fn main() {\n    let mut input = String::new();\n    println!(\"Puffer bereit.\");\n}\n", "Lücke: Den Puffer erstellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`.", "Bitte etwas tippen:\nGelesen!", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    \n    // Lücke: io::stdin().read_line(____ buffer).unwrap();\n    io::stdin().read_line(____ buffer).unwrap();\n    \n    println!(\"Gelesen!\");\n}\n", "rust", 122, 3, "&mut", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    io::stdin().read_line(&mut buffer).unwrap();\n    println!(\"Gelesen!\");\n}\n", "Lücke: Die Referenz" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`.", "", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    \n    // Lücke: ____::stdin().read_line(&mut input).unwrap();\n    ____::stdin().read_line(&mut input).unwrap();\n}\n", "rust", 122, 4, "io::stdin", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n}\n", "Lücke: Das Modul aufrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe die komplette Zeile, um eine Eingabe in die Variable `text` einzulesen. <br>Vergiss das `.unwrap()` am Ende nicht!", "Eingabe erfolgt.", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    \n    // Schreibe hier die komplette read_line Zeile:\n    \n    println!(\"Eingabe erfolgt.\");\n}\n", "rust", 122, 5, "read_line,&mut,unwrap", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    io::stdin().read_line(&mut text).unwrap();\n    println!(\"Eingabe erfolgt.\");\n}\n", "Lücke: Alles zusammen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "rust", 123, 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", "rust", 123, 2, null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", "rust", 123, 3, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "rust", 124, "Referenzsemantik und Speichersicherheit" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `laenge`, sodass sie die Länge eines Strings berechnet, ohne den Besitz (Ownership) zu übernehmen.", "Die Länge von 'Hallo' ist 5.", "fn laenge(s: &String) -> usize {\n    // Berechne die Länge\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    // Übergebe eine Referenz mit &\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "rust", 124, "&String,&s1", "fn laenge(s: &String) -> usize {\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "Unveränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `&mut`, um den Inhalt eines Strings in einer Funktion zu verändern.", "Hallo, Welt", "fn aendern(s: &mut String) {\n    // Füge Text an\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    // Übergebe eine veränderbare Referenz mit &mut\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "rust", 124, 3, "&mut String,&mut s", "fn aendern(s: &mut String) {\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "Veränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `&` oder `&mut`.", "Lesen: Daten\nDaten...geändert", "fn main() {\n    let ___ s = String::from(\"Daten\");\n    \n    process_read(___s);  // Nur Lesen\n    process_write(___s); // Schreiben\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: ___String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: ___String) {\n    s.push_str(\"...geändert\");\n}\n", "rust", 124, 4, "&s,&mut s,&String,&mut String", "fn main() {\n    let mut s = String::from(\"Daten\");\n    \n    process_read(&s);\n    process_write(&mut s);\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: &String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: &mut String) {\n    s.push_str(\"...geändert\");\n}\n", "Lückentext: Rust Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "cpp", 125, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um die Adresse von `zahl` in einem Raw Pointer zu speichern und den Wert darüber auszugeben.", "Wert: 100", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    // Lücke: int* ptr = ...\n    int* ptr = ________;\n    \n    // Lücke: Wert über Pointer ausgeben (Dereferenzierung)\n    std::cout << \"Wert: \" << ________;\n    return 0;\n}\n", "cpp", 125, "&zahl,*ptr", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    int* ptr = &zahl;\n    std::cout << \"Wert: \" << *ptr;\n    return 0;\n}\n", "Raw Pointer: Adresse abrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `std::unique_ptr`, um Speicher auf dem Heap sicher zu verwalten. Erstelle einen `unique_ptr<int>` mit `std::make_unique`.", "Smart Wert: 42", "#include <iostream>\n#include <memory>\n\nint main() {\n    // Erstelle einen unique_ptr für den Wert 42\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    \n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", "cpp", 125, "unique_ptr,make_unique", "#include <iostream>\n#include <memory>\n\nint main() {\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", "Smart Pointer: unique_ptr" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Ein `shared_ptr` erlaubt es mehreren Pointern, denselben Speicher zu besitzen. Erstelle einen `shared_ptr` und gib den `use_count()` aus.", "Count: 2", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        // Erstelle eine Kopie von p1\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "cpp", 125, 4, "make_shared,use_count", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "Smart Pointer: shared_ptr" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", "cpp", 126, 1, null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus.", "15", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 126, 2, "int,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 126, 3, "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'string', um zwei Texte zu verknüpfen.", "Hallo Welt", "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 126, 4, "string,cout", "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "#include <iostream>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "cpp", 126, 5, "bool,if,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        cout << \"Wahr\";\n    } else {\n        cout << \"Falsch\";\n    }\n    return 0;\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "cpp", 127, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `std::cin` mit dem `>>` Operator, um eine Zahl einzulesen.", "Gelesen: 42", "#include <iostream>\n\nint main() {\n    int zahl;\n    // Nutze cin zum Einlesen\n    std::cin >> zahl;\n    std::cout << \"Gelesen: \" << zahl;\n    return 0;\n}\n", "cpp", 127, "cin >>", "#include <iostream>\n\nint main() {\n    int zahl;\n    std::cin >> zahl;\n    std::cout << \"Gelesen: \" << zahl;\n    return 0;\n}\n", "std::cin: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Welcher Operator wird für Eingaben mit `cin` verwendet?", "OK", "#include <iostream>\n\nint main() {\n    int x;\n    std::cin __ x; // Lücke füllen\n    std::cout << \"OK\";\n    return 0;\n}\n", "cpp", 127, 3, ">>", "#include <iostream>\n\nint main() {\n    int x;\n    std::cin >> x;\n    std::cout << \"OK\";\n    return 0;\n}\n", "Lückentext: cin Operator" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", "cpp", 128, 1, null, null, "Branch Prediction und Sprungtabellen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 128, 2, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "cpp", 129, 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "", "", "cpp", 129, 2, null, null, "Was ist C++?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 129, 3, "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "cpp", 130, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt (Call by Value).", "Wert nach Funktion: 5", "#include <iostream>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 130, "x = x * 2", "#include <iostream>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine Referenz (`&`), um den Wert der Originalvariable in der Funktion `verdoppleRef` dauerhaft zu ändern.", "Geänderter Wert: 10", "#include <iostream>\n\n// Nutze & für Call by Reference\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 130, "int&", "#include <iostream>\n\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Reference" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Wert über Pointer: 10", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 130, "int*,&zahl", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Pointer" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit der richtigen Syntax für Pointer und Referenzen.", "x=2, y=1", "#include <iostream>\n\nvoid swap(int__ a, int__ b) { // Nutze & für Referenzen\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=\" << x << \", y=\" << y;\n    return 0;\n}\n", "cpp", 130, 5, "int&", "#include <iostream>\n\nvoid swap(int& a, int& b) {\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=2, y=1\";\n    return 0;\n}\n", "Lückentext: Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", "c", 131, 1, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "15", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 131, 2, "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", null, "Ganzzahlen (int)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 131, 3, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "Hallo Welt", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 131, 4, "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "Wahr", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "c", 131, 5, "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", "c", 132, 1, null, null, "Branch Prediction und Sprungtabellen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "InitialCode", "Language", "LessonId", "Order", "Solution" },
                values: new object[] { "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", 132, 2, "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "c", 133, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", "c", 133, null, null, "Was ist C?", 0 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1118, null, null, "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 133, 3, null, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", null, "Hallo Welt", 1 },
                    { 1119, null, null, "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "c", 134, 1, null, null, null, null, "Systemcalls und Buffering", 0 },
                    { 1120, null, null, "Lies eine Ganzzahl mit `scanf` ein und gib sie aus.", "Zahl: 100", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    // scanf nutzt %d und den Adressoperator &\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", "c", 134, 2, null, "scanf,&zahl", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", null, "scanf: Ganzzahlen", 1 },
                    { 1121, null, null, "Bei `scanf` musst du immer die Adresse der Variable angeben. Welches Zeichen wird dafür benötigt?", "OK", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", __x); // Lücke füllen\n    printf(\"OK\");\n    return 0;\n}\n", "c", 134, 3, null, "&x", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", &x);\n    printf(\"OK\");\n    return 0;\n}\n", null, "Lückentext: Adressoperator", 1 },
                    { 1122, null, null, "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "c", 135, 1, null, null, null, null, "Referenzsemantik und Speichersicherheit", 0 },
                    { 1123, null, null, "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Wert nach Funktion: 5", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "c", 135, 2, null, "x = x * 2", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", null, "Call by Value in C", 1 },
                    { 1124, null, null, "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Geänderter Wert: 10", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl mit &\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "c", 135, 3, null, "int *,*x,&zahl", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", null, "Call by Pointer in C", 1 },
                    { 1125, null, null, "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen.", "x=2, y=1", "#include <stdio.h>\n\nvoid swap(int ____ a, int ____ b) {\n    int temp = ____ a;\n    ____ a = ____ b;\n    ____ b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=%d, y=%d\", x, y);\n    return 0;\n}\n", "c", 135, 4, null, "int *,* a,* b", "#include <stdio.h>\n\nvoid swap(int * a, int * b) {\n    int temp = * a;\n    * a = * b;\n    * b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=2, y=1\");\n    return 0;\n}\n", null, "Lückentext: Pointer-Syntax", 1 },
                    { 1126, null, null, "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", "python", 136, 1, null, null, null, null, "Speicherverwaltung von Variablen", 0 },
                    { 1127, null, null, "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "# Dein Code hier", "python", 136, 2, null, "print", "a = 10\nb = 5\nprint(a + b)", null, "Ganzzahlen (Integer)", 1 },
                    { 1128, null, null, "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "python", 136, 3, null, "print", "a = 2.5\nb = 5\nprint(a * b)", null, "Gleitkommazahlen (Float)", 1 },
                    { 1129, null, null, "Strings können in Python mit dem + Operator verknüpft werden.", "Hallo Welt", "# Dein Code hier", "python", 136, 4, null, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", null, "Zeichenketten (String)", 1 },
                    { 1130, null, null, "Verwende einen Boolean (True/False) in einer if-Anweisung.", "Wahr", "is_active = True\n# Dein Code", "python", 136, 5, null, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", null, "Booleans (Wahrheitswerte)", 1 },
                    { 1131, null, null, "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "python", 137, 1, null, null, null, null, "Referenzsemantik und Speichersicherheit", 0 },
                    { 1132, null, null, "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "def verdopple(x):\n    # x lokal verdoppeln\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "python", 137, 2, null, "x = x * 2", "def verdopple(x):\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", null, "Unveränderliche Typen (Integers)", 1 },
                    { 1133, null, null, "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden.", "Python", "def add_element(liste):\n    # Füge \"Python\" zur Liste hinzu\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "python", 137, 3, null, "append", "def add_element(liste):\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", null, "Veränderliche Typen (Listen)", 1 },
                    { 1134, null, null, "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", "python", 138, 1, null, null, null, null, "Branch Prediction und Sprungtabellen", 0 },
                    { 1135, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", 138, 2, null, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", null, "Logik: Positiv/Negativ", 1 },
                    { 1136, null, null, "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", 138, 3, null, "for,in,range", "for i in range(1, 4):\n    print(i)\n", null, "Zahlen von 1 bis 3 ausgeben", 1 },
                    { 1137, null, null, "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden.", "", "", "python", 139, 1, null, null, null, null, "Effizienz von Schleifen", 0 },
                    { 1138, null, null, "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", "python", 139, 2, null, "for,in,range", "for i in range(1, 6):\n    print(i)\n", null, "Zahlen 1 bis 5", 1 },
                    { 1139, null, null, "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", "python", 139, 3, null, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", null, "Summe bis 10", 1 },
                    { 1140, null, null, "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "python", 140, 1, null, null, null, null, "Wie Programme funktionieren", 0 },
                    { 1141, null, null, "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", 140, 2, null, null, null, null, "Was ist Python?", 0 },
                    { 1142, null, null, "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", 140, 3, null, "print", "print(\"Hallo Welt!\")\n", null, "Hallo Welt", 1 },
                    { 1143, null, null, "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "python", 141, 1, null, null, null, null, "Systemcalls und Buffering", 0 },
                    { 1144, null, null, "Nutze `input()`, um einen Namen einzulesen und gib 'Hallo [Name]' aus. <br>Hinweis: Tippe deinen Namen in das Eingabefeld rechts unten.", "Hallo Python", "# Lese den Namen ein\nname = input()\nprint(\"Hallo \" + name)\n", "python", 141, 2, null, "input", "name = input()\nprint(\"Hallo \" + name)\n", null, "input() Grundlagen", 1 },
                    { 1145, null, null, "Eingaben von `input()` sind immer Strings. Wandle die Eingabe in ein `int` um, um damit zu rechnen.", "20", "# Lücke: zahl = ___(input())\nzahl = ___(input())\nprint(zahl * 2)\n", "python", 141, 3, null, "int", "zahl = int(input())\nprint(zahl * 2)\n", null, "Lückentext: Typumwandlung", 1 },
                    { 1146, null, null, "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", "java", 142, 1, null, null, null, null, "Speicherverwaltung von Variablen", 0 },
                    { 1147, null, null, "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 142, 2, null, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", null, "Ganzzahlen (int)", 1 },
                    { 1148, null, null, "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 142, 3, null, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", null, "Gleitkommazahlen (double)", 1 },
                    { 1149, null, null, "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 142, 4, null, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", null, "Zeichenketten (String)", 1 },
                    { 1150, null, null, "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", "java", 142, 5, null, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", null, "Booleans (boolean)", 1 },
                    { 1151, null, null, "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "java", 143, 1, null, null, null, null, "Wie Programme funktionieren", 0 },
                    { 1152, null, null, "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", 143, 2, null, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", null, "Java: Hallo Welt", 1 },
                    { 1153, null, null, "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 143, 3, null, "if", null, null, "Java: If-Else", 1 },
                    { 1154, null, null, "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 143, 4, null, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 },
                    { 1155, null, null, "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "java", 144, 1, null, null, null, null, "Referenzsemantik und Speichersicherheit", 0 },
                    { 1156, null, null, "Versuche den Wert von `x` in der Methode `verdopple` zu ändern. Bleibt das Original in `main` gleich?", "5", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "java", 144, 2, null, "x = x * 2", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", null, "Primitive: Pass by Value", 1 },
                    { 1157, null, null, "In Java werden Objektreferenzen per Wert übergeben. Du kannst das Objekt verändern, aber nicht die Referenz selbst.", "Java", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        // Füge ein Element hinzu\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "java", 144, 3, null, "list.add", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", null, "Objekte: Referenz ändern", 1 },
                    { 1158, null, null, "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "java", 145, 1, null, null, null, null, "Systemcalls und Buffering", 0 },
                    { 1159, null, null, "Nutze die `Scanner`-Klasse, um einen Namen einzulesen.", "Hallo Java", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        // Erstelle einen Scanner\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", "java", 145, 2, null, "Scanner,System.in", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", null, "Scanner: Einlesen", 1 },
                    { 1160, null, null, "Welche Methode des Scanners liest die nächste Ganzzahl ein?", "42", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        // Lücke: int x = sc.____();\n        int x = sc.____();\n        System.out.print(x);\n    }\n}\n", "java", 145, 3, null, "nextInt", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        int x = sc.nextInt();\n        System.out.print(x);\n    }\n}\n", null, "Lückentext: Nächste Zahl", 1 },
                    { 1161, null, null, "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", "java", 146, 1, null, null, null, null, "Branch Prediction und Sprungtabellen", 0 },
                    { 1162, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 146, 2, null, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", null, "Logik: Positiv/Negativ", 1 },
                    { 1163, null, null, "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden.", "", "", "java", 147, 1, null, null, null, null, "Effizienz von Schleifen", 0 },
                    { 1164, null, null, "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", "java", 147, 2, null, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", null, "Zahlen 1 bis 5", 1 },
                    { 1165, null, null, "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", "java", 147, 3, null, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", null, "Summe bis 10", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "In JavaScript gibt es den Typ 'number' für alle Zahlen. Erstelle eine Variable mit let, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "// Dein Code hier", "let,console.log", "let a = 10;\nlet b = 5;\nconsole.log(a + b);", "Ganzzahlen (Number)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Description", "ExpectedOutput", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Auch Gleitkommazahlen sind in JavaScript vom Typ 'number'. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "console.log", "let a = 2.5;\nlet b = 5;\nconsole.log(a * b);", "Gleitkommazahlen (Number)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende String Interpolation (Backticks ``), um zwei Variablen in einem String auszugeben.", "Hallo Welt", "const s1 = \"Hallo\";\nconst s2 = \"Welt\";\n// Dein Code hier", "console.log,$,{", "const s1 = \"Hallo\";\nconst s2 = \"Welt\";\nconsole.log(`${s1} ${s2}`);", "Zeichenketten (String Interpotalion)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "let isActive = true;\n// Dein Code hier", "if,console.log", "let isActive = true;\nif (isActive) {\n    console.log(\"Wahr\");\n} else {\n    console.log(\"Falsch\");\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `zahl` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "function verdopple(x) {\n    x = x * 2;\n}\n\nlet zahl = 5;\nverdopple(zahl);\nconsole.log(zahl);\n", 101, 1, "x = x * 2", "function verdopple(x) {\n    x = x * 2;\n}\n\nlet zahl = 5;\nverdopple(zahl);\nconsole.log(zahl);\n", "Primitive: Pass by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "In JS werden Objekte über eine Referenz übergeben. Ändere die Eigenschaft `name` des Objekts in der Funktion.", "Geändert", "function updateName(obj) {\n    // Ändere obj.name zu \"Geändert\"\n    obj.name = \"Geändert\";\n}\n\nlet person = { name: \"Original\" };\nupdateName(person);\nconsole.log(person.name);\n", 2, "obj.name", "function updateName(obj) {\n    obj.name = \"Geändert\";\n}\n\nlet person = { name: \"Original\" };\nupdateName(person);\nconsole.log(person.name);\n", "Objekte: Referenzen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `fs.readFileSync(0)` für synchrones Einlesen von der Konsole.", "Eingabe war: JS", "const fs = require('fs');\n// Lese von stdin\nlet input = fs.readFileSync(0).toString().trim();\nconsole.log(\"Eingabe war: \" + input);\n", 102, 1, "readFileSync", "const fs = require('fs');\nlet input = fs.readFileSync(0).toString().trim();\nconsole.log(\"Eingabe war: \" + input);\n", "readline: Einlesen" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "let zahl = -5;\n// Dein Code hier\n", 103, "if,else", "let zahl = -5;\nif (zahl > 0) {\n    console.log(\"Positiv\");\n} else {\n    console.log(\"Negativ\");\n}\n", "Logik: Positiv/Negativ", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "// Dein Code hier\n", 104, 1, "for", "for (let i = 1; i <= 5; i++) {\n    console.log(i);\n}\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "let summe = 0;\nlet i = 1;\n// Dein Code hier\n", 104, 2, "while", "let summe = 0;\nlet i = 1;\nwhile (i < 5) {\n    summe += i;\n    i++;\n}\nconsole.log(summe);\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Schreibe 'Hallo Welt!' in JavaScript.", "Hallo Welt!", "console.log();", 105, "console.log", "console.log(\"Hallo Welt!\");", "JS: Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine Funktion 'begruessung', die 'Hallo' zurückgibt.", "Hallo", "function begruessung() {\n    // Dein Code hier\n}\nconsole.log(begruessung());", 105, "function,return", null, "JS: Funktionen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", "go", 106, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    var a int = 10\n    b := 5\n    fmt.Println(a + b)\n}", "Ganzzahlen (int)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", "go", 106, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    a := 2.5\n    b := 5.0\n    fmt.Println(a * b)\n}", "Gleitkommazahlen (float64)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei Strings in Go.", "Hallo Welt", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}", "go", 106, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    s1 := \"Hallo \"\n    s2 := \"Welt\"\n    fmt.Println(s1 + s2)\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    // Dein Code\n}", "go", 106, 4, "if,fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    if isActive {\n        fmt.Println(\"Wahr\")\n    } else {\n        fmt.Println(\"Falsch\")\n    }\n}", "Booleans (bool)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    // Dein Code hier\n}\n", "go", 107, 1, "if,else", "package main\nimport \"fmt\"\nfunc main() {\n    zahl := -5\n    if zahl > 0 {\n        fmt.Print(\"Positiv\")\n    } else {\n        fmt.Print(\"Negativ\")\n    }\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Go ist eine bei Google entwickelte Open-Source-Programmiersprache, die sich durch Effizienz und Einfachheit auszeichnet.", "", "", "go", 108, 1, null, "Was ist Go?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}\n", 108, 2, "fmt.Println", "package main\n\nimport \"fmt\"\n\nfunc main() {\n    fmt.Println(\"Hallo Welt!\")\n}\n", "Hallo Welt", 1 });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Welches Zeichen wird benötigt, um die Adresse einer Variable an Scanln zu übergeben?", "OK", "package main\nimport \"fmt\"\n\nfunc main() {\n    var x int\n    fmt.Scanln(__x) // Lücke füllen\n    fmt.Print(\"OK\")\n}\n", 109, 2, "&x", "package main\nimport \"fmt\"\n\nfunc main() {\n    var x int\n    fmt.Scanln(&x)\n    fmt.Print(\"OK\")\n}\n", "Lückentext: Adressoperator in Go" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `updateName`, sodass sie den Namen lokal ändert, aber das Original in `main` unverändert bleibt.", "Original", "package main\nimport \"fmt\"\n\nfunc updateName(n string) {\n    // Name ändern\n    n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateName(name)\n    fmt.Print(name)\n}\n", 110, 1, "n = \"Geändert\"", "package main\nimport \"fmt\"\n\nfunc updateName(n string) {\n    n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateName(name)\n    fmt.Print(name)\n}\n", "Call by Value in Go" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*string`), um den Wert des Originals zu verändern.", "Geändert", "package main\nimport \"fmt\"\n\nfunc updateNamePtr(n *string) {\n    // Ändere den Wert, auf den der Pointer zeigt\n    *n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    // Übergebe die Adresse mit &\n    updateNamePtr(&name)\n    fmt.Print(name)\n}\n", 110, 2, "*string,*n,&name", "package main\nimport \"fmt\"\n\nfunc updateNamePtr(n *string) {\n    *n = \"Geändert\"\n}\n\nfunc main() {\n    name := \"Original\"\n    updateNamePtr(&name)\n    fmt.Print(name)\n}\n", "Call by Pointer in Go" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Fülle die Lücken, um eine Zahl per Pointer zu verdoppeln.", "20", "package main\nimport \"fmt\"\n\nfunc double(n ___int) { // Pointer-Typ\n    ___n = ___n * 2     // Dereferenzierung\n}\n\nfunc main() {\n    x := 10\n    double(___x)        // Adresse übergeben\n    fmt.Print(x)\n}\n", 110, 3, "*int,*n,&x", "package main\nimport \"fmt\"\n\nfunc double(n *int) {\n    *n = *n * 2\n}\n\nfunc main() {\n    x := 10\n    double(&x)\n    fmt.Print(x)\n}\n", "Lückentext: Pointer-Syntax", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 111, 1, "int,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int a = 10;\n		int b = 5;\n		Console.WriteLine(a + b);\n	}\n}", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie mit einer anderen Zahl und gib das Ergebnis aus.", "12.5", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 111, 2, "double,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		double a = 2.5;\n		double b = 5.0;\n		Console.WriteLine(a * b);\n	}\n}", "Gleitkommazahlen (Double)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verknüpfe zwei Strings und gib sie aus.", "Hallo Welt", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 111, 3, "string,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		string s1 = \"Hallo \";\n		string s2 = \"Welt\";\n		Console.WriteLine(s1 + s2);\n	}\n}", "Zeichenketten (String)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende eine bool-Variable in einer if-Anweisung, um 'Wahr' auszugeben, wenn sie true ist, sonst 'Falsch'.", "Wahr", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		// Dein Code\n	}\n}", "csharp", 111, 4, "bool,if,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		if (isActive)\n		{\n			Console.WriteLine(\"Wahr\");\n		}\n		else\n		{\n			Console.WriteLine(\"Falsch\");\n		}\n	}\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", "csharp", 112, "if,else", "Logik: Positiv/Negativ", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Berechne die Summe der Zahlen 1 bis 5.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", "csharp", 113, 1, "for", null, "For-Schleife: Summe" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies einen Namen mit `Console.ReadLine()` ein.", "Hallo CSharp", "using System;\n\npublic class Program {\n    public static void Main() {\n        // Lese von der Konsole\n        string name = Console.ReadLine();\n        Console.Write(\"Hallo \" + name);\n    }\n}\n", "csharp", 114, 1, "Console.ReadLine", "using System;\n\npublic class Program {\n    public static void Main() {\n        string name = Console.ReadLine();\n        Console.Write(\"Hallo \" + name);\n    }\n}\n", "ReadLine: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Wandle die Eingabe mit `int.Parse()` in eine Zahl um.", "20", "using System;\n\npublic class Program {\n    public static void Main() {\n        string s = Console.ReadLine();\n        // Lücke: int x = ___.Parse(s);\n        int x = ___.Parse(s);\n        Console.Write(x * 2);\n    }\n}\n", "csharp", 114, 2, "int.Parse", "using System;\n\npublic class Program {\n    public static void Main() {\n        string s = Console.ReadLine();\n        int x = int.Parse(s);\n        Console.Write(x * 2);\n    }\n}\n", "Lückentext: String zu Zahl", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C# ist eine objektorientierte Sprache von Microsoft.", "", "", "csharp", 115, 1, null, null, "Was ist C#?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 115, 2, "Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		Console.WriteLine(\"Hallo Welt!\");\n	}\n}", "Hallo Welt" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze das `out`-Keyword, um einen Wert von einer Methode zurückzugeben, ohne den Rückgabewert zu nutzen.", "42", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        // out Variablen MÜSSEN in der Methode zugewiesen werden\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", 116, 2, "out int,out zahl", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das out Keyword", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `ref` oder `out`.", "x=2,y=1", "using System;\n\npublic class Program\n{\n    static void Swap(____ int a, ____ int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(____ x, ____ y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", 116, 3, "ref int,ref x", "using System;\n\npublic class Program\n{\n    static void Swap(ref int a, ref int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(ref x, ref y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", "Lückentext: C# Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'.", "", "public class Calculator \n{\n    // Hier deine Methode\n}", 117, 1, "class,Calculator,static,int", null, "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Zahl `x` größer als 10 ist. Gib 'Groß' aus, ansonsten 'Klein'.", "Groß", "fn main() {\n    let x = 15;\n    // Dein Code hier\n}\n", "rust", 118, 1, "if,else", "fn main() {\n    let x = 15;\n    if x > 10 {\n        println!(\"Groß\");\n    } else {\n        println!(\"Klein\");\n    }\n}\n", "Einfaches if/else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Rust hat eine endlose Schleife namens `loop`. Nutze `break`, um sie zu verlassen, wenn `i` den Wert 5 erreicht hat. Gib `i` in jedem Durchgang aus.", "0\n1\n2\n3\n4\n5", "fn main() {\n    let mut i = 0;\n    loop {\n        // Dein Code hier\n        i += 1;\n    }\n}\n", "rust", 118, 2, "loop,break", "fn main() {\n    let mut i = 0;\n    loop {\n        println!(\"{}\", i);\n        if i == 5 {\n            break;\n        }\n        i += 1;\n    }\n}\n", "Die `loop` Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine `while` Schleife, um die Zahlen von 3 bis 1 (herunterzählend) auszugeben.", "3\n2\n1", "fn main() {\n    let mut n = 3;\n    // Dein Code hier\n}\n", "rust", 118, 3, "while", "fn main() {\n    let mut n = 3;\n    while n > 0 {\n        println!(\"{}\", n);\n        n -= 1;\n    }\n}\n", "While Schleife", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine i32-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "fn main() {\n    // Dein Code\n}", "rust", 119, 1, "let,println!", "fn main() {\n    let a: i32 = 10;\n    let b: i32 = 5;\n    println!(\"{}\", a + b);\n}", "Ganzzahlen (i32)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine f64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "fn main() {\n    // Dein Code\n}", "rust", 119, 2, "f64,println!", "fn main() {\n    let a: f64 = 2.5;\n    let b: f64 = 5.0;\n    println!(\"{}\", a * b);\n}", "Gleitkommazahlen (f64)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "fn main() {\n    // Dein Code\n}", "rust", 119, 3, "String,println!", "fn main() {\n    let s1 = String::from(\"Hallo \");\n    let s2 = \"Welt\";\n    println!(\"{}{}\", s1, s2);\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "fn main() {\n    let is_active = true;\n    // Dein Code\n}", "rust", 119, 4, "bool,if,println!", "fn main() {\n    let is_active = true;\n    if is_active {\n        println!(\"Wahr\");\n    } else {\n        println!(\"Falsch\");\n    }\n}", "Booleans (bool)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "[\"Damit sie schneller geladen wird\", \"Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen\", \"Um anzuzeigen, dass es ein String ist\", \"Das mut ist optional\"]", "Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen", "Warum muss die Variable für die Eingabe mit `mut` deklariert werden (z.B. `let mut input`)?", "", "", "rust", 120, 1, null, null, "Anatomie der Eingabe", 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust nutzt man `std::io::stdin()`, um Eingaben einzulesen. <br>Lies einen Namen von der Tastatur ein und gib 'Hallo [Name]!' aus. <br>Hinweis: Tippe in das Eingabefeld rechts das Wort 'Rust' ein, bevor du auf Ausführen klickst.", "Hallo Rust!", "use std::io;\n\nfn main() {\n    let mut input = String::new(); // Erstellt einen Puffer\n    \n    // Deine Aufgabe: Nutze io::stdin().read_line(&mut input).unwrap();\n    \n    println!(\"Hallo {}!\", input.trim());\n}\n", "rust", 120, 2, "read_line", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    println!(\"Hallo {}!\", input.trim());\n}\n", "Einen String einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lies eine Zahl von der Tastatur ein, verdopple sie und gib das Ergebnis aus. <br>Hinweis: Nutze `.trim().parse::<i32>().unwrap()`, um den String in eine Zahl zu wandeln. <br>Tippe die Zahl '21' in das Eingabefeld.", "Ergebnis: 42", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    // Deine Aufgabe: Wandle 'input' in eine Zahl 'n' um\n    // let n: i32 = ...\n    \n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "rust", 120, 2, "parse", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let n: i32 = input.trim().parse().unwrap();\n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "Zahl einlesen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lies zwei Zahlen nacheinander ein und gib deren Summe aus. <br>Wichtig: Das Eingabefeld unterstützt aktuell nur eine Zeile. Trenne deine beiden Zahlen im Eingabefeld mit einem Leerzeichen (z.B. '10 5').", "Summe: 15", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    \n    println!(\"Summe: {}\", a + b);\n}\n", "rust", 120, 3, "split_whitespace", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    println!(\"Summe: {}\", a + b);\n}\n", "Zwei Zahlen addieren", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust kannst du viele unveränderbare Referenzen haben, aber nur eine veränderbare. Fülle die Lücken, um den Wert zu lesen und zu schreiben.", "Lesen: 10\nNeu: 20", "fn main() {\n    let mut data = 10;\n    \n    let r1 = &data; // Immutable\n    println!(\"Lesen: {}\", r1);\n    \n    // Lücke: Erstelle eine veränderbare Referenz\n    let r2 = ________;\n    *r2 += 10;\n    \n    println!(\"Neu: {}\", data);\n}\n", "rust", 121, 1, "&mut data,*r2", "fn main() {\n    let mut data = 10;\n    let r1 = &data;\n    println!(\"Lesen: {}\", r1);\n    \n    let r2 = &mut data;\n    *r2 += 10;\n    println!(\"Neu: {}\", data);\n}\n", "Immutable vs Mutable" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze `Box<T>`, um einen Wert auf dem Heap zu speichern. Vervollständige die Zeile mit `Box::new()`.", "Heap Wert: 50", "fn main() {\n    // Speichere die Zahl 50 auf dem Heap\n    let heap_val = Box::new(50);\n    \n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", "rust", 121, 2, "Box::new,*heap_val", "fn main() {\n    let heap_val = Box::new(50);\n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", "Box: Smart Pointer auf dem Heap", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Referenzen können automatisch dereferenziert werden. Übergebe eine Referenz an eine Funktion, die einen primitiven Typ erwartet.", "Zahl: 42", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    // Übergebe den Wert hinter der Referenz\n    print_int(*r);\n}\n", "rust", 121, 3, "*r", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    print_int(*r);\n}\n", "Deref Coercion" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Zeile, um einen neuen, leeren String-Puffer zu erstellen. <br>Nutze `String::new()`.", "Puffer bereit.", "fn main() {\n    // Vervollständige: let mut input = ...\n    let mut input = ___________;\n    \n    println!(\"Puffer bereit.\");\n}\n", "rust", 122, 1, "String::new", "fn main() {\n    let mut input = String::new();\n    println!(\"Puffer bereit.\");\n}\n", "Lücke: Den Puffer erstellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`.", "Bitte etwas tippen:\nGelesen!", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    \n    // Lücke: io::stdin().read_line(____ buffer).unwrap();\n    io::stdin().read_line(____ buffer).unwrap();\n    \n    println!(\"Gelesen!\");\n}\n", "rust", 122, 2, "&mut", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    io::stdin().read_line(&mut buffer).unwrap();\n    println!(\"Gelesen!\");\n}\n", "Lücke: Die Referenz" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`.", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    \n    // Lücke: ____::stdin().read_line(&mut input).unwrap();\n    ____::stdin().read_line(&mut input).unwrap();\n}\n", "rust", 122, 3, "io::stdin", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n}\n", "Lücke: Das Modul aufrufen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Schreibe die komplette Zeile, um eine Eingabe in die Variable `text` einzulesen. <br>Vergiss das `.unwrap()` am Ende nicht!", "Eingabe erfolgt.", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    \n    // Schreibe hier die komplette read_line Zeile:\n    \n    println!(\"Eingabe erfolgt.\");\n}\n", "rust", 122, 4, "read_line,&mut,unwrap", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    io::stdin().read_line(&mut text).unwrap();\n    println!(\"Eingabe erfolgt.\");\n}\n", null, "Lücke: Alles zusammen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "LessonId", "Title" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", 123, "Was ist Rust?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", 123, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `laenge`, sodass sie die Länge eines Strings berechnet, ohne den Besitz (Ownership) zu übernehmen.", "Die Länge von 'Hallo' ist 5.", "fn laenge(s: &String) -> usize {\n    // Berechne die Länge\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    // Übergebe eine Referenz mit &\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", 124, 1, "&String,&s1", "fn laenge(s: &String) -> usize {\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "Unveränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `&mut`, um den Inhalt eines Strings in einer Funktion zu verändern.", "Hallo, Welt", "fn aendern(s: &mut String) {\n    // Füge Text an\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    // Übergebe eine veränderbare Referenz mit &mut\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", 124, 2, "&mut String,&mut s", "fn aendern(s: &mut String) {\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "Veränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Fülle die Lücken mit `&` oder `&mut`.", "Lesen: Daten\nDaten...geändert", "fn main() {\n    let ___ s = String::from(\"Daten\");\n    \n    process_read(___s);  // Nur Lesen\n    process_write(___s); // Schreiben\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: ___String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: ___String) {\n    s.push_str(\"...geändert\");\n}\n", 124, 3, "&s,&mut s,&String,&mut String", "fn main() {\n    let mut s = String::from(\"Daten\");\n    \n    process_read(&s);\n    process_write(&mut s);\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: &String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: &mut String) {\n    s.push_str(\"...geändert\");\n}\n", "Lückentext: Rust Referenzen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um die Adresse von `zahl` in einem Raw Pointer zu speichern und den Wert darüber auszugeben.", "Wert: 100", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    // Lücke: int* ptr = ...\n    int* ptr = ________;\n    \n    // Lücke: Wert über Pointer ausgeben (Dereferenzierung)\n    std::cout << \"Wert: \" << ________;\n    return 0;\n}\n", "cpp", 125, 1, "&zahl,*ptr", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    int* ptr = &zahl;\n    std::cout << \"Wert: \" << *ptr;\n    return 0;\n}\n", "Raw Pointer: Adresse abrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `std::unique_ptr`, um Speicher auf dem Heap sicher zu verwalten. Erstelle einen `unique_ptr<int>` mit `std::make_unique`.", "Smart Wert: 42", "#include <iostream>\n#include <memory>\n\nint main() {\n    // Erstelle einen unique_ptr für den Wert 42\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    \n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", "cpp", 125, 2, "unique_ptr,make_unique", "#include <iostream>\n#include <memory>\n\nint main() {\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", "Smart Pointer: unique_ptr" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Ein `shared_ptr` erlaubt es mehreren Pointern, denselben Speicher zu besitzen. Erstelle einen `shared_ptr` und gib den `use_count()` aus.", "Count: 2", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        // Erstelle eine Kopie von p1\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "cpp", 125, 3, "make_shared,use_count", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "Smart Pointer: shared_ptr" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus.", "15", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 126, 1, "int,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 126, 2, "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { null, null, "Verwende den Typ 'string', um zwei Texte zu verknüpfen.", "Hallo Welt", "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 126, 3, "string,cout", "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}", "Zeichenketten (string)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "#include <iostream>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "cpp", 126, 4, "bool,if,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        cout << \"Wahr\";\n    } else {\n        cout << \"Falsch\";\n    }\n    return 0;\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `std::cin` mit dem `>>` Operator, um eine Zahl einzulesen.", "Gelesen: 42", "#include <iostream>\n\nint main() {\n    int zahl;\n    // Nutze cin zum Einlesen\n    std::cin >> zahl;\n    std::cout << \"Gelesen: \" << zahl;\n    return 0;\n}\n", "cpp", 127, 1, "cin >>", "#include <iostream>\n\nint main() {\n    int zahl;\n    std::cin >> zahl;\n    std::cout << \"Gelesen: \" << zahl;\n    return 0;\n}\n", "std::cin: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Welcher Operator wird für Eingaben mit `cin` verwendet?", "OK", "#include <iostream>\n\nint main() {\n    int x;\n    std::cin __ x; // Lücke füllen\n    std::cout << \"OK\";\n    return 0;\n}\n", "cpp", 127, 2, ">>", "#include <iostream>\n\nint main() {\n    int x;\n    std::cin >> x;\n    std::cout << \"OK\";\n    return 0;\n}\n", "Lückentext: cin Operator" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 128, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ", 1 });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt (Call by Value).", "Wert nach Funktion: 5", "#include <iostream>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 130, 1, "x = x * 2", "#include <iostream>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Value" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit der richtigen Syntax für Pointer und Referenzen.", "x=2, y=1", "#include <iostream>\n\nvoid swap(int__ a, int__ b) { // Nutze & für Referenzen\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=\" << x << \", y=\" << y;\n    return 0;\n}\n", "cpp", 130, 4, "int&", "#include <iostream>\n\nvoid swap(int& a, int& b) {\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=2, y=1\";\n    return 0;\n}\n", "Lückentext: Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "15", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 131, 1, "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 131, 2, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "Hallo Welt", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 131, 3, "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "Wahr", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "c", 131, 4, "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", 132, 1, "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "c", 133, "Was ist C?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 133, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies eine Ganzzahl mit `scanf` ein und gib sie aus.", "Zahl: 100", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    // scanf nutzt %d und den Adressoperator &\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", "c", 134, 1, "scanf,&zahl", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", "scanf: Ganzzahlen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Bei `scanf` musst du immer die Adresse der Variable angeben. Welches Zeichen wird dafür benötigt?", "OK", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", __x); // Lücke füllen\n    printf(\"OK\");\n    return 0;\n}\n", "c", 134, 2, "&x", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", &x);\n    printf(\"OK\");\n    return 0;\n}\n", "Lückentext: Adressoperator" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Wert nach Funktion: 5", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "c", 135, "x = x * 2", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "Call by Value in C", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Geänderter Wert: 10", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl mit &\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "c", 135, "int *,*x,&zahl", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "Call by Pointer in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen.", "x=2, y=1", "#include <stdio.h>\n\nvoid swap(int ____ a, int ____ b) {\n    int temp = ____ a;\n    ____ a = ____ b;\n    ____ b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=%d, y=%d\", x, y);\n    return 0;\n}\n", "c", 135, "int *,* a,* b", "#include <stdio.h>\n\nvoid swap(int * a, int * b) {\n    int temp = * a;\n    * a = * b;\n    * b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=2, y=1\");\n    return 0;\n}\n", "Lückentext: Pointer-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "# Dein Code hier", "python", 136, 1, "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "python", 136, 2, "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "Hallo Welt", "# Dein Code hier", "python", 136, 3, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "Wahr", "is_active = True\n# Dein Code", "python", 136, 4, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "def verdopple(x):\n    # x lokal verdoppeln\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "python", 137, 1, "x = x * 2", "def verdopple(x):\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "Unveränderliche Typen (Integers)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden.", "Python", "def add_element(liste):\n    # Füge \"Python\" zur Liste hinzu\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "python", 137, 2, "append", "def add_element(liste):\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "Veränderliche Typen (Listen)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", 138, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", "Logik: Positiv/Negativ", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", 138, "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", "python", 139, 1, "for,in,range", "for i in range(1, 6):\n    print(i)\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", "python", 139, 2, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", "Summe bis 10", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", 140, 1, null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", 140, 2, "print", "print(\"Hallo Welt!\")\n", "Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze `input()`, um einen Namen einzulesen und gib 'Hallo [Name]' aus. <br>Hinweis: Tippe deinen Namen in das Eingabefeld rechts unten.", "Hallo Python", "# Lese den Namen ein\nname = input()\nprint(\"Hallo \" + name)\n", "python", 141, 1, "input", "name = input()\nprint(\"Hallo \" + name)\n", "input() Grundlagen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Eingaben von `input()` sind immer Strings. Wandle die Eingabe in ein `int` um, um damit zu rechnen.", "20", "# Lücke: zahl = ___(input())\nzahl = ___(input())\nprint(zahl * 2)\n", "python", 141, 2, "int", "zahl = int(input())\nprint(zahl * 2)\n", "Lückentext: Typumwandlung" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 142, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", "Ganzzahlen (int)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 142, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 142, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", "java", 142, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", "Booleans (boolean)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", 143, 1, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", "Java: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 143, 2, "if", "Java: If-Else", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 143, 3, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Versuche den Wert von `x` in der Methode `verdopple` zu ändern. Bleibt das Original in `main` gleich?", "5", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "java", 144, 1, "x = x * 2", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "Primitive: Pass by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Java werden Objektreferenzen per Wert übergeben. Du kannst das Objekt verändern, aber nicht die Referenz selbst.", "Java", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        // Füge ein Element hinzu\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "java", 144, 2, "list.add", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "Objekte: Referenz ändern" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze die `Scanner`-Klasse, um einen Namen einzulesen.", "Hallo Java", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        // Erstelle einen Scanner\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", "java", 145, 1, "Scanner,System.in", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", "Scanner: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Welche Methode des Scanners liest die nächste Ganzzahl ein?", "42", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        // Lücke: int x = sc.____();\n        int x = sc.____();\n        System.out.print(x);\n    }\n}\n", "java", 145, 2, "nextInt", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        int x = sc.nextInt();\n        System.out.print(x);\n    }\n}\n", "Lückentext: Nächste Zahl", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "InitialCode", "Language", "LessonId", "Order", "Solution" },
                values: new object[] { "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 146, 1, "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", "java", 147, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", "Zahlen 1 bis 5", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", "java", 147, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", "Summe bis 10", 1 });
        }
    }
}

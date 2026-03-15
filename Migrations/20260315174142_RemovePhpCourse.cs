using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class RemovePhpCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du scanf für Eingaben in C nutzt.</p><p>In C ist <strong><code>scanf</code></strong> die Standardfunktion zum Einlesen von formatierten Daten.</p>\n<ol>\n<li><strong>Format-String</strong>: <code>%d</code> für Integer, <code>%f</code> für Float, etc.</li>\n<li><strong>Adressoperator (<code>&amp;</code>)</strong>: <code>scanf</code> benötigt die Speicheradresse der Variable, in die der Wert geschrieben werden soll.</li>\n</ol>\n", "c", "C: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Pointer in C.</p><p>In C gibt es (im Gegensatz zu C++) kein echtes &quot;Call by Reference&quot;. Stattdessen nutzt man Pointer, um ähnliche Effekte zu erzielen.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie des Wertes an die Funktion übergeben. Änderungen betreffen nur die Kopie.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse einer Variable wird übergeben. Die Funktion kann über diese Adresse direkt auf den Speicher des Aufrufers zugreifen und den Wert ändern.</li>\n</ol>\n", "c", "C: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Python arbeitest.</p><p>In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.</p>\n", "python", 4, "Variablen in Python" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Python mit Referenzen und veränderlichen Objekten umgeht.</p><p>Python nutzt ein Modell namens <strong>Pass-by-Object-Reference</strong>.</p>\n<ol>\n<li><strong>Unveränderliche Typen (<code>int</code>, <code>str</code>, <code>tuple</code>)</strong>: Da diese nicht geändert werden können, verhält es sich wie <strong>Call by Value</strong>. Jede &quot;Änderung&quot; erzeugt ein neues Objekt lokal in der Funktion.</li>\n<li><strong>Veränderliche Typen (<code>list</code>, <code>dict</code>, <code>set</code>)</strong>: Die Referenz wird übergeben. Änderungen am Objekt (z.B. <code>.append()</code>) wirken sich direkt auf das Original aus.</li>\n</ol>\n", "python", 5, "Python: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", "python", 2, "Python: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Code-Blöcke wiederholst.</p><p>Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet <code>for</code> für bekannte Iterationen und <code>while</code> für bedingte Wiederholungen.</p>\n", "python", 3, "Python: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", 1, "Python Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Daten von der Konsole einliest.</p><p>In Python nutzt du die Funktion <strong><code>input()</code></strong>, um Daten vom Benutzer zu erhalten.</p>\n<ol>\n<li><strong>Standard</strong>: <code>input()</code> gibt immer einen String zurück.</li>\n<li><strong>Konvertierung</strong>: Wenn du mit Zahlen rechnen möchtest, musst du das Ergebnis explizit umwandeln (z.B. <code>int(input())</code> oder <code>float(input())</code>).</li>\n</ol>\n", 5, "Python: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", "java", 4, "Variablen in Java" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", 1, "Java Einstieg" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Verstehe den Unterschied zwischen Primitiven und Objekten in Java.</p><p>In Java gibt es oft Diskussionen über &quot;Call by Reference&quot;. Die Wahrheit ist: <strong>Java ist immer Call by Value.</strong></p>\n<ol>\n<li><strong>Primitive Typen (<code>int</code>, <code>double</code>, etc.)</strong>: Es wird eine Kopie des eigentlichen Wertes übergeben.</li>\n<li><strong>Objekt-Referenzen</strong>: Es wird eine Kopie der <strong>Adresse</strong> des Objekts übergeben. Deshalb kannst du Attribute des Objekts in einer Methode ändern, aber du kannst nicht die ursprüngliche Variable auf ein komplett neues Objekt zeigen lassen.</li>\n</ol>\n", "java", 5, "Java: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du die Scanner-Klasse für Eingaben in Java nutzt.</p><p>In Java ist die Klasse <strong><code>java.util.Scanner</code></strong> der einfachste Weg für Konsoleneingaben.</p>\n<ol>\n<li><strong>Instanziierung</strong>: <code>Scanner sc = new Scanner(System.in);</code>.</li>\n<li><strong>Methoden</strong>: <code>next()</code> für Strings, <code>nextInt()</code> für Ganzzahlen, <code>nextDouble()</code> für Kommazahlen.</li>\n<li><strong>Puffer</strong>: Beachte, dass <code>nextInt()</code> oft einen Zeilenumbruch im Puffer lässt.</li>\n</ol>\n", "java", 6, "Java: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "java", 2, "Java: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", 3, "Java: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "c", "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "InitialCode", "Language", "Solution" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "c", "Was ist C?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "InitialCode", "Language", "RequiredKeywords", "Solution" },
                values: new object[] { "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies eine Ganzzahl mit `scanf` ein und gib sie aus.", "Zahl: 100", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    // scanf nutzt %d und den Adressoperator &\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", "c", "scanf,&zahl", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", "scanf: Ganzzahlen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Bei `scanf` musst du immer die Adresse der Variable angeben. Welches Zeichen wird dafür benötigt?", "OK", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", __x); // Lücke füllen\n    printf(\"OK\");\n    return 0;\n}\n", "c", "&x", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", &x);\n    printf(\"OK\");\n    return 0;\n}\n", "Lückentext: Adressoperator" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Wert nach Funktion: 5", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "c", "x = x * 2", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "Call by Value in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl mit &\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "c", "int *,*x,&zahl", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "Call by Pointer in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen.", "x=2, y=1", "#include <stdio.h>\n\nvoid swap(int ____ a, int ____ b) {\n    int temp = ____ a;\n    ____ a = ____ b;\n    ____ b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=%d, y=%d\", x, y);\n    return 0;\n}\n", "c", "int *,* a,* b", "#include <stdio.h>\n\nvoid swap(int * a, int * b) {\n    int temp = * a;\n    * a = * b;\n    * b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=2, y=1\");\n    return 0;\n}\n", "Lückentext: Pointer-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "# Dein Code hier", "python", "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "python", "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "# Dein Code hier", "python", "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "is_active = True\n# Dein Code", "python", "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "def verdopple(x):\n    # x lokal verdoppeln\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "python", "x = x * 2", "def verdopple(x):\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "Unveränderliche Typen (Integers)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden.", "Python", "def add_element(liste):\n    # Füge \"Python\" zur Liste hinzu\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "python", 137, 2, "append", "def add_element(liste):\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "Veränderliche Typen (Listen)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", 1, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", 138, 2, "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", "python", 139, 2, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", 1, null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", 2, "print", "print(\"Hallo Welt!\")\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `input()`, um einen Namen einzulesen und gib 'Hallo [Name]' aus. <br>Hinweis: Tippe deinen Namen in das Eingabefeld rechts unten.", "Hallo Python", "# Lese den Namen ein\nname = input()\nprint(\"Hallo \" + name)\n", "input", "name = input()\nprint(\"Hallo \" + name)\n", "input() Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Eingaben von `input()` sind immer Strings. Wandle die Eingabe in ein `int` um, um damit zu rechnen.", "20", "# Lücke: zahl = ___(input())\nzahl = ___(input())\nprint(zahl * 2)\n", "int", "zahl = int(input())\nprint(zahl * 2)\n", "Lückentext: Typumwandlung" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 142, 1, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 142, 2, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 3, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", "java", 4, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", "Booleans (boolean)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", "Java: Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", "if", null, "Java: If-Else" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Versuche den Wert von `x` in der Methode `verdopple` zu ändern. Bleibt das Original in `main` gleich?", "5", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "java", 1, "x = x * 2", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "Primitive: Pass by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "In Java werden Objektreferenzen per Wert übergeben. Du kannst das Objekt verändern, aber nicht die Referenz selbst.", "Java", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        // Füge ein Element hinzu\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "java", 144, 2, "list.add", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "Objekte: Referenz ändern", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze die `Scanner`-Klasse, um einen Namen einzulesen.", "Hallo Java", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        // Erstelle einen Scanner\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", "java", 1, "Scanner,System.in", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", "Scanner: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Welche Methode des Scanners liest die nächste Ganzzahl ein?", "42", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        // Lücke: int x = sc.____();\n        int x = sc.____();\n        System.out.print(x);\n    }\n}\n", "java", 145, 2, "nextInt", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        int x = sc.nextInt();\n        System.out.print(x);\n    }\n}\n", "Lückentext: Nächste Zahl" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 1, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", "Summe bis 10" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du Daten in PHP von STDIN einliest.</p><p>In PHP nutzt du oft die vordefinierte Konstante <strong><code>STDIN</code></strong> für Eingaben.</p>\n<ol>\n<li><strong><code>fgets(STDIN)</code></strong>: Liest eine Zeile von der Standard-Eingabe.</li>\n<li><strong><code>trim()</code></strong>: Wichtig, da die Eingabe meist das Zeichen für das Zeilenende (<code>\\n</code>) enthält.</li>\n</ol>\n", "php", "PHP: Benutzereingaben" });

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
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "c", 2, "C: Kontrollstrukturen" });

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
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Pointer in C.</p><p>In C gibt es (im Gegensatz zu C++) kein echtes &quot;Call by Reference&quot;. Stattdessen nutzt man Pointer, um ähnliche Effekte zu erzielen.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie des Wertes an die Funktion übergeben. Änderungen betreffen nur die Kopie.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse einer Variable wird übergeben. Die Funktion kann über diese Adresse direkt auf den Speicher des Aufrufers zugreifen und den Wert ändern.</li>\n</ol>\n", "c", 4, "C: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Python arbeitest.</p><p>In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.</p>\n", 4, "Variablen in Python" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Python mit Referenzen und veränderlichen Objekten umgeht.</p><p>Python nutzt ein Modell namens <strong>Pass-by-Object-Reference</strong>.</p>\n<ol>\n<li><strong>Unveränderliche Typen (<code>int</code>, <code>str</code>, <code>tuple</code>)</strong>: Da diese nicht geändert werden können, verhält es sich wie <strong>Call by Value</strong>. Jede &quot;Änderung&quot; erzeugt ein neues Objekt lokal in der Funktion.</li>\n<li><strong>Veränderliche Typen (<code>list</code>, <code>dict</code>, <code>set</code>)</strong>: Die Referenz wird übergeben. Änderungen am Objekt (z.B. <code>.append()</code>) wirken sich direkt auf das Original aus.</li>\n</ol>\n", "python", 5, "Python: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", "python", 2, "Python: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Code-Blöcke wiederholst.</p><p>Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet <code>for</code> für bekannte Iterationen und <code>while</code> für bedingte Wiederholungen.</p>\n", "python", 3, "Python: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", 1, "Python Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Daten von der Konsole einliest.</p><p>In Python nutzt du die Funktion <strong><code>input()</code></strong>, um Daten vom Benutzer zu erhalten.</p>\n<ol>\n<li><strong>Standard</strong>: <code>input()</code> gibt immer einen String zurück.</li>\n<li><strong>Konvertierung</strong>: Wenn du mit Zahlen rechnen möchtest, musst du das Ergebnis explizit umwandeln (z.B. <code>int(input())</code> oder <code>float(input())</code>).</li>\n</ol>\n", "python", 5, "Python: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", 4, "Variablen in Java" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[,]
                {
                    { 148, "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", 1, "Java Einstieg" },
                    { 149, "<p>Verstehe den Unterschied zwischen Primitiven und Objekten in Java.</p><p>In Java gibt es oft Diskussionen über &quot;Call by Reference&quot;. Die Wahrheit ist: <strong>Java ist immer Call by Value.</strong></p>\n<ol>\n<li><strong>Primitive Typen (<code>int</code>, <code>double</code>, etc.)</strong>: Es wird eine Kopie des eigentlichen Wertes übergeben.</li>\n<li><strong>Objekt-Referenzen</strong>: Es wird eine Kopie der <strong>Adresse</strong> des Objekts übergeben. Deshalb kannst du Attribute des Objekts in einer Methode ändern, aber du kannst nicht die ursprüngliche Variable auf ein komplett neues Objekt zeigen lassen.</li>\n</ol>\n", "java", 5, "Java: Parameterübergabe" },
                    { 150, "<p>Lerne, wie du die Scanner-Klasse für Eingaben in Java nutzt.</p><p>In Java ist die Klasse <strong><code>java.util.Scanner</code></strong> der einfachste Weg für Konsoleneingaben.</p>\n<ol>\n<li><strong>Instanziierung</strong>: <code>Scanner sc = new Scanner(System.in);</code>.</li>\n<li><strong>Methoden</strong>: <code>next()</code> für Strings, <code>nextInt()</code> für Ganzzahlen, <code>nextDouble()</code> für Kommazahlen.</li>\n<li><strong>Puffer</strong>: Beachte, dass <code>nextInt()</code> oft einen Zeilenumbruch im Puffer lässt.</li>\n</ol>\n", "java", 6, "Java: Benutzereingaben" },
                    { 151, "<p>Entscheidungen treffen mit if und else.</p>", "java", 2, "Java: Kontrollstrukturen" },
                    { 152, "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", "java", 3, "Java: Schleifen" }
                });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In PHP beginnen Variablen mit einem $. Addiere zwei Zahlen und gib das Ergebnis mit echo aus.", "<?php\n// Dein Code", "php", "echo,$", "<?php\n$a = 10;\n$b = 5;\necho $a + $b;", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Multipliziere zwei Gleitkommazahlen und gib das Ergebnis aus.", "12.5", "<?php\n// Dein Code", "php", "echo", "<?php\n$a = 2.5;\n$b = 5.0;\necho $a * $b;", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings werden in PHP mit dem Punkt (.) verknüpft.", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\n// Dein Code", "php", "echo,.", "<?php\n$s1 = \"Hallo \";\n$s2 = \"Welt\";\necho $s1 . $s2;", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "<?php\n$isActive = true;\n// Dein Code", "php", "if,echo", "<?php\n$isActive = true;\nif ($isActive) {\n    echo \"Wahr\";\n} else {\n    echo \"Falsch\";\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "InitialCode", "Language", "Solution" },
                values: new object[] { "Prüfe, ob die Variable '$zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "<?php\n$zahl = -5;\n// Dein Code hier\n?>\n", "php", "<?php\n$zahl = -5;\nif ($zahl > 0) {\n    echo \"Positiv\";\n} else {\n    echo \"Negativ\";\n}\n?>\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "PHP (Hypertext Preprocessor) ist eine weit verbreitete serverseitige Skriptsprache, die besonders für die Webentwicklung geeignet ist.", "php", "Was ist PHP?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "InitialCode", "Language", "RequiredKeywords", "Solution" },
                values: new object[] { "<?php\n// Dein Code hier\n", "php", "echo", "<?php\necho \"Hallo Welt!\";\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `fgets(STDIN)`, um eine Eingabe zu erhalten.", "Du hast gesagt: PHP", "<?php\n// Lese von der Standard-Eingabe\n$input = fgets(STDIN);\necho \"Du hast gesagt: \" . trim($input);\n", "php", "fgets,STDIN", "<?php\n$input = fgets(STDIN);\necho \"Du hast gesagt: \" . trim($input);\n", "STDIN: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Eingaben enthalten oft einen Zeilenumbruch. Welche Funktion entfernt diesen?", "Text", "<?php\n$s = \"Text\\n\";\n// Lücke: $s = ____($s);\n$s = ____($s);\necho $s;\n", "php", "trim", "<?php\n$s = \"Text\\n\";\n$s = trim($s);\necho $s;\n", "Lückentext: trim Funktion" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Originalwert: 5", "<?php\n\nfunction verdopple($zahl) {\n    // Ändere den Wert lokal\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", "php", "$zahl = $zahl * 2", "<?php\n\nfunction verdopple($zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdopple($meineZahl);\necho \"Originalwert: \" . $meineZahl;\n", "Call by Value in PHP" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das Ampersand-Zeichen (`&`) in der Parameterliste, um den Wert des Originals zu verändern.", "<?php\n\n// Nutze & vor der Variable\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", "php", "&$zahl", "<?php\n\nfunction verdoppleRef(&$zahl) {\n    $zahl = $zahl * 2;\n}\n\n$meineZahl = 5;\nverdoppleRef($meineZahl);\necho \"Geänderter Wert: \" . $meineZahl;\n", "Call by Reference in PHP" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um eine Referenz an die Funktion zu übergeben.", "11", "<?php\n\nfunction addOne(____$n) { // Ampersand hier einfügen\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", "php", "&$n", "<?php\n\nfunction addOne(&$n) {\n    $n++;\n}\n\n$x = 10;\naddOne($x);\necho $x;\n", "Lückentext: Referenz-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Description", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "c", "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 2, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Bei `scanf` musst du immer die Adresse der Variable angeben. Welches Zeichen wird dafür benötigt?", "OK", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", __x); // Lücke füllen\n    printf(\"OK\");\n    return 0;\n}\n", "c", 2, "&x", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", &x);\n    printf(\"OK\");\n    return 0;\n}\n", "Lückentext: Adressoperator" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Geänderter Wert: 10", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl mit &\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "c", 2, "int *,*x,&zahl", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "Call by Pointer in C", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen.", "x=2, y=1", "#include <stdio.h>\n\nvoid swap(int ____ a, int ____ b) {\n    int temp = ____ a;\n    ____ a = ____ b;\n    ____ b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=%d, y=%d\", x, y);\n    return 0;\n}\n", "c", 3, "int *,* a,* b", "#include <stdio.h>\n\nvoid swap(int * a, int * b) {\n    int temp = * a;\n    * a = * b;\n    * b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=2, y=1\");\n    return 0;\n}\n", "Lückentext: Pointer-Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "# Dein Code hier", "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "Hallo Welt", "# Dein Code hier", "python", 141, 3, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "Wahr", "is_active = True\n# Dein Code", "python", 141, 4, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "def verdopple(x):\n    # x lokal verdoppeln\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "python", 1, "x = x * 2", "def verdopple(x):\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "Unveränderliche Typen (Integers)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden.", "Python", "def add_element(liste):\n    # Füge \"Python\" zur Liste hinzu\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "python", 2, "append", "def add_element(liste):\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "Veränderliche Typen (Listen)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", "python", 144, 1, "for,in,range", "for i in range(1, 6):\n    print(i)\n", null, "Zahlen 1 bis 5", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", "python", 2, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", 145, 1, null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", 2, "print", "print(\"Hallo Welt!\")\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `input()`, um einen Namen einzulesen und gib 'Hallo [Name]' aus. <br>Hinweis: Tippe deinen Namen in das Eingabefeld rechts unten.", "Hallo Python", "# Lese den Namen ein\nname = input()\nprint(\"Hallo \" + name)\n", "python", 146, 1, "input", "name = input()\nprint(\"Hallo \" + name)\n", "input() Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Eingaben von `input()` sind immer Strings. Wandle die Eingabe in ein `int` um, um damit zu rechnen.", "20", "# Lücke: zahl = ___(input())\nzahl = ___(input())\nprint(zahl * 2)\n", "python", 2, "int", "zahl = int(input())\nprint(zahl * 2)\n", "Lückentext: Typumwandlung" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[,]
                {
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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddAspNetCoreAndSpringBootCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>DBContext, Migrations, LINQ und Deep Theory zur SQL-Generierung.</p><p>Entity Framework Core ist der Standard O/RM (Object-Relational Mapper) für .NET.</p>\n<ol>\n<li><strong>DbContext</strong>: Repräsentiert die Datenbank-Session.</li>\n<li><strong>Migrations</strong>: Ermöglichen die Versionierung des Datenbank-Schemas.</li>\n<li><strong>LINQ</strong>: Eine typsichere Abfragesprache direkt in C#.</li>\n</ol>\n", "aspnetcore", 3, "ASP.NET Core: Entity Framework Core" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Erfahre mehr über Lifetimes (Scoped, Transient, Singleton) und Inversion of Control.</p><p>Lifetimes im DI-Container:</p>\n<ol>\n<li><strong>Transient</strong>: Jedes Mal neu erstellt.</li>\n<li><strong>Scoped</strong>: Einmal pro HTTP-Request erstellt.</li>\n<li><strong>Singleton</strong>: Einmal für die gesamte App-Laufzeit erstellt.</li>\n</ol>\n", "aspnetcore", 4, "ASP.NET Core: Dependency Injection" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Erfahre mehr über Controller, Views, Routing und Deep Theory zu VTables.</p><p>MVC (Model-View-Controller) strukturiert Anwendungen in drei Bereiche.</p>\n<ol>\n<li><strong>Routing</strong>: Bestimmt, welche Action welcher Controller aufruft.</li>\n<li><strong>Views</strong>: Razor-Templates für die UI-Erzeugung.</li>\n<li><strong>Controller</strong>: Verarbeiten Requests und liefern Ergebnisse zurück.</li>\n</ol>\n", "aspnetcore", 2, "ASP.NET Core: MVC & Routing" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne die Grundlagen der ASP.NET Core Architektur und der Middleware-Pipeline kennen.</p><p>ASP.NET Core ist modular aufgebaut. Die Pipeline besteht aus <code>RequestDelegates</code>, die nacheinander aufgerufen werden.</p>\n<p>Wichtige Punkte:</p>\n<ol>\n<li><strong>Kestrel</strong>: Der performante Cross-Plattform Webserver.</li>\n<li><strong>Middleware</strong>: Komponenten wie <code>UseRouting</code>, <code>UseAuthentication</code> und <code>UseEndpoints</code>.</li>\n<li><strong>Dependency Injection</strong>: Von Grund auf im Framework integriert.</li>\n</ol>\n", "aspnetcore", 1, "ASP.NET Core: Architektur & Middleware" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C# arbeitest.</p><p>Variablen sind Container zum Speichern von Datenwerten. In C# musst du den Datentyp einer Variable angeben.</p>\n", 5, "Variablen in C#" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne Entscheidungen im Code zu treffen.</p><p>In dieser Lektion lernst du <code>if</code> und <code>else</code> kennen.</p>\n", 2, "Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben effizient.</p><p>Schleifen helfen dir, Aufgaben mehrfach auszuführen.</p>\n", 3, "Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Console.ReadLine() für Eingaben in C# nutzt.</p><p>In C# nutzt du die Klasse <strong><code>Console</code></strong>, um Eingaben zu erhalten.</p>\n<ol>\n<li><strong><code>Console.ReadLine()</code></strong>: Liest eine komplette Zeile als String ein.</li>\n<li><strong><code>Console.Read()</code></strong>: Liest nur ein einzelnes Zeichen als Ganzzahl-Code (ASCII/Unicode).</li>\n<li><strong>Parsing</strong>: Nutze Methoden wie <code>int.Parse()</code> oder <code>Convert.ToInt32()</code>, um Texte in Zahlen zu wandeln.</li>\n</ol>\n", "csharp", 7, "C#: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von C#.</p><p>In dieser Lektion lernst du die ersten Schritte in C#.</p>\n", "csharp", 1, "C# Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Einsatz von ref und out für Call by Reference in C#.</p><p>In C# werden Werttypen (wie <code>int</code>, <code>bool</code>) standardmäßig per <strong>Call by Value</strong> übergeben.</p>\n<ol>\n<li><strong>ref</strong>: Übergibt eine Referenz auf eine Variable. Die Variable muss vor der Übergabe initialisiert sein.</li>\n<li><strong>out</strong>: Übergibt eine Referenz, aber die Variable muss nicht initialisiert sein. Die Methode <strong>muss</strong> der <code>out</code>-Variable jedoch einen Wert zuweisen.</li>\n<li><strong>Pointer</strong>: C# unterstützt Pointer nur in <code>unsafe</code> Codeblöcken, was für allgemeine Anwendungen selten genutzt wird.</li>\n</ol>\n", "csharp", 6, "C#: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Objektorientierte Programmierung.</p><p>Alles in C# findet in Klassen statt.</p>\n", "csharp", 4, "Klassen & Methoden" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen und Code wiederholen.</p><p>Kontrollstrukturen sind das Herzstück jeder Programmiersprache. In Rust gibt es neben <code>if</code> und <code>else</code> auch mächtige Schleifen-Konstrukte wie <code>loop</code>, <code>while</code> und <code>for</code>.</p>\n", 3, "Rust: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Rust arbeitest.</p><p>In Rust sind Variablen standardmäßig unveränderlich (immutable). Mit <code>let mut</code> kannst du sie veränderbar machen.</p>\n", 4, "Variablen in Rust" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Wie liest man Daten von der Tastatur in Rust ein?</p><p>Rust legt großen Wert auf Sicherheit. Daher ist die Standardeingabe etwas ausführlicher als in anderen Sprachen. Das Modul <code>std::io</code> bietet Zugriff auf die Funktionen, um von der Tastatur zu lesen.</p>\n", 2, "Rust: Ein- und Ausgabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Vertiefe dein Wissen über Borrowing und lerne Smart Pointer wie Box kennen.</p><p>Rust erzwingt strikte Regeln für Referenzen zur Kompilierzeit (<strong>Borrow Checker</strong>).</p>\n<ol>\n<li><strong>Immutable Borrowing (<code>&amp;T</code>)</strong>: Beliebig viele Referenzen zum Lesen erlaubt.</li>\n<li><strong>Mutable Borrowing (<code>&amp;mut T</code>)</strong>: Nur eine Referenz zum Schreiben erlaubt.</li>\n<li><strong>Smart Pointer (<code>Box&lt;T&gt;</code>)</strong>: Ermöglicht es, Daten auf dem Heap statt auf dem Stack zu speichern. <code>Box</code> besitzt die Daten und gibt sie automatisch frei.</li>\n</ol>\n", "rust", 7, "Rust: Fortgeschrittene Referenzen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Übe die Syntax für Benutzereingaben in Rust, indem du die Lücken füllst.</p><p>In Rust ist das Einlesen von der Konsole explizit. Du brauchst:</p>\n<ol>\n<li>Einen <strong>veränderbaren String</strong> (<code>let mut input = String::new()</code>).</li>\n<li>Den Aufruf von <strong><code>io::stdin().read_line()</code></strong>.</li>\n<li>Eine <strong>veränderbare Referenz</strong> auf deinen String (<code>&amp;mut input</code>).</li>\n<li>Eine Fehlerbehandlung wie <strong><code>.unwrap()</code></strong> oder <code>.expect()</code>.</li>\n</ol>\n", "rust", 5, "Rust: Lückentext Eingabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Rust - Sicher, schnell und modern.</p><p>In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.</p>\n", "rust", 1, "Rust Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Rust Daten sicher per Referenz übergibt.</p><p>In Rust gibt es kein klassisches &quot;Call by Reference&quot; wie in C++, sondern <strong>Borrowing</strong> (Ausleihen).</p>\n<ol>\n<li><strong>Unveränderbares Borrowing (<code>&amp;T</code>)</strong>: Man darf den Wert lesen, aber nicht ändern. Man kann beliebig viele dieser Referenzen gleichzeitig haben.</li>\n<li><strong>Veränderbares Borrowing (<code>&amp;mut T</code>)</strong>: Man darf den Wert ändern. Es darf jedoch immer nur <strong>eine</strong> veränderbare Referenz zur gleichen Zeit existieren (Sicherheit gegen Data Races).</li>\n<li><strong>Ownership</strong>: Wird kein <code>&amp;</code> verwendet, wird der Wert <strong>verschoben</strong> (Move) und die ursprüngliche Variable ist nicht mehr nutzbar.</li>\n</ol>\n", "rust", 6, "Rust: Referenzen und Borrowing" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Erstelle moderne REST-APIs mit Content Negotiation und lerne Deep Theory zu HTTP/3.</p><p>RESTful APIs sind das Herzstück moderner Backends.</p>\n<ol>\n<li><strong>@RestController</strong>: Kombiniert <code>@Controller</code> und <code>@ResponseBody</code>.</li>\n<li><strong>Content Negotiation</strong>: Automatisches Auswählen des Antwortformats (JSON, XML) basierend auf dem <code>Accept</code> Header.</li>\n<li><strong>HTTP/3</strong>: Erhöht Performance und Stabilität der Kommunikation.</li>\n</ol>\n", "springboot", 2, "Spring Boot: REST Services & HTTP/3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Datenbankzugriff mit Repositories und Deep Theory zum Hibernate Dirty Checking.</p><p>Spring Data JPA vereinfacht den Datenbankzugriff massiv.</p>\n<ol>\n<li><strong>Repositories</strong>: Interfaces definieren statt Implementierungen schreiben.</li>\n<li><strong>Derived Queries</strong>: SQL-Abfragen werden automatisch aus Methodennamen generiert.</li>\n<li><strong>Paging &amp; Sorting</strong>: Integrierte Unterstützung für große Datenmengen.</li>\n</ol>\n", "springboot", 3, "Spring Boot: Spring Data & JPA" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne die Magie hinter Spring Boot und die Performance von Java 25 Virtual Threads kennen.</p><p>Spring Boot 4 setzt auf moderne Java-Features.</p>\n<ol>\n<li><strong>Auto-Configuration</strong>: Spring scannt den Classpath und konfiguriert automatisch passende Beans.</li>\n<li><strong>Starters</strong>: Zusammenfassungen von Abhängigkeiten (z.B. <code>spring-boot-starter-web</code>), die Versionierungskonflikte lösen.</li>\n<li><strong>Java 25</strong>: Volle Unterstützung für virtuelle Threads und moderne Syntax-Features.</li>\n</ol>\n", "springboot", 1, "Spring Boot: Auto-Configuration & Virtual Threads" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Spring Security, Resilience-Patterns und Deep Theory zu OAuth2/OIDC.</p><p>Sicherheit und Robustheit sind essenziell für Enterprise-Backends.</p>\n<ol>\n<li><strong>Spring Security</strong>: Bietet Schutz gegen CSRF, Session-Hijacking und verwaltet RBAC (Role-Based Access Control).</li>\n<li><strong>Resilience</strong>: Mit <code>@Retryable</code> und <code>@CircuitBreaker</code> können Anwendungen gracefully mit Fehlern umgehen.</li>\n<li><strong>OAuth2/OIDC</strong>: Industriestandard für moderne, verteilte Authentifizierung.</li>\n</ol>\n", "springboot", 4, "Spring Boot: Resilience & Security" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den sicheren Umgang mit Raw Pointern und modernen Smart Pointern in C++.</p><p>In modernem C++ (ab C++11) solltest du <strong>Smart Pointer</strong> gegenüber Raw Pointern bevorzugen, um Speicherlecks zu vermeiden.</p>\n<ol>\n<li><strong>Raw Pointer (<code>T*</code>)</strong>: Speichert eine nackte Speicheradresse. Du musst dich selbst um <code>delete</code> kümmern.</li>\n<li><strong><code>std::unique_ptr&lt;T&gt;</code></strong>: Exklusives Eigentum. Der Speicher wird automatisch freigegeben, wenn der Pointer out-of-scope geht.</li>\n<li><strong><code>std::shared_ptr&lt;T&gt;</code></strong>: Gemeinsames Eigentum. Nutzt Reference Counting.</li>\n</ol>\n", "cpp", 5, "C++: Pointer und Smart Pointer" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C++ arbeitest.</p><p>C++ ist eine objektorientierte Erweiterung von C und bietet komfortable Typen wie <code>std::string</code>.</p>\n", "cpp", 3, "Variablen in C++" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du std::cin für Eingaben in C++ nutzt.</p><p>In C++ nutzt du den Input-Stream <strong><code>std::cin</code></strong>.</p>\n<ol>\n<li><strong>Extraktionsoperator (<code>&gt;&gt;</code>)</strong>: Die Daten werden aus dem Stream extrahiert und in die Variable geschrieben.</li>\n<li><strong>Mehrere Eingaben</strong>: Du kannst <code>std::cin &gt;&gt; a &gt;&gt; b;</code> nutzen, um zwei Werte nacheinander zu lesen.</li>\n</ol>\n", "cpp", 6, "C++: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "cpp", 2, "C++: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", "cpp", 1, "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value, Call by Reference und Call by Pointer.</p><p>In C++ gibt es drei Hauptarten, wie Daten an Funktionen übergeben werden können:</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie erstellt. Änderungen in der Funktion haben keine Auswirkung auf das Original.</li>\n<li><strong>Call by Reference</strong>: Die Funktion erhält direkten Zugriff auf das Original (Alias). Änderungen wirken sich sofort aus. Syntax: <code>Type&amp; name</code>.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse der Variable wird übergeben. Die Funktion greift über Dereferenzierung (<code>*</code>) auf das Original zu. Syntax: <code>Type* name</code> und beim Aufruf <code>&amp;variable</code>.</li>\n</ol>\n", "cpp", 4, "C++: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C arbeitest.</p><p>In C musst du Datentypen explizit angeben. Für Booleans musst du <code>&lt;stdbool.h&gt;</code> einbinden.</p>\n", "c", "Variablen in C" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "c", 2, "C: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die prozedurale Programmierung mit C.</p><p>In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.</p>\n", "c", 1, "C Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du scanf für Eingaben in C nutzt.</p><p>In C ist <strong><code>scanf</code></strong> die Standardfunktion zum Einlesen von formatierten Daten.</p>\n<ol>\n<li><strong>Format-String</strong>: <code>%d</code> für Integer, <code>%f</code> für Float, etc.</li>\n<li><strong>Adressoperator (<code>&amp;</code>)</strong>: <code>scanf</code> benötigt die Speicheradresse der Variable, in die der Wert geschrieben werden soll.</li>\n</ol>\n", "c", 5, "C: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Pointer in C.</p><p>In C gibt es (im Gegensatz zu C++) kein echtes &quot;Call by Reference&quot;. Stattdessen nutzt man Pointer, um ähnliche Effekte zu erzielen.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie des Wertes an die Funktion übergeben. Änderungen betreffen nur die Kopie.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse einer Variable wird übergeben. Die Funktion kann über diese Adresse direkt auf den Speicher des Aufrufers zugreifen und den Wert ändern.</li>\n</ol>\n", "c", "C: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Python arbeitest.</p><p>In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.</p>\n", "python", 4, "Variablen in Python" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie Python mit Referenzen und veränderlichen Objekten umgeht.</p><p>Python nutzt ein Modell namens <strong>Pass-by-Object-Reference</strong>.</p>\n<ol>\n<li><strong>Unveränderliche Typen (<code>int</code>, <code>str</code>, <code>tuple</code>)</strong>: Da diese nicht geändert werden können, verhält es sich wie <strong>Call by Value</strong>. Jede &quot;Änderung&quot; erzeugt ein neues Objekt lokal in der Funktion.</li>\n<li><strong>Veränderliche Typen (<code>list</code>, <code>dict</code>, <code>set</code>)</strong>: Die Referenz wird übergeben. Änderungen am Objekt (z.B. <code>.append()</code>) wirken sich direkt auf das Original aus.</li>\n</ol>\n", "python", "Python: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du den Programmfluss steuerst.</p><p>Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern <code>{}</code> wie in C# oder Java.</p>\n", "python", 2, "Python: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Code-Blöcke wiederholst.</p><p>Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet <code>for</code> für bekannte Iterationen und <code>while</code> für bedingte Wiederholungen.</p>\n", "python", 3, "Python: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Python.</p><p>In dieser Lektion lernst du die ersten Schritte in Python. Python wird häufig in der Webentwicklung, Datenanalyse und künstlichen Intelligenz verwendet.</p>\n", "python", 1, "Python Grundlagen" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[,]
                {
                    { 149, "<p>Lerne, wie du Daten von der Konsole einliest.</p><p>In Python nutzt du die Funktion <strong><code>input()</code></strong>, um Daten vom Benutzer zu erhalten.</p>\n<ol>\n<li><strong>Standard</strong>: <code>input()</code> gibt immer einen String zurück.</li>\n<li><strong>Konvertierung</strong>: Wenn du mit Zahlen rechnen möchtest, musst du das Ergebnis explizit umwandeln (z.B. <code>int(input())</code> oder <code>float(input())</code>).</li>\n</ol>\n", "python", 5, "Python: Benutzereingaben" },
                    { 150, "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", "java", 4, "Variablen in Java" },
                    { 151, "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", 1, "Java Einstieg" },
                    { 152, "<p>Verstehe den Unterschied zwischen Primitiven und Objekten in Java.</p><p>In Java gibt es oft Diskussionen über &quot;Call by Reference&quot;. Die Wahrheit ist: <strong>Java ist immer Call by Value.</strong></p>\n<ol>\n<li><strong>Primitive Typen (<code>int</code>, <code>double</code>, etc.)</strong>: Es wird eine Kopie des eigentlichen Wertes übergeben.</li>\n<li><strong>Objekt-Referenzen</strong>: Es wird eine Kopie der <strong>Adresse</strong> des Objekts übergeben. Deshalb kannst du Attribute des Objekts in einer Methode ändern, aber du kannst nicht die ursprüngliche Variable auf ein komplett neues Objekt zeigen lassen.</li>\n</ol>\n", "java", 5, "Java: Parameterübergabe" },
                    { 153, "<p>Lerne, wie du die Scanner-Klasse für Eingaben in Java nutzt.</p><p>In Java ist die Klasse <strong><code>java.util.Scanner</code></strong> der einfachste Weg für Konsoleneingaben.</p>\n<ol>\n<li><strong>Instanziierung</strong>: <code>Scanner sc = new Scanner(System.in);</code>.</li>\n<li><strong>Methoden</strong>: <code>next()</code> für Strings, <code>nextInt()</code> für Ganzzahlen, <code>nextDouble()</code> für Kommazahlen.</li>\n<li><strong>Puffer</strong>: Beachte, dass <code>nextInt()</code> oft einen Zeilenumbruch im Puffer lässt.</li>\n</ol>\n", "java", 6, "Java: Benutzereingaben" },
                    { 154, "<p>Entscheidungen treffen mit if und else.</p>", "java", 2, "Java: Kontrollstrukturen" },
                    { 155, "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", "java", 3, "Java: Schleifen" }
                });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "EF Core übersetzt LINQ-Queries in SQL. Dies geschieht durch einen Provider (z.B. SQL Server, SQLite). Ein kritischer Aspekt ist das 'N+1 Problem', bei dem für jede Entität einer Liste eine zusätzliche Query ausgeführt wird. Durch Eager Loading mit `.Include()` kann dies verhindert werden. Die Performance hängt stark von der effizienten Übersetzung der Expression Trees in SQL ab.", "aspnetcore", "Deep Theory: SQL-Generierung und Performance" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine Klasse 'AppDbContext', die von 'DbContext' erbt und ein DbSet für 'User' enthält.", "", "using Microsoft.EntityFrameworkCore;\n\npublic class AppDbContext : _________\n{\n    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }\n\n    public DbSet<User> _____ { get; set; }\n}\n", "aspnetcore", "DbContext,Users", "using Microsoft.EntityFrameworkCore;\n\npublic class AppDbContext : DbContext\n{\n    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }\n\n    public DbSet<User> Users { get; set; }\n}\n", "DbContext Setup" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die LINQ-Query, um alle Benutzer zu finden, deren Name mit 'A' beginnt.", "", "// In einem Controller mit _context\nvar users = _context.Users\n    .______(u => u.Name.StartsWith(\"A\"))\n    .ToList();\n", "aspnetcore", "Where", "// In einem Controller mit _context\nvar users = _context.Users\n    .Where(u => u.Name.StartsWith(\"A\"))\n    .ToList();\n", "Lücke: LINQ Query" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Inversion of Control (IoC) bedeutet, dass die Kontrolle über die Instanziierung von Objekten an ein Framework oder einen Container delegiert wird. ASP.NET Core nutzt dazu Dependency Injection (DI). Der DI-Container verwaltet die Lebensdauer von Services und injiziert sie automatisch dort, wo sie benötigt werden, was die Testbarkeit und Modularität massiv verbessert.", "", "", "aspnetcore", 112, 1, null, null, "Deep Theory: Inversion of Control", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Registriere ein Interface 'IMyService' mit der Implementierung 'MyService' als Singleton.", "", "var builder = WebApplication.CreateBuilder(args);\n\n// Registrierung als Singleton\nbuilder.Services._____________<IMyService, MyService>();\n\nvar app = builder.Build();\napp.Run();\n", "aspnetcore", 112, 2, "AddSingleton", "var builder = WebApplication.CreateBuilder(args);\n\n// Registrierung als Singleton\nbuilder.Services.AddSingleton<IMyService, MyService>();\n\nvar app = builder.Build();\napp.Run();\n", "Service Registrierung" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "Description", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Vervollständige die Registrierung für einen 'Scoped' Service. Scoped bedeutet: Eine Instanz pro HTTP-Request.", "var builder = WebApplication.CreateBuilder(args);\n\n// Registrierung als Scoped\nbuilder.Services.________<IRepository, MyRepository>();\n\nvar app = builder.Build();\napp.Run();\n", "aspnetcore", 3, "AddScoped", "var builder = WebApplication.CreateBuilder(args);\n\n// Registrierung als Scoped\nbuilder.Services.AddScoped<IRepository, MyRepository>();\n\nvar app = builder.Build();\napp.Run();\n", "Lücke: Service Lifetimes", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "In C# nutzen virtuelle Methoden eine Virtual Method Table (VTable), um den Aufruf zur Laufzeit auf die korrekte Implementierung einer abgeleiteten Klasse zu delegieren. ASP.NET Core MVC baut darauf auf: Ein Controller-Aufruf wird durch Reflexion und Metadaten zur Laufzeit aufgelöst. Dies ermöglicht die lose Kopplung und hohe Flexibilität des Frameworks.", "", "", "aspnetcore", 113, 1, null, "Deep Theory: VTables und Dynamic Dispatch", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Description", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine Action-Methode 'Index' in einer Klasse 'HomeController', die den String 'Welcome' zurückgibt.", "using Microsoft.AspNetCore.Mvc;\n\npublic class HomeController : __________\n{\n    public string Index()\n    {\n        return \"_______\";\n    }\n}\n", "aspnetcore", 2, "Controller,Index", "using Microsoft.AspNetCore.Mvc;\n\npublic class HomeController : Controller\n{\n    public string Index()\n    {\n        return \"Welcome\";\n    }\n}\n", "Einfacher Controller", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `[Route]` Attribut, um die Action auf den Pfad '/api/hello' zu mappen.", "", "using Microsoft.AspNetCore.Mvc;\n\npublic class HelloController : ControllerBase\n{\n    [____(\"api/_____\")]\n    public IActionResult Greet() => Ok(\"Hi\");\n}\n", "aspnetcore", 3, "Route", "using Microsoft.AspNetCore.Mvc;\n\npublic class HelloController : ControllerBase\n{\n    [Route(\"api/hello\")]\n    public IActionResult Greet() => Ok(\"Hi\");\n}\n", "Lücke: Attribut-Routing" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "In ASP.NET Core durchläuft jeder Request eine Kette von Middleware-Komponenten. Diese Kette wird beim Start der Anwendung konfiguriert. Jede Komponente kann den Request entweder an die nächste Komponente weitergeben oder den Zyklus vorzeitig beenden (short-circuiting), z.B. bei fehlender Autorisierung. Der Rückweg (Response) durchläuft die Pipeline in umgekehrter Reihenfolge, was Transformationen der Antwort ermöglicht.", "aspnetcore", "Deep Theory: Request/Response-Zyklen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Schreibe eine einfache Middleware, die 'Hello World' in die Response schreibt.", "", "var builder = WebApplication.CreateBuilder(args);\nvar app = builder.Build();\n\napp.Run(async context => \n{\n    await context.Response.________Async(\"Hello World\");\n});\n\napp.Run();\n", "aspnetcore", "WriteAsync", "var builder = WebApplication.CreateBuilder(args);\nvar app = builder.Build();\n\napp.Run(async context => \n{\n    await context.Response.WriteAsync(\"Hello World\");\n});\n\napp.Run();\n", "Einfache Middleware" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige den Aufruf, um statische Dateien in der Middleware-Pipeline zu aktivieren.", "", "var builder = WebApplication.CreateBuilder(args);\nvar app = builder.Build();\n\n// Aktiviere statische Dateien\napp.________________();\n\napp.MapGet(\"/\", () => \"Hello World!\");\napp.Run();\n", "aspnetcore", "UseStaticFiles", "var builder = WebApplication.CreateBuilder(args);\nvar app = builder.Build();\n\n// Aktiviere statische Dateien\napp.UseStaticFiles();\n\napp.MapGet(\"/\", () => \"Hello World!\");\napp.Run();\n", "Lücke: Middleware Pipeline" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "Speicherverwaltung von Variablen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "int,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int a = 10;\n		int b = 5;\n		Console.WriteLine(a + b);\n	}\n}", "Ganzzahlen (Integer)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Description", "ExpectedOutput", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie mit einer anderen Zahl und gib das Ergebnis aus.", "12.5", "double,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		double a = 2.5;\n		double b = 5.0;\n		Console.WriteLine(a * b);\n	}\n}", "Gleitkommazahlen (Double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verknüpfe zwei Strings und gib sie aus.", "Hallo Welt", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", 115, 4, "string,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		string s1 = \"Hallo \";\n		string s2 = \"Welt\";\n		Console.WriteLine(s1 + s2);\n	}\n}", "Zeichenketten (String)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende eine bool-Variable in einer if-Anweisung, um 'Wahr' auszugeben, wenn sie true ist, sonst 'Falsch'.", "Wahr", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		// Dein Code\n	}\n}", 115, 5, "bool,if,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		bool isActive = true;\n		if (isActive)\n		{\n			Console.WriteLine(\"Wahr\");\n		}\n		else\n		{\n			Console.WriteLine(\"Falsch\");\n		}\n	}\n}", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", 1, null, null, "Branch Prediction und Sprungtabellen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", 2, "if,else", null, "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden.", "Effizienz von Schleifen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "TestCode", "Title", "Type" },
                values: new object[] { "Berechne die Summe der Zahlen 1 bis 5.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", "for", null, "For-Schleife: Summe", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "csharp", "Systemcalls und Buffering" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies einen Namen mit `Console.ReadLine()` ein.", "Hallo CSharp", "using System;\n\npublic class Program {\n    public static void Main() {\n        // Lese von der Konsole\n        string name = Console.ReadLine();\n        Console.Write(\"Hallo \" + name);\n    }\n}\n", "csharp", "Console.ReadLine", "using System;\n\npublic class Program {\n    public static void Main() {\n        string name = Console.ReadLine();\n        Console.Write(\"Hallo \" + name);\n    }\n}\n", "ReadLine: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Wandle die Eingabe mit `int.Parse()` in eine Zahl um.", "20", "using System;\n\npublic class Program {\n    public static void Main() {\n        string s = Console.ReadLine();\n        // Lücke: int x = ___.Parse(s);\n        int x = ___.Parse(s);\n        Console.Write(x * 2);\n    }\n}\n", "csharp", "int.Parse", "using System;\n\npublic class Program {\n    public static void Main() {\n        string s = Console.ReadLine();\n        int x = int.Parse(s);\n        Console.Write(x * 2);\n    }\n}\n", "Lückentext: String zu Zahl" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "csharp", 119, 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "C# ist eine objektorientierte Sprache von Microsoft.", "csharp", 2, "Was ist C#?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 3, "Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		Console.WriteLine(\"Hallo Welt!\");\n	}\n}", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "csharp", 120, 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `ref`-Keyword, um den Wert der Variable `zahl` in der Methode `Verdopple` zu ändern.", "10", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        // Nutze ref auch beim Aufruf\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", "csharp", 120, 2, "ref int,ref zahl", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das ref Keyword" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `out`-Keyword, um einen Wert von einer Methode zurückzugeben, ohne den Rückgabewert zu nutzen.", "42", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        // out Variablen MÜSSEN in der Methode zugewiesen werden\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", "csharp", 120, 3, "out int,out zahl", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das out Keyword" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Fülle die Lücken mit `ref` oder `out`.", "x=2,y=1", "using System;\n\npublic class Program\n{\n    static void Swap(____ int a, ____ int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(____ x, ____ y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", "csharp", 4, "ref int,ref x", "using System;\n\npublic class Program\n{\n    static void Swap(ref int a, ref int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(ref x, ref y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", "Lückentext: C# Syntax", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "Language", "LessonId", "Order", "Title", "Type" },
                values: new object[] { null, null, "Objekte einer Klasse werden im Heap gespeichert. Ein Objekt enthält nicht nur seine Datenfelder, sondern oft auch einen Zeiger auf eine Virtual Method Table (VTable), die es ermöglicht, zur Laufzeit die richtigen Methodenaufrufe (Polymorphismus) zuzuordnen.", "csharp", 121, 1, "Objektlayout im Speicher", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'.", "", "public class Calculator \n{\n    // Hier deine Methode\n}", "csharp", 121, 2, "class,Calculator,static,int", null, "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", 122, 1, null, null, "Branch Prediction und Sprungtabellen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Zahl `x` größer als 10 ist. Gib 'Groß' aus, ansonsten 'Klein'.", "Groß", "fn main() {\n    let x = 15;\n    // Dein Code hier\n}\n", 122, 2, "if,else", "fn main() {\n    let x = 15;\n    if x > 10 {\n        println!(\"Groß\");\n    } else {\n        println!(\"Klein\");\n    }\n}\n", "Einfaches if/else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust hat eine endlose Schleife namens `loop`. Nutze `break`, um sie zu verlassen, wenn `i` den Wert 5 erreicht hat. Gib `i` in jedem Durchgang aus.", "0\n1\n2\n3\n4\n5", "fn main() {\n    let mut i = 0;\n    loop {\n        // Dein Code hier\n        i += 1;\n    }\n}\n", 122, 3, "loop,break", "fn main() {\n    let mut i = 0;\n    loop {\n        println!(\"{}\", i);\n        if i == 5 {\n            break;\n        }\n        i += 1;\n    }\n}\n", "Die `loop` Schleife", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while` Schleife, um die Zahlen von 3 bis 1 (herunterzählend) auszugeben.", "3\n2\n1", "fn main() {\n    let mut n = 3;\n    // Dein Code hier\n}\n", 122, 4, "while", "fn main() {\n    let mut n = 3;\n    while n > 0 {\n        println!(\"{}\", n);\n        n -= 1;\n    }\n}\n", "While Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", 123, 1, null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine i32-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "fn main() {\n    // Dein Code\n}", 123, 2, "let,println!", "fn main() {\n    let a: i32 = 10;\n    let b: i32 = 5;\n    println!(\"{}\", a + b);\n}", "Ganzzahlen (i32)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine f64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "fn main() {\n    // Dein Code\n}", 123, 3, "f64,println!", "fn main() {\n    let a: f64 = 2.5;\n    let b: f64 = 5.0;\n    println!(\"{}\", a * b);\n}", "Gleitkommazahlen (f64)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "fn main() {\n    // Dein Code\n}", 123, 4, "String,println!", "fn main() {\n    let s1 = String::from(\"Hallo \");\n    let s2 = \"Welt\";\n    println!(\"{}{}\", s1, s2);\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "fn main() {\n    let is_active = true;\n    // Dein Code\n}", 123, 5, "bool,if,println!", "fn main() {\n    let is_active = true;\n    if is_active {\n        println!(\"Wahr\");\n    } else {\n        println!(\"Falsch\");\n    }\n}", "Booleans (bool)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", 124, 1, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "[\"Damit sie schneller geladen wird\", \"Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen\", \"Um anzuzeigen, dass es ein String ist\", \"Das mut ist optional\"]", "Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen", "Warum muss die Variable für die Eingabe mit `mut` deklariert werden (z.B. `let mut input`)?", "", "", 124, 2, null, null, "Anatomie der Eingabe", 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "In Rust nutzt man `std::io::stdin()`, um Eingaben einzulesen. <br>Lies einen Namen von der Tastatur ein und gib 'Hallo [Name]!' aus. <br>Hinweis: Tippe in das Eingabefeld rechts das Wort 'Rust' ein, bevor du auf Ausführen klickst.", "Hallo Rust!", "use std::io;\n\nfn main() {\n    let mut input = String::new(); // Erstellt einen Puffer\n    \n    // Deine Aufgabe: Nutze io::stdin().read_line(&mut input).unwrap();\n    \n    println!(\"Hallo {}!\", input.trim());\n}\n", 124, 3, "read_line", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    println!(\"Hallo {}!\", input.trim());\n}\n", "Einen String einlesen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lies eine Zahl von der Tastatur ein, verdopple sie und gib das Ergebnis aus. <br>Hinweis: Nutze `.trim().parse::<i32>().unwrap()`, um den String in eine Zahl zu wandeln. <br>Tippe die Zahl '21' in das Eingabefeld.", "Ergebnis: 42", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    // Deine Aufgabe: Wandle 'input' in eine Zahl 'n' um\n    // let n: i32 = ...\n    \n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", 124, 3, "parse", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let n: i32 = input.trim().parse().unwrap();\n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "Zahl einlesen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies zwei Zahlen nacheinander ein und gib deren Summe aus. <br>Wichtig: Das Eingabefeld unterstützt aktuell nur eine Zeile. Trenne deine beiden Zahlen im Eingabefeld mit einem Leerzeichen (z.B. '10 5').", "Summe: 15", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    \n    println!(\"Summe: {}\", a + b);\n}\n", 124, 4, "split_whitespace", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    println!(\"Summe: {}\", a + b);\n}\n", "Zwei Zahlen addieren" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1083,
                column: "LessonId",
                value: 125);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust kannst du viele unveränderbare Referenzen haben, aber nur eine veränderbare. Fülle die Lücken, um den Wert zu lesen und zu schreiben.", "Lesen: 10\nNeu: 20", "fn main() {\n    let mut data = 10;\n    \n    let r1 = &data; // Immutable\n    println!(\"Lesen: {}\", r1);\n    \n    // Lücke: Erstelle eine veränderbare Referenz\n    let r2 = ________;\n    *r2 += 10;\n    \n    println!(\"Neu: {}\", data);\n}\n", 125, "&mut data,*r2", "fn main() {\n    let mut data = 10;\n    let r1 = &data;\n    println!(\"Lesen: {}\", r1);\n    \n    let r2 = &mut data;\n    *r2 += 10;\n    println!(\"Neu: {}\", data);\n}\n", "Immutable vs Mutable" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `Box<T>`, um einen Wert auf dem Heap zu speichern. Vervollständige die Zeile mit `Box::new()`.", "Heap Wert: 50", "fn main() {\n    // Speichere die Zahl 50 auf dem Heap\n    let heap_val = Box::new(50);\n    \n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", 125, "Box::new,*heap_val", "fn main() {\n    let heap_val = Box::new(50);\n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", "Box: Smart Pointer auf dem Heap" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Referenzen können automatisch dereferenziert werden. Übergebe eine Referenz an eine Funktion, die einen primitiven Typ erwartet.", "Zahl: 42", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    // Übergebe den Wert hinter der Referenz\n    print_int(*r);\n}\n", 125, "*r", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    print_int(*r);\n}\n", "Deref Coercion" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "rust", 126, "Systemcalls und Buffering" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Zeile, um einen neuen, leeren String-Puffer zu erstellen. <br>Nutze `String::new()`.", "Puffer bereit.", "fn main() {\n    // Vervollständige: let mut input = ...\n    let mut input = ___________;\n    \n    println!(\"Puffer bereit.\");\n}\n", "rust", 126, "String::new", "fn main() {\n    let mut input = String::new();\n    println!(\"Puffer bereit.\");\n}\n", "Lücke: Den Puffer erstellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`.", "Bitte etwas tippen:\nGelesen!", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    \n    // Lücke: io::stdin().read_line(____ buffer).unwrap();\n    io::stdin().read_line(____ buffer).unwrap();\n    \n    println!(\"Gelesen!\");\n}\n", "rust", 126, "&mut", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    io::stdin().read_line(&mut buffer).unwrap();\n    println!(\"Gelesen!\");\n}\n", "Lücke: Die Referenz" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`.", "", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    \n    // Lücke: ____::stdin().read_line(&mut input).unwrap();\n    ____::stdin().read_line(&mut input).unwrap();\n}\n", "rust", 126, "io::stdin", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n}\n", "Lücke: Das Modul aufrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Schreibe die komplette Zeile, um eine Eingabe in die Variable `text` einzulesen. <br>Vergiss das `.unwrap()` am Ende nicht!", "Eingabe erfolgt.", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    \n    // Schreibe hier die komplette read_line Zeile:\n    \n    println!(\"Eingabe erfolgt.\");\n}\n", "rust", 5, "read_line,&mut,unwrap", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    io::stdin().read_line(&mut text).unwrap();\n    println!(\"Eingabe erfolgt.\");\n}\n", "Lücke: Alles zusammen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "rust", 127, 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", "rust", 127, 2, null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", "rust", 127, 3, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "rust", 128, 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Vervollständige die Funktion `laenge`, sodass sie die Länge eines Strings berechnet, ohne den Besitz (Ownership) zu übernehmen.", "Die Länge von 'Hallo' ist 5.", "fn laenge(s: &String) -> usize {\n    // Berechne die Länge\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    // Übergebe eine Referenz mit &\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "rust", 128, 2, "&String,&s1", "fn laenge(s: &String) -> usize {\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "Unveränderbare Referenzen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `&mut`, um den Inhalt eines Strings in einer Funktion zu verändern.", "Hallo, Welt", "fn aendern(s: &mut String) {\n    // Füge Text an\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    // Übergebe eine veränderbare Referenz mit &mut\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "rust", 128, 3, "&mut String,&mut s", "fn aendern(s: &mut String) {\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "Veränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `&` oder `&mut`.", "Lesen: Daten\nDaten...geändert", "fn main() {\n    let ___ s = String::from(\"Daten\");\n    \n    process_read(___s);  // Nur Lesen\n    process_write(___s); // Schreiben\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: ___String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: ___String) {\n    s.push_str(\"...geändert\");\n}\n", "rust", 128, 4, "&s,&mut s,&String,&mut String", "fn main() {\n    let mut s = String::from(\"Daten\");\n    \n    process_read(&s);\n    process_write(&mut s);\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: &String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: &mut String) {\n    s.push_str(\"...geändert\");\n}\n", "Lückentext: Rust Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "HTTP/3 nutzt QUIC statt TCP, um Head-of-Line Blocking zu vermeiden und schnellere Verbindungsaufbaue (0-RTT) zu ermöglichen. Spring Boot 4 integriert Native Unterstützung für HTTP/3 durch moderne Server-Engines wie Netty oder Tomcat. Dies verbessert die Latenz bei mobilen Netzwerken und instabilen Verbindungen erheblich.", "springboot", 129, "Deep Theory: HTTP/3 Support" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle einen REST-Controller, der bei einem GET-Aufruf auf '/api/status' 'OK' zurückgibt.", "", "import org.springframework.web.bind.annotation.*;\n\n@________________\npublic class StatusController {\n    @___________(\"/api/status\")\n    public String getStatus() {\n        return \"OK\";\n    }\n}\n", "springboot", 129, "RestController,GetMapping", "import org.springframework.web.bind.annotation.*;\n\n@RestController\npublic class StatusController {\n    @GetMapping(\"/api/status\")\n    public String getStatus() {\n        return \"OK\";\n    }\n}\n", "REST Controller" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Description", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Vervollständige die Annotation, um anzugeben, dass diese Methode nur JSON zurückgibt.", "@GetMapping(value = \"/user\", produces = MediaType._________________VALUE)\npublic User getUser() {\n    return new User(\"Tom\");\n}\n", "springboot", 3, "APPLICATION_JSON_VALUE", "@GetMapping(value = \"/user\", produces = MediaType.APPLICATION_JSON_VALUE)\npublic User getUser() {\n    return new User(\"Tom\");\n}\n", "Lücke: Content Negotiation", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Description", "Language", "LessonId", "Order", "Title" },
                values: new object[] { "Hibernate verfolgt den Zustand geladener Entitäten im Persistence Context. Beim Flush-Vorgang vergleicht Hibernate den aktuellen Zustand der Objekte mit ihrem Ursprungszustand ('Dirty Checking'). Nur wenn Änderungen festgestellt werden, generiert Hibernate automatisch die entsprechenden SQL-UPDATE-Statements. Dies erspart manuelle Aufrufe von `.save()` oder `.update()`.", "springboot", 130, 1, "Deep Theory: Hibernate Dirty Checking" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle ein Interface 'UserRepository', das von 'JpaRepository' für die Klasse 'User' mit dem ID-Typ 'Long' erbt.", "", "import org.springframework.data.jpa.repository.JpaRepository;\n\npublic interface UserRepository extends _____________<User, ____> {\n}\n", "springboot", 130, 2, "JpaRepository,Long", "import org.springframework.data.jpa.repository.JpaRepository;\n\npublic interface UserRepository extends JpaRepository<User, Long> {\n}\n", "Repository Erstellung" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "Description", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Definiere eine Methode, um einen Benutzer anhand seiner E-Mail-Adresse zu finden (Derived Query).", "public interface UserRepository extends JpaRepository<User, Long> {\n    User find_________________(String email);\n}\n", "springboot", 3, "findByEmail", "public interface UserRepository extends JpaRepository<User, Long> {\n    User findByEmail(String email);\n}\n", "Lücke: Query Method", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Virtual Threads (Project Loom) in Java 25 ermöglichen es, Millionen von Threads gleichzeitig zu betreiben, ohne den Overhead von Betriebssystem-Threads. In Spring Boot 4 werden diese Threads standardmäßig genutzt, um die Skalierbarkeit massiv zu erhöhen. Jede HTTP-Anfrage kann nun ihren eigenen Thread haben, ohne dass der Speicherverbrauch oder Context-Switching-Overhead die Anwendung bremst.", "", "", "springboot", 131, 1, null, null, "Deep Theory: Java 25 Virtual Threads", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Hauptklasse mit der `@SpringBootApplication` Annotation und der `run` Methode.", "", "import org.springframework.boot.SpringApplication;\nimport org.springframework.boot.autoconfigure.SpringBootApplication;\n\n@____________________\npublic class MyBackend {\n    public static void main(String[] args) {\n        SpringApplication.______(MyBackend.class, args);\n    }\n}\n", "springboot", 131, 2, "SpringBootApplication,run", "import org.springframework.boot.SpringApplication;\nimport org.springframework.boot.autoconfigure.SpringBootApplication;\n\n@SpringBootApplication\npublic class MyBackend {\n    public static void main(String[] args) {\n        SpringApplication.run(MyBackend.class, args);\n    }\n}\n", "Die Hauptklasse" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Spring Boot nutzt Konventionen statt Konfiguration. Mit welcher Annotation kannst du die Auto-Konfiguration explizit deaktivieren (selten benötigt)?", "", "@SpringBootApplication(exclude = {DataSourceAutoConfiguration._______})\npublic class MyBackend { }\n", "springboot", 131, 3, "class", "@SpringBootApplication(exclude = {DataSourceAutoConfiguration.class})\npublic class MyBackend { }\n", "Lücke: Auto-Configuration" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "OAuth 2.0 ist ein Framework für delegierte Autorisierung. OpenID Connect (OIDC) erweitert OAuth um eine Identitätsschicht. Mit ID-Tokens und Access-Tokens wird sichergestellt, dass Backends nur autorisierte Zugriffe erlauben. Spring Security bietet First-Class Support für JWT-Validierung und Integration mit Identity Providern wie Keycloak oder Azure AD.", "", "", "springboot", 132, 1, null, null, "Deep Theory: OAuth2 und OIDC", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze die Annotation `@Retryable`, um eine Methode bei einer 'RuntimeException' automatisch 3-mal neu zu versuchen.", "import org.springframework.retry.annotation.Retryable;\n\n@__________ (retryFor = { RuntimeException._____ })\npublic void callExternalService() {\n    // Fehleranfälliger Aufruf\n}\n", "springboot", 132, 2, "Retryable,class", "import org.springframework.retry.annotation.Retryable;\n\n@Retryable (retryFor = { RuntimeException.class })\npublic void callExternalService() {\n    // Fehleranfälliger Aufruf\n}\n", "Resilience mit @Retryable", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Sicherheitskonfiguration, um alle HTTP-Requests zu authentifizieren.", "", "@Bean\npublic SecurityFilterChain filterChain(HttpSecurity http) throws Exception {\n    http.authorizeHttpRequests(auth -> auth.____________().authenticated());\n    return http.build();\n}\n", "springboot", 132, 3, "anyRequest", "@Bean\npublic SecurityFilterChain filterChain(HttpSecurity http) throws Exception {\n    http.authorizeHttpRequests(auth -> auth.anyRequest().authenticated());\n    return http.build();\n}\n", "Lücke: Security Config" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "cpp", 133, 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken, um die Adresse von `zahl` in einem Raw Pointer zu speichern und den Wert darüber auszugeben.", "Wert: 100", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    // Lücke: int* ptr = ...\n    int* ptr = ________;\n    \n    // Lücke: Wert über Pointer ausgeben (Dereferenzierung)\n    std::cout << \"Wert: \" << ________;\n    return 0;\n}\n", "cpp", 133, 2, "&zahl,*ptr", "#include <iostream>\n\nint main() {\n    int zahl = 100;\n    int* ptr = &zahl;\n    std::cout << \"Wert: \" << *ptr;\n    return 0;\n}\n", "Raw Pointer: Adresse abrufen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `std::unique_ptr`, um Speicher auf dem Heap sicher zu verwalten. Erstelle einen `unique_ptr<int>` mit `std::make_unique`.", "Smart Wert: 42", "#include <iostream>\n#include <memory>\n\nint main() {\n    // Erstelle einen unique_ptr für den Wert 42\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    \n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", "cpp", 133, 3, "unique_ptr,make_unique", "#include <iostream>\n#include <memory>\n\nint main() {\n    std::unique_ptr<int> smartPtr = std::make_unique<int>(42);\n    if (smartPtr) {\n        std::cout << \"Smart Wert: \" << *smartPtr;\n    }\n    return 0;\n}\n", "Smart Pointer: unique_ptr" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Ein `shared_ptr` erlaubt es mehreren Pointern, denselben Speicher zu besitzen. Erstelle einen `shared_ptr` und gib den `use_count()` aus.", "Count: 2", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        // Erstelle eine Kopie von p1\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "cpp", 133, 4, "make_shared,use_count", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "Smart Pointer: shared_ptr", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", "cpp", 134, 1, null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus.", "15", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 134, 2, "int,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}", "Ganzzahlen (int)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 134, 3, "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1118,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende den Typ 'string', um zwei Texte zu verknüpfen.", "Hallo Welt", "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 134, 4, "string,cout", "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}", "Zeichenketten (string)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1119,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "#include <iostream>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "cpp", 5, "bool,if,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        cout << \"Wahr\";\n    } else {\n        cout << \"Falsch\";\n    }\n    return 0;\n}", "Booleans (bool)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1120,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "cpp", 135, 1, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1121,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `std::cin` mit dem `>>` Operator, um eine Zahl einzulesen.", "Gelesen: 42", "#include <iostream>\n\nint main() {\n    int zahl;\n    // Nutze cin zum Einlesen\n    std::cin >> zahl;\n    std::cout << \"Gelesen: \" << zahl;\n    return 0;\n}\n", "cpp", 135, 2, "cin >>", "#include <iostream>\n\nint main() {\n    int zahl;\n    std::cin >> zahl;\n    std::cout << \"Gelesen: \" << zahl;\n    return 0;\n}\n", "std::cin: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Welcher Operator wird für Eingaben mit `cin` verwendet?", "OK", "#include <iostream>\n\nint main() {\n    int x;\n    std::cin __ x; // Lücke füllen\n    std::cout << \"OK\";\n    return 0;\n}\n", "cpp", 3, ">>", "#include <iostream>\n\nint main() {\n    int x;\n    std::cin >> x;\n    std::cout << \"OK\";\n    return 0;\n}\n", "Lückentext: cin Operator", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1123,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", "cpp", 136, 1, null, null, "Branch Prediction und Sprungtabellen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1124,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 136, 2, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1125,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "cpp", 137, 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "Description", "Language", "LessonId", "Order", "Title" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "cpp", 137, 2, "Was ist C++?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <iostream>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 137, 3, "cout", "#include <iostream>\n\nint main() {\n    std::cout << \"Hallo Welt!\" << std::endl;\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "cpp", 138, 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt (Call by Value).", "Wert nach Funktion: 5", "#include <iostream>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 138, 2, "x = x * 2", "#include <iostream>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine Referenz (`&`), um den Wert der Originalvariable in der Funktion `verdoppleRef` dauerhaft zu ändern.", "Geänderter Wert: 10", "#include <iostream>\n\n// Nutze & für Call by Reference\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 138, 3, "int&", "#include <iostream>\n\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Reference" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Wert über Pointer: 10", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 138, 4, "int*,&zahl", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Pointer", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1132,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit der richtigen Syntax für Pointer und Referenzen.", "x=2, y=1", "#include <iostream>\n\nvoid swap(int__ a, int__ b) { // Nutze & für Referenzen\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=\" << x << \", y=\" << y;\n    return 0;\n}\n", "cpp", 138, 5, "int&", "#include <iostream>\n\nvoid swap(int& a, int& b) {\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=2, y=1\";\n    return 0;\n}\n", "Lückentext: Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1133,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", "c", 139, 1, null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1134,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "15", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 139, 2, "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1135,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 139, 3, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1136,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus.", "Hallo Welt", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 139, 4, "char,printf", "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}", "Zeichenketten (char Array)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1137,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung.", "Wahr", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "c", 5, "bool,if,printf", "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}", "Booleans (stdbool.h)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1138,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", "c", 140, 1, null, null, "Branch Prediction und Sprungtabellen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1139,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", 140, 2, "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1140,
                columns: new[] { "Language", "LessonId" },
                values: new object[] { "c", 141 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1141,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "c", 141, "Was ist C?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1142,
                columns: new[] { "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution" },
                values: new object[] { "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 141, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1143,
                columns: new[] { "Language", "LessonId" },
                values: new object[] { "c", 142 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1144,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies eine Ganzzahl mit `scanf` ein und gib sie aus.", "Zahl: 100", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    // scanf nutzt %d und den Adressoperator &\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", "c", 142, "scanf,&zahl", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", "scanf: Ganzzahlen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1145,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Bei `scanf` musst du immer die Adresse der Variable angeben. Welches Zeichen wird dafür benötigt?", "OK", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", __x); // Lücke füllen\n    printf(\"OK\");\n    return 0;\n}\n", "c", 142, "&x", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", &x);\n    printf(\"OK\");\n    return 0;\n}\n", "Lückentext: Adressoperator" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1146,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "c", 143, "Referenzsemantik und Speichersicherheit" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1147,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Wert nach Funktion: 5", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "c", 143, "x = x * 2", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "Call by Value in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1148,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Geänderter Wert: 10", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl mit &\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "c", 143, "int *,*x,&zahl", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "Call by Pointer in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1149,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen.", "x=2, y=1", "#include <stdio.h>\n\nvoid swap(int ____ a, int ____ b) {\n    int temp = ____ a;\n    ____ a = ____ b;\n    ____ b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=%d, y=%d\", x, y);\n    return 0;\n}\n", "c", 4, "int *,* a,* b", "#include <stdio.h>\n\nvoid swap(int * a, int * b) {\n    int temp = * a;\n    * a = * b;\n    * b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=2, y=1\");\n    return 0;\n}\n", "Lückentext: Pointer-Syntax", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1150,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", "python", 144, 1, null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1151,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "# Dein Code hier", "python", 144, 2, "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1152,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "python", 144, 3, "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1153,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "Hallo Welt", "# Dein Code hier", "python", 144, 4, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1154,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "Wahr", "is_active = True\n# Dein Code", "python", 5, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1155,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "python", 145, 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1156,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "def verdopple(x):\n    # x lokal verdoppeln\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "python", 145, 2, "x = x * 2", "def verdopple(x):\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "Unveränderliche Typen (Integers)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1157,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden.", "Python", "def add_element(liste):\n    # Füge \"Python\" zur Liste hinzu\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "python", 145, 3, "append", "def add_element(liste):\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", null, "Veränderliche Typen (Listen)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1158,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "python", 146, "Branch Prediction und Sprungtabellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1159,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", 146, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1160,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", 146, "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1161,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden.", "python", 147, "Effizienz von Schleifen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1162,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", "python", 147, "for,in,range", "for i in range(1, 6):\n    print(i)\n", "Zahlen 1 bis 5" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1163,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", "python", 147, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1164,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "python", 148, "Wie Programme funktionieren" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1165,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "", "", "python", 148, null, null, "Was ist Python?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1166,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "# Dein Code hier\n", "python", 3, "print", "print(\"Hallo Welt!\")\n", "Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1167,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "python", 149, 1, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1168,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `input()`, um einen Namen einzulesen und gib 'Hallo [Name]' aus. <br>Hinweis: Tippe deinen Namen in das Eingabefeld rechts unten.", "Hallo Python", "# Lese den Namen ein\nname = input()\nprint(\"Hallo \" + name)\n", "python", 149, 2, "input", "name = input()\nprint(\"Hallo \" + name)\n", "input() Grundlagen" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1169, null, null, "Eingaben von `input()` sind immer Strings. Wandle die Eingabe in ein `int` um, um damit zu rechnen.", "20", "# Lücke: zahl = ___(input())\nzahl = ___(input())\nprint(zahl * 2)\n", "python", 149, 3, null, "int", "zahl = int(input())\nprint(zahl * 2)\n", null, "Lückentext: Typumwandlung", 1 },
                    { 1170, null, null, "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", "java", 150, 1, null, null, null, null, "Speicherverwaltung von Variablen", 0 },
                    { 1171, null, null, "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 150, 2, null, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", null, "Ganzzahlen (int)", 1 },
                    { 1172, null, null, "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 150, 3, null, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", null, "Gleitkommazahlen (double)", 1 },
                    { 1173, null, null, "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 150, 4, null, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", null, "Zeichenketten (String)", 1 },
                    { 1174, null, null, "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", "java", 150, 5, null, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", null, "Booleans (boolean)", 1 },
                    { 1175, null, null, "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "java", 151, 1, null, null, null, null, "Wie Programme funktionieren", 0 },
                    { 1176, null, null, "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", 151, 2, null, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", null, "Java: Hallo Welt", 1 },
                    { 1177, null, null, "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 151, 3, null, "if", null, null, "Java: If-Else", 1 },
                    { 1178, null, null, "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 151, 4, null, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 },
                    { 1179, null, null, "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "java", 152, 1, null, null, null, null, "Referenzsemantik und Speichersicherheit", 0 },
                    { 1180, null, null, "Versuche den Wert von `x` in der Methode `verdopple` zu ändern. Bleibt das Original in `main` gleich?", "5", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "java", 152, 2, null, "x = x * 2", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", null, "Primitive: Pass by Value", 1 },
                    { 1181, null, null, "In Java werden Objektreferenzen per Wert übergeben. Du kannst das Objekt verändern, aber nicht die Referenz selbst.", "Java", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        // Füge ein Element hinzu\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "java", 152, 3, null, "list.add", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", null, "Objekte: Referenz ändern", 1 },
                    { 1182, null, null, "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "java", 153, 1, null, null, null, null, "Systemcalls und Buffering", 0 },
                    { 1183, null, null, "Nutze die `Scanner`-Klasse, um einen Namen einzulesen.", "Hallo Java", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        // Erstelle einen Scanner\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", "java", 153, 2, null, "Scanner,System.in", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", null, "Scanner: Einlesen", 1 },
                    { 1184, null, null, "Welche Methode des Scanners liest die nächste Ganzzahl ein?", "42", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        // Lücke: int x = sc.____();\n        int x = sc.____();\n        System.out.print(x);\n    }\n}\n", "java", 153, 3, null, "nextInt", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        int x = sc.nextInt();\n        System.out.print(x);\n    }\n}\n", null, "Lückentext: Nächste Zahl", 1 },
                    { 1185, null, null, "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", "java", 154, 1, null, null, null, null, "Branch Prediction und Sprungtabellen", 0 },
                    { 1186, null, null, "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 154, 2, null, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", null, "Logik: Positiv/Negativ", 1 },
                    { 1187, null, null, "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden.", "", "", "java", 155, 1, null, null, null, null, "Effizienz von Schleifen", 0 },
                    { 1188, null, null, "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", "java", 155, 2, null, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", null, "Zahlen 1 bis 5", 1 },
                    { 1189, null, null, "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", "java", 155, 3, null, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", null, "Summe bis 10", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1189);

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

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C# arbeitest.</p><p>Variablen sind Container zum Speichern von Datenwerten. In C# musst du den Datentyp einer Variable angeben.</p>\n", "csharp", 5, "Variablen in C#" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne Entscheidungen im Code zu treffen.</p><p>In dieser Lektion lernst du <code>if</code> und <code>else</code> kennen.</p>\n", "csharp", 2, "Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben effizient.</p><p>Schleifen helfen dir, Aufgaben mehrfach auszuführen.</p>\n", "csharp", 3, "Schleifen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Console.ReadLine() für Eingaben in C# nutzt.</p><p>In C# nutzt du die Klasse <strong><code>Console</code></strong>, um Eingaben zu erhalten.</p>\n<ol>\n<li><strong><code>Console.ReadLine()</code></strong>: Liest eine komplette Zeile als String ein.</li>\n<li><strong><code>Console.Read()</code></strong>: Liest nur ein einzelnes Zeichen als Ganzzahl-Code (ASCII/Unicode).</li>\n<li><strong>Parsing</strong>: Nutze Methoden wie <code>int.Parse()</code> oder <code>Convert.ToInt32()</code>, um Texte in Zahlen zu wandeln.</li>\n</ol>\n", "csharp", 7, "C#: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von C#.</p><p>In dieser Lektion lernst du die ersten Schritte in C#.</p>\n", 1, "C# Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne den Einsatz von ref und out für Call by Reference in C#.</p><p>In C# werden Werttypen (wie <code>int</code>, <code>bool</code>) standardmäßig per <strong>Call by Value</strong> übergeben.</p>\n<ol>\n<li><strong>ref</strong>: Übergibt eine Referenz auf eine Variable. Die Variable muss vor der Übergabe initialisiert sein.</li>\n<li><strong>out</strong>: Übergibt eine Referenz, aber die Variable muss nicht initialisiert sein. Die Methode <strong>muss</strong> der <code>out</code>-Variable jedoch einen Wert zuweisen.</li>\n<li><strong>Pointer</strong>: C# unterstützt Pointer nur in <code>unsafe</code> Codeblöcken, was für allgemeine Anwendungen selten genutzt wird.</li>\n</ol>\n", 6, "C#: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Objektorientierte Programmierung.</p><p>Alles in C# findet in Klassen statt.</p>\n", 4, "Klassen & Methoden" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen und Code wiederholen.</p><p>Kontrollstrukturen sind das Herzstück jeder Programmiersprache. In Rust gibt es neben <code>if</code> und <code>else</code> auch mächtige Schleifen-Konstrukte wie <code>loop</code>, <code>while</code> und <code>for</code>.</p>\n", "rust", 3, "Rust: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Rust arbeitest.</p><p>In Rust sind Variablen standardmäßig unveränderlich (immutable). Mit <code>let mut</code> kannst du sie veränderbar machen.</p>\n", "rust", 4, "Variablen in Rust" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Wie liest man Daten von der Tastatur in Rust ein?</p><p>Rust legt großen Wert auf Sicherheit. Daher ist die Standardeingabe etwas ausführlicher als in anderen Sprachen. Das Modul <code>std::io</code> bietet Zugriff auf die Funktionen, um von der Tastatur zu lesen.</p>\n", "rust", 2, "Rust: Ein- und Ausgabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Vertiefe dein Wissen über Borrowing und lerne Smart Pointer wie Box kennen.</p><p>Rust erzwingt strikte Regeln für Referenzen zur Kompilierzeit (<strong>Borrow Checker</strong>).</p>\n<ol>\n<li><strong>Immutable Borrowing (<code>&amp;T</code>)</strong>: Beliebig viele Referenzen zum Lesen erlaubt.</li>\n<li><strong>Mutable Borrowing (<code>&amp;mut T</code>)</strong>: Nur eine Referenz zum Schreiben erlaubt.</li>\n<li><strong>Smart Pointer (<code>Box&lt;T&gt;</code>)</strong>: Ermöglicht es, Daten auf dem Heap statt auf dem Stack zu speichern. <code>Box</code> besitzt die Daten und gibt sie automatisch frei.</li>\n</ol>\n", "rust", 7, "Rust: Fortgeschrittene Referenzen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Übe die Syntax für Benutzereingaben in Rust, indem du die Lücken füllst.</p><p>In Rust ist das Einlesen von der Konsole explizit. Du brauchst:</p>\n<ol>\n<li>Einen <strong>veränderbaren String</strong> (<code>let mut input = String::new()</code>).</li>\n<li>Den Aufruf von <strong><code>io::stdin().read_line()</code></strong>.</li>\n<li>Eine <strong>veränderbare Referenz</strong> auf deinen String (<code>&amp;mut input</code>).</li>\n<li>Eine Fehlerbehandlung wie <strong><code>.unwrap()</code></strong> oder <code>.expect()</code>.</li>\n</ol>\n", 5, "Rust: Lückentext Eingabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die Welt von Rust - Sicher, schnell und modern.</p><p>In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.</p>\n", 1, "Rust Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie Rust Daten sicher per Referenz übergibt.</p><p>In Rust gibt es kein klassisches &quot;Call by Reference&quot; wie in C++, sondern <strong>Borrowing</strong> (Ausleihen).</p>\n<ol>\n<li><strong>Unveränderbares Borrowing (<code>&amp;T</code>)</strong>: Man darf den Wert lesen, aber nicht ändern. Man kann beliebig viele dieser Referenzen gleichzeitig haben.</li>\n<li><strong>Veränderbares Borrowing (<code>&amp;mut T</code>)</strong>: Man darf den Wert ändern. Es darf jedoch immer nur <strong>eine</strong> veränderbare Referenz zur gleichen Zeit existieren (Sicherheit gegen Data Races).</li>\n<li><strong>Ownership</strong>: Wird kein <code>&amp;</code> verwendet, wird der Wert <strong>verschoben</strong> (Move) und die ursprüngliche Variable ist nicht mehr nutzbar.</li>\n</ol>\n", 6, "Rust: Referenzen und Borrowing" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den sicheren Umgang mit Raw Pointern und modernen Smart Pointern in C++.</p><p>In modernem C++ (ab C++11) solltest du <strong>Smart Pointer</strong> gegenüber Raw Pointern bevorzugen, um Speicherlecks zu vermeiden.</p>\n<ol>\n<li><strong>Raw Pointer (<code>T*</code>)</strong>: Speichert eine nackte Speicheradresse. Du musst dich selbst um <code>delete</code> kümmern.</li>\n<li><strong><code>std::unique_ptr&lt;T&gt;</code></strong>: Exklusives Eigentum. Der Speicher wird automatisch freigegeben, wenn der Pointer out-of-scope geht.</li>\n<li><strong><code>std::shared_ptr&lt;T&gt;</code></strong>: Gemeinsames Eigentum. Nutzt Reference Counting.</li>\n</ol>\n", "cpp", 5, "C++: Pointer und Smart Pointer" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C++ arbeitest.</p><p>C++ ist eine objektorientierte Erweiterung von C und bietet komfortable Typen wie <code>std::string</code>.</p>\n", "cpp", 3, "Variablen in C++" });

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
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "cpp", 2, "C++: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Ein Einstieg in die objektorientierte Programmierung mit C++.</p><p>In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.</p>\n", "cpp", 1, "C++ Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value, Call by Reference und Call by Pointer.</p><p>In C++ gibt es drei Hauptarten, wie Daten an Funktionen übergeben werden können:</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie erstellt. Änderungen in der Funktion haben keine Auswirkung auf das Original.</li>\n<li><strong>Call by Reference</strong>: Die Funktion erhält direkten Zugriff auf das Original (Alias). Änderungen wirken sich sofort aus. Syntax: <code>Type&amp; name</code>.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse der Variable wird übergeben. Die Funktion greift über Dereferenzierung (<code>*</code>) auf das Original zu. Syntax: <code>Type* name</code> und beim Aufruf <code>&amp;variable</code>.</li>\n</ol>\n", "cpp", 4, "C++: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in C arbeitest.</p><p>In C musst du Datentypen explizit angeben. Für Booleans musst du <code>&lt;stdbool.h&gt;</code> einbinden.</p>\n", "c", 3, "Variablen in C" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "c", 2, "C: Kontrollstrukturen" });

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
                values: new object[] { "<p>Lerne, wie du scanf für Eingaben in C nutzt.</p><p>In C ist <strong><code>scanf</code></strong> die Standardfunktion zum Einlesen von formatierten Daten.</p>\n<ol>\n<li><strong>Format-String</strong>: <code>%d</code> für Integer, <code>%f</code> für Float, etc.</li>\n<li><strong>Adressoperator (<code>&amp;</code>)</strong>: <code>scanf</code> benötigt die Speicheradresse der Variable, in die der Wert geschrieben werden soll.</li>\n</ol>\n", "c", 5, "C: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne den Unterschied zwischen Call by Value und Call by Pointer in C.</p><p>In C gibt es (im Gegensatz zu C++) kein echtes &quot;Call by Reference&quot;. Stattdessen nutzt man Pointer, um ähnliche Effekte zu erzielen.</p>\n<ol>\n<li><strong>Call by Value</strong>: Es wird eine Kopie des Wertes an die Funktion übergeben. Änderungen betreffen nur die Kopie.</li>\n<li><strong>Call by Pointer</strong>: Die Adresse einer Variable wird übergeben. Die Funktion kann über diese Adresse direkt auf den Speicher des Aufrufers zugreifen und den Wert ändern.</li>\n</ol>\n", "c", 4, "C: Parameterübergabe" });

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
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du Code-Blöcke wiederholst.</p><p>Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet <code>for</code> für bekannte Iterationen und <code>while</code> für bedingte Wiederholungen.</p>\n", "python", "Python: Schleifen" });

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
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du Daten von der Konsole einliest.</p><p>In Python nutzt du die Funktion <strong><code>input()</code></strong>, um Daten vom Benutzer zu erhalten.</p>\n<ol>\n<li><strong>Standard</strong>: <code>input()</code> gibt immer einen String zurück.</li>\n<li><strong>Konvertierung</strong>: Wenn du mit Zahlen rechnen möchtest, musst du das Ergebnis explizit umwandeln (z.B. <code>int(input())</code> oder <code>float(input())</code>).</li>\n</ol>\n", "python", 5, "Python: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne die Grundlagen des modernen Spring Boot 4 Frameworks kennen.</p><p>Spring Boot 4 ist der aktuelle Standard für Java-Backend-Entwicklung.</p>\n<ol>\n<li><strong>Auto-Konfiguration</strong>: Spring Boot konfiguriert deine Anwendung automatisch basierend auf den JAR-Abhängigkeiten.</li>\n<li><strong>Virtual Threads</strong>: Standardmäßige Nutzung von Java-Virtual-Threads für extrem skalierbare Anwendungen.</li>\n<li><strong>Resilience</strong>: Integrierte Unterstützung für Retry- und Circuit-Breaker-Patterns direkt im Framework.</li>\n</ol>\n", "java", 7, "Java: Spring Boot 4 Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Lerne, wie du mit verschiedenen Datentypen in Java arbeitest.</p><p>Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.</p>\n", "java", "Variablen in Java" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne Java kennen.</p><p>Java ist eine plattformunabhängige Sprache.</p>\n", "java", 1, "Java Einstieg" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "<p>Verstehe den Unterschied zwischen Primitiven und Objekten in Java.</p><p>In Java gibt es oft Diskussionen über &quot;Call by Reference&quot;. Die Wahrheit ist: <strong>Java ist immer Call by Value.</strong></p>\n<ol>\n<li><strong>Primitive Typen (<code>int</code>, <code>double</code>, etc.)</strong>: Es wird eine Kopie des eigentlichen Wertes übergeben.</li>\n<li><strong>Objekt-Referenzen</strong>: Es wird eine Kopie der <strong>Adresse</strong> des Objekts übergeben. Deshalb kannst du Attribute des Objekts in einer Methode ändern, aber du kannst nicht die ursprüngliche Variable auf ein komplett neues Objekt zeigen lassen.</li>\n</ol>\n", "java", "Java: Parameterübergabe" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Lerne, wie du die Scanner-Klasse für Eingaben in Java nutzt.</p><p>In Java ist die Klasse <strong><code>java.util.Scanner</code></strong> der einfachste Weg für Konsoleneingaben.</p>\n<ol>\n<li><strong>Instanziierung</strong>: <code>Scanner sc = new Scanner(System.in);</code>.</li>\n<li><strong>Methoden</strong>: <code>next()</code> für Strings, <code>nextInt()</code> für Ganzzahlen, <code>nextDouble()</code> für Kommazahlen.</li>\n<li><strong>Puffer</strong>: Beachte, dass <code>nextInt()</code> oft einen Zeilenumbruch im Puffer lässt.</li>\n</ol>\n", "java", 6, "Java: Benutzereingaben" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Entscheidungen treffen mit if und else.</p>", "java", 2, "Java: Kontrollstrukturen" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "<p>Wiederhole Aufgaben mit for und while.</p><p>Java nutzt <code>for</code>- und <code>while</code>-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.</p>\n", "java", 3, "Java: Schleifen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "csharp", "Speicherverwaltung von Variablen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", "int,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int a = 10;\n		int b = 5;\n		Console.WriteLine(a + b);\n	}\n}", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie mit einer anderen Zahl und gib das Ergebnis aus.", "12.5", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", "double,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		double a = 2.5;\n		double b = 5.0;\n		Console.WriteLine(a * b);\n	}\n}", "Gleitkommazahlen (Double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verknüpfe zwei Strings und gib sie aus.", "Hallo Welt", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		// Dein Code\n	}\n}", "csharp", 111, 4, "string,Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		string s1 = \"Hallo \";\n		string s2 = \"Welt\";\n		Console.WriteLine(s1 + s2);\n	}\n}", "Zeichenketten (String)", 1 });

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
                columns: new[] { "Description", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "csharp", 1, null, null, "Branch Prediction und Sprungtabellen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int zahl = -5;\n		// Dein Code hier\n	}\n}", "csharp", 112, 2, "if,else", "Logik: Positiv/Negativ", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Description", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden.", "", "csharp", 1, null, null, "Effizienz von Schleifen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Berechne die Summe der Zahlen 1 bis 5.", "15", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		int summe = 0;\n		// Nutze eine for-Schleife\n		Console.WriteLine(summe);\n	}\n}", "csharp", 2, "for", null, "For-Schleife: Summe" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "csharp", "Systemcalls und Buffering" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies einen Namen mit `Console.ReadLine()` ein.", "Hallo CSharp", "using System;\n\npublic class Program {\n    public static void Main() {\n        // Lese von der Konsole\n        string name = Console.ReadLine();\n        Console.Write(\"Hallo \" + name);\n    }\n}\n", "csharp", "Console.ReadLine", "using System;\n\npublic class Program {\n    public static void Main() {\n        string name = Console.ReadLine();\n        Console.Write(\"Hallo \" + name);\n    }\n}\n", "ReadLine: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Wandle die Eingabe mit `int.Parse()` in eine Zahl um.", "20", "using System;\n\npublic class Program {\n    public static void Main() {\n        string s = Console.ReadLine();\n        // Lücke: int x = ___.Parse(s);\n        int x = ___.Parse(s);\n        Console.Write(x * 2);\n    }\n}\n", "csharp", "int.Parse", "using System;\n\npublic class Program {\n    public static void Main() {\n        string s = Console.ReadLine();\n        int x = int.Parse(s);\n        Console.Write(x * 2);\n    }\n}\n", "Lückentext: String zu Zahl" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "Wie Programme funktionieren" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C# ist eine objektorientierte Sprache von Microsoft.", "", "", null, null, "Was ist C#?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Description", "ExpectedOutput", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "Console.WriteLine", "using System;\n\npublic class Program\n{\n	public static void Main()\n	{\n		Console.WriteLine(\"Hallo Welt!\");\n	}\n}", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", 116, 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze das `ref`-Keyword, um den Wert der Variable `zahl` in der Methode `Verdopple` zu ändern.", "10", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        // Nutze ref auch beim Aufruf\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", 116, 2, "ref int,ref zahl", "using System;\n\npublic class Program\n{\n    static void Verdopple(ref int x) {\n        x *= 2;\n    }\n    \n    public static void Main()\n    {\n        int zahl = 5;\n        Verdopple(ref zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das ref Keyword" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze das `out`-Keyword, um einen Wert von einer Methode zurückzugeben, ohne den Rückgabewert zu nutzen.", "42", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        // out Variablen MÜSSEN in der Methode zugewiesen werden\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", 3, "out int,out zahl", "using System;\n\npublic class Program\n{\n    static void Initialisiere(out int x) {\n        x = 42;\n    }\n    \n    public static void Main()\n    {\n        int zahl;\n        Initialisiere(out zahl);\n        Console.Write(zahl);\n    }\n}\n", "Das out Keyword", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `ref` oder `out`.", "x=2,y=1", "using System;\n\npublic class Program\n{\n    static void Swap(____ int a, ____ int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(____ x, ____ y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", 4, "ref int,ref x", "using System;\n\npublic class Program\n{\n    static void Swap(ref int a, ref int b) {\n        int temp = a;\n        a = b;\n        b = temp;\n    }\n    \n    public static void Main()\n    {\n        int x = 1, y = 2;\n        Swap(ref x, ref y);\n        Console.Write($\"x={x},y={y}\");\n    }\n}\n", "Lückentext: C# Syntax" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Objekte einer Klasse werden im Heap gespeichert. Ein Objekt enthält nicht nur seine Datenfelder, sondern oft auch einen Zeiger auf eine Virtual Method Table (VTable), die es ermöglicht, zur Laufzeit die richtigen Methodenaufrufe (Polymorphismus) zuzuordnen.", "Objektlayout im Speicher" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "RequiredKeywords", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'.", "", "public class Calculator \n{\n    // Hier deine Methode\n}", "class,Calculator,static,int", "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}", "Edu: Die Rechner-Klasse", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Description", "Language", "Title" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "rust", "Branch Prediction und Sprungtabellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Zahl `x` größer als 10 ist. Gib 'Groß' aus, ansonsten 'Klein'.", "Groß", "fn main() {\n    let x = 15;\n    // Dein Code hier\n}\n", "rust", "if,else", "fn main() {\n    let x = 15;\n    if x > 10 {\n        println!(\"Groß\");\n    } else {\n        println!(\"Klein\");\n    }\n}\n", "Einfaches if/else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Rust hat eine endlose Schleife namens `loop`. Nutze `break`, um sie zu verlassen, wenn `i` den Wert 5 erreicht hat. Gib `i` in jedem Durchgang aus.", "0\n1\n2\n3\n4\n5", "fn main() {\n    let mut i = 0;\n    loop {\n        // Dein Code hier\n        i += 1;\n    }\n}\n", "rust", "loop,break", "fn main() {\n    let mut i = 0;\n    loop {\n        println!(\"{}\", i);\n        if i == 5 {\n            break;\n        }\n        i += 1;\n    }\n}\n", "Die `loop` Schleife" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine `while` Schleife, um die Zahlen von 3 bis 1 (herunterzählend) auszugeben.", "3\n2\n1", "fn main() {\n    let mut n = 3;\n    // Dein Code hier\n}\n", "rust", 118, 4, "while", "fn main() {\n    let mut n = 3;\n    while n > 0 {\n        println!(\"{}\", n);\n        n -= 1;\n    }\n}\n", "While Schleife", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Description", "Language", "Order", "Title" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "rust", 1, "Speicherverwaltung von Variablen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine i32-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "fn main() {\n    // Dein Code\n}", "rust", 2, "let,println!", "fn main() {\n    let a: i32 = 10;\n    let b: i32 = 5;\n    println!(\"{}\", a + b);\n}", "Ganzzahlen (i32)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine f64-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "fn main() {\n    // Dein Code\n}", "rust", 119, 3, "f64,println!", "fn main() {\n    let a: f64 = 2.5;\n    let b: f64 = 5.0;\n    println!(\"{}\", a * b);\n}", "Gleitkommazahlen (f64)", 1 });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "rust", 1, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "Language", "LessonId", "Order", "Title", "Type" },
                values: new object[] { "[\"Damit sie schneller geladen wird\", \"Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen\", \"Um anzuzeigen, dass es ein String ist\", \"Das mut ist optional\"]", "Weil sie standardmäßig unveränderbar ist und wir Text hineinschreiben wollen", "Warum muss die Variable für die Eingabe mit `mut` deklariert werden (z.B. `let mut input`)?", "rust", 120, 2, "Anatomie der Eingabe", 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "In Rust nutzt man `std::io::stdin()`, um Eingaben einzulesen. <br>Lies einen Namen von der Tastatur ein und gib 'Hallo [Name]!' aus. <br>Hinweis: Tippe in das Eingabefeld rechts das Wort 'Rust' ein, bevor du auf Ausführen klickst.", "Hallo Rust!", "use std::io;\n\nfn main() {\n    let mut input = String::new(); // Erstellt einen Puffer\n    \n    // Deine Aufgabe: Nutze io::stdin().read_line(&mut input).unwrap();\n    \n    println!(\"Hallo {}!\", input.trim());\n}\n", "rust", 120, 3, "read_line", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    println!(\"Hallo {}!\", input.trim());\n}\n", null, "Einen String einlesen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lies eine Zahl von der Tastatur ein, verdopple sie und gib das Ergebnis aus. <br>Hinweis: Nutze `.trim().parse::<i32>().unwrap()`, um den String in eine Zahl zu wandeln. <br>Tippe die Zahl '21' in das Eingabefeld.", "Ergebnis: 42", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    // Deine Aufgabe: Wandle 'input' in eine Zahl 'n' um\n    // let n: i32 = ...\n    \n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", 120, 3, "parse", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let n: i32 = input.trim().parse().unwrap();\n    let ergebnis = n * 2;\n    println!(\"Ergebnis: {}\", ergebnis);\n}\n", "Zahl einlesen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Lies zwei Zahlen nacheinander ein und gib deren Summe aus. <br>Wichtig: Das Eingabefeld unterstützt aktuell nur eine Zeile. Trenne deine beiden Zahlen im Eingabefeld mit einem Leerzeichen (z.B. '10 5').", "Summe: 15", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    \n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    \n    println!(\"Summe: {}\", a + b);\n}\n", 120, 4, "split_whitespace", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n    let mut parts = input.split_whitespace();\n    let a: i32 = parts.next().unwrap().parse().unwrap();\n    let b: i32 = parts.next().unwrap().parse().unwrap();\n    println!(\"Summe: {}\", a + b);\n}\n", "Zwei Zahlen addieren" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", 121, 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Rust kannst du viele unveränderbare Referenzen haben, aber nur eine veränderbare. Fülle die Lücken, um den Wert zu lesen und zu schreiben.", "Lesen: 10\nNeu: 20", "fn main() {\n    let mut data = 10;\n    \n    let r1 = &data; // Immutable\n    println!(\"Lesen: {}\", r1);\n    \n    // Lücke: Erstelle eine veränderbare Referenz\n    let r2 = ________;\n    *r2 += 10;\n    \n    println!(\"Neu: {}\", data);\n}\n", 121, 2, "&mut data,*r2", "fn main() {\n    let mut data = 10;\n    let r1 = &data;\n    println!(\"Lesen: {}\", r1);\n    \n    let r2 = &mut data;\n    *r2 += 10;\n    println!(\"Neu: {}\", data);\n}\n", "Immutable vs Mutable" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze `Box<T>`, um einen Wert auf dem Heap zu speichern. Vervollständige die Zeile mit `Box::new()`.", "Heap Wert: 50", "fn main() {\n    // Speichere die Zahl 50 auf dem Heap\n    let heap_val = Box::new(50);\n    \n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", 121, 3, "Box::new,*heap_val", "fn main() {\n    let heap_val = Box::new(50);\n    println!(\"Heap Wert: {}\", *heap_val);\n}\n", "Box: Smart Pointer auf dem Heap", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Referenzen können automatisch dereferenziert werden. Übergebe eine Referenz an eine Funktion, die einen primitiven Typ erwartet.", "Zahl: 42", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    // Übergebe den Wert hinter der Referenz\n    print_int(*r);\n}\n", 121, 4, "*r", "fn print_int(val: i32) {\n    println!(\"Zahl: {}\", val);\n}\n\nfn main() {\n    let x = 42;\n    let r = &x;\n    print_int(*r);\n}\n", "Deref Coercion" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", 122, 1, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Zeile, um einen neuen, leeren String-Puffer zu erstellen. <br>Nutze `String::new()`.", "Puffer bereit.", "fn main() {\n    // Vervollständige: let mut input = ...\n    let mut input = ___________;\n    \n    println!(\"Puffer bereit.\");\n}\n", 122, 2, "String::new", "fn main() {\n    let mut input = String::new();\n    println!(\"Puffer bereit.\");\n}\n", "Lücke: Den Puffer erstellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`.", "Bitte etwas tippen:\nGelesen!", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    \n    // Lücke: io::stdin().read_line(____ buffer).unwrap();\n    io::stdin().read_line(____ buffer).unwrap();\n    \n    println!(\"Gelesen!\");\n}\n", 122, 3, "&mut", "use std::io;\n\nfn main() {\n    let mut buffer = String::new();\n    println!(\"Bitte etwas tippen:\");\n    io::stdin().read_line(&mut buffer).unwrap();\n    println!(\"Gelesen!\");\n}\n", "Lücke: Die Referenz" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Description", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`.", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    \n    // Lücke: ____::stdin().read_line(&mut input).unwrap();\n    ____::stdin().read_line(&mut input).unwrap();\n}\n", 122, 4, "io::stdin", "use std::io;\n\nfn main() {\n    let mut input = String::new();\n    io::stdin().read_line(&mut input).unwrap();\n}\n", "Lücke: Das Modul aufrufen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { null, null, "Schreibe die komplette Zeile, um eine Eingabe in die Variable `text` einzulesen. <br>Vergiss das `.unwrap()` am Ende nicht!", "Eingabe erfolgt.", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    \n    // Schreibe hier die komplette read_line Zeile:\n    \n    println!(\"Eingabe erfolgt.\");\n}\n", 122, 5, "read_line,&mut,unwrap", "use std::io;\n\nfn main() {\n    let mut text = String::new();\n    io::stdin().read_line(&mut text).unwrap();\n    println!(\"Eingabe erfolgt.\");\n}\n", "Lücke: Alles zusammen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", 123, 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert.", "", "", 123, 2, null, null, "Was ist Rust?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "fn main() {\n    // Dein Code hier\n}\n", 123, 3, "println!", "fn main() {\n    println!(\"Hallo Welt!\");\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1083,
                column: "LessonId",
                value: 124);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `laenge`, sodass sie die Länge eines Strings berechnet, ohne den Besitz (Ownership) zu übernehmen.", "Die Länge von 'Hallo' ist 5.", "fn laenge(s: &String) -> usize {\n    // Berechne die Länge\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    // Übergebe eine Referenz mit &\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", 124, "&String,&s1", "fn laenge(s: &String) -> usize {\n    s.len()\n}\n\nfn main() {\n    let s1 = String::from(\"Hallo\");\n    let len = laenge(&s1);\n    println!(\"Die Länge von '{}' ist {}.\", s1, len);\n}\n", "Unveränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `&mut`, um den Inhalt eines Strings in einer Funktion zu verändern.", "Hallo, Welt", "fn aendern(s: &mut String) {\n    // Füge Text an\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    // Übergebe eine veränderbare Referenz mit &mut\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", 124, "&mut String,&mut s", "fn aendern(s: &mut String) {\n    s.push_str(\", Welt\");\n}\n\nfn main() {\n    let mut s = String::from(\"Hallo\");\n    aendern(&mut s);\n    println!(\"{}\", s);\n}\n", "Veränderbare Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Fülle die Lücken mit `&` oder `&mut`.", "Lesen: Daten\nDaten...geändert", "fn main() {\n    let ___ s = String::from(\"Daten\");\n    \n    process_read(___s);  // Nur Lesen\n    process_write(___s); // Schreiben\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: ___String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: ___String) {\n    s.push_str(\"...geändert\");\n}\n", 124, "&s,&mut s,&String,&mut String", "fn main() {\n    let mut s = String::from(\"Daten\");\n    \n    process_read(&s);\n    process_write(&mut s);\n    \n    println!(\"{}\", s);\n}\n\nfn process_read(s: &String) {\n    println!(\"Lesen: {}\", s);\n}\n\nfn process_write(s: &mut String) {\n    s.push_str(\"...geändert\");\n}\n", "Lückentext: Rust Referenzen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "cpp", 125, "Referenzsemantik und Speichersicherheit" });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Ein `shared_ptr` erlaubt es mehreren Pointern, denselben Speicher zu besitzen. Erstelle einen `shared_ptr` und gib den `use_count()` aus.", "Count: 2", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        // Erstelle eine Kopie von p1\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "cpp", 125, "make_shared,use_count", "#include <iostream>\n#include <memory>\n\nint main() {\n    auto p1 = std::make_shared<int>(10);\n    {\n        std::shared_ptr<int> p2 = p1;\n        std::cout << \"Count: \" << p1.use_count();\n    }\n    return 0;\n}\n", "Smart Pointer: shared_ptr" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", "cpp", 1, null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus.", "15", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 126, 2, "int,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}", "Ganzzahlen (int)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "cpp", 126, 3, "double,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}", "Gleitkommazahlen (double)", 1 });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verwende einen bool in einer if-Anweisung.", "Wahr", "#include <iostream>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}", "cpp", 126, 5, "bool,if,cout", "#include <iostream>\nusing namespace std;\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        cout << \"Wahr\";\n    } else {\n        cout << \"Falsch\";\n    }\n    return 0;\n}", "Booleans (bool)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "cpp", 127, 1, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `std::cin` mit dem `>>` Operator, um eine Zahl einzulesen.", "Gelesen: 42", "#include <iostream>\n\nint main() {\n    int zahl;\n    // Nutze cin zum Einlesen\n    std::cin >> zahl;\n    std::cout << \"Gelesen: \" << zahl;\n    return 0;\n}\n", "cpp", 127, 2, "cin >>", "#include <iostream>\n\nint main() {\n    int zahl;\n    std::cin >> zahl;\n    std::cout << \"Gelesen: \" << zahl;\n    return 0;\n}\n", "std::cin: Einlesen" });

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
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "cpp", 128, "Branch Prediction und Sprungtabellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "cpp", 128, "if,else", "#include <iostream>\nusing namespace std;\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        cout << \"Positiv\";\n    } else {\n        cout << \"Negativ\";\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Description", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "cpp", 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Description", "Language", "LessonId", "Order", "Title" },
                values: new object[] { "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung.", "cpp", 129, 2, "Was ist C++?" });

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
                columns: new[] { "Description", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "cpp", 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt (Call by Value).", "Wert nach Funktion: 5", "#include <iostream>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 130, 2, "x = x * 2", "#include <iostream>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    std::cout << \"Wert nach Funktion: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Value", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine Referenz (`&`), um den Wert der Originalvariable in der Funktion `verdoppleRef` dauerhaft zu ändern.", "Geänderter Wert: 10", "#include <iostream>\n\n// Nutze & für Call by Reference\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 130, 3, "int&", "#include <iostream>\n\nvoid verdoppleRef(int& x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdoppleRef(zahl);\n    std::cout << \"Geänderter Wert: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Reference" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Wert über Pointer: 10", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "cpp", 130, 4, "int*,&zahl", "#include <iostream>\n\nvoid verdopplePtr(int* x) {\n    if (x != nullptr) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    std::cout << \"Wert über Pointer: \" << zahl << std::endl;\n    return 0;\n}\n", "Call by Pointer" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Fülle die Lücken mit der richtigen Syntax für Pointer und Referenzen.", "x=2, y=1", "#include <iostream>\n\nvoid swap(int__ a, int__ b) { // Nutze & für Referenzen\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=\" << x << \", y=\" << y;\n    return 0;\n}\n", "cpp", 130, 5, "int&", "#include <iostream>\n\nvoid swap(int& a, int& b) {\n    int temp = a;\n    a = b;\n    b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(x, y);\n    std::cout << \"x=2, y=1\";\n    return 0;\n}\n", "Lückentext: Syntax", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "Description", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "c", 131, 1, null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus.", "15", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 131, 2, "int,printf", "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}", "Ganzzahlen (int)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus.", "12.500000", "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}", "c", 131, 3, "float,printf", "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}", "Gleitkommazahlen (float)", 1 });

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
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    // Dein Code hier\n    return 0;\n}\n", "c", 132, 2, "if,else", "#include <stdio.h>\nint main() {\n    int zahl = -5;\n    if (zahl > 0) {\n        printf(\"Positiv\");\n    } else {\n        printf(\"Negativ\");\n    }\n    return 0;\n}\n", "Logik: Positiv/Negativ", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "c", 133, 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird.", "", "", "c", 133, 2, null, null, "Was ist C?", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1118,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Gib 'Hallo Welt!' aus.", "Hallo Welt!", "#include <stdio.h>\n\nint main() {\n    // Dein Code hier\n    return 0;\n}\n", "c", 133, 3, "printf", "#include <stdio.h>\n\nint main() {\n    printf(\"Hallo Welt!\\n\");\n    return 0;\n}\n", "Hallo Welt" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1119,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "", "", "c", 1, null, null, "Systemcalls und Buffering", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1120,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lies eine Ganzzahl mit `scanf` ein und gib sie aus.", "Zahl: 100", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    // scanf nutzt %d und den Adressoperator &\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", "c", 134, 2, "scanf,&zahl", "#include <stdio.h>\n\nint main() {\n    int zahl;\n    scanf(\"%d\", &zahl);\n    printf(\"Zahl: %d\", zahl);\n    return 0;\n}\n", "scanf: Ganzzahlen", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1121,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Bei `scanf` musst du immer die Adresse der Variable angeben. Welches Zeichen wird dafür benötigt?", "OK", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", __x); // Lücke füllen\n    printf(\"OK\");\n    return 0;\n}\n", "c", 134, 3, "&x", "#include <stdio.h>\n\nint main() {\n    int x;\n    scanf(\"%d\", &x);\n    printf(\"OK\");\n    return 0;\n}\n", "Lückentext: Adressoperator" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "c", 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1123,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt.", "Wert nach Funktion: 5", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    // Hier den Code einfügen\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "c", 135, 2, "x = x * 2", "#include <stdio.h>\n\nvoid verdopple(int x) {\n    x = x * 2;\n}\n\nint main() {\n    int zahl = 5;\n    verdopple(zahl);\n    printf(\"Wert nach Funktion: %d\", zahl);\n    return 0;\n}\n", "Call by Value in C", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1124,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern.", "Geänderter Wert: 10", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        // Ändere den Wert, auf den x zeigt\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    // Übergebe die Adresse von zahl mit &\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "c", 135, 3, "int *,*x,&zahl", "#include <stdio.h>\n\nvoid verdopplePtr(int *x) {\n    if (x != NULL) {\n        *x = *x * 2;\n    }\n}\n\nint main() {\n    int zahl = 5;\n    verdopplePtr(&zahl);\n    printf(\"Geänderter Wert: %d\", zahl);\n    return 0;\n}\n", "Call by Pointer in C" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1125,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen.", "x=2, y=1", "#include <stdio.h>\n\nvoid swap(int ____ a, int ____ b) {\n    int temp = ____ a;\n    ____ a = ____ b;\n    ____ b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=%d, y=%d\", x, y);\n    return 0;\n}\n", "c", 135, 4, "int *,* a,* b", "#include <stdio.h>\n\nvoid swap(int * a, int * b) {\n    int temp = * a;\n    * a = * b;\n    * b = temp;\n}\n\nint main() {\n    int x = 1, y = 2;\n    swap(&x, &y);\n    printf(\"x=2, y=1\");\n    return 0;\n}\n", "Lückentext: Pointer-Syntax", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "Description", "Language", "LessonId", "Order", "Title" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "python", 136, 1, "Speicherverwaltung von Variablen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "# Dein Code hier", "python", 136, 2, "print", "a = 10\nb = 5\nprint(a + b)", "Ganzzahlen (Integer)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus.", "12.5", "# Dein Code hier", "python", 136, 3, "print", "a = 2.5\nb = 5\nprint(a * b)", "Gleitkommazahlen (Float)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Strings können in Python mit dem + Operator verknüpft werden.", "Hallo Welt", "# Dein Code hier", "python", 136, 4, "print", "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen Boolean (True/False) in einer if-Anweisung.", "Wahr", "is_active = True\n# Dein Code", "python", 136, 5, "if,print", "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")", "Booleans (Wahrheitswerte)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "", "", "python", 137, 1, null, null, "Referenzsemantik und Speichersicherheit", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1132,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?", "5", "def verdopple(x):\n    # x lokal verdoppeln\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "python", 137, 2, "x = x * 2", "def verdopple(x):\n    x = x * 2\n\nzahl = 5\nverdopple(zahl)\nprint(zahl)\n", "Unveränderliche Typen (Integers)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1133,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden.", "Python", "def add_element(liste):\n    # Füge \"Python\" zur Liste hinzu\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "python", 137, 3, "append", "def add_element(liste):\n    liste.append(\"Python\")\n\nmeine_liste = []\nadd_element(meine_liste)\nprint(meine_liste[0])\n", "Veränderliche Typen (Listen)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1134,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "", "", "python", 138, 1, null, null, "Branch Prediction und Sprungtabellen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1135,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "zahl = -5\n# Dein Code hier\n", "python", 138, 2, "if,else", "zahl = -5\nif zahl > 0:\n    print(\"Positiv\")\nelse:\n    print(\"Negativ\")\n", "Logik: Positiv/Negativ" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1136,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben.", "1\n2\n3", "# Nutze for i in range(1, 4):\n", "python", 138, 3, "for,in,range", "for i in range(1, 4):\n    print(i)\n", "Zahlen von 1 bis 3 ausgeben" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1137,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden.", "", "", "python", 1, null, null, "Effizienz von Schleifen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1138,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "# Nutze range()\n", "python", 139, 2, "for,in,range", "for i in range(1, 6):\n    print(i)\n", "Zahlen 1 bis 5", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1139,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "summe = 0\ni = 1\n# Dein Code hier\n", "python", 139, 3, "while", "summe = 0\ni = 1\nwhile i < 5:\n    summe += i\n    i += 1\nprint(summe)\n", "Summe bis 10" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1140,
                columns: new[] { "Language", "LessonId" },
                values: new object[] { "python", 140 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1141,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Python ist eine interpretierte, höhere Programmiersprache, die für ihre einfache Lesbarkeit und Vielseitigkeit bekannt ist.", "python", 140, "Was ist Python?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1142,
                columns: new[] { "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution" },
                values: new object[] { "# Dein Code hier\n", "python", 140, "print", "print(\"Hallo Welt!\")\n" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1143,
                columns: new[] { "Language", "LessonId" },
                values: new object[] { "python", 141 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1144,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze `input()`, um einen Namen einzulesen und gib 'Hallo [Name]' aus. <br>Hinweis: Tippe deinen Namen in das Eingabefeld rechts unten.", "Hallo Python", "# Lese den Namen ein\nname = input()\nprint(\"Hallo \" + name)\n", "python", 141, "input", "name = input()\nprint(\"Hallo \" + name)\n", "input() Grundlagen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1145,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Eingaben von `input()` sind immer Strings. Wandle die Eingabe in ein `int` um, um damit zu rechnen.", "20", "# Lücke: zahl = ___(input())\nzahl = ___(input())\nprint(zahl * 2)\n", "python", 141, "int", "zahl = int(input())\nprint(zahl * 2)\n", "Lückentext: Typumwandlung" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1146,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Spring Boot 4 (erschienen Nov 2025) basiert auf Java 25 und Jakarta EE 11. Es bietet massive Performance-Vorteile durch AOT-Optimierung und native Unterstützung für virtuelle Threads.", "java", 142, "Was ist Spring Boot 4?" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1147,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Vervollständige die Hauptklasse mit der `@SpringBootApplication` Annotation und der `run` Methode.", "", "import org.springframework.boot.SpringApplication;\nimport org.springframework.boot.autoconfigure.SpringBootApplication;\n\n@____________________\npublic class MyBackend {\n    public static void main(String[] args) {\n        SpringApplication.______(MyBackend.class, args);\n    }\n}\n", "java", 142, "SpringBootApplication,run", "import org.springframework.boot.SpringApplication;\nimport org.springframework.boot.autoconfigure.SpringBootApplication;\n\n@SpringBootApplication\npublic class MyBackend {\n    public static void main(String[] args) {\n        SpringApplication.run(MyBackend.class, args);\n    }\n}\n", "Die Hauptklasse" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1148,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle einen einfachen REST-Controller, der bei einem GET-Aufruf auf '/hello' den Text 'Spring 4' zurückgibt.", "", "import org.springframework.web.bind.annotation.GetMapping;\nimport org.springframework.web.bind.annotation.RestController;\n\n@RestController\npublic class HelloController {\n    \n    @GetMapping(\"/hello\")\n    public String sayHello() {\n        return \"_______ _\";\n    }\n}\n", "java", 142, "RestController,GetMapping", "import org.springframework.web.bind.annotation.GetMapping;\nimport org.springframework.web.bind.annotation.RestController;\n\n@RestController\npublic class HelloController {\n    \n    @GetMapping(\"/hello\")\n    public String sayHello() {\n        return \"Spring 4\";\n    }\n}\n", "REST Controller" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1149,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird.", "", "", "java", 1, null, null, "Speicherverwaltung von Variablen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1150,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus.", "15", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 143, 2, "int,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}", "Ganzzahlen (int)", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1151,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus.", "12.5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 143, 3, "double,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}", "Gleitkommazahlen (double)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1152,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verknüpfe zwei String-Objekte und gib sie aus.", "Hallo Welt", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}", "java", 143, 4, "String,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}", "Zeichenketten (String)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1153,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Verwende einen boolean in einer if-Anweisung.", "Wahr", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}", "java", 143, 5, "boolean,if,System.out.println", "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}", "Booleans (boolean)" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1154,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt.", "", "", "java", 1, null, null, "Wie Programme funktionieren", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1155,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Schreibe 'Hallo Welt!' in Java.", "Hallo Welt!", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}", "java", 144, 2, "System.out.println", "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}", "Java: Hallo Welt", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1156,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus.", "Ja", "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}", "java", 144, 3, "if", null, "Java: If-Else" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1157,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[] { "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen.", "SUCCESS_ALL_TESTS_PASSED", "class Calculator {\n    // Deine Methode hier\n}", "java", 144, 4, "static,int", "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}", "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}", "Java: Taschenrechner", 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1158,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern.", "java", 145, "Referenzsemantik und Speichersicherheit" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1159,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Versuche den Wert von `x` in der Methode `verdopple` zu ändern. Bleibt das Original in `main` gleich?", "5", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "java", 145, "x = x * 2", "public class Main {\n    public static void verdopple(int x) {\n        x = x * 2;\n    }\n    public static void main(String[] args) {\n        int zahl = 5;\n        verdopple(zahl);\n        System.out.print(zahl);\n    }\n}\n", "Primitive: Pass by Value" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1160,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "In Java werden Objektreferenzen per Wert übergeben. Du kannst das Objekt verändern, aber nicht die Referenz selbst.", "Java", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        // Füge ein Element hinzu\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "java", 145, "list.add", "import java.util.ArrayList;\nimport java.util.List;\n\npublic class Main {\n    public static void addElement(List<String> list) {\n        list.add(\"Java\");\n    }\n    public static void main(String[] args) {\n        List<String> list = new ArrayList<>();\n        addElement(list);\n        System.out.print(list.get(0));\n    }\n}\n", "Objekte: Referenz ändern" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1161,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren.", "java", 146, "Systemcalls und Buffering" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1162,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze die `Scanner`-Klasse, um einen Namen einzulesen.", "Hallo Java", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        // Erstelle einen Scanner\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", "java", 146, "Scanner,System.in", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        String name = sc.next();\n        System.out.print(\"Hallo \" + name);\n    }\n}\n", "Scanner: Einlesen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1163,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Welche Methode des Scanners liest die nächste Ganzzahl ein?", "42", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        // Lücke: int x = sc.____();\n        int x = sc.____();\n        System.out.print(x);\n    }\n}\n", "java", 146, "nextInt", "import java.util.Scanner;\n\npublic class Main {\n    public static void main(String[] args) {\n        Scanner sc = new Scanner(System.in);\n        int x = sc.nextInt();\n        System.out.print(x);\n    }\n}\n", "Lückentext: Nächste Zahl" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1164,
                columns: new[] { "Description", "Language", "LessonId", "Title" },
                values: new object[] { "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen.", "java", 147, "Branch Prediction und Sprungtabellen" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1165,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus.", "Negativ", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        // Dein Code hier\n    }\n}\n", "java", 147, "if,else", "public class Program {\n    public static void main(String[] args) {\n        int zahl = -5;\n        if (zahl > 0) {\n            System.out.print(\"Positiv\");\n        } else {\n            System.out.print(\"Negativ\");\n        }\n    }\n}\n", "Logik: Positiv/Negativ", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1166,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden.", "", "", "java", 1, null, null, "Effizienz von Schleifen", 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1167,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title", "Type" },
                values: new object[] { "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben.", "1\n2\n3\n4\n5", "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}\n", "java", 148, 2, "for", "public class Program {\n    public static void main(String[] args) {\n        for (int i = 1; i <= 5; i++) {\n            System.out.println(i);\n        }\n    }\n}\n", "Zahlen 1 bis 5", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1168,
                columns: new[] { "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "RequiredKeywords", "Solution", "Title" },
                values: new object[] { "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist.", "10", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        // Dein Code hier\n    }\n}\n", "java", 148, 3, "while", "public class Program {\n    public static void main(String[] args) {\n        int summe = 0;\n        int i = 1;\n        while (i < 5) {\n            summe += i;\n            i++;\n        }\n        System.out.print(summe);\n    }\n}\n", "Summe bis 10" });
        }
    }
}

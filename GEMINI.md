# CodeKurs.Web - Projekt-Mandate

Dieses Dokument bietet grundlegenden Kontext und Mandate für das Projekt **CodeKurs.Web**, eine interaktive Programmierplattform, die mit ASP.NET Core 10.0 MVC erstellt wurde.

## Projektübersicht
CodeKurs.Web ist eine Webanwendung für interaktive Programmierkurse. Sie ermöglicht es Benutzern, Theorie zu lesen, Programmieraufgaben direkt im Browser zu lösen (unter Verwendung des Monaco Editors) und ihren Fortschritt zu verfolgen.

## Tech-Stack
- **Backend:** C# / ASP.NET Core 10.0 MVC, Entity Framework Core mit SQLite.
- **Content Parsing:** `Markdig` (Markdown zu HTML), `YamlDotNet` (YAML Frontmatter).
- **Code-Ausführung:** `Microsoft.CodeAnalysis.CSharp.Scripting` (Roslyn) für C#, und externe Prozessausführung für Java (`javac`/`java`) und JavaScript (`node`).
- **Frontend:** Bootstrap 5, Monaco Editor, jQuery (für Aufgabenübermittlung und Validierung).

## Architektonische Kernmuster
- **Datenbank-Seeding:** Lektionen und Programmieraufgaben werden primär über Markdown-Dateien im Verzeichnis `lernen/` verwaltet. Beim Anwendungsstart (konfiguriert in `Program.cs` und `ApplicationDbContext.cs`) werden diese Dateien analysiert und ihr Inhalt in die SQLite-Datenbank eingepflegt.
- **Code Execution Service:** Der `CodeExecutorService` ist die zentrale Komponente zum Ausführen und Validieren von benutzerdefiniertem Code über verschiedene Programmiersprachen hinweg.
- **Aufgabenvalidierung:** Aufgaben können validiert werden über:
    - `OutputComparison`: Abgleich der Benutzerausgabe mit einer erwarteten Zeichenfolge.
    - `KeywordCheck`: Überprüfung, ob bestimmte Schlüsselwörter (z. B. `while`, `int`) im Code vorhanden sind.
    - `Edu`: Ausführen des Codes des Benutzers gegen versteckten Testcode (z. B. Aufruf einer bestimmten Methode und Überprüfung ihres Rückgabewerts).

## Kern-Workflows
1.  **Inhaltsaktualisierungen:** Um Kursinhalte hinzuzufügen oder zu ändern, bearbeiten Sie die `.md`-Dateien in `lernen/<sprache>/`. Das YAML-Frontmatter muss Metadaten wie `id`, `title`, `order` und `tasks` enthalten.
2.  **Sprachen hinzufügen:** Um eine neue Sprache zu unterstützen, aktualisieren Sie `CodeExecutorService.cs` mit der entsprechenden Ausführungslogik und stellen Sie sicher, dass die erforderliche Laufzeitumgebung (z. B. `python`, `go`) verfügbar ist.
3.  **Datenbank-Migrationen:** Verwenden Sie Standard-EF-Core-Migrationsbefehle (`dotnet ef migrations add`, `dotnet ef database update`).

## Coding-Standards & Richtlinien
- **Async/Await:** Verwenden Sie asynchrone Muster für alle E/A- und Datenbankoperationen.
- **Dependency Injection:** Registrieren Sie alle Dienste in `Program.cs` und injizieren Sie diese über Konstruktoren.
- **Views:** Halten Sie Razor-Views schlank; delegieren Sie komplexe Logik an Controller oder ViewModels.
- **Markdown-Inhalt:** Behalten Sie streng formatierte YAML-Frontmatter in den Dateien unter `lernen/` bei, um ein erfolgreiches Datenbank-Seeding zu gewährleisten.

## Gemini CLI-Mandate
- **Verifizieren Sie immer die Markdown-Seeding-Logik**, wenn Sie `ApplicationDbContext`- oder `ProgrammingTask`-Modelle ändern, da der Inhalt entscheidend für die Funktionalität der Anwendung ist.
- **Wenn Sie Funktionen zum Code-Editor hinzufügen**, stellen Sie die Kompatibilität mit der Monaco-Editor-Integration in `Views/Home/Index.cshtml` sicher.
- **Priorisieren Sie die Sicherheit** in `CodeExecutorService.cs`, da dieser beliebigen Benutzercode ausführt (stellen Sie sicher, dass Prozesse ressourcenbeschränkt oder nach Möglichkeit sandboxed sind).

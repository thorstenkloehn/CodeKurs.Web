# CodeKurs.Web - Projektkontext

## Projektübersicht
CodeKurs.Web ist eine pädagogische ASP.NET Core MVC-Anwendung, die zum Lehren von Programmierung (C#, Java, JavaScript) entwickelt wurde. Sie bietet interaktive Lektionen, Programmieraufgaben und Echtzeit-Codeausführung mit Feedback.

## Technologie-Stack
- **Framework:** ASP.NET Core 10.0 (MVC)
- **Datenbank:** SQLite mit Entity Framework Core
- **Code-Ausführung:**
  - **C#:** In-Memory-Kompilierung mit Roslyn (`Microsoft.CodeAnalysis.CSharp`).
  - **Java/JavaScript:** Ausführung externer Prozesse mit `javac` und `node`.
- **Frontend:**
  - Razor Views (Bootstrap-basiert)
  - Monaco Editor für die Code-Eingabe.
  - Vanilla JavaScript für Editor-Interaktionen.

## Kern-Modelle
- **Lesson:** Repräsentiert ein Lernmodul (z. B. „C# Einführung“).
- **ProgrammingTask:** Eine einzelne Übung innerhalb einer Lektion.
  - **TaskType:**
    - `Theory`: Nur Textinhalt.
    - `Programming`: Erfordert Code, der einer bestimmten `ExpectedOutput` entspricht.
    - `Edu`: Erfordert Code, der einen versteckten `TestCode` (Unit-Tests) besteht.
    - `MultipleChoice`: Quizbasierte Aufgaben.

## Wichtige Dienste
- **CodeExecutorService:** Verarbeitet die Kompilierungs- und Ausführungslogik für verschiedene Sprachen.

## Projektstruktur
- `Controllers/`: Standard-MVC-Controller (Admin, Dashboard, Home).
- `Models/`: Daten- und ViewModels.
- `Views/`: Razor-Views für die Benutzeroberfläche.
- `Data/`: DB-Kontext und Front Matter + Markdown.
- `Services/`: Geschäftslogik, insbesondere Code-Ausführung.
- `wwwroot/`: Statische Assets, einschließlich der Monaco-Editor-Konfiguration.

## Entwicklungsrichtlinien
- **Datenbankmigrationen:** Verwenden Sie `dotnet ef migrations add <Name>` und `dotnet ef database update`, um Schemaänderungen zu verwalten.
- **Front Matter + Markdown:** Aktualisieren Sie Verzeichniss `lernen`, um Standardlektionen und -aufgaben hinzuzufügen oder zu ändern.
- **Testcode:** Stellen Sie bei `Edu`-Aufgaben sicher, dass der `TestCode` eine `Main`-Methode enthält, die bei Erfolg `SUCCESS_ALL_TESTS_PASSED` ausgibt.
- **Styling:** Befolgen Sie die standardmäßigen ASP.NET Core MVC-Konventionen. Verwenden Sie Bootstrap für das Styling.
- **Fehlerbehandlung:** Kompilierungsfehler sollten `EditorError`-Objekten zugeordnet werden, um im Monaco-Editor angezeigt zu werden.

## Gemeinsame Workflows
- **Hinzufügen einer neuen Aufgabe:** Fügen Sie die Aufgabe zur Front Matter + Markdown des `lernen` hinzu und definieren Sie `InitialCode`, `ExpectedOutput` (oder `TestCode`) sowie `RequiredKeywords`.
- **Anpassen der Benutzeroberfläche:** Bearbeiten Sie die entsprechende `.cshtml`-Datei in `Views/`. Die Editor-Logik befindet sich hauptsächlich in `wwwroot/js/site.js`.


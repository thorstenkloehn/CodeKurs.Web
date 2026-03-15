# CodeKurs - Projekt-Mandate

Dieses Dokument beschreibt die Architektur von **CodeKurs**, einer nativen Visual Studio Code Erweiterung für interaktive Programmierkurse.

## Projektübersicht
CodeKurs integriert Theorie und Praxis direkt in VS Code. Nutzer navigieren durch Lektionen in einer Sidebar, lesen Theorie in Webviews und lösen Programmieraufgaben in echten Editor-Tabs.

## Tech-Stack (Extension)
- **Runtime:** Node.js / VS Code Extension API.
- **Sprache:** TypeScript.
- **Content:** Markdown-Dateien mit YAML-Frontmatter im Verzeichnis `lernen/`.
- **Parsing:** `marked` für Markdown-zu-HTML, `js-yaml` für Metadaten.
- **Execution:** Lokale Prozesssteuerung via `child_process` zur Validierung von Code (gcc, python, node, etc.).

## Architektonische Kernmuster
- **Markdown-Driven:** Die Kursinhalte liegen in `lernen/`. Der `contentParser.ts` liest diese dynamisch ein.
- **Webview Provider:** Theorie wird über ein `WebviewPanel` gerendert, das VS Code Themes (Dark/Light) respektiert.
- **Tree Data Provider:** Die Kursstruktur wird über einen `TreeDataProvider` in der `codekurs-explorer` Sidebar dargestellt.
- **Native Execution:** Code wird nicht in einem Simulator, sondern über die auf dem System installierten Compiler des Nutzers validiert.

## Kern-Workflows
1. **Inhalt bearbeiten:** Änderungen in `lernen/` werden beim nächsten Start der Erweiterung (oder Refresh) sofort übernommen.
2. **Aufgabenprüfung:** Der Befehl `codekurs.checkCode` liest den aktiven Editor aus, führt den Code lokal aus und gleicht den Output ab.
3. **Entwicklung:** Testen der Erweiterung via `F5` im Extension Development Host.

## Coding-Standards
- **TypeScript Strict Mode:** Alle neuen Komponenten müssen strikt typisiert sein.
- **Asynchronität:** Dateisystem- und Prozessoperationen müssen `async/await` nutzen.
- **VS Code API:** Nutze bevorzugt native VS Code UI-Elemente (Notifications, ProgressBars) für Feedback.


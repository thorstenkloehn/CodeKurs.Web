# CodeKurs.Web - Interaktive Programmier-Lernplattform

> [!WARNING]
> **PROTOTYP:** Dies ist eine reine Testumgebung und kein Produktivserver. Die Anwendung dient dem Testen von CodeKurs.Web in einer kontrollierten Umgebung.

CodeKurs.Web ist eine webbasierte Lernplattform, die es ermöglicht, Programmiersprachen direkt im Browser zu erlernen. Mit einem integrierten Monaco-Editor und automatisierter Code-Validierung bietet sie ein interaktives Lernerlebnis.

## 🚀 Projektstatus & Umgebung

Dieses Projekt ist für die **lokale Ausführung** konzipiert. Es dient als Prototyp für eine Lernumgebung, bei der die Code-Ausführung und Validierung auf dem lokalen Rechner des Nutzers stattfindet.

## 🛠 Features

- **Interaktiver Monaco Editor:** Bekannt aus VS Code, direkt im Browser.
- **Lernmodule:** Theorie, Quizfragen und Programmieraufgaben.
- **Code-Ausführung:** Lokale Ausführung und Validierung von Benutzercode.
- **Fortschrittsanzeige:** Speicherung des Lernfortschritts in einer lokalen SQLite-Datenbank.

## 📋 Voraussetzungen

Bevor Sie das Projekt starten, stellen Sie sicher, dass folgende Software installiert ist:

- [.NET SDK 10.0](https://dotnet.microsoft.com/download)
- [Node.js & npm](https://nodejs.org/) (Nur einmalig für `npm install` benötigt)

### Lokale Compiler (WICHTIG für Übungen)

Damit die Übungen in den verschiedenen Sprachen (C, C++, Java, Python, etc.) lokal ausgeführt werden können, müssen die jeweiligen Compiler auf Ihrem Rechner installiert und im System-Pfad (`PATH`) erreichbar sein.

Nutzen Sie die **Diagnose-Seite** in der Anwendung (`/Home/Diagnostics`), um zu prüfen, welche Sprachen auf Ihrem System bereits unterstützt werden.

## 🔧 Installation & Setup

Befolgen Sie diese Schritte, um die Anwendung lokal ohne Docker auszuführen:

1. **Repository klonen oder herunterladen:**
   ```bash
   cd CodeKurs.Web
   ```

2. **Frontend-Abhängigkeiten installieren:**
   (Nur nötig, falls `wwwroot/lib/monaco-editor` noch nicht existiert)
   ```bash
   npm install
   ```

3. **Anwendung starten:**
   ```bash
   dotnet run
   ```

4. **Browser öffnen:**
   Navigieren Sie zur im Terminal angezeigten URL (meist `https://localhost:7xxx` oder `http://localhost:5xxx`).

## 🏗 Technischer Stack

- **Backend:** ASP.NET Core 10.0 MVC
- **Datenbank:** SQLite (Lokal, Datei: `codekurs.db`)
- **Code Execution:** Lokale Prozesse (kein Docker-Sandboxing für maximale Performance im Offline-Modus)

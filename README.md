# CodeKurs.Web - Interaktive Programmier-Lernplattform

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

- [.NET SDK 8.0](https://dotnet.microsoft.com/download) (oder höher)
- [Node.js & npm](https://nodejs.org/) (für die Verwaltung der Frontend-Bibliotheken)

## 🔧 Installation & Setup

Befolgen Sie diese Schritte, um die Anwendung lokal auszuführen:

1. **Repository klonen oder herunterladen:**
   ```bash
   git clone <repository-url>
   cd codekurs/src/CodeKurs.Web
   ```

2. **Frontend-Abhängigkeiten installieren:**
   Dies lädt den Monaco-Editor und andere benötigte Pakete herunter.
   ```bash
   npm install
   ```

3. **.NET Abhängigkeiten wiederherstellen:**
   ```bash
   dotnet restore
   ```

4. **Datenbank initialisieren (optional):**
   Die SQLite-Datenbank `codekurs.db` wird beim ersten Start automatisch erstellt, falls sie noch nicht existiert.

5. **Anwendung starten:**
   ```bash
   dotnet run
   ```

6. **Browser öffnen:**
   Navigieren Sie zu `https://localhost:5001` oder `http://localhost:5000` (die genauen URLs werden im Terminal angezeigt).

## 🏗 Technischer Stack

- **Backend:** ASP.NET Core MVC
- **Datenbank:** SQLite3 (Entity Framework Core)
- **Frontend:** Bootstrap 5, Monaco Editor
- **Sprachen:** C#, HTML, CSS, JavaScript

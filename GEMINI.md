# Webbasierte Lernplattform für Programmiersprachen

## 1. Projektübersicht
Eine interaktive Plattform zum Erlernen von Programmiersprachen mit direktem Feedback im Browser.

## Kursstruktur
* Lektionen – Die wichtigsten Lernbausteine, die Aufgaben nach Themen gruppieren
* Aufgaben – Die kleinsten Lerneinheiten.
* Theorie – theoretisches Lernmaterial.
* Multiple-Choice-Test – Quiz mit Einzel- oder Mehrfachauswahl.
* Edu – eine Programmierübung, deren Ergebnisse durch Tests validiert wurden.
* Output – eine Programmierübung, deren Ergebnisse durch den Output validiert werden.-+-+-+-+-+
* Konfigurationsdateien
* 

## 2. Kernfunktionen
- **Kurserstellung:** Start eines neuen Kursprojekts.
- **Übungsentwicklung:** Schreiben des Codes, der als Basis für die Übungen dient.
- **Platzhalter:** Hinzufügen von interaktiven Platzhaltern, die die Lernenden ausfüllen müssen.
- **Beschreibungen:** Bereitstellung von Kontext und Anweisungen mittels HTML oder Markdown.
- **Automatisiertes Testen:** Erstellung benutzerdefinierter Tests zur automatischen Überprüfung der Lösungen.
- **Interaktiver Editor:** Integration von Monaco Editor oder CodeMirror mit Unterstützung für Platzhalter ("Answer Placeholders"), die von Schülern ausgefüllt werden müssen.
- **Lernmodule:** Strukturierte Lektionen mit verschiedenen Aufgaben-Typen: Theorie-Lektionen, Quizfragen (Multiple Choice) und Programmieraufgaben.
- **Code-Ausführung & Validierung:** Ausführung von Benutzercode auf dem Server inklusive automatisierter Tests zur sofortigen Korrektur und Rückmeldung.
- **Fortschrittsanzeige:** Dashboard für abgeschlossene Lektionen und Quizzes.
- **Aufgabenformatierung:** Technischer Leitfaden zur Verbesserung von Aufgabenbeschreibungen unter Nutzung von HTML, Markdown, Code-Snippets, Hinweisen (Hints), Links und Bildern.
## 3. Technischer Stack (Vorschlag)
- **Frontend:** Bootstrap 5, Monaco Editor install npm herunterladen
- **Backend:** ASP.NET Core MVC.
- **Datenbank:** SQLite3 für Lernfortschritte.
- **Infrastruktur:** Code-Laufzeiten auf lokalem Rechner testen.
### Struktur und Funktionsweise
#### 1. Code-Synchronisation
- Der Kursersteller nutzt die Funktion **"Sync Files with Next Tasks"** 
- Dies propagiert Code-Änderungen an alle nachfolgenden Aufgaben, um sicherzustellen, dass die Startpunkte konsistent sind.

#### 2. Platzhalter-Abhängigkeiten (Placeholder Dependencies)
Um den vom Lernenden geschriebenen Code von einer Aufgabe in die nächste zu übernehmen, werden Abhängigkeiten definiert:
- **Format**: `<Lektionsname>#<Aufgabenname>#<Dateipfad>#<Dateiname>#<Platzhalternummer>`
- Dies bewirkt, dass der Inhalt eines Platzhalters automatisch in den entsprechenden Platzhalter der Folgeaufgabe kopiert wird.

---

### Konfigurationsschritte für Ersteller
1. **Aufgaben erstellen**: Definieren von `task.html`/`task.md` für Beschreibungen sowie Exercise- und Test-Dateien.
2. **Antwort-Platzhalter hinzufügen**: Über das Kontextmenü ("Add Answer Placeholder") Stellen im Code markieren, die vom Lernenden gelöst werden müssen.
3. **Tests schreiben**: Jede Aufgabe benötigt spezifische Tests, die den Fortschritt in diesem Schritt validieren.
4. **Synchronisation prüfen**: Regelmäßiges Abgleichen der Dateien, um sicherzustellen, dass spätere Aufgaben die Lösungen der früheren enthalten (sofern gewünscht).
## 4. Nächste Schritte
1. Anforderungsanalyse und Wireframing.
2. Setup des Repositories (Monorepo-Struktur).
3. Implementierung des Editors und einer einfachen Code-Validierung.

## eigene Kurse erstellen
* Editor für Lektion,Task,Test,zu schreiben
* Import yaml
* Export yaml


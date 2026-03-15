---
title: "Python: Benutzereingaben"
description: "Lerne, wie du Daten von der Konsole einliest."
order: 5
language: "python"
tasks:
  - title: "Systemcalls und Buffering"
    type: "Theory"
    order: 1
    description: "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren."
  - title: "input() Grundlagen"
    type: "Programming"
    order: 2
    description: "Nutze `input()`, um einen Namen einzulesen und gib 'Hallo [Name]' aus. <br>Hinweis: Tippe deinen Namen in das Eingabefeld rechts unten."
    initialCode: |
      # Lese den Namen ein
      name = input()
      print("Hallo " + name)
    expectedOutput: "Hallo Python"
    solution: |
      name = input()
      print("Hallo " + name)
    requiredKeywords: "input"
  - title: "Lückentext: Typumwandlung"
    type: "Programming"
    order: 3
    description: "Eingaben von `input()` sind immer Strings. Wandle die Eingabe in ein `int` um, um damit zu rechnen."
    initialCode: |
      # Lücke: zahl = ___(input())
      zahl = ___(input())
      print(zahl * 2)
    expectedOutput: "20"
    solution: |
      zahl = int(input())
      print(zahl * 2)
    requiredKeywords: "int"
---
In Python nutzt du die Funktion **`input()`**, um Daten vom Benutzer zu erhalten.

1. **Standard**: `input()` gibt immer einen String zurück.
2. **Konvertierung**: Wenn du mit Zahlen rechnen möchtest, musst du das Ergebnis explizit umwandeln (z.B. `int(input())` oder `float(input())`).

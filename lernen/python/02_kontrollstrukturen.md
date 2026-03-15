---
title: "Python: Kontrollstrukturen"
description: "Lerne, wie du den Programmfluss steuerst."
order: 2
language: "python"
tasks:
  - title: "Branch Prediction und Sprungtabellen"
    type: "Theory"
    order: 1
    description: "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen."
  - title: "Logik: Positiv/Negativ"
    type: "Programming"
    order: 2
    description: "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus."
    initialCode: |
      zahl = -5
      # Dein Code hier
    expectedOutput: "Negativ"
    solution: |
      zahl = -5
      if zahl > 0:
          print("Positiv")
      else:
          print("Negativ")
    requiredKeywords: "if,else"
  - title: "Zahlen von 1 bis 3 ausgeben"
    type: "Programming"
    order: 3
    description: "Nutze eine `for`-Schleife und die `range()` Funktion, um die Zahlen 1, 2 und 3 auszugeben."
    initialCode: |
      # Nutze for i in range(1, 4):
    expectedOutput: "1\n2\n3"
    solution: |
      for i in range(1, 4):
          print(i)
    requiredKeywords: "for,in,range"
---
Python nutzt Einrückungen, um Code-Blöcke zu definieren. Es gibt keine geschweiften Klammern `{}` wie in C# oder Java.

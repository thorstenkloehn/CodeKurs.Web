---
title: "Python: Schleifen"
description: "Lerne, wie du Code-Blöcke wiederholst."
order: 3
language: "python"
tasks:
  - title: "Effizienz von Schleifen"
    type: "Theory"
    order: 1
    description: "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden."
  - title: "Zahlen 1 bis 5"
    type: "Programming"
    order: 2
    description: "Nutze eine `for`-Schleife und `range()`, um die Zahlen 1, 2, 3, 4 und 5 auszugeben."
    initialCode: |
      # Nutze range()
    expectedOutput: "1\n2\n3\n4\n5"
    solution: |
      for i in range(1, 6):
          print(i)
    requiredKeywords: "for,in,range"
  - title: "Summe bis 10"
    type: "Programming"
    order: 3
    description: "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist."
    initialCode: |
      summe = 0
      i = 1
      # Dein Code hier
    expectedOutput: "10"
    solution: |
      summe = 0
      i = 1
      while i < 5:
          summe += i
          i += 1
      print(summe)
    requiredKeywords: "while"
---
Schleifen erlauben es uns, Aktionen mehrfach auszuführen. Python bietet `for` für bekannte Iterationen und `while` für bedingte Wiederholungen.

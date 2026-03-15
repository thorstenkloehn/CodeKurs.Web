---
title: "Schleifen"
description: "Wiederhole Aufgaben effizient."
order: 3
language: "csharp"
tasks:
  - title: "Effizienz von Schleifen"
    type: "Theory"
    order: 1
    description: "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden."
  - title: "For-Schleife: Summe"
    type: "Programming"
    order: 2
    description: "Berechne die Summe der Zahlen 1 bis 5."
    initialCode: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\tint summe = 0;\n\t\t// Nutze eine for-Schleife\n\t\tConsole.WriteLine(summe);\n\t}\n}"
    expectedOutput: "15"
    requiredKeywords: "for"
---
Schleifen helfen dir, Aufgaben mehrfach auszuführen.

---
title: "Kontrollstrukturen"
description: "Lerne Entscheidungen im Code zu treffen."
order: 2
language: "csharp"
tasks:
  - title: "Branch Prediction und Sprungtabellen"
    type: "Theory"
    order: 1
    description: "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen."
  - title: "Logik: Positiv/Negativ"
    type: "Programming"
    order: 2
    description: "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus."
    initialCode: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\tint zahl = -5;\n\t\t// Dein Code hier\n\t}\n}"
    expectedOutput: "Negativ"
    requiredKeywords: "if,else"
---
In dieser Lektion lernst du `if` und `else` kennen.

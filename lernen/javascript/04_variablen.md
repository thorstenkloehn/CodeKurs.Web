---
title: "Variablen in JavaScript"
description: "Lerne, wie du mit verschiedenen Datentypen in JavaScript arbeitest."
order: 4
language: "javascript"
tasks:
  - title: "Speicherverwaltung von Variablen"
    type: "Theory"
    order: 1
    description: "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird."
  - title: "Ganzzahlen (Number)"
    type: "Programming"
    order: 2
    description: "In JavaScript gibt es den Typ 'number' für alle Zahlen. Erstelle eine Variable mit let, addiere zwei Zahlen und gib das Ergebnis aus."
    initialCode: "// Dein Code hier"
    expectedOutput: "15"
    solution: "let a = 10;\nlet b = 5;\nconsole.log(a + b);"
    requiredKeywords: "let,console.log"
  - title: "Gleitkommazahlen (Number)"
    type: "Programming"
    order: 3
    description: "Auch Gleitkommazahlen sind in JavaScript vom Typ 'number'. Multipliziere zwei Zahlen und gib das Ergebnis aus."
    initialCode: "// Dein Code hier"
    expectedOutput: "12.5"
    solution: "let a = 2.5;\nlet b = 5;\nconsole.log(a * b);"
    requiredKeywords: "console.log"
  - title: "Zeichenketten (String Interpotalion)"
    type: "Programming"
    order: 4
    description: "Verwende String Interpolation (Backticks ``), um zwei Variablen in einem String auszugeben."
    initialCode: "const s1 = \"Hallo\";\nconst s2 = \"Welt\";\n// Dein Code hier"
    expectedOutput: "Hallo Welt"
    solution: "const s1 = \"Hallo\";\nconst s2 = \"Welt\";\nconsole.log(`${s1} ${s2}`);"
    requiredKeywords: "console.log,$,{"
  - title: "Booleans (Wahrheitswerte)"
    type: "Programming"
    order: 5
    description: "Verwende einen boolean in einer if-Anweisung."
    initialCode: "let isActive = true;\n// Dein Code hier"
    expectedOutput: "Wahr"
    solution: "let isActive = true;\nif (isActive) {\n    console.log(\"Wahr\");\n} else {\n    console.log(\"Falsch\");\n}"
    requiredKeywords: "if,console.log"
---
In JavaScript deklarierst du Variablen heutzutage meist mit `let` oder `const`.

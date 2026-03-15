---
title: "Variablen in Go"
description: "Lerne, wie du mit verschiedenen Datentypen in Go arbeitest."
order: 3
language: "go"
tasks:
  - title: "Speicherverwaltung von Variablen"
    type: "Theory"
    order: 1
    description: "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird."
  - title: "Ganzzahlen (int)"
    type: "Programming"
    order: 2
    description: "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus."
    initialCode: "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}"
    expectedOutput: "15"
    solution: "package main\n\nimport \"fmt\"\n\nfunc main() {\n    var a int = 10\n    b := 5\n    fmt.Println(a + b)\n}"
    requiredKeywords: "fmt.Println"
  - title: "Gleitkommazahlen (float64)"
    type: "Programming"
    order: 3
    description: "Erstelle eine float64-Variable, multipliziere sie und gib das Ergebnis aus."
    initialCode: "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}"
    expectedOutput: "12.5"
    solution: "package main\n\nimport \"fmt\"\n\nfunc main() {\n    a := 2.5\n    b := 5.0\n    fmt.Println(a * b)\n}"
    requiredKeywords: "fmt.Println"
  - title: "Zeichenketten (string)"
    type: "Programming"
    order: 4
    description: "Verknüpfe zwei Strings in Go."
    initialCode: "package main\n\nimport \"fmt\"\n\nfunc main() {\n    // Dein Code\n}"
    expectedOutput: "Hallo Welt"
    solution: "package main\n\nimport \"fmt\"\n\nfunc main() {\n    s1 := \"Hallo \"\n    s2 := \"Welt\"\n    fmt.Println(s1 + s2)\n}"
    requiredKeywords: "fmt.Println"
  - title: "Booleans (bool)"
    type: "Programming"
    order: 5
    description: "Verwende einen bool in einer if-Anweisung."
    initialCode: "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    // Dein Code\n}"
    expectedOutput: "Wahr"
    solution: "package main\n\nimport \"fmt\"\n\nfunc main() {\n    isActive := true\n    if isActive {\n        fmt.Println(\"Wahr\")\n    } else {\n        fmt.Println(\"Falsch\")\n    }\n}"
    requiredKeywords: "if,fmt.Println"
---
In Go kannst du Variablen mit `var` oder der Kurzschreibweise `:=` deklarieren.

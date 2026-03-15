---
title: "Variablen in Python"
description: "Lerne, wie du mit verschiedenen Datentypen in Python arbeitest."
order: 4
language: "python"
tasks:
  - title: "Speicherverwaltung von Variablen"
    type: "Theory"
    order: 1
    description: "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird."
  - title: "Ganzzahlen (Integer)"
    type: "Programming"
    order: 2
    description: "In Python werden Ganzzahlen einfach zugewiesen. Erstelle eine Variable, addiere zwei Zahlen und gib das Ergebnis aus."
    initialCode: "# Dein Code hier"
    expectedOutput: "15"
    solution: "a = 10\nb = 5\nprint(a + b)"
    requiredKeywords: "print"
  - title: "Gleitkommazahlen (Float)"
    type: "Programming"
    order: 3
    description: "Gleitkommazahlen werden in Python automatisch als Float erkannt. Multipliziere zwei Zahlen und gib das Ergebnis aus."
    initialCode: "# Dein Code hier"
    expectedOutput: "12.5"
    solution: "a = 2.5\nb = 5\nprint(a * b)"
    requiredKeywords: "print"
  - title: "Zeichenketten (String)"
    type: "Programming"
    order: 4
    description: "Strings können in Python mit dem + Operator verknüpft werden."
    initialCode: "# Dein Code hier"
    expectedOutput: "Hallo Welt"
    solution: "s1 = \"Hallo \"\ns2 = \"Welt\"\nprint(s1 + s2)"
    requiredKeywords: "print"
  - title: "Booleans (Wahrheitswerte)"
    type: "Programming"
    order: 5
    description: "Verwende einen Boolean (True/False) in einer if-Anweisung."
    initialCode: "is_active = True\n# Dein Code"
    expectedOutput: "Wahr"
    solution: "is_active = True\nif is_active:\n    print(\"Wahr\")\nelse:\n    print(\"Falsch\")"
    requiredKeywords: "if,print"
---
In Python sind Variablen dynamisch typisiert, das bedeutet, du musst den Datentyp nicht explizit angeben.

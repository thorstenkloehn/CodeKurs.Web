---
title: "Variablen in C#"
description: "Lerne, wie du mit verschiedenen Datentypen in C# arbeitest."
order: 5
language: "csharp"
tasks:
  - title: "Speicherverwaltung von Variablen"
    type: "Theory"
    order: 1
    description: "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird."
  - title: "Ganzzahlen (Integer)"
    type: "Programming"
    order: 2
    description: "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus."
    initialCode: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\t// Dein Code\n\t}\n}"
    expectedOutput: "15"
    solution: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\tint a = 10;\n\t\tint b = 5;\n\t\tConsole.WriteLine(a + b);\n\t}\n}"
    requiredKeywords: "int,Console.WriteLine"
  - title: "Gleitkommazahlen (Double)"
    type: "Programming"
    order: 3
    description: "Erstelle eine double-Variable, multipliziere sie mit einer anderen Zahl und gib das Ergebnis aus."
    initialCode: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\t// Dein Code\n\t}\n}"
    expectedOutput: "12.5"
    solution: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\tdouble a = 2.5;\n\t\tdouble b = 5.0;\n\t\tConsole.WriteLine(a * b);\n\t}\n}"
    requiredKeywords: "double,Console.WriteLine"
  - title: "Zeichenketten (String)"
    type: "Programming"
    order: 4
    description: "Verknüpfe zwei Strings und gib sie aus."
    initialCode: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\t// Dein Code\n\t}\n}"
    expectedOutput: "Hallo Welt"
    solution: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\tstring s1 = \"Hallo \";\n\t\tstring s2 = \"Welt\";\n\t\tConsole.WriteLine(s1 + s2);\n\t}\n}"
    requiredKeywords: "string,Console.WriteLine"
  - title: "Booleans (Wahrheitswerte)"
    type: "Programming"
    order: 5
    description: "Verwende eine bool-Variable in einer if-Anweisung, um 'Wahr' auszugeben, wenn sie true ist, sonst 'Falsch'."
    initialCode: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\tbool isActive = true;\n\t\t// Dein Code\n\t}\n}"
    expectedOutput: "Wahr"
    solution: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\tbool isActive = true;\n\t\tif (isActive)\n\t\t{\n\t\t\tConsole.WriteLine(\"Wahr\");\n\t\t}\n\t\telse\n\t\t{\n\t\t\tConsole.WriteLine(\"Falsch\");\n\t\t}\n\t}\n}"
    requiredKeywords: "bool,if,Console.WriteLine"
---
Variablen sind Container zum Speichern von Datenwerten. In C# musst du den Datentyp einer Variable angeben.

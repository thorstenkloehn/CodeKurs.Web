---
title: "C# Grundlagen"
description: "Ein Einstieg in die Welt von C#."
order: 1
language: "csharp"
tasks:
  - title: "Wie Programme funktionieren"
    type: "Theory"
    order: 1
    description: "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt."
  - title: "Was ist C#?"
    type: "Theory"
    order: 2
    description: "C# ist eine objektorientierte Sprache von Microsoft."
  - title: "Hallo Welt"
    type: "Programming"
    order: 3
    description: "Gib 'Hallo Welt!' aus."
    initialCode: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\t// Dein Code\n\t}\n}"
    expectedOutput: "Hallo Welt!"
    solution: "using System;\n\npublic class Program\n{\n\tpublic static void Main()\n\t{\n\t\tConsole.WriteLine(\"Hallo Welt!\");\n\t}\n}"
    requiredKeywords: "Console.WriteLine"
---
In dieser Lektion lernst du die ersten Schritte in C#.

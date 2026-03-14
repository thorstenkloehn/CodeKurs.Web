---
title: "Klassen & Methoden"
description: "Objektorientierte Programmierung."
order: 4
language: "csharp"
tasks:
  - title: "Edu: Die Rechner-Klasse"
    type: "Edu"
    order: 1
    description: "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'."
    initialCode: "public class Calculator \n{\n    // Hier deine Methode\n}"
    testCode: "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}"
    requiredKeywords: "class,Calculator,static,int"
---
Alles in C# findet in Klassen statt.

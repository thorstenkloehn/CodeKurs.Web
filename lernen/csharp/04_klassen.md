---
title: "Klassen & Methoden"
description: "Objektorientierte Programmierung."
order: 4
language: "csharp"
tasks:
  - title: "Objektlayout im Speicher"
    type: "Theory"
    order: 1
    description: "Objekte einer Klasse werden im Heap gespeichert. Ein Objekt enthält nicht nur seine Datenfelder, sondern oft auch einen Zeiger auf eine Virtual Method Table (VTable), die es ermöglicht, zur Laufzeit die richtigen Methodenaufrufe (Polymorphismus) zuzuordnen."
  - title: "Edu: Die Rechner-Klasse"
    type: "Edu"
    order: 2
    description: "Erstelle eine Klasse 'Calculator' mit einer statischen Methode 'Add(int a, int b)'."
    initialCode: "public class Calculator \n{\n    // Hier deine Methode\n}"
    testCode: "public class TestRunner {\n    public static void Main() {\n        if(Calculator.Add(5, 5) == 10 && Calculator.Add(-1, 1) == 0)\n            System.Console.WriteLine(\"SUCCESS_ALL_TESTS_PASSED\");\n        else\n            throw new System.Exception(\"Tests fehlgeschlagen.\");\n    }\n}"
    requiredKeywords: "class,Calculator,static,int"
---
Alles in C# findet in Klassen statt.

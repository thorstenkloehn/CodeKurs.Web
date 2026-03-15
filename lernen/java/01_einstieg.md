---
title: "Java Einstieg"
description: "Lerne Java kennen."
order: 1
language: "java"
tasks:
  - title: "Wie Programme funktionieren"
    type: "Theory"
    order: 1
    description: "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt."
  - title: "Java: Hallo Welt"
    type: "Programming"
    order: 2
    description: "Schreibe 'Hallo Welt!' in Java."
    initialCode: "public class Program {\n    public static void main(String[] args) {\n        // Dein Code hier\n    }\n}"
    expectedOutput: "Hallo Welt!"
    solution: "public class Program {\n    public static void main(String[] args) {\n        System.out.println(\"Hallo Welt!\");\n    }\n}"
    requiredKeywords: "System.out.println"
  - title: "Java: If-Else"
    type: "Programming"
    order: 3
    description: "Prüfe, ob x (10) > 5 ist und gib 'Ja' aus."
    initialCode: "public class Program {\n    public static void main(String[] args) {\n        int x = 10;\n        // Dein Code hier\n    }\n}"
    expectedOutput: "Ja"
    requiredKeywords: "if"
  - title: "Java: Taschenrechner"
    type: "Edu"
    order: 4
    description: "Erstelle eine Methode 'add(int a, int b)', die die Summe zurückgibt. Diese soll in einer Klasse 'Calculator' liegen."
    initialCode: "class Calculator {\n    // Deine Methode hier\n}"
    expectedOutput: "SUCCESS_ALL_TESTS_PASSED"
    solution: "class Calculator {\n    public static int add(int a, int b) {\n        return a + b;\n    }\n}"
    requiredKeywords: "static,int"
    testCode: "\npublic class Program {\n    public static void main(String[] args) {\n        if (Calculator.add(10, 5) == 15 && Calculator.add(-1, 1) == 0) {\n            System.out.println(\"SUCCESS_ALL_TESTS_PASSED\");\n        } else {\n            System.out.println(\"Tests fehlgeschlagen.\");\n        }\n    }\n}"
---
Java ist eine plattformunabhängige Sprache.

---
title: "Variablen in Java"
description: "Lerne, wie du mit verschiedenen Datentypen in Java arbeitest."
order: 4
language: "java"
tasks:
  - title: "Speicherverwaltung von Variablen"
    type: "Theory"
    order: 1
    description: "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird."
  - title: "Ganzzahlen (int)"
    type: "Programming"
    order: 2
    description: "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis aus."
    initialCode: "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}"
    expectedOutput: "15"
    solution: "public class Program {\n    public static void main(String[] args) {\n        int a = 10;\n        int b = 5;\n        System.out.println(a + b);\n    }\n}"
    requiredKeywords: "int,System.out.println"
  - title: "Gleitkommazahlen (double)"
    type: "Programming"
    order: 3
    description: "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus."
    initialCode: "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}"
    expectedOutput: "12.5"
    solution: "public class Program {\n    public static void main(String[] args) {\n        double a = 2.5;\n        double b = 5.0;\n        System.out.println(a * b);\n    }\n}"
    requiredKeywords: "double,System.out.println"
  - title: "Zeichenketten (String)"
    type: "Programming"
    order: 4
    description: "Verknüpfe zwei String-Objekte und gib sie aus."
    initialCode: "public class Program {\n    public static void main(String[] args) {\n        // Dein Code\n    }\n}"
    expectedOutput: "Hallo Welt"
    solution: "public class Program {\n    public static void main(String[] args) {\n        String s1 = \"Hallo \";\n        String s2 = \"Welt\";\n        System.out.println(s1 + s2);\n    }\n}"
    requiredKeywords: "String,System.out.println"
  - title: "Booleans (boolean)"
    type: "Programming"
    order: 5
    description: "Verwende einen boolean in einer if-Anweisung."
    initialCode: "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        // Dein Code\n    }\n}"
    expectedOutput: "Wahr"
    solution: "public class Program {\n    public static void main(String[] args) {\n        boolean isActive = true;\n        if (isActive) {\n            System.out.println(\"Wahr\");\n        } else {\n            System.out.println(\"Falsch\");\n        }\n    }\n}"
    requiredKeywords: "boolean,if,System.out.println"
---
Java ist eine streng typisierte Sprache. Jede Variable muss mit einem Typ deklariert werden.

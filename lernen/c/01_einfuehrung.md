---
title: "C Grundlagen"
description: "Ein Einstieg in die prozedurale Programmierung mit C."
order: 1
language: "c"
tasks:
  - title: "Wie Programme funktionieren"
    type: "Theory"
    order: 1
    description: "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt."
  - title: "Was ist C?"
    type: "Theory"
    order: 2
    description: "C ist eine imperative und prozedurale Programmiersprache, die in den 1970er Jahren entwickelt wurde und bis heute für Betriebssysteme und hardwarenahe Software eingesetzt wird."
  - title: "Hallo Welt"
    type: "Programming"
    order: 3
    description: "Gib 'Hallo Welt!' aus."
    initialCode: |
      #include <stdio.h>

      int main() {
          // Dein Code hier
          return 0;
      }
    expectedOutput: "Hallo Welt!"
    solution: |
      #include <stdio.h>

      int main() {
          printf("Hallo Welt!\n");
          return 0;
      }
    requiredKeywords: "printf"
---
In dieser Lektion lernst du die ersten Schritte in C. C bildet die Grundlage für viele moderne Sprachen wie C++, C# und Java.

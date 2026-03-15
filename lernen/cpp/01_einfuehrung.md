---
title: "C++ Grundlagen"
description: "Ein Einstieg in die objektorientierte Programmierung mit C++."
order: 1
language: "cpp"
tasks:
  - title: "Wie Programme funktionieren"
    type: "Theory"
    order: 1
    description: "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt."
  - title: "Was ist C++?"
    type: "Theory"
    order: 2
    description: "C++ ist eine von Bjarne Stroustrup entwickelte Programmiersprache, die als Erweiterung der Sprache C entstand. Sie unterstützt verschiedene Programmierparadigmen wie die prozedurale und die objektorientierte Programmierung."
  - title: "Hallo Welt"
    type: "Programming"
    order: 3
    description: "Gib 'Hallo Welt!' aus."
    initialCode: |
      #include <iostream>

      int main() {
          // Dein Code hier
          return 0;
      }
    expectedOutput: "Hallo Welt!"
    solution: |
      #include <iostream>

      int main() {
          std::cout << "Hallo Welt!" << std::endl;
          return 0;
      }
    requiredKeywords: "cout"
---
In dieser Lektion lernst du die ersten Schritte in C++. C++ wird häufig für Systemsoftware, Spieleentwicklung, Treiber und Hochleistungsanwendungen verwendet.

---
title: "C++: Benutzereingaben"
description: "Lerne, wie du std::cin für Eingaben in C++ nutzt."
order: 6
language: "cpp"
tasks:
  - title: "Systemcalls und Buffering"
    type: "Theory"
    order: 1
    description: "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren."
  - title: "std::cin: Einlesen"
    type: "Programming"
    order: 2
    description: "Nutze `std::cin` mit dem `>>` Operator, um eine Zahl einzulesen."
    initialCode: |
      #include <iostream>
      
      int main() {
          int zahl;
          // Nutze cin zum Einlesen
          std::cin >> zahl;
          std::cout << "Gelesen: " << zahl;
          return 0;
      }
    expectedOutput: "Gelesen: 42"
    solution: |
      #include <iostream>
      
      int main() {
          int zahl;
          std::cin >> zahl;
          std::cout << "Gelesen: " << zahl;
          return 0;
      }
    requiredKeywords: "cin >>"
  - title: "Lückentext: cin Operator"
    type: "Programming"
    order: 3
    description: "Welcher Operator wird für Eingaben mit `cin` verwendet?"
    initialCode: |
      #include <iostream>
      
      int main() {
          int x;
          std::cin __ x; // Lücke füllen
          std::cout << "OK";
          return 0;
      }
    expectedOutput: "OK"
    solution: |
      #include <iostream>
      
      int main() {
          int x;
          std::cin >> x;
          std::cout << "OK";
          return 0;
      }
    requiredKeywords: ">>"
---
In C++ nutzt du den Input-Stream **`std::cin`**.

1. **Extraktionsoperator (`>>`)**: Die Daten werden aus dem Stream extrahiert und in die Variable geschrieben.
2. **Mehrere Eingaben**: Du kannst `std::cin >> a >> b;` nutzen, um zwei Werte nacheinander zu lesen.

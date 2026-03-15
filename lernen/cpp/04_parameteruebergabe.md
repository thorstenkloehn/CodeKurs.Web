---
title: "C++: Parameterübergabe"
description: "Lerne den Unterschied zwischen Call by Value, Call by Reference und Call by Pointer."
order: 4
language: "cpp"
tasks:
  - title: "Referenzsemantik und Speichersicherheit"
    type: "Theory"
    order: 1
    description: "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern."
  - title: "Call by Value"
    type: "Programming"
    order: 2
    description: "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt (Call by Value)."
    initialCode: |
      #include <iostream>
      
      void verdopple(int x) {
          // Hier den Code einfügen
      }
      
      int main() {
          int zahl = 5;
          verdopple(zahl);
          std::cout << "Wert nach Funktion: " << zahl << std::endl;
          return 0;
      }
    expectedOutput: "Wert nach Funktion: 5"
    solution: |
      #include <iostream>
      
      void verdopple(int x) {
          x = x * 2;
      }
      
      int main() {
          int zahl = 5;
          verdopple(zahl);
          std::cout << "Wert nach Funktion: " << zahl << std::endl;
          return 0;
      }
    requiredKeywords: "x = x * 2"
  - title: "Call by Reference"
    type: "Programming"
    order: 3
    description: "Nutze eine Referenz (`&`), um den Wert der Originalvariable in der Funktion `verdoppleRef` dauerhaft zu ändern."
    initialCode: |
      #include <iostream>
      
      // Nutze & für Call by Reference
      void verdoppleRef(int& x) {
          x = x * 2;
      }
      
      int main() {
          int zahl = 5;
          verdoppleRef(zahl);
          std::cout << "Geänderter Wert: " << zahl << std::endl;
          return 0;
      }
    expectedOutput: "Geänderter Wert: 10"
    solution: |
      #include <iostream>
      
      void verdoppleRef(int& x) {
          x = x * 2;
      }
      
      int main() {
          int zahl = 5;
          verdoppleRef(zahl);
          std::cout << "Geänderter Wert: " << zahl << std::endl;
          return 0;
      }
    requiredKeywords: "int&"
  - title: "Call by Pointer"
    type: "Programming"
    order: 4
    description: "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern."
    initialCode: |
      #include <iostream>
      
      void verdopplePtr(int* x) {
          if (x != nullptr) {
              // Ändere den Wert, auf den x zeigt
              *x = *x * 2;
          }
      }
      
      int main() {
          int zahl = 5;
          // Übergebe die Adresse von zahl
          verdopplePtr(&zahl);
          std::cout << "Wert über Pointer: " << zahl << std::endl;
          return 0;
      }
    expectedOutput: "Wert über Pointer: 10"
    solution: |
      #include <iostream>
      
      void verdopplePtr(int* x) {
          if (x != nullptr) {
              *x = *x * 2;
          }
      }
      
      int main() {
          int zahl = 5;
          verdopplePtr(&zahl);
          std::cout << "Wert über Pointer: " << zahl << std::endl;
          return 0;
      }
    requiredKeywords: "int*,&zahl"
  - title: "Lückentext: Syntax"
    type: "Programming"
    order: 5
    description: "Fülle die Lücken mit der richtigen Syntax für Pointer und Referenzen."
    initialCode: |
      #include <iostream>
      
      void swap(int__ a, int__ b) { // Nutze & für Referenzen
          int temp = a;
          a = b;
          b = temp;
      }
      
      int main() {
          int x = 1, y = 2;
          swap(x, y);
          std::cout << "x=" << x << ", y=" << y;
          return 0;
      }
    expectedOutput: "x=2, y=1"
    solution: |
      #include <iostream>
      
      void swap(int& a, int& b) {
          int temp = a;
          a = b;
          b = temp;
      }
      
      int main() {
          int x = 1, y = 2;
          swap(x, y);
          std::cout << "x=2, y=1";
          return 0;
      }
    requiredKeywords: "int&"
---
In C++ gibt es drei Hauptarten, wie Daten an Funktionen übergeben werden können:

1. **Call by Value**: Es wird eine Kopie erstellt. Änderungen in der Funktion haben keine Auswirkung auf das Original.
2. **Call by Reference**: Die Funktion erhält direkten Zugriff auf das Original (Alias). Änderungen wirken sich sofort aus. Syntax: `Type& name`.
3. **Call by Pointer**: Die Adresse der Variable wird übergeben. Die Funktion greift über Dereferenzierung (`*`) auf das Original zu. Syntax: `Type* name` und beim Aufruf `&variable`.

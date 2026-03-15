---
title: "C++: Pointer und Smart Pointer"
description: "Lerne den sicheren Umgang mit Raw Pointern und modernen Smart Pointern in C++."
order: 5
language: "cpp"
tasks:
  - title: "Referenzsemantik und Speichersicherheit"
    type: "Theory"
    order: 1
    description: "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern."
  - title: "Raw Pointer: Adresse abrufen"
    type: "Programming"
    order: 2
    description: "Fülle die Lücken, um die Adresse von `zahl` in einem Raw Pointer zu speichern und den Wert darüber auszugeben."
    initialCode: |
      #include <iostream>
      
      int main() {
          int zahl = 100;
          // Lücke: int* ptr = ...
          int* ptr = ________;
          
          // Lücke: Wert über Pointer ausgeben (Dereferenzierung)
          std::cout << "Wert: " << ________;
          return 0;
      }
    expectedOutput: "Wert: 100"
    solution: |
      #include <iostream>
      
      int main() {
          int zahl = 100;
          int* ptr = &zahl;
          std::cout << "Wert: " << *ptr;
          return 0;
      }
    requiredKeywords: "&zahl,*ptr"
  - title: "Smart Pointer: unique_ptr"
    type: "Programming"
    order: 3
    description: "Nutze `std::unique_ptr`, um Speicher auf dem Heap sicher zu verwalten. Erstelle einen `unique_ptr<int>` mit `std::make_unique`."
    initialCode: |
      #include <iostream>
      #include <memory>
      
      int main() {
          // Erstelle einen unique_ptr für den Wert 42
          std::unique_ptr<int> smartPtr = std::make_unique<int>(42);
          
          if (smartPtr) {
              std::cout << "Smart Wert: " << *smartPtr;
          }
          return 0;
      }
    expectedOutput: "Smart Wert: 42"
    solution: |
      #include <iostream>
      #include <memory>
      
      int main() {
          std::unique_ptr<int> smartPtr = std::make_unique<int>(42);
          if (smartPtr) {
              std::cout << "Smart Wert: " << *smartPtr;
          }
          return 0;
      }
    requiredKeywords: "unique_ptr,make_unique"
  - title: "Smart Pointer: shared_ptr"
    type: "Programming"
    order: 4
    description: "Ein `shared_ptr` erlaubt es mehreren Pointern, denselben Speicher zu besitzen. Erstelle einen `shared_ptr` und gib den `use_count()` aus."
    initialCode: |
      #include <iostream>
      #include <memory>
      
      int main() {
          auto p1 = std::make_shared<int>(10);
          {
              // Erstelle eine Kopie von p1
              std::shared_ptr<int> p2 = p1;
              std::cout << "Count: " << p1.use_count();
          }
          return 0;
      }
    expectedOutput: "Count: 2"
    solution: |
      #include <iostream>
      #include <memory>
      
      int main() {
          auto p1 = std::make_shared<int>(10);
          {
              std::shared_ptr<int> p2 = p1;
              std::cout << "Count: " << p1.use_count();
          }
          return 0;
      }
    requiredKeywords: "make_shared,use_count"
---
In modernem C++ (ab C++11) solltest du **Smart Pointer** gegenüber Raw Pointern bevorzugen, um Speicherlecks zu vermeiden.

1. **Raw Pointer (`T*`)**: Speichert eine nackte Speicheradresse. Du musst dich selbst um `delete` kümmern.
2. **`std::unique_ptr<T>`**: Exklusives Eigentum. Der Speicher wird automatisch freigegeben, wenn der Pointer out-of-scope geht.
3. **`std::shared_ptr<T>`**: Gemeinsames Eigentum. Nutzt Reference Counting.

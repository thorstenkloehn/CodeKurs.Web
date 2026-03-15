---
title: "C: Parameterübergabe"
description: "Lerne den Unterschied zwischen Call by Value und Call by Pointer in C."
order: 4
language: "c"
tasks:
  - title: "Referenzsemantik und Speichersicherheit"
    type: "Theory"
    order: 1
    description: "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern."
  - title: "Call by Value in C"
    type: "Programming"
    order: 2
    description: "Vervollständige die Funktion `verdopple`, sodass sie den Wert verdoppelt, aber das Original unverändert bleibt."
    initialCode: |
      #include <stdio.h>
      
      void verdopple(int x) {
          // Hier den Code einfügen
      }
      
      int main() {
          int zahl = 5;
          verdopple(zahl);
          printf("Wert nach Funktion: %d", zahl);
          return 0;
      }
    expectedOutput: "Wert nach Funktion: 5"
    solution: |
      #include <stdio.h>
      
      void verdopple(int x) {
          x = x * 2;
      }
      
      int main() {
          int zahl = 5;
          verdopple(zahl);
          printf("Wert nach Funktion: %d", zahl);
          return 0;
      }
    requiredKeywords: "x = x * 2"
  - title: "Call by Pointer in C"
    type: "Programming"
    order: 3
    description: "Nutze einen Pointer (`*`), um den Wert über die Adresse zu ändern."
    initialCode: |
      #include <stdio.h>
      
      void verdopplePtr(int *x) {
          if (x != NULL) {
              // Ändere den Wert, auf den x zeigt
              *x = *x * 2;
          }
      }
      
      int main() {
          int zahl = 5;
          // Übergebe die Adresse von zahl mit &
          verdopplePtr(&zahl);
          printf("Geänderter Wert: %d", zahl);
          return 0;
      }
    expectedOutput: "Geänderter Wert: 10"
    solution: |
      #include <stdio.h>
      
      void verdopplePtr(int *x) {
          if (x != NULL) {
              *x = *x * 2;
          }
      }
      
      int main() {
          int zahl = 5;
          verdopplePtr(&zahl);
          printf("Geänderter Wert: %d", zahl);
          return 0;
      }
    requiredKeywords: "int *,*x,&zahl"
  - title: "Lückentext: Pointer-Syntax"
    type: "Programming"
    order: 4
    description: "Fülle die Lücken, um zwei Zahlen mithilfe von Pointern zu tauschen."
    initialCode: |
      #include <stdio.h>
      
      void swap(int ____ a, int ____ b) {
          int temp = ____ a;
          ____ a = ____ b;
          ____ b = temp;
      }
      
      int main() {
          int x = 1, y = 2;
          swap(&x, &y);
          printf("x=%d, y=%d", x, y);
          return 0;
      }
    expectedOutput: "x=2, y=1"
    solution: |
      #include <stdio.h>
      
      void swap(int * a, int * b) {
          int temp = * a;
          * a = * b;
          * b = temp;
      }
      
      int main() {
          int x = 1, y = 2;
          swap(&x, &y);
          printf("x=2, y=1");
          return 0;
      }
    requiredKeywords: "int *,* a,* b"
---
In C gibt es (im Gegensatz zu C++) kein echtes "Call by Reference". Stattdessen nutzt man Pointer, um ähnliche Effekte zu erzielen.

1. **Call by Value**: Es wird eine Kopie des Wertes an die Funktion übergeben. Änderungen betreffen nur die Kopie.
2. **Call by Pointer**: Die Adresse einer Variable wird übergeben. Die Funktion kann über diese Adresse direkt auf den Speicher des Aufrufers zugreifen und den Wert ändern.

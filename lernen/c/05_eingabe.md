---
title: "C: Benutzereingaben"
description: "Lerne, wie du scanf für Eingaben in C nutzt."
order: 5
language: "c"
tasks:
  - title: "Systemcalls und Buffering"
    type: "Theory"
    order: 1
    description: "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren."
  - title: "scanf: Ganzzahlen"
    type: "Programming"
    order: 2
    description: "Lies eine Ganzzahl mit `scanf` ein und gib sie aus."
    initialCode: |
      #include <stdio.h>
      
      int main() {
          int zahl;
          // scanf nutzt %d und den Adressoperator &
          scanf("%d", &zahl);
          printf("Zahl: %d", zahl);
          return 0;
      }
    expectedOutput: "Zahl: 100"
    solution: |
      #include <stdio.h>
      
      int main() {
          int zahl;
          scanf("%d", &zahl);
          printf("Zahl: %d", zahl);
          return 0;
      }
    requiredKeywords: "scanf,&zahl"
  - title: "Lückentext: Adressoperator"
    type: "Programming"
    order: 3
    description: "Bei `scanf` musst du immer die Adresse der Variable angeben. Welches Zeichen wird dafür benötigt?"
    initialCode: |
      #include <stdio.h>
      
      int main() {
          int x;
          scanf("%d", __x); // Lücke füllen
          printf("OK");
          return 0;
      }
    expectedOutput: "OK"
    solution: |
      #include <stdio.h>
      
      int main() {
          int x;
          scanf("%d", &x);
          printf("OK");
          return 0;
      }
    requiredKeywords: "&x"
---
In C ist **`scanf`** die Standardfunktion zum Einlesen von formatierten Daten.

1. **Format-String**: `%d` für Integer, `%f` für Float, etc.
2. **Adressoperator (`&`)**: `scanf` benötigt die Speicheradresse der Variable, in die der Wert geschrieben werden soll.

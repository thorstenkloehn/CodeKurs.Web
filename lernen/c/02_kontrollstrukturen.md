---
title: "C: Kontrollstrukturen"
description: "Entscheidungen treffen mit if und else."
order: 2
language: "c"
tasks:
  - title: "Branch Prediction und Sprungtabellen"
    type: "Theory"
    order: 1
    description: "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen."
  - title: "Logik: Positiv/Negativ"
    type: "Programming"
    order: 2
    description: "Prüfe, ob die Variable 'zahl' positiv oder negativ ist. Gib 'Positiv' oder 'Negativ' aus."
    initialCode: |
      #include <stdio.h>
      int main() {
          int zahl = -5;
          // Dein Code hier
          return 0;
      }
    expectedOutput: "Negativ"
    solution: |
      #include <stdio.h>
      int main() {
          int zahl = -5;
          if (zahl > 0) {
              printf("Positiv");
          } else {
              printf("Negativ");
          }
          return 0;
      }
    requiredKeywords: "if,else"
---

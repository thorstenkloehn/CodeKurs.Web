---
title: "Java: Schleifen"
description: "Wiederhole Aufgaben mit for und while."
order: 3
language: "java"
tasks:
  - title: "Effizienz von Schleifen"
    type: "Theory"
    order: 1
    description: "Erfahre, wie Compiler Schleifen optimieren können. Beim Loop Unrolling wird der Schleifenkörper vervielfacht, um die Anzahl der Bedingungsprüfungen zu reduzieren. Zudem ist der Zugriff auf Daten im Speicher effizienter, wenn sie sequenziell (Cache Locality) verarbeitet werden."
  - title: "Zahlen 1 bis 5"
    type: "Programming"
    order: 2
    description: "Nutze eine `for`-Schleife, um die Zahlen 1, 2, 3, 4 und 5 auszugeben."
    initialCode: |
      public class Program {
          public static void main(String[] args) {
              // Dein Code hier
          }
      }
    expectedOutput: "1\n2\n3\n4\n5"
    solution: |
      public class Program {
          public static void main(String[] args) {
              for (int i = 1; i <= 5; i++) {
                  System.out.println(i);
              }
          }
      }
    requiredKeywords: "for"
  - title: "Summe bis 10"
    type: "Programming"
    order: 3
    description: "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist."
    initialCode: |
      public class Program {
          public static void main(String[] args) {
              int summe = 0;
              int i = 1;
              // Dein Code hier
          }
      }
    expectedOutput: "10"
    solution: |
      public class Program {
          public static void main(String[] args) {
              int summe = 0;
              int i = 1;
              while (i < 5) {
                  summe += i;
                  i++;
              }
              System.out.print(summe);
          }
      }
    requiredKeywords: "while"
---
Java nutzt `for`- und `while`-Schleifen wie viele andere C-basierte Sprachen. Achte auf die korrekte Definition der Laufvariable.

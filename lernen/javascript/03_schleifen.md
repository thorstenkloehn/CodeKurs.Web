---
title: "JavaScript: Schleifen"
description: "Wiederhole Aufgaben mit for und while."
order: 3
language: "javascript"
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
      // Dein Code hier
    expectedOutput: "1\n2\n3\n4\n5"
    solution: |
      for (let i = 1; i <= 5; i++) {
          console.log(i);
      }
    requiredKeywords: "for"
  - title: "Summe bis 10"
    type: "Programming"
    order: 3
    description: "Nutze eine `while`-Schleife, um die Summe der Zahlen von 1 bis 4 zu berechnen und auszugeben. Addiere solange `i < 5` ist."
    initialCode: |
      let summe = 0;
      let i = 1;
      // Dein Code hier
    expectedOutput: "10"
    solution: |
      let summe = 0;
      let i = 1;
      while (i < 5) {
          summe += i;
          i++;
      }
      console.log(summe);
    requiredKeywords: "while"
---
In JavaScript sind Schleifen ein wichtiges Werkzeug, um Arrays zu durchlaufen oder wiederkehrende Aufgaben zu automatisieren.

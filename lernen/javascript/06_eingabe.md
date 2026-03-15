---
title: "JavaScript: Benutzereingaben"
description: "Lerne, wie du Daten in Node.js von der Konsole einliest."
order: 6
language: "javascript"
tasks:
  - title: "Systemcalls und Buffering"
    type: "Theory"
    order: 1
    description: "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren."
  - title: "readline: Einlesen"
    type: "Programming"
    order: 2
    description: "Nutze `fs.readFileSync(0)` für synchrones Einlesen von der Konsole."
    initialCode: |
      const fs = require('fs');
      // Lese von stdin
      let input = fs.readFileSync(0).toString().trim();
      console.log("Eingabe war: " + input);
    expectedOutput: "Eingabe war: JS"
    solution: |
      const fs = require('fs');
      let input = fs.readFileSync(0).toString().trim();
      console.log("Eingabe war: " + input);
    requiredKeywords: "readFileSync"
  - title: "Lückentext: fs Modul"
    type: "Programming"
    order: 3
    description: "Welches Modul wird für den Zugriff auf das Dateisystem und stdin benötigt?"
    initialCode: |
      const fs = ____('fs');
      
      let data = fs.readFileSync(0);
      console.log("Gelesen!");
    expectedOutput: "Gelesen!"
    solution: |
      const fs = require('fs');
      let data = fs.readFileSync(0);
      console.log("Gelesen!");
    requiredKeywords: "require"
---
In Node.js ist das Einlesen von der Konsole etwas technischer als im Browser.

1. **fs Modul**: Über `fs.readFileSync(0)` kann synchron von der Standard-Eingabe gelesen werden.
2. **Buffer zu String**: Das Ergebnis muss meist mit `.toString()` umgewandelt und mit `.trim()` von Zeilenumbrüchen befreit werden.

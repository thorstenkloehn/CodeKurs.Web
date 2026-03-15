---
title: "JavaScript: Parameterübergabe"
description: "Lerne, wie JavaScript mit Werten und Objekten umgeht."
order: 5
language: "javascript"
tasks:
  - title: "Referenzsemantik und Speichersicherheit"
    type: "Theory"
    order: 1
    description: "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern."
  - title: "Primitive: Pass by Value"
    type: "Programming"
    order: 2
    description: "Vervollständige die Funktion `verdopple`, sodass sie `zahl` lokal ändert. Bleibt die Variable in der Außenwelt gleich?"
    initialCode: |
      function verdopple(x) {
          x = x * 2;
      }
      
      let zahl = 5;
      verdopple(zahl);
      console.log(zahl);
    expectedOutput: "5"
    solution: |
      function verdopple(x) {
          x = x * 2;
      }
      
      let zahl = 5;
      verdopple(zahl);
      console.log(zahl);
    requiredKeywords: "x = x * 2"
  - title: "Objekte: Referenzen"
    type: "Programming"
    order: 3
    description: "In JS werden Objekte über eine Referenz übergeben. Ändere die Eigenschaft `name` des Objekts in der Funktion."
    initialCode: |
      function updateName(obj) {
          // Ändere obj.name zu "Geändert"
          obj.name = "Geändert";
      }
      
      let person = { name: "Original" };
      updateName(person);
      console.log(person.name);
    expectedOutput: "Geändert"
    solution: |
      function updateName(obj) {
          obj.name = "Geändert";
      }
      
      let person = { name: "Original" };
      updateName(person);
      console.log(person.name);
    requiredKeywords: "obj.name"
---
JavaScript nutzt ein Modell, das oft als **Call-by-Sharing** bezeichnet wird.

1. **Primitive Typen (`number`, `string`, `boolean`)**: Diese werden per Wert (**Call by Value**) übergeben. Die Funktion erhält eine echte Kopie.
2. **Objekte und Arrays**: Hier wird eine Referenz auf das Objekt übergeben. Du kannst den Inhalt des Objekts ändern, aber du kannst die Variable selbst nicht in der Funktion auf ein neues Objekt umbiegen.

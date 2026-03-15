---
title: "Python: Parameterübergabe"
description: "Lerne, wie Python mit Referenzen und veränderlichen Objekten umgeht."
order: 5
language: "python"
tasks:
  - title: "Referenzsemantik und Speichersicherheit"
    type: "Theory"
    order: 1
    description: "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern."
  - title: "Unveränderliche Typen (Integers)"
    type: "Programming"
    order: 2
    description: "Vervollständige die Funktion `verdopple`, sodass sie `x` lokal ändert. Bleibt die Variable in der Außenwelt gleich?"
    initialCode: |
      def verdopple(x):
          # x lokal verdoppeln
          x = x * 2
      
      zahl = 5
      verdopple(zahl)
      print(zahl)
    expectedOutput: "5"
    solution: |
      def verdopple(x):
          x = x * 2
      
      zahl = 5
      verdopple(zahl)
      print(zahl)
    requiredKeywords: "x = x * 2"
  - title: "Veränderliche Typen (Listen)"
    type: "Programming"
    order: 3
    description: "In Python können veränderliche Objekte (wie Listen) in Funktionen modifiziert werden."
    initialCode: |
      def add_element(liste):
          # Füge "Python" zur Liste hinzu
          liste.append("Python")
      
      meine_liste = []
      add_element(meine_liste)
      print(meine_liste[0])
    expectedOutput: "Python"
    solution: |
      def add_element(liste):
          liste.append("Python")
      
      meine_liste = []
      add_element(meine_liste)
      print(meine_liste[0])
    requiredKeywords: "append"
---
Python nutzt ein Modell namens **Pass-by-Object-Reference**.

1. **Unveränderliche Typen (`int`, `str`, `tuple`)**: Da diese nicht geändert werden können, verhält es sich wie **Call by Value**. Jede "Änderung" erzeugt ein neues Objekt lokal in der Funktion.
2. **Veränderliche Typen (`list`, `dict`, `set`)**: Die Referenz wird übergeben. Änderungen am Objekt (z.B. `.append()`) wirken sich direkt auf das Original aus.

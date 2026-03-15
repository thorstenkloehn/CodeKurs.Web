---
title: "Java: Parameterübergabe"
description: "Verstehe den Unterschied zwischen Primitiven und Objekten in Java."
order: 5
language: "java"
tasks:
  - title: "Referenzsemantik und Speichersicherheit"
    type: "Theory"
    order: 1
    description: "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern."
  - title: "Primitive: Pass by Value"
    type: "Programming"
    order: 2
    description: "Versuche den Wert von `x` in der Methode `verdopple` zu ändern. Bleibt das Original in `main` gleich?"
    initialCode: |
      public class Main {
          public static void verdopple(int x) {
              x = x * 2;
          }
          public static void main(String[] args) {
              int zahl = 5;
              verdopple(zahl);
              System.out.print(zahl);
          }
      }
    expectedOutput: "5"
    solution: |
      public class Main {
          public static void verdopple(int x) {
              x = x * 2;
          }
          public static void main(String[] args) {
              int zahl = 5;
              verdopple(zahl);
              System.out.print(zahl);
          }
      }
    requiredKeywords: "x = x * 2"
  - title: "Objekte: Referenz ändern"
    type: "Programming"
    order: 3
    description: "In Java werden Objektreferenzen per Wert übergeben. Du kannst das Objekt verändern, aber nicht die Referenz selbst."
    initialCode: |
      import java.util.ArrayList;
      import java.util.List;
      
      public class Main {
          public static void addElement(List<String> list) {
              // Füge ein Element hinzu
              list.add("Java");
          }
          public static void main(String[] args) {
              List<String> list = new ArrayList<>();
              addElement(list);
              System.out.print(list.get(0));
          }
      }
    expectedOutput: "Java"
    solution: |
      import java.util.ArrayList;
      import java.util.List;
      
      public class Main {
          public static void addElement(List<String> list) {
              list.add("Java");
          }
          public static void main(String[] args) {
              List<String> list = new ArrayList<>();
              addElement(list);
              System.out.print(list.get(0));
          }
      }
    requiredKeywords: "list.add"
---
In Java gibt es oft Diskussionen über "Call by Reference". Die Wahrheit ist: **Java ist immer Call by Value.**

1. **Primitive Typen (`int`, `double`, etc.)**: Es wird eine Kopie des eigentlichen Wertes übergeben.
2. **Objekt-Referenzen**: Es wird eine Kopie der **Adresse** des Objekts übergeben. Deshalb kannst du Attribute des Objekts in einer Methode ändern, aber du kannst nicht die ursprüngliche Variable auf ein komplett neues Objekt zeigen lassen.

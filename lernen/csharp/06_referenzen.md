---
title: "C#: Parameterübergabe"
description: "Lerne den Einsatz von ref und out für Call by Reference in C#."
order: 6
language: "csharp"
tasks:
  - title: "Referenzsemantik und Speichersicherheit"
    type: "Theory"
    order: 1
    description: "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern."
  - title: "Das ref Keyword"
    type: "Programming"
    order: 2
    description: "Nutze das `ref`-Keyword, um den Wert der Variable `zahl` in der Methode `Verdopple` zu ändern."
    initialCode: |
      using System;
      
      public class Program
      {
          static void Verdopple(ref int x) {
              x *= 2;
          }
          
          public static void Main()
          {
              int zahl = 5;
              // Nutze ref auch beim Aufruf
              Verdopple(ref zahl);
              Console.Write(zahl);
          }
      }
    expectedOutput: "10"
    solution: |
      using System;
      
      public class Program
      {
          static void Verdopple(ref int x) {
              x *= 2;
          }
          
          public static void Main()
          {
              int zahl = 5;
              Verdopple(ref zahl);
              Console.Write(zahl);
          }
      }
    requiredKeywords: "ref int,ref zahl"
  - title: "Das out Keyword"
    type: "Programming"
    order: 3
    description: "Nutze das `out`-Keyword, um einen Wert von einer Methode zurückzugeben, ohne den Rückgabewert zu nutzen."
    initialCode: |
      using System;
      
      public class Program
      {
          static void Initialisiere(out int x) {
              // out Variablen MÜSSEN in der Methode zugewiesen werden
              x = 42;
          }
          
          public static void Main()
          {
              int zahl;
              Initialisiere(out zahl);
              Console.Write(zahl);
          }
      }
    expectedOutput: "42"
    solution: |
      using System;
      
      public class Program
      {
          static void Initialisiere(out int x) {
              x = 42;
          }
          
          public static void Main()
          {
              int zahl;
              Initialisiere(out zahl);
              Console.Write(zahl);
          }
      }
    requiredKeywords: "out int,out zahl"
  - title: "Lückentext: C# Syntax"
    type: "Programming"
    order: 4
    description: "Fülle die Lücken mit `ref` oder `out`."
    initialCode: |
      using System;
      
      public class Program
      {
          static void Swap(____ int a, ____ int b) {
              int temp = a;
              a = b;
              b = temp;
          }
          
          public static void Main()
          {
              int x = 1, y = 2;
              Swap(____ x, ____ y);
              Console.Write($"x={x},y={y}");
          }
      }
    expectedOutput: "x=2,y=1"
    solution: |
      using System;
      
      public class Program
      {
          static void Swap(ref int a, ref int b) {
              int temp = a;
              a = b;
              b = temp;
          }
          
          public static void Main()
          {
              int x = 1, y = 2;
              Swap(ref x, ref y);
              Console.Write($"x={x},y={y}");
          }
      }
    requiredKeywords: "ref int,ref x"
---
In C# werden Werttypen (wie `int`, `bool`) standardmäßig per **Call by Value** übergeben.

1. **ref**: Übergibt eine Referenz auf eine Variable. Die Variable muss vor der Übergabe initialisiert sein.
2. **out**: Übergibt eine Referenz, aber die Variable muss nicht initialisiert sein. Die Methode **muss** der `out`-Variable jedoch einen Wert zuweisen.
3. **Pointer**: C# unterstützt Pointer nur in `unsafe` Codeblöcken, was für allgemeine Anwendungen selten genutzt wird.

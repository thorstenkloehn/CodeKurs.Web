---
title: "C#: Benutzereingaben"
description: "Lerne, wie du Console.ReadLine() für Eingaben in C# nutzt."
order: 7
language: "csharp"
tasks:
  - title: "Systemcalls und Buffering"
    type: "Theory"
    order: 1
    description: "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren."
  - title: "ReadLine: Einlesen"
    type: "Programming"
    order: 2
    description: "Lies einen Namen mit `Console.ReadLine()` ein."
    initialCode: |
      using System;
      
      public class Program {
          public static void Main() {
              // Lese von der Konsole
              string name = Console.ReadLine();
              Console.Write("Hallo " + name);
          }
      }
    expectedOutput: "Hallo CSharp"
    solution: |
      using System;
      
      public class Program {
          public static void Main() {
              string name = Console.ReadLine();
              Console.Write("Hallo " + name);
          }
      }
    requiredKeywords: "Console.ReadLine"
  - title: "Lückentext: String zu Zahl"
    type: "Programming"
    order: 3
    description: "Wandle die Eingabe mit `int.Parse()` in eine Zahl um."
    initialCode: |
      using System;
      
      public class Program {
          public static void Main() {
              string s = Console.ReadLine();
              // Lücke: int x = ___.Parse(s);
              int x = ___.Parse(s);
              Console.Write(x * 2);
          }
      }
    expectedOutput: "20"
    solution: |
      using System;
      
      public class Program {
          public static void Main() {
              string s = Console.ReadLine();
              int x = int.Parse(s);
              Console.Write(x * 2);
          }
      }
    requiredKeywords: "int.Parse"
---
In C# nutzt du die Klasse **`Console`**, um Eingaben zu erhalten.

1. **`Console.ReadLine()`**: Liest eine komplette Zeile als String ein.
2. **`Console.Read()`**: Liest nur ein einzelnes Zeichen als Ganzzahl-Code (ASCII/Unicode).
3. **Parsing**: Nutze Methoden wie `int.Parse()` oder `Convert.ToInt32()`, um Texte in Zahlen zu wandeln.

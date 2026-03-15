---
title: "Java: Benutzereingaben"
description: "Lerne, wie du die Scanner-Klasse für Eingaben in Java nutzt."
order: 6
language: "java"
tasks:
  - title: "Systemcalls und Buffering"
    type: "Theory"
    order: 1
    description: "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren."
  - title: "Scanner: Einlesen"
    type: "Programming"
    order: 2
    description: "Nutze die `Scanner`-Klasse, um einen Namen einzulesen."
    initialCode: |
      import java.util.Scanner;
      
      public class Main {
          public static void main(String[] args) {
              // Erstelle einen Scanner
              Scanner sc = new Scanner(System.in);
              String name = sc.next();
              System.out.print("Hallo " + name);
          }
      }
    expectedOutput: "Hallo Java"
    solution: |
      import java.util.Scanner;
      
      public class Main {
          public static void main(String[] args) {
              Scanner sc = new Scanner(System.in);
              String name = sc.next();
              System.out.print("Hallo " + name);
          }
      }
    requiredKeywords: "Scanner,System.in"
  - title: "Lückentext: Nächste Zahl"
    type: "Programming"
    order: 3
    description: "Welche Methode des Scanners liest die nächste Ganzzahl ein?"
    initialCode: |
      import java.util.Scanner;
      
      public class Main {
          public static void main(String[] args) {
              Scanner sc = new Scanner(System.in);
              // Lücke: int x = sc.____();
              int x = sc.____();
              System.out.print(x);
          }
      }
    expectedOutput: "42"
    solution: |
      import java.util.Scanner;
      
      public class Main {
          public static void main(String[] args) {
              Scanner sc = new Scanner(System.in);
              int x = sc.nextInt();
              System.out.print(x);
          }
      }
    requiredKeywords: "nextInt"
---
In Java ist die Klasse **`java.util.Scanner`** der einfachste Weg für Konsoleneingaben.

1. **Instanziierung**: `Scanner sc = new Scanner(System.in);`.
2. **Methoden**: `next()` für Strings, `nextInt()` für Ganzzahlen, `nextDouble()` für Kommazahlen.
3. **Puffer**: Beachte, dass `nextInt()` oft einen Zeilenumbruch im Puffer lässt.

---
title: "Rust: Lückentext Eingabe"
description: "Übe die Syntax für Benutzereingaben in Rust, indem du die Lücken füllst."
order: 5
language: "rust"
tasks:
  - title: "Systemcalls und Buffering"
    type: "Theory"
    order: 1
    description: "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren."
  - title: "Lücke: Den Puffer erstellen"
    type: "Programming"
    order: 2
    description: "Vervollständige die Zeile, um einen neuen, leeren String-Puffer zu erstellen. <br>Nutze `String::new()`."
    initialCode: |
      fn main() {
          // Vervollständige: let mut input = ...
          let mut input = ___________;
          
          println!("Puffer bereit.");
      }
    expectedOutput: "Puffer bereit."
    solution: |
      fn main() {
          let mut input = String::new();
          println!("Puffer bereit.");
      }
    requiredKeywords: "String::new"
  - title: "Lücke: Die Referenz"
    type: "Programming"
    order: 3
    description: "Beim Einlesen muss der Puffer als **veränderbare Referenz** übergeben werden. <br>Fülle die Lücke mit `&mut`."
    initialCode: |
      use std::io;

      fn main() {
          let mut buffer = String::new();
          println!("Bitte etwas tippen:");
          
          // Lücke: io::stdin().read_line(____ buffer).unwrap();
          io::stdin().read_line(____ buffer).unwrap();
          
          println!("Gelesen!");
      }
    expectedOutput: "Bitte etwas tippen:\nGelesen!"
    solution: |
      use std::io;

      fn main() {
          let mut buffer = String::new();
          println!("Bitte etwas tippen:");
          io::stdin().read_line(&mut buffer).unwrap();
          println!("Gelesen!");
      }
    requiredKeywords: "&mut"
  - title: "Lücke: Das Modul aufrufen"
    type: "Programming"
    order: 4
    description: "Fülle die Lücke, um auf die Standardeingabe zuzugreifen. <br>Nutze `io::stdin()`."
    initialCode: |
      use std::io;

      fn main() {
          let mut input = String::new();
          
          // Lücke: ____::stdin().read_line(&mut input).unwrap();
          ____::stdin().read_line(&mut input).unwrap();
      }
    expectedOutput: ""
    solution: |
      use std::io;

      fn main() {
          let mut input = String::new();
          io::stdin().read_line(&mut input).unwrap();
      }
    requiredKeywords: "io::stdin"
  - title: "Lücke: Alles zusammen"
    type: "Programming"
    order: 5
    description: "Schreibe die komplette Zeile, um eine Eingabe in die Variable `text` einzulesen. <br>Vergiss das `.unwrap()` am Ende nicht!"
    initialCode: |
      use std::io;

      fn main() {
          let mut text = String::new();
          
          // Schreibe hier die komplette read_line Zeile:
          
          println!("Eingabe erfolgt.");
      }
    expectedOutput: "Eingabe erfolgt."
    solution: |
      use std::io;

      fn main() {
          let mut text = String::new();
          io::stdin().read_line(&mut text).unwrap();
          println!("Eingabe erfolgt.");
      }
    requiredKeywords: "read_line,&mut,unwrap"
---
In Rust ist das Einlesen von der Konsole explizit. Du brauchst:
1. Einen **veränderbaren String** (`let mut input = String::new()`).
2. Den Aufruf von **`io::stdin().read_line()`**.
3. Eine **veränderbare Referenz** auf deinen String (`&mut input`).
4. Eine Fehlerbehandlung wie **`.unwrap()`** oder `.expect()`.

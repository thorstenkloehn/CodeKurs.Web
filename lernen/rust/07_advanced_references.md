---
title: "Rust: Fortgeschrittene Referenzen"
description: "Vertiefe dein Wissen über Borrowing und lerne Smart Pointer wie Box kennen."
order: 7
language: "rust"
tasks:
  - title: "Referenzsemantik und Speichersicherheit"
    type: "Theory"
    order: 1
    description: "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern."
  - title: "Immutable vs Mutable"
    type: "Programming"
    order: 2
    description: "In Rust kannst du viele unveränderbare Referenzen haben, aber nur eine veränderbare. Fülle die Lücken, um den Wert zu lesen und zu schreiben."
    initialCode: |
      fn main() {
          let mut data = 10;
          
          let r1 = &data; // Immutable
          println!("Lesen: {}", r1);
          
          // Lücke: Erstelle eine veränderbare Referenz
          let r2 = ________;
          *r2 += 10;
          
          println!("Neu: {}", data);
      }
    expectedOutput: "Lesen: 10\nNeu: 20"
    solution: |
      fn main() {
          let mut data = 10;
          let r1 = &data;
          println!("Lesen: {}", r1);
          
          let r2 = &mut data;
          *r2 += 10;
          println!("Neu: {}", data);
      }
    requiredKeywords: "&mut data,*r2"
  - title: "Box: Smart Pointer auf dem Heap"
    type: "Programming"
    order: 3
    description: "Nutze `Box<T>`, um einen Wert auf dem Heap zu speichern. Vervollständige die Zeile mit `Box::new()`."
    initialCode: |
      fn main() {
          // Speichere die Zahl 50 auf dem Heap
          let heap_val = Box::new(50);
          
          println!("Heap Wert: {}", *heap_val);
      }
    expectedOutput: "Heap Wert: 50"
    solution: |
      fn main() {
          let heap_val = Box::new(50);
          println!("Heap Wert: {}", *heap_val);
      }
    requiredKeywords: "Box::new,*heap_val"
  - title: "Deref Coercion"
    type: "Programming"
    order: 4
    description: "Referenzen können automatisch dereferenziert werden. Übergebe eine Referenz an eine Funktion, die einen primitiven Typ erwartet."
    initialCode: |
      fn print_int(val: i32) {
          println!("Zahl: {}", val);
      }
      
      fn main() {
          let x = 42;
          let r = &x;
          // Übergebe den Wert hinter der Referenz
          print_int(*r);
      }
    expectedOutput: "Zahl: 42"
    solution: |
      fn print_int(val: i32) {
          println!("Zahl: {}", val);
      }
      
      fn main() {
          let x = 42;
          let r = &x;
          print_int(*r);
      }
    requiredKeywords: "*r"
---
Rust erzwingt strikte Regeln für Referenzen zur Kompilierzeit (**Borrow Checker**).

1. **Immutable Borrowing (`&T`)**: Beliebig viele Referenzen zum Lesen erlaubt.
2. **Mutable Borrowing (`&mut T`)**: Nur eine Referenz zum Schreiben erlaubt.
3. **Smart Pointer (`Box<T>`)**: Ermöglicht es, Daten auf dem Heap statt auf dem Stack zu speichern. `Box` besitzt die Daten und gibt sie automatisch frei.

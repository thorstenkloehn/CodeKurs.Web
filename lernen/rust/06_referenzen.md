---
title: "Rust: Referenzen und Borrowing"
description: "Lerne, wie Rust Daten sicher per Referenz übergibt."
order: 6
language: "rust"
tasks:
  - title: "Referenzsemantik und Speichersicherheit"
    type: "Theory"
    order: 1
    description: "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern."
  - title: "Unveränderbare Referenzen"
    type: "Programming"
    order: 2
    description: "Vervollständige die Funktion `laenge`, sodass sie die Länge eines Strings berechnet, ohne den Besitz (Ownership) zu übernehmen."
    initialCode: |
      fn laenge(s: &String) -> usize {
          // Berechne die Länge
          s.len()
      }
      
      fn main() {
          let s1 = String::from("Hallo");
          // Übergebe eine Referenz mit &
          let len = laenge(&s1);
          println!("Die Länge von '{}' ist {}.", s1, len);
      }
    expectedOutput: "Die Länge von 'Hallo' ist 5."
    solution: |
      fn laenge(s: &String) -> usize {
          s.len()
      }
      
      fn main() {
          let s1 = String::from("Hallo");
          let len = laenge(&s1);
          println!("Die Länge von '{}' ist {}.", s1, len);
      }
    requiredKeywords: "&String,&s1"
  - title: "Veränderbare Referenzen"
    type: "Programming"
    order: 3
    description: "Nutze `&mut`, um den Inhalt eines Strings in einer Funktion zu verändern."
    initialCode: |
      fn aendern(s: &mut String) {
          // Füge Text an
          s.push_str(", Welt");
      }
      
      fn main() {
          let mut s = String::from("Hallo");
          // Übergebe eine veränderbare Referenz mit &mut
          aendern(&mut s);
          println!("{}", s);
      }
    expectedOutput: "Hallo, Welt"
    solution: |
      fn aendern(s: &mut String) {
          s.push_str(", Welt");
      }
      
      fn main() {
          let mut s = String::from("Hallo");
          aendern(&mut s);
          println!("{}", s);
      }
    requiredKeywords: "&mut String,&mut s"
  - title: "Lückentext: Rust Referenzen"
    type: "Programming"
    order: 4
    description: "Fülle die Lücken mit `&` oder `&mut`."
    initialCode: |
      fn main() {
          let ___ s = String::from("Daten");
          
          process_read(___s);  // Nur Lesen
          process_write(___s); // Schreiben
          
          println!("{}", s);
      }
      
      fn process_read(s: ___String) {
          println!("Lesen: {}", s);
      }
      
      fn process_write(s: ___String) {
          s.push_str("...geändert");
      }
    expectedOutput: "Lesen: Daten\nDaten...geändert"
    solution: |
      fn main() {
          let mut s = String::from("Daten");
          
          process_read(&s);
          process_write(&mut s);
          
          println!("{}", s);
      }
      
      fn process_read(s: &String) {
          println!("Lesen: {}", s);
      }
      
      fn process_write(s: &mut String) {
          s.push_str("...geändert");
      }
    requiredKeywords: "&s,&mut s,&String,&mut String"
---
In Rust gibt es kein klassisches "Call by Reference" wie in C++, sondern **Borrowing** (Ausleihen).

1. **Unveränderbares Borrowing (`&T`)**: Man darf den Wert lesen, aber nicht ändern. Man kann beliebig viele dieser Referenzen gleichzeitig haben.
2. **Veränderbares Borrowing (`&mut T`)**: Man darf den Wert ändern. Es darf jedoch immer nur **eine** veränderbare Referenz zur gleichen Zeit existieren (Sicherheit gegen Data Races).
3. **Ownership**: Wird kein `&` verwendet, wird der Wert **verschoben** (Move) und die ursprüngliche Variable ist nicht mehr nutzbar.

---
title: "Rust: Kontrollstrukturen"
description: "Entscheidungen treffen und Code wiederholen."
order: 3
language: "rust"
tasks:
  - title: "Branch Prediction und Sprungtabellen"
    type: "Theory"
    order: 1
    description: "Moderne CPUs nutzen Branch Prediction, um vorherzusagen, welchen Pfad eine if-Anweisung nehmen wird. Bei switch-Statements werden oft Sprungtabellen (Jump Tables) verwendet, um direkt zum passenden Codeabschnitt zu springen, anstatt viele Vergleiche nacheinander durchzuführen."
  - title: "Einfaches if/else"
    type: "Programming"
    order: 2
    description: "Prüfe, ob die Zahl `x` größer als 10 ist. Gib 'Groß' aus, ansonsten 'Klein'."
    initialCode: |
      fn main() {
          let x = 15;
          // Dein Code hier
      }
    expectedOutput: "Groß"
    solution: |
      fn main() {
          let x = 15;
          if x > 10 {
              println!("Groß");
          } else {
              println!("Klein");
          }
      }
    requiredKeywords: "if,else"
  - title: "Die `loop` Schleife"
    type: "Programming"
    order: 3
    description: "Rust hat eine endlose Schleife namens `loop`. Nutze `break`, um sie zu verlassen, wenn `i` den Wert 5 erreicht hat. Gib `i` in jedem Durchgang aus."
    initialCode: |
      fn main() {
          let mut i = 0;
          loop {
              // Dein Code hier
              i += 1;
          }
      }
    expectedOutput: "0\n1\n2\n3\n4\n5"
    solution: |
      fn main() {
          let mut i = 0;
          loop {
              println!("{}", i);
              if i == 5 {
                  break;
              }
              i += 1;
          }
      }
    requiredKeywords: "loop,break"
  - title: "While Schleife"
    type: "Programming"
    order: 4
    description: "Nutze eine `while` Schleife, um die Zahlen von 3 bis 1 (herunterzählend) auszugeben."
    initialCode: |
      fn main() {
          let mut n = 3;
          // Dein Code hier
      }
    expectedOutput: "3\n2\n1"
    solution: |
      fn main() {
          let mut n = 3;
          while n > 0 {
              println!("{}", n);
              n -= 1;
          }
      }
    requiredKeywords: "while"
---
Kontrollstrukturen sind das Herzstück jeder Programmiersprache. In Rust gibt es neben `if` und `else` auch mächtige Schleifen-Konstrukte wie `loop`, `while` und `for`.

---
title: "Variablen in Rust"
description: "Lerne, wie du mit verschiedenen Datentypen in Rust arbeitest."
order: 4
language: "rust"
tasks:
  - title: "Speicherverwaltung von Variablen"
    type: "Theory"
    order: 1
    description: "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird."
  - title: "Ganzzahlen (i32)"
    type: "Programming"
    order: 2
    description: "Erstelle eine i32-Variable, addiere zwei Zahlen und gib das Ergebnis aus."
    initialCode: "fn main() {\n    // Dein Code\n}"
    expectedOutput: "15"
    solution: "fn main() {\n    let a: i32 = 10;\n    let b: i32 = 5;\n    println!(\"{}\", a + b);\n}"
    requiredKeywords: "let,println!"
  - title: "Gleitkommazahlen (f64)"
    type: "Programming"
    order: 3
    description: "Erstelle eine f64-Variable, multipliziere sie und gib das Ergebnis aus."
    initialCode: "fn main() {\n    // Dein Code\n}"
    expectedOutput: "12.5"
    solution: "fn main() {\n    let a: f64 = 2.5;\n    let b: f64 = 5.0;\n    println!(\"{}\", a * b);\n}"
    requiredKeywords: "f64,println!"
  - title: "Zeichenketten (String)"
    type: "Programming"
    order: 4
    description: "Verknüpfe zwei String-Objekte und gib sie aus."
    initialCode: "fn main() {\n    // Dein Code\n}"
    expectedOutput: "Hallo Welt"
    solution: "fn main() {\n    let s1 = String::from(\"Hallo \");\n    let s2 = \"Welt\";\n    println!(\"{}{}\", s1, s2);\n}"
    requiredKeywords: "String,println!"
  - title: "Booleans (bool)"
    type: "Programming"
    order: 5
    description: "Verwende einen boolean in einer if-Anweisung."
    initialCode: "fn main() {\n    let is_active = true;\n    // Dein Code\n}"
    expectedOutput: "Wahr"
    solution: "fn main() {\n    let is_active = true;\n    if is_active {\n        println!(\"Wahr\");\n    } else {\n        println!(\"Falsch\");\n    }\n}"
    requiredKeywords: "bool,if,println!"
---
In Rust sind Variablen standardmäßig unveränderlich (immutable). Mit `let mut` kannst du sie veränderbar machen.

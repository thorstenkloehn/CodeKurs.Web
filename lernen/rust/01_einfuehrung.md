---
title: "Rust Grundlagen"
description: "Ein Einstieg in die Welt von Rust - Sicher, schnell und modern."
order: 1
language: "rust"
tasks:
  - title: "Wie Programme funktionieren"
    type: "Theory"
    order: 1
    description: "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt."
  - title: "Was ist Rust?"
    type: "Theory"
    order: 2
    description: "Rust ist eine moderne Systemprogrammiersprache, die sich auf Sicherheit, Geschwindigkeit und Nebenläufigkeit konzentriert. Besonders bekannt ist sie für ihr einzigartiges Konzept der 'Ownership', das Speicherfehler verhindert."
  - title: "Hallo Welt"
    type: "Programming"
    order: 3
    description: "Gib 'Hallo Welt!' aus."
    initialCode: |
      fn main() {
          // Dein Code hier
      }
    expectedOutput: "Hallo Welt!"
    solution: |
      fn main() {
          println!("Hallo Welt!");
      }
    requiredKeywords: "println!"
---
In dieser Lektion lernst du die ersten Schritte in Rust. Rust wird zunehmend für Systemsoftware, Webentwicklung (WebAssembly) und sicherheitskritische Anwendungen eingesetzt.

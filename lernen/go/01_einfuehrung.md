---
title: "Go Grundlagen"
description: "Ein Einstieg in die Welt von Go (Golang)."
order: 1
language: "go"
tasks:
  - title: "Wie Programme funktionieren"
    type: "Theory"
    order: 1
    description: "Erfahre mehr über die Funktionsweise von Compilern und Interpretern. Ein Compiler übersetzt den gesamten Quellcode in Maschinensprache (Binärcode), bevor das Programm ausgeführt wird, während ein Interpreter den Code Zeile für Zeile während der Laufzeit ausführt."
  - title: "Was ist Go?"
    type: "Theory"
    order: 2
    description: "Go ist eine bei Google entwickelte Open-Source-Programmiersprache, die sich durch Effizienz und Einfachheit auszeichnet."
  - title: "Hallo Welt"
    type: "Programming"
    order: 3
    description: "Gib 'Hallo Welt!' aus."
    initialCode: |
      package main

      import "fmt"

      func main() {
          // Dein Code
      }
    expectedOutput: "Hallo Welt!"
    solution: |
      package main

      import "fmt"

      func main() {
          fmt.Println("Hallo Welt!")
      }
    requiredKeywords: "fmt.Println"
---
In dieser Lektion lernst du die ersten Schritte in Go. Go ist bekannt für seine starke Unterstützung von Nebenläufigkeit und seine schnelle Kompilierung.

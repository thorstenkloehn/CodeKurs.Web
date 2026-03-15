---
title: "Go: Benutzereingaben"
description: "Lerne, wie du Daten in Go mit fmt.Scanln einliest."
order: 5
language: "go"
tasks:
  - title: "Systemcalls und Buffering"
    type: "Theory"
    order: 1
    description: "Jede Ein- oder Ausgabe erfordert einen Systemcall an das Betriebssystem. Da diese teuer sind, verwenden viele Sprachen Buffering. Dabei werden Daten gesammelt und in größeren Blöcken übertragen, um die Anzahl der Interaktionen mit der Hardware zu minimieren."
  - title: "Scanln: Einlesen"
    type: "Programming"
    order: 2
    description: "Nutze `fmt.Scanln`, um einen String einzulesen. Übergib die Adresse der Variable mit `&`."
    initialCode: |
      package main
      import "fmt"
      
      func main() {
          var input string
          // Nutze fmt.Scanln
          fmt.Scanln(&input)
          fmt.Print("Gelesen: " + input)
      }
    expectedOutput: "Gelesen: Go"
    solution: |
      package main
      import "fmt"
      
      func main() {
          var input string
          fmt.Scanln(&input)
          fmt.Print("Gelesen: " + input)
      }
    requiredKeywords: "Scanln,&input"
  - title: "Lückentext: Adressoperator in Go"
    type: "Programming"
    order: 3
    description: "Welches Zeichen wird benötigt, um die Adresse einer Variable an Scanln zu übergeben?"
    initialCode: |
      package main
      import "fmt"
      
      func main() {
          var x int
          fmt.Scanln(__x) // Lücke füllen
          fmt.Print("OK")
      }
    expectedOutput: "OK"
    solution: |
      package main
      import "fmt"
      
      func main() {
          var x int
          fmt.Scanln(&x)
          fmt.Print("OK")
      }
    requiredKeywords: "&x"
---
In Go bietet das Package **`fmt`** einfache Möglichkeiten für Konsoleneingaben.

1. **`fmt.Scanln()`**: Liest bis zum Ende der Zeile. Benötigt einen Pointer (Adresse) auf die Variable.
2. **`fmt.Scanf()`**: Ermöglicht formatiertes Einlesen, ähnlich wie in C.
3. **bufio**: Für komplexere Eingaben nutzt man oft `bufio.NewReader(os.Stdin)`, um ganze Sätze mit Leerzeichen zu lesen.

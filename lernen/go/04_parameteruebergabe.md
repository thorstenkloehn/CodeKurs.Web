---
title: "Go: Parameterübergabe"
description: "Verstehe den Unterschied zwischen Werten und Pointern in Go."
order: 4
language: "go"
tasks:
  - title: "Referenzsemantik und Speichersicherheit"
    type: "Theory"
    order: 1
    description: "Lerne den Unterschied zwischen Call-by-Value (Kopie des Wertes) und Call-by-Reference (Verweis auf das Original). In modernen Sprachen helfen Konzepte wie Smart Pointer oder das Ownership-Modell dabei, Speicherlecks und ungültige Speicherzugriffe (Dangling Pointers) zu verhindern."
  - title: "Call by Value in Go"
    type: "Programming"
    order: 2
    description: "Vervollständige die Funktion `updateName`, sodass sie den Namen lokal ändert, aber das Original in `main` unverändert bleibt."
    initialCode: |
      package main
      import "fmt"
      
      func updateName(n string) {
          // Name ändern
          n = "Geändert"
      }
      
      func main() {
          name := "Original"
          updateName(name)
          fmt.Print(name)
      }
    expectedOutput: "Original"
    solution: |
      package main
      import "fmt"
      
      func updateName(n string) {
          n = "Geändert"
      }
      
      func main() {
          name := "Original"
          updateName(name)
          fmt.Print(name)
      }
    requiredKeywords: "n = \"Geändert\""
  - title: "Call by Pointer in Go"
    type: "Programming"
    order: 3
    description: "Nutze einen Pointer (`*string`), um den Wert des Originals zu verändern."
    initialCode: |
      package main
      import "fmt"
      
      func updateNamePtr(n *string) {
          // Ändere den Wert, auf den der Pointer zeigt
          *n = "Geändert"
      }
      
      func main() {
          name := "Original"
          // Übergebe die Adresse mit &
          updateNamePtr(&name)
          fmt.Print(name)
      }
    expectedOutput: "Geändert"
    solution: |
      package main
      import "fmt"
      
      func updateNamePtr(n *string) {
          *n = "Geändert"
      }
      
      func main() {
          name := "Original"
          updateNamePtr(&name)
          fmt.Print(name)
      }
    requiredKeywords: "*string,*n,&name"
  - title: "Lückentext: Pointer-Syntax"
    type: "Programming"
    order: 4
    description: "Fülle die Lücken, um eine Zahl per Pointer zu verdoppeln."
    initialCode: |
      package main
      import "fmt"
      
      func double(n ___int) { // Pointer-Typ
          ___n = ___n * 2     // Dereferenzierung
      }
      
      func main() {
          x := 10
          double(___x)        // Adresse übergeben
          fmt.Print(x)
      }
    expectedOutput: "20"
    solution: |
      package main
      import "fmt"
      
      func double(n *int) {
          *n = *n * 2
      }
      
      func main() {
          x := 10
          double(&x)
          fmt.Print(x)
      }
    requiredKeywords: "*int,*n,&x"
---
Go ist eine "Call by Value" Sprache. Das bedeutet, es wird immer eine Kopie übergeben.

1. **Werte übergeben**: Die Funktion erhält eine Kopie des Wertes.
2. **Pointer übergeben**: Die Funktion erhält eine Kopie der Speicheradresse. Da sie die Adresse kennt, kann sie den Wert an dieser Stelle im Speicher verändern. Dies wird oft als "Call by Reference"-Verhalten bezeichnet, technisch gesehen ist es aber die Übergabe eines Pointer-Wertes.

---
title: "ASP.NET Core: MVC & Routing"
description: "Erfahre mehr über Controller, Views, Routing und Deep Theory zu VTables."
order: 2
language: "aspnetcore"
tasks:
  - title: "Deep Theory: VTables und Dynamic Dispatch"
    type: "Theory"
    order: 1
    description: "In C# nutzen virtuelle Methoden eine Virtual Method Table (VTable), um den Aufruf zur Laufzeit auf die korrekte Implementierung einer abgeleiteten Klasse zu delegieren. ASP.NET Core MVC baut darauf auf: Ein Controller-Aufruf wird durch Reflexion und Metadaten zur Laufzeit aufgelöst. Dies ermöglicht die lose Kopplung und hohe Flexibilität des Frameworks."
  - title: "Einfacher Controller"
    type: "Programming"
    order: 2
    description: "Erstelle eine Action-Methode 'Index' in einer Klasse 'HomeController', die den String 'Welcome' zurückgibt."
    initialCode: |
      using Microsoft.AspNetCore.Mvc;

      public class HomeController : __________
      {
          public string Index()
          {
              return "_______";
          }
      }
    expectedOutput: ""
    solution: |
      using Microsoft.AspNetCore.Mvc;

      public class HomeController : Controller
      {
          public string Index()
          {
              return "Welcome";
          }
      }
    requiredKeywords: "Controller,Index"
  - title: "Lücke: Attribut-Routing"
    type: "Programming"
    order: 3
    description: "Nutze das `[Route]` Attribut, um die Action auf den Pfad '/api/hello' zu mappen."
    initialCode: |
      using Microsoft.AspNetCore.Mvc;

      public class HelloController : ControllerBase
      {
          [____("api/_____")]
          public IActionResult Greet() => Ok("Hi");
      }
    expectedOutput: ""
    solution: |
      using Microsoft.AspNetCore.Mvc;

      public class HelloController : ControllerBase
      {
          [Route("api/hello")]
          public IActionResult Greet() => Ok("Hi");
      }
    requiredKeywords: "Route"
---
MVC (Model-View-Controller) strukturiert Anwendungen in drei Bereiche.

1. **Routing**: Bestimmt, welche Action welcher Controller aufruft.
2. **Views**: Razor-Templates für die UI-Erzeugung.
3. **Controller**: Verarbeiten Requests und liefern Ergebnisse zurück.

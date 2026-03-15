---
title: "ASP.NET Core: Architektur & Middleware"
description: "Lerne die Grundlagen der ASP.NET Core Architektur und der Middleware-Pipeline kennen."
order: 1
language: "aspnetcore"
tasks:
  - title: "Deep Theory: Request/Response-Zyklen"
    type: "Theory"
    order: 1
    description: "In ASP.NET Core durchläuft jeder Request eine Kette von Middleware-Komponenten. Diese Kette wird beim Start der Anwendung konfiguriert. Jede Komponente kann den Request entweder an die nächste Komponente weitergeben oder den Zyklus vorzeitig beenden (short-circuiting), z.B. bei fehlender Autorisierung. Der Rückweg (Response) durchläuft die Pipeline in umgekehrter Reihenfolge, was Transformationen der Antwort ermöglicht."
  - title: "Einfache Middleware"
    type: "Programming"
    order: 2
    description: "Schreibe eine einfache Middleware, die 'Hello World' in die Response schreibt."
    initialCode: |
      var builder = WebApplication.CreateBuilder(args);
      var app = builder.Build();

      app.Run(async context => 
      {
          await context.Response.________Async("Hello World");
      });

      app.Run();
    expectedOutput: ""
    solution: |
      var builder = WebApplication.CreateBuilder(args);
      var app = builder.Build();

      app.Run(async context => 
      {
          await context.Response.WriteAsync("Hello World");
      });

      app.Run();
    requiredKeywords: "WriteAsync"
  - title: "Lücke: Middleware Pipeline"
    type: "Programming"
    order: 3
    description: "Vervollständige den Aufruf, um statische Dateien in der Middleware-Pipeline zu aktivieren."
    initialCode: |
      var builder = WebApplication.CreateBuilder(args);
      var app = builder.Build();

      // Aktiviere statische Dateien
      app.________________();

      app.MapGet("/", () => "Hello World!");
      app.Run();
    expectedOutput: ""
    solution: |
      var builder = WebApplication.CreateBuilder(args);
      var app = builder.Build();

      // Aktiviere statische Dateien
      app.UseStaticFiles();

      app.MapGet("/", () => "Hello World!");
      app.Run();
    requiredKeywords: "UseStaticFiles"
---
ASP.NET Core ist modular aufgebaut. Die Pipeline besteht aus `RequestDelegates`, die nacheinander aufgerufen werden.

Wichtige Punkte:
1. **Kestrel**: Der performante Cross-Plattform Webserver.
2. **Middleware**: Komponenten wie `UseRouting`, `UseAuthentication` und `UseEndpoints`.
3. **Dependency Injection**: Von Grund auf im Framework integriert.

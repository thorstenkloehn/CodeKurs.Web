---
title: "ASP.NET Core: Dependency Injection"
description: "Erfahre mehr über Lifetimes (Scoped, Transient, Singleton) und Inversion of Control."
order: 4
language: "aspnetcore"
tasks:
  - title: "Deep Theory: Inversion of Control"
    type: "Theory"
    order: 1
    description: "Inversion of Control (IoC) bedeutet, dass die Kontrolle über die Instanziierung von Objekten an ein Framework oder einen Container delegiert wird. ASP.NET Core nutzt dazu Dependency Injection (DI). Der DI-Container verwaltet die Lebensdauer von Services und injiziert sie automatisch dort, wo sie benötigt werden, was die Testbarkeit und Modularität massiv verbessert."
  - title: "Service Registrierung"
    type: "Programming"
    order: 2
    description: "Registriere ein Interface 'IMyService' mit der Implementierung 'MyService' als Singleton."
    initialCode: |
      var builder = WebApplication.CreateBuilder(args);

      // Registrierung als Singleton
      builder.Services._____________<IMyService, MyService>();

      var app = builder.Build();
      app.Run();
    expectedOutput: ""
    solution: |
      var builder = WebApplication.CreateBuilder(args);

      // Registrierung als Singleton
      builder.Services.AddSingleton<IMyService, MyService>();

      var app = builder.Build();
      app.Run();
    requiredKeywords: "AddSingleton"
  - title: "Lücke: Service Lifetimes"
    type: "Programming"
    order: 3
    description: "Vervollständige die Registrierung für einen 'Scoped' Service. Scoped bedeutet: Eine Instanz pro HTTP-Request."
    initialCode: |
      var builder = WebApplication.CreateBuilder(args);

      // Registrierung als Scoped
      builder.Services.________<IRepository, MyRepository>();

      var app = builder.Build();
      app.Run();
    expectedOutput: ""
    solution: |
      var builder = WebApplication.CreateBuilder(args);

      // Registrierung als Scoped
      builder.Services.AddScoped<IRepository, MyRepository>();

      var app = builder.Build();
      app.Run();
    requiredKeywords: "AddScoped"
---
Lifetimes im DI-Container:
1. **Transient**: Jedes Mal neu erstellt.
2. **Scoped**: Einmal pro HTTP-Request erstellt.
3. **Singleton**: Einmal für die gesamte App-Laufzeit erstellt.

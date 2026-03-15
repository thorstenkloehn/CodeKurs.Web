---
title: "ASP.NET Core: Entity Framework Core"
description: "DBContext, Migrations, LINQ und Deep Theory zur SQL-Generierung."
order: 3
language: "aspnetcore"
tasks:
  - title: "Deep Theory: SQL-Generierung und Performance"
    type: "Theory"
    order: 1
    description: "EF Core übersetzt LINQ-Queries in SQL. Dies geschieht durch einen Provider (z.B. SQL Server, SQLite). Ein kritischer Aspekt ist das 'N+1 Problem', bei dem für jede Entität einer Liste eine zusätzliche Query ausgeführt wird. Durch Eager Loading mit `.Include()` kann dies verhindert werden. Die Performance hängt stark von der effizienten Übersetzung der Expression Trees in SQL ab."
  - title: "DbContext Setup"
    type: "Programming"
    order: 2
    description: "Erstelle eine Klasse 'AppDbContext', die von 'DbContext' erbt und ein DbSet für 'User' enthält."
    initialCode: |
      using Microsoft.EntityFrameworkCore;

      public class AppDbContext : _________
      {
          public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

          public DbSet<User> _____ { get; set; }
      }
    expectedOutput: ""
    solution: |
      using Microsoft.EntityFrameworkCore;

      public class AppDbContext : DbContext
      {
          public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

          public DbSet<User> Users { get; set; }
      }
    requiredKeywords: "DbContext,Users"
  - title: "Lücke: LINQ Query"
    type: "Programming"
    order: 3
    description: "Vervollständige die LINQ-Query, um alle Benutzer zu finden, deren Name mit 'A' beginnt."
    initialCode: |
      // In einem Controller mit _context
      var users = _context.Users
          .______(u => u.Name.StartsWith("A"))
          .ToList();
    expectedOutput: ""
    solution: |
      // In einem Controller mit _context
      var users = _context.Users
          .Where(u => u.Name.StartsWith("A"))
          .ToList();
    requiredKeywords: "Where"
---
Entity Framework Core ist der Standard O/RM (Object-Relational Mapper) für .NET.

1. **DbContext**: Repräsentiert die Datenbank-Session.
2. **Migrations**: Ermöglichen die Versionierung des Datenbank-Schemas.
3. **LINQ**: Eine typsichere Abfragesprache direkt in C#.

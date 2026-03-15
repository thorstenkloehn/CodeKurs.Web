---
title: "Spring Boot: Spring Data & JPA"
description: "Datenbankzugriff mit Repositories und Deep Theory zum Hibernate Dirty Checking."
order: 3
language: "springboot"
tasks:
  - title: "Deep Theory: Hibernate Dirty Checking"
    type: "Theory"
    order: 1
    description: "Hibernate verfolgt den Zustand geladener Entitäten im Persistence Context. Beim Flush-Vorgang vergleicht Hibernate den aktuellen Zustand der Objekte mit ihrem Ursprungszustand ('Dirty Checking'). Nur wenn Änderungen festgestellt werden, generiert Hibernate automatisch die entsprechenden SQL-UPDATE-Statements. Dies erspart manuelle Aufrufe von `.save()` oder `.update()`."
  - title: "Repository Erstellung"
    type: "Programming"
    order: 2
    description: "Erstelle ein Interface 'UserRepository', das von 'JpaRepository' für die Klasse 'User' mit dem ID-Typ 'Long' erbt."
    initialCode: |
      import org.springframework.data.jpa.repository.JpaRepository;
      
      public interface UserRepository extends _____________<User, ____> {
      }
    expectedOutput: ""
    solution: |
      import org.springframework.data.jpa.repository.JpaRepository;
      
      public interface UserRepository extends JpaRepository<User, Long> {
      }
    requiredKeywords: "JpaRepository,Long"
  - title: "Lücke: Query Method"
    type: "Programming"
    order: 3
    description: "Definiere eine Methode, um einen Benutzer anhand seiner E-Mail-Adresse zu finden (Derived Query)."
    initialCode: |
      public interface UserRepository extends JpaRepository<User, Long> {
          User find_________________(String email);
      }
    expectedOutput: ""
    solution: |
      public interface UserRepository extends JpaRepository<User, Long> {
          User findByEmail(String email);
      }
    requiredKeywords: "findByEmail"
---
Spring Data JPA vereinfacht den Datenbankzugriff massiv.

1. **Repositories**: Interfaces definieren statt Implementierungen schreiben.
2. **Derived Queries**: SQL-Abfragen werden automatisch aus Methodennamen generiert.
3. **Paging & Sorting**: Integrierte Unterstützung für große Datenmengen.

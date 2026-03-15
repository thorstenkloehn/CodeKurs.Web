---
title: "Spring Boot: Auto-Configuration & Virtual Threads"
description: "Lerne die Magie hinter Spring Boot und die Performance von Java 25 Virtual Threads kennen."
order: 1
language: "springboot"
tasks:
  - title: "Deep Theory: Java 25 Virtual Threads"
    type: "Theory"
    order: 1
    description: "Virtual Threads (Project Loom) in Java 25 ermöglichen es, Millionen von Threads gleichzeitig zu betreiben, ohne den Overhead von Betriebssystem-Threads. In Spring Boot 4 werden diese Threads standardmäßig genutzt, um die Skalierbarkeit massiv zu erhöhen. Jede HTTP-Anfrage kann nun ihren eigenen Thread haben, ohne dass der Speicherverbrauch oder Context-Switching-Overhead die Anwendung bremst."
  - title: "Die Hauptklasse"
    type: "Programming"
    order: 2
    description: "Vervollständige die Hauptklasse mit der `@SpringBootApplication` Annotation und der `run` Methode."
    initialCode: |
      import org.springframework.boot.SpringApplication;
      import org.springframework.boot.autoconfigure.SpringBootApplication;
      
      @____________________
      public class MyBackend {
          public static void main(String[] args) {
              SpringApplication.______(MyBackend.class, args);
          }
      }
    expectedOutput: ""
    solution: |
      import org.springframework.boot.SpringApplication;
      import org.springframework.boot.autoconfigure.SpringBootApplication;
      
      @SpringBootApplication
      public class MyBackend {
          public static void main(String[] args) {
              SpringApplication.run(MyBackend.class, args);
          }
      }
    requiredKeywords: "SpringBootApplication,run"
  - title: "Lücke: Auto-Configuration"
    type: "Programming"
    order: 3
    description: "Spring Boot nutzt Konventionen statt Konfiguration. Mit welcher Annotation kannst du die Auto-Konfiguration explizit deaktivieren (selten benötigt)?"
    initialCode: |
      @SpringBootApplication(exclude = {DataSourceAutoConfiguration._______})
      public class MyBackend { }
    expectedOutput: ""
    solution: |
      @SpringBootApplication(exclude = {DataSourceAutoConfiguration.class})
      public class MyBackend { }
    requiredKeywords: "class"
---
Spring Boot 4 setzt auf moderne Java-Features.

1. **Auto-Configuration**: Spring scannt den Classpath und konfiguriert automatisch passende Beans.
2. **Starters**: Zusammenfassungen von Abhängigkeiten (z.B. `spring-boot-starter-web`), die Versionierungskonflikte lösen.
3. **Java 25**: Volle Unterstützung für virtuelle Threads und moderne Syntax-Features.

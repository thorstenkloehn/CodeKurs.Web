---
title: "Spring Boot: REST Services & HTTP/3"
description: "Erstelle moderne REST-APIs mit Content Negotiation und lerne Deep Theory zu HTTP/3."
order: 2
language: "springboot"
tasks:
  - title: "Deep Theory: HTTP/3 Support"
    type: "Theory"
    order: 1
    description: "HTTP/3 nutzt QUIC statt TCP, um Head-of-Line Blocking zu vermeiden und schnellere Verbindungsaufbaue (0-RTT) zu ermöglichen. Spring Boot 4 integriert Native Unterstützung für HTTP/3 durch moderne Server-Engines wie Netty oder Tomcat. Dies verbessert die Latenz bei mobilen Netzwerken und instabilen Verbindungen erheblich."
  - title: "REST Controller"
    type: "Programming"
    order: 2
    description: "Erstelle einen REST-Controller, der bei einem GET-Aufruf auf '/api/status' 'OK' zurückgibt."
    initialCode: |
      import org.springframework.web.bind.annotation.*;

      @________________
      public class StatusController {
          @___________("/api/status")
          public String getStatus() {
              return "OK";
          }
      }
    expectedOutput: ""
    solution: |
      import org.springframework.web.bind.annotation.*;

      @RestController
      public class StatusController {
          @GetMapping("/api/status")
          public String getStatus() {
              return "OK";
          }
      }
    requiredKeywords: "RestController,GetMapping"
  - title: "Lücke: Content Negotiation"
    type: "Programming"
    order: 3
    description: "Vervollständige die Annotation, um anzugeben, dass diese Methode nur JSON zurückgibt."
    initialCode: |
      @GetMapping(value = "/user", produces = MediaType._________________VALUE)
      public User getUser() {
          return new User("Tom");
      }
    expectedOutput: ""
    solution: |
      @GetMapping(value = "/user", produces = MediaType.APPLICATION_JSON_VALUE)
      public User getUser() {
          return new User("Tom");
      }
    requiredKeywords: "APPLICATION_JSON_VALUE"
---
RESTful APIs sind das Herzstück moderner Backends.

1. **@RestController**: Kombiniert `@Controller` und `@ResponseBody`.
2. **Content Negotiation**: Automatisches Auswählen des Antwortformats (JSON, XML) basierend auf dem `Accept` Header.
3. **HTTP/3**: Erhöht Performance und Stabilität der Kommunikation.

---
title: "Spring Boot: Resilience & Security"
description: "Spring Security, Resilience-Patterns und Deep Theory zu OAuth2/OIDC."
order: 4
language: "springboot"
tasks:
  - title: "Deep Theory: OAuth2 und OIDC"
    type: "Theory"
    order: 1
    description: "OAuth 2.0 ist ein Framework für delegierte Autorisierung. OpenID Connect (OIDC) erweitert OAuth um eine Identitätsschicht. Mit ID-Tokens und Access-Tokens wird sichergestellt, dass Backends nur autorisierte Zugriffe erlauben. Spring Security bietet First-Class Support für JWT-Validierung und Integration mit Identity Providern wie Keycloak oder Azure AD."
  - title: "Resilience mit @Retryable"
    type: "Programming"
    order: 2
    description: "Nutze die Annotation `@Retryable`, um eine Methode bei einer 'RuntimeException' automatisch 3-mal neu zu versuchen."
    initialCode: |
      import org.springframework.retry.annotation.Retryable;
      
      @__________ (retryFor = { RuntimeException._____ })
      public void callExternalService() {
          // Fehleranfälliger Aufruf
      }
    expectedOutput: ""
    solution: |
      import org.springframework.retry.annotation.Retryable;
      
      @Retryable (retryFor = { RuntimeException.class })
      public void callExternalService() {
          // Fehleranfälliger Aufruf
      }
    requiredKeywords: "Retryable,class"
  - title: "Lücke: Security Config"
    type: "Programming"
    order: 3
    description: "Vervollständige die Sicherheitskonfiguration, um alle HTTP-Requests zu authentifizieren."
    initialCode: |
      @Bean
      public SecurityFilterChain filterChain(HttpSecurity http) throws Exception {
          http.authorizeHttpRequests(auth -> auth.____________().authenticated());
          return http.build();
      }
    expectedOutput: ""
    solution: |
      @Bean
      public SecurityFilterChain filterChain(HttpSecurity http) throws Exception {
          http.authorizeHttpRequests(auth -> auth.anyRequest().authenticated());
          return http.build();
      }
    requiredKeywords: "anyRequest"
---
Sicherheit und Robustheit sind essenziell für Enterprise-Backends.

1. **Spring Security**: Bietet Schutz gegen CSRF, Session-Hijacking und verwaltet RBAC (Role-Based Access Control).
2. **Resilience**: Mit `@Retryable` und `@CircuitBreaker` können Anwendungen gracefully mit Fehlern umgehen.
3. **OAuth2/OIDC**: Industriestandard für moderne, verteilte Authentifizierung.

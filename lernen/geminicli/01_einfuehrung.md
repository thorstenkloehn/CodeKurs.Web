---
title: "Gemini CLI Grundlagen"
description: "Ein Einstieg in die Welt der Gemini CLI und Agenten-Architektur."
order: 1
language: "geminicli"
tasks:
  - title: "Agenten-Architektur und Tool-Use"
    type: "Theory"
    order: 1
    description: "Deep Theory: Gemini CLI basiert auf einer Agenten-Architektur, bei der ein Large Language Model (LLM) nicht nur Texte generiert, sondern aktiv Tools aufruft. Der Prozess folgt dem Schema: Research (Informationsbeschaffung), Strategy (Planung) und Execution (Durchführung). Dabei kommuniziert das LLM über strukturierte Tool-Calls mit dem System, um z.B. Dateien zu lesen, zu bearbeiten oder Befehle auszuführen."
  - title: "Den Hilfe-Befehl aufrufen"
    type: "Programming"
    order: 2
    description: "Gib den Befehl `/help` ein, um die verfügbaren Befehle und die Dokumentation der Gemini CLI anzuzeigen."
    initialCode: ""
    expectedOutput: ""
    solution: "/help"
    requiredKeywords: "/help"
  - title: "Version abfragen"
    type: "Programming"
    order: 3
    description: "Vervollständige den Aufruf, um die Version der Gemini CLI abzufragen: `gemini-cli --_____`"
    initialCode: "gemini-cli --_____"
    expectedOutput: ""
    solution: "gemini-cli --version"
    requiredKeywords: "version"
---
In dieser Lektion lernst du die Grundlagen der Gemini CLI kennen.

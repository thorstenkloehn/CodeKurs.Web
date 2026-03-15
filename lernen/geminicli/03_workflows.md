---
title: "Fortgeschrittene Workflows"
description: "Lifecycle und Sub-Agenten für komplexe Aufgaben."
order: 3
language: "geminicli"
tasks:
  - title: "Der Research-Strategy-Execution Lifecycle"
    type: "Theory"
    order: 1
    description: "Deep Theory: Der Workflow der Gemini CLI ist in drei Phasen unterteilt: 1. **Research**: Systematische Analyse des Codes und Validierung von Annahmen (z.B. durch `grep_search` und `read_file`). 2. **Strategy**: Entwurf eines Plans basierend auf den Erkenntnissen. 3. **Execution**: Durchführung der Änderungen in iterativen Plan-Act-Validate-Schritten. Jede Änderung wird durch Tests oder manuelle Prüfung validiert."
  - title: "Codebase Investigation"
    type: "Programming"
    order: 2
    description: "Nutze den `codebase_investigator`, um die Datenbank-Struktur des Projekts zu analysieren."
    initialCode: ""
    expectedOutput: ""
    solution: "codebase_investigator objective=\"Analysiere DB-Struktur\""
    requiredKeywords: "codebase_investigator,objective,DB-Struktur"
  - title: "Skill-Creator aktivieren"
    type: "Programming"
    order: 3
    description: "Vervollständige den Befehl, um den Skill-Creator zu aktivieren: `activate_skill name=\"_____\"`"
    initialCode: "activate_skill name=\"_____\""
    expectedOutput: ""
    solution: "activate_skill name=\"skill-creator\""
    requiredKeywords: "activate_skill,name,skill-creator"
---
In dieser Lektion lernst du fortgeschrittene Workflows und den Einsatz von Sub-Agenten kennen.

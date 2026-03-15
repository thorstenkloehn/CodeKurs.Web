---
title: "Datei-Operationen"
description: "Effizientes Arbeiten mit dem Dateisystem durch chirurgische Edits."
order: 2
language: "geminicli"
tasks:
  - title: "Chirurgische Edits vs. Full Writes"
    type: "Theory"
    order: 1
    description: "Deep Theory: Bei chirurgischen Edits (Surgical Updates) werden nur gezielte Teile einer Datei verändert, anstatt die gesamte Datei neu zu schreiben (Full Writes). Dies spart Kontext-Tokens und minimiert das Risiko von unbeabsichtigten Änderungen in nicht betroffenen Bereichen. Die Gemini CLI bevorzugt chirurgische Edits mittels Tools wie `replace`, um Präzision und Effizienz zu gewährleisten."
  - title: "Suche nach TODOs"
    type: "Programming"
    order: 2
    description: "Nutze das Tool `grep_search`, um nach allen Vorkommen des Musters \"TODO\" im gesamten Projekt zu suchen."
    initialCode: ""
    expectedOutput: ""
    solution: "grep_search pattern=\"TODO\""
    requiredKeywords: "grep_search,pattern,TODO"
  - title: "Datei lesen"
    type: "Programming"
    order: 3
    description: "Vervollständige den Befehl, um den Inhalt der Datei `Program.cs` zu lesen: `read_file file_path=\"_____\"`"
    initialCode: "read_file file_path=\"_____\""
    expectedOutput: ""
    solution: "read_file file_path=\"Program.cs\""
    requiredKeywords: "read_file,file_path,Program.cs"
---
In dieser Lektion erfährst du, wie du effizient mit dem Dateisystem arbeitest.

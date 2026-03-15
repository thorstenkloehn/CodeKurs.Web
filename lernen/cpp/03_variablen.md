---
title: "Variablen in C++"
description: "Lerne, wie du mit verschiedenen Datentypen in C++ arbeitest."
order: 3
language: "cpp"
tasks:
  - title: "Speicherverwaltung von Variablen"
    type: "Theory"
    order: 1
    description: "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird."
  - title: "Ganzzahlen (int)"
    type: "Programming"
    order: 2
    description: "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit cout aus."
    initialCode: "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}"
    expectedOutput: "15"
    solution: "#include <iostream>\nusing namespace std;\n\nint main() {\n    int a = 10;\n    int b = 5;\n    cout << a + b;\n    return 0;\n}"
    requiredKeywords: "int,cout"
  - title: "Gleitkommazahlen (double)"
    type: "Programming"
    order: 3
    description: "Erstelle eine double-Variable, multipliziere sie und gib das Ergebnis aus."
    initialCode: "#include <iostream>\n\nint main() {\n    // Dein Code\n    return 0;\n}"
    expectedOutput: "12.5"
    solution: "#include <iostream>\nusing namespace std;\n\nint main() {\n    double a = 2.5;\n    double b = 5.0;\n    cout << a * b;\n    return 0;\n}"
    requiredKeywords: "double,cout"
  - title: "Zeichenketten (string)"
    type: "Programming"
    order: 4
    description: "Verwende den Typ 'string', um zwei Texte zu verknüpfen."
    initialCode: "#include <iostream>\n#include <string>\n\nint main() {\n    // Dein Code\n    return 0;\n}"
    expectedOutput: "Hallo Welt"
    solution: "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main() {\n    string s1 = \"Hallo \";\n    string s2 = \"Welt\";\n    cout << s1 + s2;\n    return 0;\n}"
    requiredKeywords: "string,cout"
  - title: "Booleans (bool)"
    type: "Programming"
    order: 5
    description: "Verwende einen bool in einer if-Anweisung."
    initialCode: "#include <iostream>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}"
    expectedOutput: "Wahr"
    solution: "#include <iostream>\nusing namespace std;\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        cout << \"Wahr\";\n    } else {\n        cout << \"Falsch\";\n    }\n    return 0;\n}"
    requiredKeywords: "bool,if,cout"
---
C++ ist eine objektorientierte Erweiterung von C und bietet komfortable Typen wie `std::string`.

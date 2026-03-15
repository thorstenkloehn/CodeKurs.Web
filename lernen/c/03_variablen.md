---
title: "Variablen in C"
description: "Lerne, wie du mit verschiedenen Datentypen in C arbeitest."
order: 3
language: "c"
tasks:
  - title: "Speicherverwaltung von Variablen"
    type: "Theory"
    order: 1
    description: "Verstehe den Unterschied zwischen Stack und Heap. Lokale Variablen und primitive Typen werden oft auf dem Stack gespeichert, was sehr schnell ist. Objekte und dynamische Daten landen auf dem Heap, der vom Garbage Collector verwaltet wird."
  - title: "Ganzzahlen (int)"
    type: "Programming"
    order: 2
    description: "Erstelle eine int-Variable, addiere zwei Zahlen und gib das Ergebnis mit printf aus."
    initialCode: "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}"
    expectedOutput: "15"
    solution: "#include <stdio.h>\n\nint main() {\n    int a = 10;\n    int b = 5;\n    printf(\"%d\", a + b);\n    return 0;\n}"
    requiredKeywords: "int,printf"
  - title: "Gleitkommazahlen (float)"
    type: "Programming"
    order: 3
    description: "Erstelle eine float-Variable, multipliziere sie und gib das Ergebnis aus."
    initialCode: "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}"
    expectedOutput: "12.500000"
    solution: "#include <stdio.h>\n\nint main() {\n    float a = 2.5;\n    float b = 5.0;\n    printf(\"%f\", a * b);\n    return 0;\n}"
    requiredKeywords: "float,printf"
  - title: "Zeichenketten (char Array)"
    type: "Programming"
    order: 4
    description: "Strings sind in C Arrays von Zeichen. Gib 'Hallo Welt' aus."
    initialCode: "#include <stdio.h>\n\nint main() {\n    // Dein Code\n    return 0;\n}"
    expectedOutput: "Hallo Welt"
    solution: "#include <stdio.h>\n\nint main() {\n    char s1[] = \"Hallo \";\n    char s2[] = \"Welt\";\n    printf(\"%s%s\", s1, s2);\n    return 0;\n}"
    requiredKeywords: "char,printf"
  - title: "Booleans (stdbool.h)"
    type: "Programming"
    order: 5
    description: "Verwende den Typ 'bool' aus stdbool.h in einer if-Anweisung."
    initialCode: "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    // Dein Code\n    return 0;\n}"
    expectedOutput: "Wahr"
    solution: "#include <stdio.h>\n#include <stdbool.h>\n\nint main() {\n    bool isActive = true;\n    if (isActive) {\n        printf(\"Wahr\");\n    } else {\n        printf(\"Falsch\");\n    }\n    return 0;\n}"
    requiredKeywords: "bool,if,printf"
---
In C musst du Datentypen explizit angeben. Für Booleans musst du `<stdbool.h>` einbinden.

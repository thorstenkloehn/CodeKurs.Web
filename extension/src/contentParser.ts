import * as fs from 'fs';
import * as path from 'path';

export interface Lesson {
    id: string;
    title: string;
    description: string;
    order: number;
    language: string;
    tasks: Task[];
    fullPath: string;
}

export interface Task {
    title: string;
    description: string;
    type: string;
    order: number;
    initialCode?: string;
    expectedOutput?: string;
    solution?: string;
    requiredKeywords?: string;
    testCode?: string;
    choicesJson?: string;
    correctAnswer?: string;
}

export function parseLessons(rootPath: string): Lesson[] {
    const lessons: Lesson[] = [];
    const files = fs.readdirSync(rootPath, { withFileTypes: true });

    for (const dir of files) {
        if (dir.isDirectory()) {
            const langPath = path.join(rootPath, dir.name);
            const mdFiles = fs.readdirSync(langPath).filter(f => f.endsWith('.md'));

            for (const file of mdFiles) {
                const filePath = path.join(langPath, file);
                const content = fs.readFileSync(filePath, 'utf8');
                const parts = content.split('---');

                if (parts.length >= 3) {
                    const yaml = parts[1];
                    const mdBody = parts.slice(2).join('---').trim();
                    
                    // Einfacher YAML-Parser Ersatz, falls js-yaml nicht geladen ist
                    const metadata = parseSimpleYaml(yaml);
                    
                    lessons.push({
                        id: `${dir.name}-${file}`,
                        title: metadata.title || file,
                        description: mdBody,
                        order: parseInt(metadata.order) || 0,
                        language: dir.name,
                        tasks: metadata.tasks || [],
                        fullPath: filePath
                    });
                }
            }
        }
    }
    return lessons.sort((a, b) => a.order - b.order);
}

function parseSimpleYaml(yaml: string): any {
    const result: any = {};
    const lines = yaml.split('\n');
    let currentKey = '';

    for (const line of lines) {
        const match = line.match(/^(\w+):\s*(.*)/);
        if (match) {
            currentKey = match[1];
            let value: any = match[2].trim();
            if (value.startsWith('[') && value.endsWith(']')) {
                // Sehr simpler Array-Parser
                value = value.slice(1, -1).split(',').map((s: string) => s.trim().replace(/^"(.*)"$/, '$1'));
            }
            result[currentKey] = value;
        }
    }
    // Hinweis: Für komplexe verschachtelte Tasks müsste hier ein echter YAML-Parser (js-yaml) ran.
    // In der echten Extension wird js-yaml via npm installiert.
    return result;
}

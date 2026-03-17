"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.parseLessons = parseLessons;
const fs = require("fs");
const path = require("path");
const vscode = require("vscode");
const outputChannel = vscode.window.createOutputChannel("CodeKurs Parser");
function parseLessons(rootPath) {
    const lessons = [];
    outputChannel.appendLine(`--- Starte Rekursives Parsing in: ${rootPath} ---`);
    if (!fs.existsSync(rootPath)) {
        outputChannel.appendLine(`KRITISCHER FEHLER: Pfad existiert nicht: ${rootPath}`);
        return [];
    }
    function walkDir(currentPath, language) {
        const files = fs.readdirSync(currentPath, { withFileTypes: true });
        for (const file of files) {
            const fullPath = path.join(currentPath, file.name);
            if (file.isDirectory()) {
                walkDir(fullPath, language || file.name);
            }
            else if (file.name.endsWith('.md')) {
                try {
                    const content = fs.readFileSync(fullPath, 'utf8');
                    // Splitte robuster (ignoriert leere Teile am Anfang/Ende)
                    const parts = content.split(/---/g).map(p => p.trim()).filter(p => p.length > 0);
                    if (parts.length >= 2) {
                        const yaml = parts[0];
                        const mdBody = parts.slice(1).join('\n\n---\n\n');
                        const metadata = parseSimpleYaml(yaml);
                        const lesson = {
                            id: `${language}-${file.name}`,
                            title: metadata.title || file.name,
                            description: mdBody,
                            order: parseInt(metadata.order) || 99,
                            language: metadata.language || language || "Allgemein",
                            tasks: metadata.tasks || [],
                            fullPath: fullPath
                        };
                        lessons.push(lesson);
                        outputChannel.appendLine(`      Gefunden: ${lesson.title} [${lesson.language}]`);
                    }
                }
                catch (e) {
                    outputChannel.appendLine(`      Fehler bei Datei ${file.name}: ${e.message}`);
                }
            }
        }
    }
    walkDir(rootPath, "");
    outputChannel.appendLine(`--- Fertig. Gesamt: ${lessons.length} Lektionen ---`);
    return lessons.sort((a, b) => a.order - b.order);
}
function parseSimpleYaml(yaml) {
    const result = { tasks: [] };
    const lines = yaml.split('\n');
    let currentKey = '';
    let currentTask = null;
    let isMultiline = false;
    let multilineContent = [];
    for (let i = 0; i < lines.length; i++) {
        const line = lines[i];
        const trimmed = line.trim();
        if (!trimmed || (trimmed.startsWith('#') && !isMultiline))
            continue;
        // Multiline support (|)
        if (isMultiline) {
            if (line.startsWith('    ') || line.startsWith('\t') || line.trim() === '') {
                multilineContent.push(line.replace(/^\s{4}/, ''));
                continue;
            }
            else {
                const finalValue = multilineContent.join('\n').trim();
                if (currentTask && currentKey)
                    currentTask[currentKey] = finalValue;
                else if (currentKey)
                    result[currentKey] = finalValue;
                isMultiline = false;
                multilineContent = [];
            }
        }
        // New Task (-)
        if (trimmed.startsWith('- ')) {
            currentTask = {};
            result.tasks.push(currentTask);
            const rest = trimmed.slice(2);
            const match = rest.match(/^(\w+):\s*(.*)/);
            if (match) {
                currentKey = match[1];
                let val = match[2].trim();
                if (val === '|') {
                    isMultiline = true;
                    multilineContent = [];
                }
                else {
                    currentTask[currentKey] = val.replace(/^["'](.*)["']$/, '$1');
                }
            }
            continue;
        }
        // Standard Key: Value (with optional quotes)
        const match = trimmed.match(/^(\w+):\s*(.*)/);
        if (match) {
            currentKey = match[1];
            let value = match[2].trim();
            if (value === '|') {
                isMultiline = true;
                multilineContent = [];
                continue;
            }
            value = value.replace(/^["'](.*)["']$/, '$1');
            if (currentTask) {
                currentTask[currentKey] = value;
            }
            else {
                result[currentKey] = value;
            }
        }
    }
    // Last multiline check
    if (isMultiline && currentKey) {
        const finalValue = multilineContent.join('\n').trim();
        if (currentTask)
            currentTask[currentKey] = finalValue;
        else
            result[currentKey] = finalValue;
    }
    return result;
}
//# sourceMappingURL=contentParser.js.map
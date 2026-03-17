"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.activate = activate;
const vscode = require("vscode");
const path = require("path");
const fs = require("fs");
const contentParser_1 = require("./contentParser");
const child_process_1 = require("child_process");
const util_1 = require("util");
const execAsync = (0, util_1.promisify)(child_process_1.exec);
function activate(context) {
    const outputChannel = vscode.window.createOutputChannel("CodeKurs");
    // Versuche den 'lernen' Ordner an verschiedenen Stellen zu finden
    let rootPath = path.join(context.extensionPath, '..', 'lernen');
    if (!fs.existsSync(rootPath) && vscode.workspace.workspaceFolders) {
        // Zweiter Versuch: Direkt im Workspace root (falls das Projekt dort geöffnet ist)
        const workspaceRoot = vscode.workspace.workspaceFolders[0].uri.fsPath;
        rootPath = path.join(workspaceRoot, 'lernen');
    }
    outputChannel.appendLine(`Suche Lektionen in: ${rootPath}`);
    outputChannel.show(); // Zeige den Output-Kanal automatisch an
    if (!fs.existsSync(rootPath)) {
        outputChannel.appendLine("FEHLER: 'lernen' Ordner wurde nicht gefunden!");
        vscode.window.showErrorMessage(`Lern-Inhalte nicht gefunden unter: ${rootPath}`);
        return;
    }
    const lessons = (0, contentParser_1.parseLessons)(rootPath);
    outputChannel.appendLine(`${lessons.length} Lektionen erfolgreich geladen.`);
    if (lessons.length === 0) {
        outputChannel.appendLine("Warnung: Der Ordner ist vorhanden, aber es wurden keine gültigen .md Dateien gefunden.");
        vscode.window.showWarningMessage("Keine Lektionen gefunden. Bitte prüfe die Markdown-Dateien.");
    }
    const treeDataProvider = new CodeKursProvider(lessons);
    vscode.window.registerTreeDataProvider('codekurs-lessons', treeDataProvider);
    context.subscriptions.push(vscode.commands.registerCommand('codekurs.openLesson', async (lesson) => {
        LessonPanel.createOrShow(context.extensionUri, lesson);
        // Automatisch eine Code-Datei für die Übung öffnen
        if (lesson.tasks && lesson.tasks.length > 0) {
            const firstTask = lesson.tasks[0];
            const languageId = mapLanguageToVsCode(lesson.language);
            const doc = await vscode.workspace.openTextDocument({
                content: firstTask.initialCode || "",
                language: languageId
            });
            await vscode.window.showTextDocument(doc, vscode.ViewColumn.Two);
        }
    }));
    context.subscriptions.push(vscode.commands.registerCommand('codekurs.checkCode', async () => {
        const editor = vscode.window.activeTextEditor;
        if (!editor) {
            vscode.window.showErrorMessage("Kein aktiver Editor gefunden.");
            return;
        }
        const code = editor.document.getText();
        const lang = editor.document.languageId;
        vscode.window.withProgress({
            location: vscode.ProgressLocation.Notification,
            title: `Code (${lang}) wird geprüft...`,
            cancellable: false
        }, async (progress) => {
            try {
                // Temporäre Datei für die Ausführung erstellen
                const tempDir = path.join(context.extensionPath, 'temp');
                if (!fs.existsSync(tempDir))
                    fs.mkdirSync(tempDir);
                const fileName = path.join(tempDir, `solution.${getExt(lang)}`);
                fs.writeFileSync(fileName, code);
                let command = "";
                if (lang === 'python')
                    command = `python "${fileName}"`;
                else if (lang === 'javascript')
                    command = `node "${fileName}"`;
                else if (lang === 'go')
                    command = `go run "${fileName}"`;
                else if (lang === 'rust')
                    command = `rustc "${fileName}" -o "${fileName}.bin" && "${fileName}.bin"`;
                if (!command) {
                    vscode.window.showWarningMessage(`Validierung für ${lang} lokal noch nicht konfiguriert.`);
                    return;
                }
                const { stdout, stderr } = await execAsync(command);
                const output = stdout || stderr;
                vscode.window.showInformationMessage("Ausgabe:\n" + output);
            }
            catch (err) {
                vscode.window.showErrorMessage("Fehler bei der Ausführung: " + err.message);
            }
        });
    }));
}
function mapLanguageToVsCode(lang) {
    const map = {
        'python': 'python',
        'csharp': 'csharp',
        'javascript': 'javascript',
        'java': 'java',
        'cpp': 'cpp',
        'c': 'c',
        'rust': 'rust',
        'go': 'go'
    };
    return map[lang.toLowerCase()] || 'plaintext';
}
function getExt(langId) {
    const map = {
        'python': 'py',
        'javascript': 'js',
        'go': 'go',
        'rust': 'rs',
        'csharp': 'cs',
        'java': 'java',
        'cpp': 'cpp',
        'c': 'c'
    };
    return map[langId] || 'txt';
}
class CodeKursProvider {
    constructor(lessons) {
        this.lessons = lessons;
        this._onDidChangeTreeData = new vscode.EventEmitter();
        this.onDidChangeTreeData = this._onDidChangeTreeData.event;
    }
    getTreeItem(element) {
        if (element instanceof LanguageGroup) {
            return {
                label: element.name,
                collapsibleState: vscode.TreeItemCollapsibleState.Collapsed,
                iconPath: new vscode.ThemeIcon('symbol-folder')
            };
        }
        return {
            label: `${element.order}. ${element.title}`,
            command: {
                command: 'codekurs.openLesson',
                title: 'Lektion öffnen',
                arguments: [element]
            },
            iconPath: new vscode.ThemeIcon('book')
        };
    }
    getChildren(element) {
        if (!element) {
            const langs = [...new Set(this.lessons.map(l => l.language))];
            return langs.map(l => new LanguageGroup(l));
        }
        if (element instanceof LanguageGroup) {
            return this.lessons.filter(l => l.language === element.name);
        }
        return [];
    }
}
class LanguageGroup {
    constructor(name) {
        this.name = name;
    }
}
class LessonPanel {
    constructor(panel, extensionUri, lesson) {
        this._disposables = [];
        this._panel = panel;
        this._panel.onDidDispose(() => this.dispose(), null, this._disposables);
        this._update(lesson);
    }
    static createOrShow(extensionUri, lesson) {
        const column = vscode.window.activeTextEditor ? vscode.window.activeTextEditor.viewColumn : undefined;
        if (LessonPanel.currentPanel) {
            LessonPanel.currentPanel._panel.reveal(column);
            LessonPanel.currentPanel._update(lesson);
            return;
        }
        const panel = vscode.window.createWebviewPanel('lessonView', `CodeKurs: ${lesson.title}`, column || vscode.ViewColumn.One, {
            enableScripts: true
        });
        panel.webview.onDidReceiveMessage(message => {
            if (message.command === 'checkCode') {
                vscode.commands.executeCommand('codekurs.checkCode');
            }
        }, undefined, []);
        LessonPanel.currentPanel = new LessonPanel(panel, extensionUri, lesson);
    }
    _update(lesson) {
        this._panel.title = `Lektion: ${lesson.title}`;
        this._panel.webview.html = this._getHtmlForWebview(lesson);
    }
    _getHtmlForWebview(lesson) {
        const firstTask = (lesson.tasks && lesson.tasks.length > 0) ? lesson.tasks[0] : null;
        const solutionHtml = firstTask?.solution ? `
            <div id="solution-container" style="display: none; margin-top: 15px;">
                <h4>Beispiellösung:</h4>
                <pre><code>${firstTask.solution.replace(/</g, '&lt;').replace(/>/g, '&gt;')}</code></pre>
            </div>
            <button onclick="toggleSolution()" style="background: var(--vscode-button-secondaryBackground); color: var(--vscode-button-secondaryForeground); margin-left: 10px;">Lösung anzeigen</button>
        ` : '';
        return `<!DOCTYPE html>
        <html lang="de">
        <head>
            <meta charset="UTF-8">
            <style>
                body { font-family: var(--vscode-font-family); color: var(--vscode-foreground); padding: 20px; line-height: 1.6; }
                h1 { color: var(--vscode-textLink-foreground); }
                pre { background: var(--vscode-editor-background); color: var(--vscode-editor-foreground); padding: 10px; border: 1px solid var(--vscode-widget-border); border-radius: 5px; overflow: auto; }
                .task-box { background: var(--vscode-editor-inactiveSelectionBackground); padding: 15px; margin-top: 20px; border-left: 5px solid var(--vscode-button-background); border-radius: 4px; }
                button { background: var(--vscode-button-background); color: var(--vscode-button-foreground); border: none; padding: 10px 20px; border-radius: 4px; cursor: pointer; font-weight: bold; margin-top: 15px; }
                button:hover { opacity: 0.8; }
            </style>
        </head>
        <body>
            <h1>${lesson.title}</h1>
            <div id="content">${lesson.description}</div>
            <div class="task-box">
                <h3>Übung</h3>
                <p>${firstTask?.description || 'Löse die Aufgabe im Editor.'}</p>
                <button onclick="checkCode()">Code jetzt prüfen</button>
                ${solutionHtml}
            </div>
            <script>
                const vscode = acquireVsCodeApi();
                function checkCode() {
                    vscode.postMessage({ command: 'checkCode' });
                }
                function toggleSolution() {
                    const container = document.getElementById('solution-container');
                    container.style.display = container.style.display === 'none' ? 'block' : 'none';
                }
            </script>
        </body>
        </html>`;
    }
    dispose() {
        LessonPanel.currentPanel = undefined;
        this._panel.dispose();
        while (this._disposables.length) {
            const x = this._disposables.pop();
            if (x)
                x.dispose();
        }
    }
}
//# sourceMappingURL=extension.js.map
import * as vscode from 'vscode';
import * as path from 'path';
import * as fs from 'fs';
import { parseLessons, Lesson, Task } from './contentParser';
import { exec } from 'child_process';
import { promisify } from 'util';

const execAsync = promisify(exec);

export function activate(context: vscode.ExtensionContext) {
    const rootPath = path.join(context.extensionPath, '..', 'lernen');
    const lessons = parseLessons(rootPath);

    const treeDataProvider = new CodeKursProvider(lessons);
    vscode.window.registerTreeDataProvider('codekurs-lessons', treeDataProvider);

    context.subscriptions.push(
        vscode.commands.registerCommand('codekurs.openLesson', (lesson: Lesson) => {
            LessonPanel.createOrShow(context.extensionUri, lesson);
        })
    );

    context.subscriptions.push(
        vscode.commands.registerCommand('codekurs.checkCode', async () => {
            const editor = vscode.window.activeTextEditor;
            if (!editor) return;

            const code = editor.document.getText();
            const fileName = editor.document.fileName;
            const ext = path.extname(fileName);

            // Hier Logik für Code-Prüfung analog zu CodeExecutorService.cs
            vscode.window.withProgress({
                location: vscode.ProgressLocation.Notification,
                title: "Code wird geprüft...",
                cancellable: false
            }, async (progress) => {
                try {
                    // Beispiel für Python
                    if (ext === '.py') {
                        const { stdout, stderr } = await execAsync(`python "${fileName}"`);
                        if (stderr) throw new Error(stderr);
                        vscode.window.showInformationMessage("Ergebnis:\n" + stdout);
                    } else {
                        vscode.window.showWarningMessage(`Prüfung für ${ext} noch nicht implementiert.`);
                    }
                } catch (err: any) {
                    vscode.window.showErrorMessage("Fehler: " + err.message);
                }
            });
        })
    );
}

class CodeKursProvider implements vscode.TreeDataProvider<Lesson | LanguageGroup> {
    private _onDidChangeTreeData: vscode.EventEmitter<Lesson | LanguageGroup | undefined | void> = new vscode.EventEmitter<Lesson | LanguageGroup | undefined | void>();
    readonly onDidChangeTreeData: vscode.Event<Lesson | LanguageGroup | undefined | void> = this._onDidChangeTreeData.event;

    constructor(private lessons: Lesson[]) {}

    getTreeItem(element: Lesson | LanguageGroup): vscode.TreeItem {
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

    getChildren(element?: Lesson | LanguageGroup): (Lesson | LanguageGroup)[] {
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
    constructor(public readonly name: string) {}
}

class LessonPanel {
    public static currentPanel: LessonPanel | undefined;
    private readonly _panel: vscode.WebviewPanel;
    private _disposables: vscode.Disposable[] = [];

    private constructor(panel: vscode.WebviewPanel, extensionUri: vscode.Uri, lesson: Lesson) {
        this._panel = panel;
        this._panel.onDidDispose(() => this.dispose(), null, this._disposables);
        this._update(lesson);
    }

    public static createOrShow(extensionUri: vscode.Uri, lesson: Lesson) {
        const column = vscode.window.activeTextEditor ? vscode.window.activeTextEditor.viewColumn : undefined;

        if (LessonPanel.currentPanel) {
            LessonPanel.currentPanel._panel.reveal(column);
            LessonPanel.currentPanel._update(lesson);
            return;
        }

        const panel = vscode.window.createWebviewPanel('lessonView', `CodeKurs: ${lesson.title}`, column || vscode.ViewColumn.One, {
            enableScripts: true
        });

        LessonPanel.currentPanel = new LessonPanel(panel, extensionUri, lesson);
    }

    private _update(lesson: Lesson) {
        this._panel.title = `Lektion: ${lesson.title}`;
        this._panel.webview.html = this._getHtmlForWebview(lesson);
    }

    private _getHtmlForWebview(lesson: Lesson) {
        return `<!DOCTYPE html>
        <html lang="de">
        <head>
            <meta charset="UTF-8">
            <style>
                body { font-family: sans-serif; padding: 20px; line-height: 1.6; }
                h1 { color: var(--vscode-textLink-foreground); }
                pre { background: #1e1e1e; color: #d4d4d4; padding: 10px; border-radius: 5px; overflow: auto; }
                .task-box { border: 2px solid var(--vscode-button-background); padding: 15px; margin-top: 20px; border-radius: 8px; }
            </style>
        </head>
        <body>
            <h1>${lesson.title}</h1>
            <div>${lesson.description}</div>
            <div class="task-box">
                <h3>Übung</h3>
                <p>Nutze den VS Code Editor, um diese Aufgabe zu lösen. Klicke dann oben im Editor auf das "Check"-Symbol.</p>
            </div>
        </body>
        </html>`;
    }

    public dispose() {
        LessonPanel.currentPanel = undefined;
        this._panel.dispose();
        while (this._disposables.length) {
            const x = this._disposables.pop();
            if (x) x.dispose();
        }
    }
}
